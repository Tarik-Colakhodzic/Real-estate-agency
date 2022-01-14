using RealEstateAgency.Model;
using RealEstateAgency.WinUI.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace RealEstateAgency.WinUI.User
{
    public partial class frmDisplayUsers : Form
    {
        private APIService _serviceUsers = new APIService(EntityNames.User);

        public frmDisplayUsers()
        {
            InitializeComponent();
            dgvUsers.AutoGenerateColumns = false;
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            frmDisplayUsers_Load(sender, e);
        }

        private async void frmDisplayUsers_Load(object sender, EventArgs e)
        {
            var searchObject = new SimpleSearchRequest
            {
                SearchText = txtSearch.Text,
                IncludeList = new string[]
                {
                    EntityNames.UserRoles,
                    EntityNames.UserRolesRoles
                },
            };
            try
            {
                var users = await _serviceUsers.GetAll<List<Model.User>>(searchObject);
                dgvUsers.DataSource = users.Where(x => !x.UserRoles.Any(y => y.Role.Name == "Administrator")).ToList();
            }
            catch (Exception)
            {
                MessageBox.Show(Resources.Error_Occured);
            }
        }

        private void dgvUsers_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var user = dgvUsers.SelectedRows[0].DataBoundItem;
            frmUsersDetails frm = new frmUsersDetails(user as Model.User);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                dgvUsers.DataSource = null;
                frmDisplayUsers_Load(sender, e);
            }
        }
    }
}