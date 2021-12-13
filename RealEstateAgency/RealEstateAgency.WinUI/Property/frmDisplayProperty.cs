using RealEstateAgency.Model;
using RealEstateAgency.Model.Requests;
using RealEstateAgency.WinUI.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace RealEstateAgency.WinUI.Property
{
    public partial class frmDisplayProperty : Form
    {
        private APIService _serviceProperty = new APIService(EntityNames.Property);
        private APIService _serviceCountry = new APIService(EntityNames.Country);
        private APIService _serviceCity = new APIService(EntityNames.City);
        private APIService _serviceOwner = new APIService(EntityNames.Owner);
        private APIService _serviceCategory = new APIService(EntityNames.Category);
        private APIService _serviceOfferType = new APIService(EntityNames.OfferType);
        private List<Model.City> _cities = new List<City>();
        private bool _startDateSelected = false;
        private bool _endDateSelected = false;
        private bool _includeFilters = false;

        public frmDisplayProperty()
        {
            InitializeComponent();
            dgvProperties.AutoGenerateColumns = false;
            loadComboBoxes();
            cbUnfinished.Checked = true;
            cbFnished.Checked = false;
            dtpStart.CustomFormat = " ";
            dtpStart.Format = DateTimePickerFormat.Custom;
            dtpEnd.CustomFormat = " ";
            dtpEnd.Format = DateTimePickerFormat.Custom;
        }

        private async void frmDisplayProperty_Load(object sender, EventArgs e)
        {
            var searchObject = new PropertySearchRequest
            {
                SearchText = txtSearch.Text,
                Finished = cbFnished.Checked,
                Unfinished = cbUnfinished.Checked,
                IncludeList = new string[]
                {
                    EntityNames.City,
                    EntityNames.Owner,
                    EntityNames.Category,
                    EntityNames.OfferType,
                    EntityNames.PropertyPhotos,
                }
            };
            if (cmbCountry.SelectedValue != null && cmbCountry?.SelectedValue?.ToString() != "0")
            {
                searchObject.CountryId = int.Parse(cmbCountry.SelectedValue.ToString());
            }
            if (cmbCity.SelectedValue != null && cmbCity?.SelectedValue?.ToString() != "0")
            {
                searchObject.CityId = int.Parse(cmbCity.SelectedValue.ToString());
            }
            if (cmbOfferType.SelectedValue != null && cmbOfferType?.SelectedValue?.ToString() != "0")
            {
                searchObject.OfferTypeId = int.Parse(cmbOfferType.SelectedValue.ToString());
            }
            if (cmbCategory.SelectedValue != null && cmbCategory?.SelectedValue?.ToString() != "0")
            {
                searchObject.CategoryId = int.Parse(cmbCategory.SelectedValue.ToString());
            }
            if (cmbOwner.SelectedValue != null && cmbOwner?.SelectedValue?.ToString() != "0")
            {
                searchObject.OwnerId = int.Parse(cmbOwner.SelectedValue.ToString());
            }
            if (APIService.Agent && !APIService.Administrator)
            {
                searchObject.AgentId = APIService.LoggedUserId;
            }
            if (_startDateSelected)
            {
                searchObject.Start = dtpStart.Value;
            }
            if (_endDateSelected)
            {
                searchObject.End = dtpEnd.Value;
            }
            try
            {
                dgvProperties.DataSource = await _serviceProperty.GetAll<List<Model.Property>>(searchObject);
            }
            catch (Exception)
            {
                MessageBox.Show(Resources.Error_Occured);
            }
        }

        private async void loadComboBoxes()
        {
            try
            {
                var countries = await _serviceCountry.GetAll<List<Model.Country>>();
                countries.Insert(0, new Country { Id = 0, Name = string.Empty });
                cmbCountry.DataSource = countries;
                cmbCountry.DisplayMember = "Name";

                var owners = await _serviceOwner.GetAll<List<Model.Owner>>();
                owners.Insert(0, new Model.Owner { Id = 0, FirstName = string.Empty, LastName = string.Empty });
                cmbOwner.DataSource = owners;
                cmbOwner.DisplayMember = "FullName";

                var categories = await _serviceCategory.GetAll<List<Model.Category>>();
                categories.Insert(0, new Category { Id = 0, Name = string.Empty });
                cmbCategory.DataSource = categories;

                var offerTypes = await _serviceOfferType.GetAll<List<Model.OfferType>>();
                offerTypes.Insert(0, new OfferType { Id = 0, Name = string.Empty });
                cmbOfferType.DataSource = offerTypes;

                _cities = await _serviceCity.GetAll<List<Model.City>>();

                cmbCity.DataSource = new List<Model.City> { new City { Id = 0, Name = "Odaberite državu" } };

                cmbCity.DisplayMember = cmbOfferType.DisplayMember = cmbCategory.DisplayMember = cmbCountry.DisplayMember = "Name";
                cmbCity.ValueMember = cmbOfferType.ValueMember = cmbCategory.ValueMember = cmbCountry.ValueMember = cmbOwner.ValueMember = "Id";
            }
            catch (Exception)
            {
                MessageBox.Show(Resources.Error_Occured);
            }
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            if (!cbFnished.Checked && !cbUnfinished.Checked)
            {
                MessageBox.Show("Jedno od polja završene ili nezavršene mora biti označeno!");
                return;
            }
            _includeFilters = true;
            frmDisplayProperty_Load(sender, e);
        }

        private void dgvProperties_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var property = dgvProperties.SelectedRows[0].DataBoundItem;
            frmPropertyDetails frm = new frmPropertyDetails(property as Model.Property);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                dgvProperties.DataSource = null;
                frmDisplayProperty_Load(sender, e);
            }
        }

        private void cmbCountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            var countryId = (cmbCountry.SelectedItem as Model.Country)?.Id;
            if (countryId != 0)
            {
                var source = _cities.Where(x => x.CountryId == countryId).ToList();
                source.Insert(0, new City { Id = 0, Name = string.Empty });
                cmbCity.DataSource = source;
                cmbCity.DisplayMember = "Name";
                cmbCity.ValueMember = "Id";
            }
            else
            {
                cmbCity.DataSource = null;
            }
        }

        private void btnClearFilters_Click(object sender, EventArgs e)
        {
            txtSearch.Text = string.Empty;
            cmbCategory.SelectedItem = cmbCategory.Items[0];
            cmbCountry.SelectedItem = cmbCountry.Items[0];
            cmbCity.DataSource = new List<Model.City> { new City { Id = 0, Name = "Odaberite državu" } };
            cmbCity.DisplayMember = "Name";
            cmbCity.ValueMember = "Id";
            cmbOfferType.SelectedItem = cmbOfferType.Items[0];
            cmbOwner.SelectedItem = cmbOwner.Items[0];
            cbFnished.Checked = false;
            cbUnfinished.Checked = true;
            dtpStart.CustomFormat = " ";
            dtpEnd.CustomFormat = " ";
            _startDateSelected = false;
            _endDateSelected = false;
        }

        private void btnClearDates_Click(object sender, EventArgs e)
        {
            dtpStart.CustomFormat = " ";
            dtpEnd.CustomFormat = " ";

            _startDateSelected = false;
            _endDateSelected = false;
        }

        private void dtpStart_ValueChanged(object sender, EventArgs e)
        {
            dtpStart.CustomFormat = "MM/dd/yyyy";
            _startDateSelected = true;
        }

        private void dtpEnd_ValueChanged(object sender, EventArgs e)
        {
            dtpEnd.CustomFormat = "MM/dd/yyyy";
            _endDateSelected = true;
        }

        private void btnGenerateReport_Click(object sender, EventArgs e)
        {
            var properties = dgvProperties.DataSource as List<Model.Property>;
            if(properties != null)
            {
                if(properties.Count == 0)
                {
                    MessageBox.Show(Resources.NoData);
                    return;
                }
                var countOfRows = properties.Count;
                var priceSum = properties.Sum(x => x.Price);
                var dateRange = string.Empty;
                var country = string.Empty;
                var city = string.Empty;
                if(_includeFilters)
                {
                    var startFormated = dtpStart.Value.Date.ToString("dd.MM.yyyy");
                    var endFormated = dtpEnd.Value.Date.ToString("dd.MM.yyyy");
                    country = (cmbCountry.SelectedItem as Model.Country)?.Name;
                    city = (cmbCity.SelectedItem as Model.City)?.Name;
                    if (_startDateSelected && _endDateSelected)
                    {
                        dateRange = $"Za period od {startFormated} do {endFormated}";
                    }
                    if (_startDateSelected && !_endDateSelected)
                    {
                        dateRange = $"Za period od {startFormated}";
                    }
                    if (!_startDateSelected && _endDateSelected)
                    {
                        dateRange = $"Za period do {endFormated}";
                    }
                    if(!string.IsNullOrEmpty(country))
                    {
                        country = $"Država: {country}";
                    }
                    if(!string.IsNullOrEmpty(city))
                    {
                        city = $"Grad: {city}";
                    }
                }
                frmPropertyReport report = new frmPropertyReport(properties, dateRange, country, city);
                report.Show();
            }
            else
            {
                MessageBox.Show(Resources.Error_Occured);
            }
        }
    }
}