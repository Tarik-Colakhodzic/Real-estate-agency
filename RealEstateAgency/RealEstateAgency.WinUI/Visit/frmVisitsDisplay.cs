using RealEstateAgency.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
                    EntityNames.Property
                }
            };
            var visits = await _visitService.GetAll<List<Model.Visit>>(searchRequest);
            dgvVisits.DataSource = visits.OrderByDescending(x => x.DateTime).ToList();
        }
    }
}
