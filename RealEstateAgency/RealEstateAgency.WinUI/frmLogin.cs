using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace RealEstateAgency.WinUI
{
    public partial class frmLogin : Form
    {
        private readonly APIService _api = new APIService("Role");

        public frmLogin()
        {
            InitializeComponent();
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            APIService.Username = txtUsername.Text;
            APIService.Password = txtPassword.Text;

            try
            {
                var result = await _api.GetAll<List<Model.Role>>();

                frmHome frm = new frmHome();
                frm.Show();
                this.Hide();
            }
            catch
            {
                MessageBox.Show("Pogrešan username ili password");
            }
        }
    }
}