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
        private readonly APIService _serviceOwners = new APIService(EntityNames.Owner);
        private readonly APIService _serviceAgents = new APIService(EntityNames.Agent);
        private bool _startDateSelected = false;
        private bool _endDateSelected = false;
        private bool _includeFilters = false;

        public frmDisplayContracts()
        {
            InitializeComponent();
            dgvContracts.AutoGenerateColumns = false;
            if (APIService.Administrator)
            {
                lblAgent.Visible = cmbAgent.Visible = true;
            }
            else
            {
                lblAgent.Visible = cmbAgent.Visible = false;
            }
            LoadComboBoxes();
            dtpStart.CustomFormat = " ";
            dtpStart.Format = DateTimePickerFormat.Custom;
            dtpEnd.CustomFormat = " ";
            dtpEnd.Format = DateTimePickerFormat.Custom;
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            frmDisplayContracts_Load(sender, e);
            _includeFilters = true;
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
                        EntityNames.Client,
                        EntityNames.PropertyOwner,
                        EntityNames.AgentUser
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
                if (!APIService.Administrator && APIService.Agent)
                {
                    searchObject.AgentId = APIService.LoggedUserId;
                }
                if (_startDateSelected)
                {
                    searchObject.Start = dtpStart.Value;
                }
                if (_endDateSelected)
                {
                    searchObject.End = dtpEnd.Value;
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

        private async void btnGenerateReport_Click(object sender, EventArgs e)
        {
            var contracts = dgvContracts.DataSource as List<Model.Contract>;
            if (contracts != null)
            {
                if (contracts.Count == 0)
                {
                    MessageBox.Show(Resources.NoData);
                    return;
                }
                var dateRange = string.Empty;
                var agent = string.Empty;
                var client = string.Empty;
                var owner = string.Empty;
                if (_includeFilters)
                {
                    var startFormated = dtpStart.Value.Date.ToString("dd.MM.yyyy");
                    var endFormated = dtpEnd.Value.Date.ToString("dd.MM.yyyy");
                    var agentFullName = (cmbAgent.SelectedItem as Model.User)?.FullName;
                    var clientFullName = (cmbClient.SelectedItem as Model.User)?.FullName;
                    var ownerFullName = (cmbOwner.SelectedItem as Model.Owner)?.FullName;
                    if (!string.IsNullOrWhiteSpace(agentFullName))
                    {
                        agent = $"Agent: {agentFullName}";
                    }
                    if (!string.IsNullOrWhiteSpace(clientFullName))
                    {
                        client = $"Klijent: {clientFullName}";
                    }
                    if (!string.IsNullOrWhiteSpace(ownerFullName))
                    {
                        owner = $"Vlasnik: {ownerFullName}";
                    }
                    if (_startDateSelected && _endDateSelected)
                    {
                        dateRange = $"Za period od {startFormated} do {endFormated}";
                    }
                    if (_startDateSelected && !_endDateSelected)
                    {
                        dateRange = $"Za period od {startFormated}";
                    }
                    if (!_startDateSelected && _endDateSelected)
                    {
                        dateRange = $"Za period do {endFormated}";
                    }
                }
                if (!APIService.Administrator && APIService.Agent)
                {
                    agent = $"Agent: {(await _serviceAgents.GetById<Model.Agent>(APIService.LoggedUserId)).FullName}";
                }

                frmContractReport report = new frmContractReport(contracts, agent, client, owner, dateRange);
                report.Show();
            }
            else
            {
                MessageBox.Show(Resources.Error_Occured);
            }
        }

        private void dtpStart_ValueChanged(object sender, EventArgs e)
        {
            dtpStart.CustomFormat = "dd/MM/yyyy";
            _startDateSelected = true;
        }

        private void dtpEnd_ValueChanged(object sender, EventArgs e)
        {
            dtpEnd.CustomFormat = "dd/MM/yyyy";
            _endDateSelected = true;
        }

        private void btnClearDates_Click(object sender, EventArgs e)
        {
            dtpStart.CustomFormat = " ";
            dtpEnd.CustomFormat = " ";

            _startDateSelected = false;
            _endDateSelected = false;
        }
    }
}