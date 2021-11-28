using RealEstateAgency.Model;
using RealEstateAgency.WinUI.Properties;
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
                SearchText = txtSearch.Text,
                IncludeList = new string[]
                {
                    EntityNames.Property,
                    EntityNames.Agent
                }
            };
            try
            {
                dgvBooksOfConstraints.DataSource = await _bookOfComplaintsService.GetAll<List<Model.BookOfComplaints>>(searchRequest);
            }
            catch (Exception)
            {
                MessageBox.Show(Resources.Error_Occured);
            }
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