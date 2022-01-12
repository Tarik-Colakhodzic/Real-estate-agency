using RealEstateAgency.Model;
using RealEstateAgency.WinUI.Properties;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace RealEstateAgency.WinUI.Contract
{
    public partial class frmContractDetails : Form
    {
        private readonly APIService _propertyService = new APIService(EntityNames.Property);
        private readonly APIService _userService = new APIService(EntityNames.User);
        private readonly APIService _contractService = new APIService(EntityNames.Contract);
        private Model.Contract _contract;
        private List<int> idsWithContract = new List<int>();

        public frmContractDetails(Model.Contract contract = null)
        {
            InitializeComponent();
            _contract = contract;
            dtmDateCreated.CustomFormat = "MM/dd/yyyy";
            dtmDateCreated.Format = DateTimePickerFormat.Custom;
        }

        private async void frmContractDetails_Load(object sender, EventArgs e)
        {
            try
            {
                var contracts = await _contractService.GetAll<List<Model.Contract>>();
                idsWithContract = contracts.Select(x => x.Id).ToList();

                var propertySearchRequest = new Model.Requests.PropertySearchRequest
                {
                    IncludeList = new string[] { EntityNames.Owner }
                };
                var properties = await _propertyService.GetAll<List<Model.Property>>(propertySearchRequest);
                if (_contract == null)
                {
                    cmbProperty.DataSource = properties.Where(x => !idsWithContract.Any(y => y == x.Id)).ToList();
                }
                else
                {
                    cmbProperty.DataSource = properties.ToList();
                }
                cmbProperty.DisplayMember = "Title";
                cmbProperty.ValueMember = "Id";

                var clients = await _userService.GetAll<List<Model.User>>(new SimpleSearchRequest
                {
                    IncludeList = new string[] { EntityNames.UserRolesRoles }
                });
                clients = clients.Where(x => x.UserRoles.Any(y => y.Role.Name == "Client")).ToList();
                cmbClient.DataSource = clients;
                cmbClient.DisplayMember = "FullName";
                cmbClient.ValueMember = "Id";

                if (_contract != null)
                {
                    txtOwner.Text = _contract.PropertyOwnerName;
                    txtDescription.Text = _contract.Description;
                    txtContractNumber.Text = _contract.ContractNumber;
                    txtPrice.Text = _contract.Price.ToString();
                    dtmDateCreated.Value = _contract.DateCreated.Date;
                    cmbClient.SelectedIndex = cmbClient.FindStringExact(_contract.Client.FullName);
                    cmbProperty.SelectedIndex = cmbProperty.FindStringExact(_contract.Property.Title);
                }
                else
                {
                    txtPrice.Text = "0";
                }
            }
            catch (Exception)
            {
                MessageBox.Show(Resources.Error_Occured);
            }
        }

        private void cmbProperty_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtOwner.Text = (cmbProperty.SelectedItem as Model.Property)?.OwnerName;
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                try
                {
                    var request = new Model.Contract
                    {
                        Id = int.Parse(cmbProperty.SelectedValue.ToString()),
                        AgentId = APIService.LoggedUserId,
                        UserId = int.Parse(cmbClient.SelectedValue.ToString()),
                        ContractNumber = txtContractNumber.Text,
                        DateCreated = dtmDateCreated.Value,
                        Description = txtDescription.Text,
                        Price = decimal.Parse(txtPrice.Text)
                    };
                    if (_contract != null)
                    {
                        if (_contract.Id != request.Id)
                        {
                            if (!idsWithContract.Any(x => x == request.Id))
                            {
                                await _contractService.Delete<Model.Contract>(_contract.Id);
                                await _contractService.Insert<Model.Contract>(request);
                            }
                            else
                            {
                                MessageBox.Show("Ugovor za odabranu nekretninu već postoji");
                                return;
                            }
                        }
                        else
                        {
                            await _contractService.Update<Model.Contract>(_contract.Id, request);
                        }
                    }
                    else
                    {
                        await _contractService.Insert<Model.Contract>(request);
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

        private void cmbProperty_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Validator.ValidateRequiredComboBox(errorProvider, cmbProperty, e);
        }

        private void cmbClient_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Validator.ValidateRequiredComboBox(errorProvider, cmbClient, e);
        }

        private void txtContractNumber_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Validator.ValidateRequiredField(errorProvider, txtContractNumber, e);
        }

        private void txtPrice_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Validator.ValidateGreaterThanZero(errorProvider, txtPrice, e);
        }

        private void dtmDateCreated_ValueChanged(object sender, EventArgs e)
        {
            dtmDateCreated.CustomFormat = "MM/dd/yyyy";
        }
    }
}