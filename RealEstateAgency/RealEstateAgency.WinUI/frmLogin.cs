using RealEstateAgency.Model;
using RealEstateAgency.WinUI.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace RealEstateAgency.WinUI
{
    public partial class frmLogin : Form
    {
        private readonly APIService _userService = new APIService(EntityNames.User);

        public frmLogin()
        {
            InitializeComponent();
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            APIService.Username = txtUsername.Text;
            APIService.Password = txtPassword.Text;
            APIService.Agent = false;
            APIService.Administrator = false;

            try
            {
                var users = await _userService.GetAll<List<Model.User>>();

                var user = users.First(x => x.Username == txtUsername.Text);

                APIService.LoggedUserId = user.Id;
                foreach (var item in user.UserRoles)
                {
                    if (item.Role.Name == "Agent")
                    {
                        APIService.Agent = true;
                    }
                    if (item.Role.Name == "Administrator")
                    {
                        APIService.Administrator = true;
                    }
                }

                frmHome frm = new frmHome();
                frm.Show();
                this.Hide();
            }
            catch
            {
                MessageBox.Show(Resources.Login_Faild);
            }
        }
    }
}