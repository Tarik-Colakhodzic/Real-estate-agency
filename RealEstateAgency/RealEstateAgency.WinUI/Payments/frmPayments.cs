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

        public frmPayments()
        {
            InitializeComponent();
            dgvPayments.AutoGenerateColumns = false;
        }

        private async void frmPayments_Load(object sender, EventArgs e)
        {
            try
            {
                var payments = await _servicePayment.GetAll<List<Model.Payment>>();
                dgvPayments.DataSource = payments;
                lblUkupno.Text += payments.Where(x => x.Status == "succeeded").Sum(x => x.Amount).ToString() + " KM";
            }
            catch (Exception)
            {
                MessageBox.Show(Resources.Error_Occured);
            }
        }
    }
}