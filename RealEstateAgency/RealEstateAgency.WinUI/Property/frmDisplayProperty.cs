using RealEstateAgency.Model;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace RealEstateAgency.WinUI.Property
{
    public partial class frmDisplayProperty : Form
    {
        private APIService _serviceOwners = new APIService(EntityNames.Property);

        public frmDisplayProperty()
        {
            InitializeComponent();
            dgvProperties.AutoGenerateColumns = false;
        }

        private async void frmDisplayProperty_Load(object sender, EventArgs e)
        {
            var searchObject = new SimpleSearchRequest
            {
                SearchText = txtSearch.Text,
                IncludeList = new string[]
                {
                    EntityNames.City,
                    EntityNames.Owner,
                    EntityNames.Category,
                    EntityNames.OfferType
                },
            };
            dgvProperties.DataSource = await _serviceOwners.GetAll<List<Model.Property>>(searchObject);
        }

        private async void btnDisplay_Click(object sender, EventArgs e)
        {
            var searchObject = new SimpleSearchRequest
            {
                SearchText = txtSearch.Text,
                IncludeList = new string[]
                {
                    EntityNames.City,
                    EntityNames.Owner,
                    EntityNames.Category,
                    EntityNames.OfferType
                },
            };
            dgvProperties.DataSource = await _serviceOwners.GetAll<List<Model.Property>>(searchObject);
        }

        private void dgvProperties_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var property = dgvProperties.SelectedRows[0].DataBoundItem;
            frmPropertyDetails frm = new frmPropertyDetails(property as Model.Property);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                dgvProperties.DataSource = null;
                frmDisplayProperty_Load(sender, e);
            }
        }
    }
}