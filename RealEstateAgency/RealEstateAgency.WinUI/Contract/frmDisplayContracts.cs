using RealEstateAgency.Model;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace RealEstateAgency.WinUI.Contract
{
    public partial class frmDisplayContracts : Form
    {
        private APIService _serviceContracts = new APIService(EntityNames.Contract);

        public frmDisplayContracts()
        {
            InitializeComponent();
            dgvContracts.AutoGenerateColumns = false;
        }

        private async void btnDisplay_Click(object sender, EventArgs e)
        {
            var searchObject = new SimpleSearchRequest
            {
                SearchText = txtSearch.Text,
                IncludeList = new string[]
                {
                    EntityNames.Property,
                    EntityNames.Agent,
                    EntityNames.Client,
                    EntityNames.PropertyOwner
                },
            };
            dgvContracts.DataSource = await _serviceContracts.GetAll<List<Model.Contract>>(searchObject);
        }

        private async void frmDisplayContracts_Load(object sender, EventArgs e)
        {
            var searchObject = new SimpleSearchRequest
            {
                SearchText = txtSearch.Text,
                IncludeList = new string[]
                {
                    EntityNames.Property,
                    EntityNames.Agent,
                    EntityNames.Client,
                    EntityNames.PropertyOwner
                },
            };
            dgvContracts.DataSource = await _serviceContracts.GetAll<List<Model.Contract>>(searchObject);
        }

        private void dgvContracts_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var entity = dgvContracts.SelectedRows[0].DataBoundItem as Model.Contract;
            frmContractDetails frm = new frmContractDetails(entity);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                dgvContracts.DataSource = null;
                frmDisplayContracts_Load(sender, e);
            }
        }
    }
}