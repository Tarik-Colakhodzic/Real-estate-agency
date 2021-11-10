using RealEstateAgency.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RealEstateAgency.WinUI.Property
{
    public partial class frmPropertyDetails : Form
    {
        private readonly APIService _cityService = new APIService(EntityNames.City);
        private readonly APIService _categoryService = new APIService(EntityNames.Category);
        private readonly APIService _offerTypeService = new APIService(EntityNames.OfferType);
        private readonly APIService _ownerService = new APIService(EntityNames.Owner);
        private Model.Property _property;

        public frmPropertyDetails(Model.Property property = null)
        {
            InitializeComponent();
            _property = property;
        }

        private async void frmPropertyDetails_Load(object sender, EventArgs e)
        {
            if(_property != null)
            {
                txtTitle.Text = _property.Title;
                txtAddress.Text = _property.Address;
                txtDescription.Text = _property.Description;
                txtShortDescription.Text = _property.ShortDescription;
                txtPrice.Text = _property.Price.ToString();
                txtBalconySquareMeters.Text = _property.BalconySquareMeters?.ToString();
                txtSquareMeters.Text = _property.SquareMeters.ToString();
                txtNumberOfBathRoom.Text = _property.NumberOfBathRooms.ToString();
                txtNumberOfBedRooms.Text = _property.NumberOfBedRooms.ToString();
                chbElectricityConnection.Checked = _property.ElectricityConnection;
                chbWaterConnection.Checked = _property.WaterConnection;
                chbFinished.Checked = _property.Finished;
                if(_property.Internet.HasValue)
                {
                    chbInternet.Checked = _property.Internet.Value;
                }

                cmbCity.DataSource = await _cityService.GetAll<List<City>>();
                cmbCity.DisplayMember = "Name";
                cmbCity.ValueMember = "Id";
                cmbCity.SelectedIndex = cmbCity.FindStringExact(_property.City.Name);

                cmbCategory.DataSource = await _categoryService.GetAll<List<Category>>();
                cmbCategory.DisplayMember = "Name";
                cmbCategory.ValueMember = "Id";
                cmbCategory.SelectedIndex = cmbCategory.FindStringExact(_property.Category.Name);

                cmbOfferType.DataSource = await _offerTypeService.GetAll<List<OfferType>>();
                cmbOfferType.DisplayMember = "Name";
                cmbOfferType.ValueMember = "Id";
                cmbOfferType.SelectedIndex = cmbOfferType.FindStringExact(_property.OfferType.Name);

                cmbOwner.DataSource = await _ownerService.GetAll<List<Model.Owner>>();
                cmbOwner.DisplayMember = "FullName";
                cmbOwner.ValueMember = "Id";
                cmbOwner.SelectedIndex = cmbOwner.FindStringExact(_property.Owner.FullName);
            }
        }
    }
}
