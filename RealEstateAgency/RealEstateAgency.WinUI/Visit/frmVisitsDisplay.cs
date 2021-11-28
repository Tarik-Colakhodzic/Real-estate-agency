using Flurl.Http;
using RealEstateAgency.Model;
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

        public frmVisitsDisplay()
        {
            InitializeComponent();
            dgvVisits.AutoGenerateColumns = false;
        }

        private async void frmVisitsDisplay_Load(object sender, EventArgs e)
        {
            var searchRequest = new SimpleSearchRequest
            {
                IncludeList = new[]
                {
                    EntityNames.Property,
                    EntityNames.Client
                }
            };
            try
            {
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
    }
}