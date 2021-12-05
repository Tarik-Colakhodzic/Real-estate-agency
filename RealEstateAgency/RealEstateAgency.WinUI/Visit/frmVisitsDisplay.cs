using Flurl.Http;
using RealEstateAgency.Model;
using RealEstateAgency.Model.Requests;
using RealEstateAgency.WinUI.Properties;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace RealEstateAgency.WinUI.Visit
{
    public partial class frmVisitsDisplay : Form
    {
        private readonly APIService _visitService = new APIService(EntityNames.Visit);
        private readonly APIService _userService = new APIService(EntityNames.User);

        public frmVisitsDisplay()
        {
            InitializeComponent();
            dgvVisits.AutoGenerateColumns = false;
            loadComboBoxes();
            chbApporeved.Checked = chbNotApproved.Checked = true;
        }

        private async void frmVisitsDisplay_Load(object sender, EventArgs e)
        {
            try
            {
                var searchRequest = new VisitSearchRequest
                {
                    PropertyTitle = txtPropertyTitle.Text,
                    Approved = chbApporeved.Checked,
                    NotApproved = chbNotApproved.Checked,
                    IncludeList = new[]
                    {
                        EntityNames.Property,
                        EntityNames.Client
                    }
                };
                if (cmbClient.SelectedValue != null && cmbClient.SelectedValue.ToString() != "0")
                {
                    searchRequest.ClientId = int.Parse(cmbClient.SelectedValue.ToString());
                }
                var visits = await _visitService.GetAll<List<Model.Visit>>(searchRequest);
                dgvVisits.DataSource = visits.OrderByDescending(x => x.DateTime).ToList();
            }
            catch (Exception)
            {
                MessageBox.Show(Resources.Error_Occured);
            }
        }

        private async void dgvVisits_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 3)
            {
                var entity = dgvVisits.SelectedRows[0].DataBoundItem as Model.Visit;
                var url = $"{Resources.ApiUrl}{EntityNames.Visit}/{entity.Id}/{!entity.Approved}";
                var result = await url.WithBasicAuth(APIService.Username, APIService.Password).PatchAsync().ReceiveJson<bool>();

                if (result)
                {
                    MessageBox.Show("Operacija uspješno izvršena");
                }
                else
                {
                    MessageBox.Show("Desila se greška");
                }
            }
        }

        private async void loadComboBoxes()
        {
            var users = await _userService.GetAll<List<Model.User>>(new SimpleSearchRequest { IncludeList = new string[] { EntityNames.UserRolesRoles } });
            var clients = users.Where(x => x.UserRoles.Any(y => y.Role.Name == "Client")).ToList();
            clients.Insert(0, new Model.User { FirstName = "", LastName = "", Id = 0 });
            cmbClient.DataSource = clients;
            cmbClient.DisplayMember = "FullName";
            cmbClient.ValueMember = "Id";
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            var entity = dgvVisits.SelectedRows[0].DataBoundItem as Model.Visit;
            if (entity != null)
            {
                var message = $"Da li ste sigurni da želite izbrisati posjetu sa klijentom {entity.ClientName}?";
                DialogResult res = MessageBox.Show(message, "Upozorenje", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (res == DialogResult.Yes)
                {
                    await _visitService.Delete<Model.Visit>(entity.Id);
                    MessageBox.Show("Operacija uspješno izvršena!");
                    frmVisitsDisplay_Load(sender, e);
                }
            }
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            if (!chbApporeved.Checked && !chbNotApproved.Checked)
            {
                MessageBox.Show("Jedno od polja odobrena ili neodobrena mora biti označeno!");
                return;
            }
            frmVisitsDisplay_Load(sender, e);
        }
    }
}