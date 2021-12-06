using RealEstateAgency.Model;
using RealEstateAgency.WinUI.Properties;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace RealEstateAgency.WinUI.Owner
{
    public partial class frmOwnerDetails : Form
    {
        private readonly APIService _ownerService = new APIService(EntityNames.Owner);
        private readonly APIService _cityService = new APIService(EntityNames.City);
        private Model.Owner _owner;

        public frmOwnerDetails(Model.Owner owner = null)
        {
            InitializeComponent();
            _owner = owner;
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                try
                {
                    var request = new Model.Owner
                    {
                        FirstName = txtFirstName.Text,
                        LastName = txtLastName.Text,
                        Email = txtEmail.Text,
                        Address = txtAddress.Text,
                        PhoneNumber = txtPhoneNumber.Text,
                        CityId = int.Parse(cmbCity.SelectedValue.ToString())
                    };
                    if (_owner == null)
                    {
                        await _ownerService.Insert<Model.Owner>(request);
                    }
                    else
                    {
                        request.Id = _owner.Id;
                        await _ownerService.Update<Model.Owner>(_owner.Id, request);
                    }
                    MessageBox.Show("Operacija uspješno izvršena");
                    DialogResult = DialogResult.OK;
                    this.Close();
                }
                catch (Exception)
                {
                    MessageBox.Show(Resources.Error_Occured);
                }
            }
        }

        private async void frmOwnerDetails_Load(object sender, EventArgs e)
        {
            try
            {
                cmbCity.DataSource = await _cityService.GetAll<List<City>>();
                cmbCity.DisplayMember = "Name";
                cmbCity.ValueMember = "Id";
                if (_owner != null)
                {
                    txtAddress.Text = _owner.Address;
                    txtEmail.Text = _owner.Email;
                    txtFirstName.Text = _owner.FirstName;
                    txtLastName.Text = _owner.LastName;
                    txtPhoneNumber.Text = _owner.PhoneNumber;
                    cmbCity.SelectedIndex = cmbCity.FindStringExact(_owner.City.Name);
                }
            }
            catch (Exception)
            {
                MessageBox.Show(Resources.Error_Occured);
            }
        }

        private void txtFirstName_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Validator.ValidateRequiredField(errorProvider, txtFirstName, e);
        }

        private void txtLastName_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Validator.ValidateRequiredField(errorProvider, txtLastName, e);
        }

        private void txtAddress_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Validator.ValidateRequiredField(errorProvider, txtAddress, e);
        }

        private void txtPhoneNumber_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Validator.ValidatePhoneNumber(errorProvider, txtPhoneNumber, e);
        }

        private void txtEmail_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Validator.ValidateEmail(errorProvider, txtEmail, e);
        }
    }
}