using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace RealEstateAgency.WinUI.Property
{
    public partial class frmPropertyReport : Form
    {
        private IList<Model.Property> _properties;
        private string _dateRange;
        private string _country;
        private string _city;

        public frmPropertyReport(IList<Model.Property> properties, string dateRange, string country, string city)
        {
            InitializeComponent();
            _properties = properties.OrderByDescending(x => x.PublishDate).ToList();
            _dateRange = dateRange;
            _country = country;
            _city = city;
        }

        private void frmPropertyReport_Load(object sender, EventArgs e)
        {
            ReportParameterCollection reportParameters = new ReportParameterCollection();
            var countOfRows = _properties.Count;
            var priceSum = _properties.Sum(x => x.Price);
            reportParameters.Add(new ReportParameter("DateRange", _dateRange));
            reportParameters.Add(new ReportParameter("Country", _country));
            reportParameters.Add(new ReportParameter("City", _city));
            reportParameters.Add(new ReportParameter("CountOfRows", $"Broj objavljenih nekretnina: {countOfRows}"));
            reportParameters.Add(new ReportParameter("PriceSum", $"Ukupna cijena nekretnina: {priceSum}"));
            reportViewer.LocalReport.SetParameters(reportParameters);

            var reportList = new List<object>();
            int i = 1;
            foreach (var item in _properties)
            {
                reportList.Add(new
                {
                    OrdinalNumber = i++,
                    PropertyTitle = item.Title,
                    City = item.CityName,
                    PublishDate = item.PublishDate.ToString("MM.dd.yyyy"),
                    Category = item.CategoryName,
                    OfferType = item.OfferTypeName,
                    Finished = item.Finished ? "Da" : "Ne",
                    Price = item.Price
                });
            }
            ReportDataSource dataSource = new ReportDataSource();
            dataSource.Name = "Properties";
            dataSource.Value = reportList;
            reportViewer.LocalReport.DataSources.Add(dataSource);

            this.reportViewer.RefreshReport();
        }
    }
}