using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace RealEstateAgency.WinUI.Contract
{
    public partial class frmContractReport : Form
    {
        private IList<Model.Contract> _contracts;
        private string _agent;
        private string _client;
        private string _owner;
        private string _dateRange;

        public frmContractReport(IList<Model.Contract> contracts, string agent, string client, string owner, string dateRange)
        {
            InitializeComponent();
            _contracts = contracts.OrderByDescending(x => x.DateCreated).ToList();
            _agent = agent;
            _client = client;
            _owner = owner;
            _dateRange = dateRange;
        }

        private void frmContractReport_Load(object sender, EventArgs e)
        {
            ReportParameterCollection reportParameters = new ReportParameterCollection();
            var countOfRows = _contracts.Count;
            var priceSum = _contracts.Sum(x => x.Price);
            reportParameters.Add(new ReportParameter("Agent", _agent));
            reportParameters.Add(new ReportParameter("Client", _client));
            reportParameters.Add(new ReportParameter("Owner", _owner));
            reportParameters.Add(new ReportParameter("CountOfRows", $"Broj sklopljenih ugovora: {countOfRows}"));
            reportParameters.Add(new ReportParameter("PriceSum", $"Ukupna cijena sklopljenih ugovora: {priceSum}"));
            reportParameters.Add(new ReportParameter("DateRange", _dateRange));

            var reportList = new List<object>();
            var i = 1;
            foreach (var item in _contracts)
            {
                reportList.Add(new
                {
                    OrdinalNumber = i++,
                    PropertyTitle = item.PropertyTitle,
                    AgentName = item.AgentName,
                    ClientName = item.ClientName,
                    OwnerName = item.PropertyOwnerName,
                    ContractNumber = item.ContractNumber,
                    Price = item.Price,
                    ContractDate = item.DateCreatedFormated
                });
            }

            ReportDataSource dataSource = new ReportDataSource();
            dataSource.Name = "Contracts";
            dataSource.Value = reportList;

            reportViewer.LocalReport.SetParameters(reportParameters);
            reportViewer.LocalReport.DataSources.Add(dataSource);
            this.reportViewer.RefreshReport();
        }
    }
}