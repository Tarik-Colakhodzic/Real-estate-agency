using RealEstateAgency.Model;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace RealEstateAgency.WinUI.User
{
    public partial class frmDisplayUsers : Form
    {
        private APIService _serviceUsers = new APIService("User");

        public frmDisplayUsers()
        {
            InitializeComponent();
            dgvUsers.AutoGenerateColumns = false;
        }

        private async void btnDisplay_Click(object sender, EventArgs e)
        {
            var searchObject = new SimpleSearchRequest
            {
                SearchText = txtSearch.Text,
                IncludeList = new string[]
                {
                    EntityNames.UserRoles
                },
            };
            dgvUsers.DataSource = await _serviceUsers.GetAll<List<Model.User>>(searchObject);
        }

        private async void frmDisplayUsers_Load(object sender, EventArgs e)
        {
            var searchObject = new SimpleSearchRequest
            {
                IncludeList = new string[]
                {
                    EntityNames.UserRoles
                },
            };
            dgvUsers.DataSource = await _serviceUsers.GetAll<List<Model.User>>(searchObject);
        }

        private void dgvUsers_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var user = dgvUsers.SelectedRows[0].DataBoundItem;
            frmUsersDetails frm = new frmUsersDetails(user as Model.User);
            frm.ShowDialog();
        }
    }
}