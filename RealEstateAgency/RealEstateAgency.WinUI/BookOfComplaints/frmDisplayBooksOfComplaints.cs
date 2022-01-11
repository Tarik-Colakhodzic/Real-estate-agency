using RealEstateAgency.Model;
using RealEstateAgency.Model.Requests;
using RealEstateAgency.WinUI.Properties;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace RealEstateAgency.WinUI.BookOfComplaints
{
    public partial class frmDisplayBooksOfComplaints : Form
    {
        private readonly APIService _bookOfComplaintsService = new APIService(EntityNames.BookOfComplaints);
        private readonly APIService _agentService = new APIService(EntityNames.Agent);

        public frmDisplayBooksOfComplaints()
        {
            InitializeComponent();
            dgvBooksOfConstraints.AutoGenerateColumns = false;
            loadComboBoxes();
        }

        private async void frmDisplayBooksOfConstraints_Load(object sender, EventArgs e)
        {
            try
            {
                var searchRequest = new BookOfComplaintsSearchRequest
                {
                    IncludeList = new string[]
                    {
                        EntityNames.Property,
                        EntityNames.AgentUser
                    }
                };
                if (cmbAgents.SelectedValue != null && cmbAgents.SelectedValue.ToString() != "0")
                {
                    searchRequest.AgentId = int.Parse(cmbAgents.SelectedValue.ToString());
                }
                dgvBooksOfConstraints.DataSource = await _bookOfComplaintsService.GetAll<List<Model.BookOfComplaints>>(searchRequest);
            }
            catch (Exception)
            {
                MessageBox.Show(Resources.Error_Occured);
            }
        }

        private async void loadComboBoxes()
        {
            var agents = await _agentService.GetAll<List<Agent>>(new Model.SimpleSearchRequest { IncludeList = new string[] { EntityNames.User } });
            agents.Insert(0, new Agent { User = new Model.User { FirstName = "", LastName = "" } });
            cmbAgents.DataSource = agents;
            cmbAgents.DisplayMember = "FullName";
            cmbAgents.ValueMember = "Id";
        }

        private void dgvBooksOfConstraints_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var entity = dgvBooksOfConstraints.SelectedRows[0].DataBoundItem as Model.BookOfComplaints;
            frmBookOfComplaintsDetails frm = new frmBookOfComplaintsDetails(entity);
            frm.Show();
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            frmDisplayBooksOfConstraints_Load(sender, e);
        }
    }
}