using RealEstateAgency.Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace RealEstateAgency.WinUI.Property
{
    public partial class frmPropertyDetails : Form
    {
        private readonly APIService _cityService = new APIService(EntityNames.City);
        private readonly APIService _categoryService = new APIService(EntityNames.Category);
        private readonly APIService _offerTypeService = new APIService(EntityNames.OfferType);
        private readonly APIService _ownerService = new APIService(EntityNames.Owner);
        private readonly APIService _propertyService = new APIService(EntityNames.Property);
        private Model.Property _property;
        private int _imageIndex = 0;

        public frmPropertyDetails(Model.Property property = null)
        {
            InitializeComponent();
            _property = property;
        }

        private void frmPropertyDetails_Load(object sender, EventArgs e)
        {
            LoadComboBox();
            if (_property != null)
            {
                txtTitle.Text = _property.Title;
                txtAddress.Text = _property.Address;
                txtDescription.Text = _property.Description;
                txtShortDescription.Text = _property.ShortDescription;
                txtPrice.Text = _property.Price.ToString();
                txtBalconySquareMeters.Text = _property.BalconySquareMeters.ToString();
                txtSquareMeters.Text = _property.SquareMeters.ToString();
                txtNumberOfBathRoom.Text = _property.NumberOfBathRooms.ToString();
                txtNumberOfBedRooms.Text = _property.NumberOfBedRooms.ToString();
                chbElectricityConnection.Checked = _property.ElectricityConnection;
                chbWaterConnection.Checked = _property.WaterConnection;
                chbFinished.Checked = _property.Finished;
                if (_property.Internet.HasValue)
                {
                    chbInternet.Checked = _property.Internet.Value;
                }
                cmbCity.SelectedIndex = cmbCity.FindStringExact(_property.City.Name);
                cmbCategory.SelectedIndex = cmbCategory.FindStringExact(_property.Category.Name);
                cmbOfferType.SelectedIndex = cmbOfferType.FindStringExact(_property.OfferType.Name);
                cmbOwner.SelectedIndex = cmbOwner.FindStringExact(_property.Owner.FullName);
                foreach (var item in _property.PropertyPhotos)
                {
                    imgList.Images.Add(ImageHelper.FromByteToImage(item.Photo));
                }
                if(imgList.Images.Count > 0)
                {
                    pbPhotos.Image = imgList.Images[_imageIndex];
                }
            }
            else
            {
                txtPrice.Text = "0";
                txtBalconySquareMeters.Text = "0";
                txtSquareMeters.Text = "0";
                txtNumberOfBathRoom.Text = "0";
                txtNumberOfBedRooms.Text = "0";
            }
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                var request = new Model.Property
                {
                    Address = txtAddress.Text,
                    Description = txtDescription.Text,
                    ShortDescription = txtShortDescription.Text,
                    ElectricityConnection = chbElectricityConnection.Checked,
                    WaterConnection = chbWaterConnection.Checked,
                    Title = txtTitle.Text,
                    Finished = chbFinished.Checked,
                    Internet = chbInternet.Checked,
                    NumberOfBathRooms = int.Parse(txtNumberOfBathRoom.Text),
                    NumberOfBedRooms = int.Parse(txtNumberOfBedRooms.Text),
                    SquareMeters = int.Parse(txtSquareMeters.Text),
                    BalconySquareMeters = int.Parse(txtBalconySquareMeters.Text),
                    Price = decimal.Parse(txtPrice.Text),
                    OfferTypeId = int.Parse(cmbOfferType.SelectedValue.ToString()),
                    CityId = int.Parse(cmbCity.SelectedValue.ToString()),
                    OwnerId = int.Parse(cmbOwner.SelectedValue.ToString()),
                    CategoryId = int.Parse(cmbCategory.SelectedValue.ToString()),
                };
                var propertyPhotos = new List<PropertyPhoto>();
                foreach (var item in imgList.Images)
                {
                    var image = item as Image;
                    if (image != null)
                    {
                        propertyPhotos.Add(new PropertyPhoto { Photo = ImageHelper.FromImageToByte(image) });
                    }
                }
                request.PropertyPhotos = propertyPhotos;
                if (_property == null)
                {
                    request.PublishDate = DateTime.Now;
                    if(APIService.Agent)
                    {
                        request.AgentId = APIService.LoggedUserId;
                    }
                    await _propertyService.Insert<Model.Property>(request);
                }
                else
                {
                    request.Id = _property.Id;
                    request.PublishDate = _property.PublishDate;
                    request.AgentId = _property.AgentId;
                    await _propertyService.Update<Model.Property>(_property.Id, request);
                }
                MessageBox.Show("Operacija uspješno izvršena");
                DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private async void LoadComboBox()
        {
            cmbCity.DataSource = await _cityService.GetAll<List<City>>();
            cmbCity.DisplayMember = "Name";
            cmbCity.ValueMember = "Id";

            cmbCategory.DataSource = await _categoryService.GetAll<List<Category>>();
            cmbCategory.DisplayMember = "Name";
            cmbCategory.ValueMember = "Id";

            cmbOfferType.DataSource = await _offerTypeService.GetAll<List<OfferType>>();
            cmbOfferType.DisplayMember = "Name";
            cmbOfferType.ValueMember = "Id";

            cmbOwner.DataSource = await _ownerService.GetAll<List<Model.Owner>>();
            cmbOwner.DisplayMember = "FullName";
            cmbOwner.ValueMember = "Id";
        }

        private void btnAddPhotos_Click(object sender, EventArgs e)
        {
            try
            {
                if (ofdImageUpload.ShowDialog() == DialogResult.OK)
                {
                    foreach (var imagePath in ofdImageUpload.FileNames)
                    {
                        imgList.Images.Add(Image.FromFile(imagePath));
                    }
                    if(imgList.Images.Count > 0)
                    {
                        pbPhotos.Image = imgList.Images[_imageIndex];
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Grška: {ex.Message}");
            }
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if(imgList.Images.Count > 0)
            {
                if (_imageIndex == 0)
                {
                    _imageIndex = imgList.Images.Count - 1;
                }
                else
                {
                    _imageIndex--;
                }
                pbPhotos.Image = imgList.Images[_imageIndex];
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if(imgList.Images.Count > 0)
            {
                if(_imageIndex == imgList.Images.Count - 1)
                {
                    _imageIndex = 0;
                }
                else
                {
                    _imageIndex++;
                }
                pbPhotos.Image = imgList.Images[_imageIndex];
            }
        }
    }
}