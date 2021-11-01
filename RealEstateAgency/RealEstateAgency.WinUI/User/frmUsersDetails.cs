using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RealEstateAgency.WinUI.User
{
    public partial class frmUsersDetails : Form
    {
        private readonly APIService _userService = new APIService("User");
        private readonly APIService _rolesService = new APIService("Role");
        private readonly APIService _agentService = new APIService("Agent");
        private Model.User _user;
        private Model.Agent _agent;

        public frmUsersDetails(Model.User user = null)
        {
            InitializeComponent();
            _user = user;
        }

        private async void frmUsersDetails_Load(object sender, EventArgs e)
        {
            lblNoAgent.Visible = true;
            await LoadUloge();
            if (_user != null)
            {
                txtFirstName.Text = _user.FirstName;
                txtLastName.Text = _user.LastName;
                txtEmail.Text = _user.Email;
                txtPhoneNumber.Text = _user.PhoneNumber;
                txtUsername.Text = _user.Username;
            }
        }

        private async Task LoadUloge()
        {
            var roles = await _rolesService.GetAll<List<Model.Role>>();
            if (_user != null)
            {
                foreach (var item in roles)
                {
                    if (_user.UserRoles.Any(x => x.RoleId == item.Id))
                    {
                        clbRoles.Items.Add(item, true);
                    }
                    else
                    {
                        clbRoles.Items.Add(item, false);
                    }
                }
            }
            else
            {
                clbRoles.DataSource = roles;
            }
            clbRoles.DisplayMember = "Name";
            var agentRoleId = roles.First(x => x.Name == "Agent").Id;
            if (_user != null && _user.UserRoles.Any(x => x?.RoleId == agentRoleId))
            {
                _agent = await _agentService.GetById<Model.Agent>(_user.Id);
                if (_agent != null)
                {
                    lblSalary.Visible = lblHireDate.Visible = txtSalary.Visible = 
                        dtpHireDate.Visible = btnSaveAgent.Visible = btnUploadImage.Visible = 
                        pbAgentImage.Visible = lblIncrease.Visible = txtIncreaseSalaryBy.Visible = 
                        btnIncrease.Visible = lblPercentage.Visible = lblKM.Visible = true;
                    lblNoAgent.Visible = false;
                    dtpHireDate.Value = _agent.HireDate;
                    txtSalary.Text = Math.Round(_agent.Salary, 2).ToString();
                    pbAgentImage.Image = ImageHelper.FromByteToImage(_agent.Photo);
                }
            }
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                var roleList = clbRoles.CheckedItems.Cast<Model.Role>();
                var roleIds = roleList.Select(x => x.Id).ToList();

                var request = new Model.Requests.UserInsertRequest();
                request.Email = txtEmail.Text;
                request.PhoneNumber = txtPhoneNumber.Text;
                request.FirstName = txtFirstName.Text;
                request.LastName = txtLastName.Text;
                request.Username = txtUsername.Text;
                request.Password = txtPassword.Text;
                request.ConfirmedPassword = txtConfirmedPassword.Text;
                request.Roles = roleIds;

                if (_user == null)
                {
                    await _userService.Insert<Model.User>(request);
                }
                else
                {
                    await _userService.Update<Model.User>(_user.Id, request);
                }
                MessageBox.Show("Operacija uspješno izvršena");
                DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void txtFirstName_Validating(object sender, CancelEventArgs e)
        {
            Validator.ValidateRequiredField(errorProvider, txtFirstName);
        }

        private void txtLastName_Validating(object sender, CancelEventArgs e)
        {
            Validator.ValidateRequiredField(errorProvider, txtLastName);
        }

        private void txtEmail_Validating(object sender, CancelEventArgs e)
        {
            Validator.ValidateEmail(errorProvider, txtEmail);
        }

        private void txtPhoneNumber_Validating(object sender, CancelEventArgs e)
        {
            //Validator.ValidateRequiredField(errorProvider, txtPhoneNumber);
            //Validator.ValidatePhoneNumber(errorProvider, txtPhoneNumber);
        }

        private void txtUsername_Validating(object sender, CancelEventArgs e)
        {
            Validator.ValidateMinLength(errorProvider, txtUsername, 3);
        }

        private void txtPassword_Validating(object sender, CancelEventArgs e)
        {
            Regex rgx = new Regex(@"^((?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])|(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[^a-zA-Z0-9])|(?=.*?[A-Z])(?=.*?[0-9])(?=.*?[^a-zA-Z0-9])|(?=.*?[a-z])(?=.*?[0-9])(?=.*?[^a-zA-Z0-9])).{8,}$");
            if (!rgx.IsMatch(txtPassword.Text))
            {
                errorProvider.SetError(txtPassword, Properties.Resources.Validation_PasswordStrength);
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtPassword, null);
            }
        }

        private void txtConfirmedPassword_Validating(object sender, CancelEventArgs e)
        {
            if (txtPassword.Text != txtConfirmedPassword.Text)
            {
                errorProvider.SetError(txtConfirmedPassword, Properties.Resources.Validation_NotEqualFields);
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtConfirmedPassword, null);
            }
        }

        private void btnUploadImage_Click(object sender, EventArgs e)
        {
            try
            {
                if (ofdImageUpload.ShowDialog() == DialogResult.OK)
                {
                    string imagePath = ofdImageUpload.FileName;
                    Image image = Image.FromFile(imagePath);
                    pbAgentImage.Image = image;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Grška: {ex.Message}");
            }
        }

        private async void btnSaveAgent_Click(object sender, EventArgs e)
        {
            try
            {
                if(!Decimal.TryParse(txtSalary.Text, out decimal salary))
                {
                    MessageBox.Show("Plata nije isprava!");
                }
                _agent.Salary = salary;
                _agent.HireDate = dtpHireDate.Value;
                _agent.Photo = ImageHelper.FromImageToByte(pbAgentImage.Image);

                await _agentService.Update<Model.Agent>(_agent.Id, _agent);
                MessageBox.Show("Operacija uspješno izvršena");
                DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnIncrease_Click(object sender, EventArgs e)
        {
            if(!decimal.TryParse(txtSalary.Text, out decimal salary))
            {
                MessageBox.Show("Plata nije ispravna!");
                return;
            }
            if(!decimal.TryParse(txtIncreaseSalaryBy.Text, out decimal increaseBy))
            {
                MessageBox.Show("Postotak povećanja nije validan!");
                return;
            }
            if(increaseBy == 0)
            {
                return;
            }
            salary += Math.Round((increaseBy / 100) * salary, 2);
            txtSalary.Text = salary.ToString();
        }
    }
}