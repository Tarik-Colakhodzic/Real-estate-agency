using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RealEstateAgency.WinUI.BookOfComplaints
{
    public partial class frmBookOfComplaintsDetails : Form
    {
        private Model.BookOfComplaints _bookOfComplaints;

        public frmBookOfComplaintsDetails(Model.BookOfComplaints bookOfComplaints = null)
        {
            InitializeComponent();
            _bookOfComplaints = bookOfComplaints;
            if(_bookOfComplaints != null)
            {
                txtProperty.Text = _bookOfComplaints.Property?.Title;
                txtAgent.Text = $"{_bookOfComplaints.Agent?.User?.FirstName} {_bookOfComplaints.Agent?.User?.LastName}";
                txtComment.Text = _bookOfComplaints.Comment;
                lblDateCreated.Text = _bookOfComplaints.DateCreated.ToString("dd.MM.yyyy");
            }
        }
    }
}
