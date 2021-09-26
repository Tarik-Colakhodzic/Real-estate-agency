using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RealEstateAgency.WinUI.User
{
    public partial class frmUsersDetails : Form
    {
        private readonly APIService _service = new APIService("User");
        private Model.User _user;

        public frmUsersDetails(Model.User user = null)
        {
            InitializeComponent();
            _user = user;
        }

        private async void frmUsersDetails_Load(object sender, EventArgs e)
        {
            await LoadUloge();
            if(_user != null)
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
            //var uloge = await ulogeService.GetAll<List<Uloge>>();
            //clbUloge.DataSource = uloge;
            //clbUloge.DisplayMember = "Naziv";
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            if(this.ValidateChildren())
            {
                var request = new Model.Requests.UserInsertRequest();
                request.Email = txtEmail.Text;
                request.PhoneNumber = txtPhoneNumber.Text;
                request.FirstName = txtFirstName.Text;
                request.LastName = txtLastName.Text;
                request.Username = txtUsername.Text;
                request.Password = txtPassword.Text;
                request.ConfirmedPassword = txtConfirmedPassword.Text;
                if (_user == null)
                {
                    await _service.Insert<Model.User>(request);
                }
                else
                {
                    await _service.Update<Model.User>(_user.Id, request);
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
            if(!rgx.IsMatch(txtPassword.Text))
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
            if(txtPassword.Text != txtConfirmedPassword.Text)
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
