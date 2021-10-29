using System;
using System.Collections.Generic;
using System.ComponentModel;
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
        private Model.User _user;

        public frmUsersDetails(Model.User user = null)
        {
            InitializeComponent();
            _user = user;
        }

        private async void frmUsersDetails_Load(object sender, EventArgs e)
        {
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
    }
}