using RealEstateAgency.WinUI.Properties;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace RealEstateAgency.WinUI.Payments
{
    public partial class frmPayments : Form
    {
        private APIService _servicePayment = new APIService("Payment");
        List<Model.Payment> payments = new List<Model.Payment>();

        public frmPayments()
        {
            InitializeComponent();
            dgvPayments.AutoGenerateColumns = false;
        }

        private async void frmPayments_Load(object sender, EventArgs e)
        {
            try
            {
                payments = await _servicePayment.GetAll<List<Model.Payment>>();
                dgvPayments.DataSource = payments;
                lblUkupno.Text += payments.Where(x => x.Status == "succeeded").Sum(x => x.Amount).ToString() + " KM";
            }
            catch (Exception)
            {
                MessageBox.Show(Resources.Error_Occured);
            }
        }

        private void btnTrazi_Click(object sender, EventArgs e)
        {
            var query = payments.AsQueryable();
            if (!string.IsNullOrEmpty(txtChargeId.Text))
            {
                query = query.Where(x => x.Id == txtChargeId.Text);
            }
            if (!string.IsNullOrEmpty(txtCustomerOrTitle.Text))
            {
                query = query.Where(x => x.Description.Contains(txtCustomerOrTitle.Text));
            }
            dgvPayments.DataSource = query.ToList();
        }
    }
}