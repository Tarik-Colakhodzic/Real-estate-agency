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
        private List<Model.City> cities = new List<City>();

        public frmDisplayProperty()
        {
            InitializeComponent();
            dgvProperties.AutoGenerateColumns = false;
            loadComboBoxes();
            cbUnfinished.Checked = true;
            cbFnished.Checked = false;
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
                    EntityNames.PropertyPhotos
                }
            };
            if(cmbCountry.SelectedValue != null && cmbCountry?.SelectedValue?.ToString() != "0")
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
            if(APIService.Agent)
            {
                searchObject.AgentId = APIService.LoggedUserId;
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
                cmbCountry.ValueMember = "Id";

                var owners = await _serviceOwner.GetAll<List<Model.Owner>>();
                owners.Insert(0, new Model.Owner { Id = 0, FirstName = string.Empty, LastName = string.Empty });
                cmbOwner.DataSource = owners;
                cmbOwner.DisplayMember = "FullName";
                cmbOwner.ValueMember = "Id";

                var categories = await _serviceCategory.GetAll<List<Model.Category>>();
                categories.Insert(0, new Category { Id = 0, Name = string.Empty });
                cmbCategory.DataSource = categories;
                cmbCategory.DisplayMember = "Name";
                cmbCategory.ValueMember = "Id";

                var offerTypes = await _serviceOfferType.GetAll<List<Model.OfferType>>();
                offerTypes.Insert(0, new OfferType { Id = 0, Name = string.Empty });
                cmbOfferType.DataSource = offerTypes;
                cmbOfferType.DisplayMember = "Name";
                cmbOfferType.ValueMember = "Id";

                cities = await _serviceCity.GetAll<List<Model.City>>();
            }
            catch (Exception)
            {
                MessageBox.Show(Resources.Error_Occured);
            }
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
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
            if(countryId != 0)
            {
                var source = cities.Where(x => x.CountryId == countryId).ToList();
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
            cmbCity.SelectedItem = cmbCity.Items[0];
            cmbCountry.SelectedItem = cmbCountry.Items[0];
            cmbOfferType.SelectedItem = cmbOfferType.Items[0];
            cmbOwner.SelectedItem = cmbOwner.Items[0];
            cbFnished.Checked = false;
            cbUnfinished.Checked = true;
        }
    }
}