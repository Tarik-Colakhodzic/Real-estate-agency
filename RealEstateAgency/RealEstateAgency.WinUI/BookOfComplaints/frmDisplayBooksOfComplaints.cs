using RealEstateAgency.Model;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace RealEstateAgency.WinUI.BookOfComplaints
{
    public partial class frmDisplayBooksOfComplaints : Form
    {
        private readonly APIService _bookOfComplaintsService = new APIService(EntityNames.BookOfComplaints);

        public frmDisplayBooksOfComplaints()
        {
            InitializeComponent();
            dgvBooksOfConstraints.AutoGenerateColumns = false;
        }

        private async void frmDisplayBooksOfConstraints_Load(object sender, EventArgs e)
        {
            var searchRequest = new SimpleSearchRequest
            {
                IncludeList = new string[]
                {
                    EntityNames.Property,
                    EntityNames.Agent
                }
            };
            dgvBooksOfConstraints.DataSource = await _bookOfComplaintsService.GetAll<List<Model.BookOfComplaints>>(searchRequest);
        }

        private void dgvBooksOfConstraints_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var entity = dgvBooksOfConstraints.SelectedRows[0].DataBoundItem as Model.BookOfComplaints;
            frmBookOfComplaintsDetails frm = new frmBookOfComplaintsDetails(entity);
            frm.Show();
        }

        private async void btnDisplay_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtSearch.Text))
            {
                return;
            }
            var searchRequest = new SimpleSearchRequest
            {
                SearchText = txtSearch.Text,
                IncludeList = new string[]
                {
                    EntityNames.Property,
                    EntityNames.Agent
                }
            };
            dgvBooksOfConstraints.DataSource = await _bookOfComplaintsService.GetAll<List<Model.BookOfComplaints>>(searchRequest);

        }
    }
}