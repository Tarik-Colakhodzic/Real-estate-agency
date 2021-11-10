
namespace RealEstateAgency.WinUI
{
    partial class frmHome
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.usersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.displayUsersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vlasniciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.displayOwnersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addOwnersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.nekretnineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pregledNekretninaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dodavanjeNekrenineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usersToolStripMenuItem,
            this.vlasniciToolStripMenuItem,
            this.nekretnineToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(843, 28);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // usersToolStripMenuItem
            // 
            this.usersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.displayUsersToolStripMenuItem,
            this.addUserToolStripMenuItem});
            this.usersToolStripMenuItem.Name = "usersToolStripMenuItem";
            this.usersToolStripMenuItem.Size = new System.Drawing.Size(79, 24);
            this.usersToolStripMenuItem.Text = "Korisnici";
            // 
            // displayUsersToolStripMenuItem
            // 
            this.displayUsersToolStripMenuItem.Name = "displayUsersToolStripMenuItem";
            this.displayUsersToolStripMenuItem.Size = new System.Drawing.Size(226, 26);
            this.displayUsersToolStripMenuItem.Text = "Pregled korisnika";
            this.displayUsersToolStripMenuItem.Click += new System.EventHandler(this.displayUsersToolStripMenuItem_Click);
            // 
            // addUserToolStripMenuItem
            // 
            this.addUserToolStripMenuItem.Name = "addUserToolStripMenuItem";
            this.addUserToolStripMenuItem.Size = new System.Drawing.Size(226, 26);
            this.addUserToolStripMenuItem.Text = "Dodavanje korisnika";
            this.addUserToolStripMenuItem.Click += new System.EventHandler(this.addUserToolStripMenuItem_Click);
            // 
            // vlasniciToolStripMenuItem
            // 
            this.vlasniciToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.displayOwnersToolStripMenuItem,
            this.addOwnersToolStripMenuItem});
            this.vlasniciToolStripMenuItem.Name = "vlasniciToolStripMenuItem";
            this.vlasniciToolStripMenuItem.Size = new System.Drawing.Size(73, 24);
            this.vlasniciToolStripMenuItem.Text = "Vlasnici";
            // 
            // displayOwnersToolStripMenuItem
            // 
            this.displayOwnersToolStripMenuItem.Name = "displayOwnersToolStripMenuItem";
            this.displayOwnersToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.displayOwnersToolStripMenuItem.Text = "Pregled vlasnika";
            this.displayOwnersToolStripMenuItem.Click += new System.EventHandler(this.displayOwnersToolStripMenuItem_Click);
            // 
            // addOwnersToolStripMenuItem
            // 
            this.addOwnersToolStripMenuItem.Name = "addOwnersToolStripMenuItem";
            this.addOwnersToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.addOwnersToolStripMenuItem.Text = "Dodavanje vlasnika";
            this.addOwnersToolStripMenuItem.Click += new System.EventHandler(this.addOwnersToolStripMenuItem_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 532);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip.Size = new System.Drawing.Size(843, 26);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(49, 20);
            this.toolStripStatusLabel.Text = "Status";
            // 
            // nekretnineToolStripMenuItem
            // 
            this.nekretnineToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pregledNekretninaToolStripMenuItem,
            this.dodavanjeNekrenineToolStripMenuItem});
            this.nekretnineToolStripMenuItem.Name = "nekretnineToolStripMenuItem";
            this.nekretnineToolStripMenuItem.Size = new System.Drawing.Size(95, 24);
            this.nekretnineToolStripMenuItem.Text = "Nekretnine";
            // 
            // pregledNekretninaToolStripMenuItem
            // 
            this.pregledNekretninaToolStripMenuItem.Name = "pregledNekretninaToolStripMenuItem";
            this.pregledNekretninaToolStripMenuItem.Size = new System.Drawing.Size(232, 26);
            this.pregledNekretninaToolStripMenuItem.Text = "Pregled nekretnina";
            this.pregledNekretninaToolStripMenuItem.Click += new System.EventHandler(this.pregledNekretninaToolStripMenuItem_Click);
            // 
            // dodavanjeNekrenineToolStripMenuItem
            // 
            this.dodavanjeNekrenineToolStripMenuItem.Name = "dodavanjeNekrenineToolStripMenuItem";
            this.dodavanjeNekrenineToolStripMenuItem.Size = new System.Drawing.Size(232, 26);
            this.dodavanjeNekrenineToolStripMenuItem.Text = "Dodavanje nekrenine";
            this.dodavanjeNekrenineToolStripMenuItem.Click += new System.EventHandler(this.dodavanjeNekrenineToolStripMenuItem_Click);
            // 
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 558);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmHome";
            this.Text = "Početna";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripMenuItem usersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem displayUsersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vlasniciToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem displayOwnersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addOwnersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nekretnineToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pregledNekretninaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dodavanjeNekrenineToolStripMenuItem;
    }
}



