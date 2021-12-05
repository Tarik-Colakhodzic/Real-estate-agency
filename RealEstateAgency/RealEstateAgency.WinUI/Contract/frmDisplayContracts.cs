using RealEstateAgency.Model;
using RealEstateAgency.Model.Requests;
using RealEstateAgency.WinUI.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace RealEstateAgency.WinUI.Contract
{
    public partial class frmDisplayContracts : Form
    {
        private readonly APIService _serviceContracts = new APIService(EntityNames.Contract);
        private readonly APIService _serviceUsers = new APIService(EntityNames.User);
        private  readonly APIService _serviceOwners = new APIService(EntityNames.Owner);

        public frmDisplayContracts()
        {
            InitializeComponent();
            dgvContracts.AutoGenerateColumns = false;
            LoadComboBoxes();
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            frmDisplayContracts_Load(sender, e);
        }

        private async void frmDisplayContracts_Load(object sender, EventArgs e)
        {
            try
            {
                var searchObject = new ContractSearchRequest
                {
                    PropertyTitle = txtPropertyTitle.Text,
                    IncludeList = new string[]
                    {
                        EntityNames.Property,
                        EntityNames.Agent,
                        EntityNames.Client,
                        EntityNames.PropertyOwner
                    },
                };
                if (cmbAgent.SelectedValue != null && cmbAgent?.SelectedValue?.ToString() != "0")
                {
                    searchObject.AgentId = int.Parse(cmbAgent.SelectedValue.ToString());
                }
                if (cmbClient.SelectedValue != null && cmbClient?.SelectedValue?.ToString() != "0")
                {
                    searchObject.ClientId = int.Parse(cmbClient.SelectedValue.ToString());
                }
                if (cmbOwner.SelectedValue != null && cmbOwner?.SelectedValue?.ToString() != "0")
                {
                    searchObject.OwnerId = int.Parse(cmbOwner.SelectedValue.ToString());
                }
                dgvContracts.DataSource = await _serviceContracts.GetAll<List<Model.Contract>>(searchObject);
            }
            catch (Exception)
            {
                MessageBox.Show(Resources.Error_Occured);
            }
        }

        private async void LoadComboBoxes()
        {
            var users = await _serviceUsers.GetAll<List<Model.User>>(new SimpleSearchRequest { IncludeList = new string[] { EntityNames.UserRolesRoles } });
            var agents = users.Where(x => x.UserRoles.Any(y => y.Role.Name == "Agent")).ToList();
            var clients = users.Where(x => x.UserRoles.Any(y => y.Role.Name == "Client")).ToList();

            agents.Insert(0, new Model.User { FirstName = "", LastName = "", Id = 0 });
            clients.Insert(0, new Model.User { FirstName = "", LastName = "", Id = 0 });

            cmbAgent.DataSource = agents;
            cmbClient.DataSource = clients;

            var owners = await _serviceOwners.GetAll<List<Model.Owner>>();
            owners.Insert(0, new Model.Owner { FirstName = "", LastName = "", Id = 0 });
            cmbOwner.DataSource = owners;

            cmbOwner.DisplayMember = cmbClient.DisplayMember = cmbAgent.DisplayMember = "FullName";
            cmbOwner.ValueMember = cmbClient.ValueMember = cmbAgent.ValueMember = "Id";
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