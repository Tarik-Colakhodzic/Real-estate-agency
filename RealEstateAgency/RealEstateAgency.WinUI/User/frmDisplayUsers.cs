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

namespace RealEstateAgency.WinUI.User
{
    public partial class frmDisplayUsers : Form
    {
        APIService _serviceUsers = new APIService("User");

        public frmDisplayUsers()
        {
            InitializeComponent();
            dgvUsers.AutoGenerateColumns = false;
        }

        private async void btnDisplay_Click(object sender, EventArgs e)
        {
            var searchObject = new UserSearchRequest
            {
                FirstName = txtFirstName.Text,
                LastName = txtLastName.Text,
                Email = txtEmail.Text,
                PhoneNumber = txtPhoneNumber.Text,
                UserName = txtUsername.Text
            };
            dgvUsers.DataSource = await _serviceUsers.GetAll<List<Model.User>>(searchObject);
        }

        private async void frmDisplayUsers_Load(object sender, EventArgs e)
        {
            dgvUsers.DataSource = await _serviceUsers.GetAll<List<Model.User>>();
        }

        private void dgvUsers_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var user = dgvUsers.SelectedRows[0].DataBoundItem;
            frmUsersDetails frm = new frmUsersDetails(user as Model.User);
            frm.ShowDialog();
        }
    }
}
