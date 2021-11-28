using RealEstateAgency.Model;
using RealEstateAgency.WinUI.Properties;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace RealEstateAgency.WinUI.Owner
{
    public partial class frmDisplayOwners : Form
    {
        private APIService _serviceOwners = new APIService(EntityNames.Owner);

        public frmDisplayOwners()
        {
            InitializeComponent();
            dgvOwners.AutoGenerateColumns = false;
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            frmDisplayOwners_Load(sender, e);
        }

        private async void frmDisplayOwners_Load(object sender, EventArgs e)
        {
            var searchObject = new SimpleSearchRequest
            {
                SearchText = txtSearch.Text,
                IncludeList = new string[]
                {
                    EntityNames.City
                },
            };
            try
            {
                dgvOwners.DataSource = await _serviceOwners.GetAll<List<Model.Owner>>(searchObject);
            }
            catch (Exception)
            {
                MessageBox.Show(Resources.Error_Occured);
            }
        }

        private void dgvOwners_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var owner = dgvOwners.SelectedRows[0].DataBoundItem;
            frmOwnerDetails frm = new frmOwnerDetails(owner as Model.Owner);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                dgvOwners.DataSource = null;
                frmDisplayOwners_Load(sender, e);
            }
        }
    }
}