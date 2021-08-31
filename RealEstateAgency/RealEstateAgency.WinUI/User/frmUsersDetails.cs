using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RealEstateAgency.WinUI.User
{
    public partial class frmUsersDetails : Form
    {
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
                txtUsername.Text = _user.UserName;
            }
        }

        private async Task LoadUloge()
        {
            //var uloge = await ulogeService.GetAll<List<Uloge>>();
            //clbUloge.DataSource = uloge;
            //clbUloge.DisplayMember = "Naziv";
        }

        private void txtFirstName_Validating(object sender, CancelEventArgs e)
        {
            if(string.IsNullOrEmpty(txtFirstName.Text))
            {
                errorProvider.SetError(txtFirstName, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtFirstName, null);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(this.ValidateChildren())
            {

            }
        }
    }
}
