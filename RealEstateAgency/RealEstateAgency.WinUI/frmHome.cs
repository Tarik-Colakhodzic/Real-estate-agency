using RealEstateAgency.Model;
using RealEstateAgency.WinUI.Owner;
using RealEstateAgency.WinUI.Property;
using RealEstateAgency.WinUI.User;
using System;
using System.Windows.Forms;

namespace RealEstateAgency.WinUI
{
    public partial class frmHome : Form
    {
        private int childFormNumber = 0;

        public frmHome()
        {
            InitializeComponent();
            if(LoggedUser.Agent)
            {
                vlasniciToolStripMenuItem.Visible = false;
            }
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void displayUsersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDisplayUsers frm = new frmDisplayUsers();
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void addUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUsersDetails frm = new frmUsersDetails();
            frm.MdiParent = this;
            frm.Show();
        }

        private void displayOwnersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDisplayOwners frm = new frmDisplayOwners();
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void addOwnersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmOwnerDetails frm = new frmOwnerDetails();
            frm.MdiParent = this;
            frm.Show();
        }

        private void pregledNekretninaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDisplayProperty frm = new frmDisplayProperty();
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void dodavanjeNekrenineToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}