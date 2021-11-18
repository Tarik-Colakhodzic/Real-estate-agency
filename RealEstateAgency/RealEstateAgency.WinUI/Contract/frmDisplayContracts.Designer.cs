
namespace RealEstateAgency.WinUI.Contract
{
    partial class frmDisplayContracts
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvContracts = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnDisplay = new System.Windows.Forms.Button();
            this.PropertyTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AgentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClientName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PropertyOwnerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateCreatedFormated = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContracts)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvContracts);
            this.groupBox1.Location = new System.Drawing.Point(13, 105);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(775, 333);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ugovori";
            // 
            // dgvContracts
            // 
            this.dgvContracts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvContracts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvContracts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PropertyTitle,
            this.AgentName,
            this.ClientName,
            this.PropertyOwnerName,
            this.DateCreatedFormated});
            this.dgvContracts.Location = new System.Drawing.Point(7, 22);
            this.dgvContracts.Name = "dgvContracts";
            this.dgvContracts.RowHeadersWidth = 51;
            this.dgvContracts.RowTemplate.Height = 24;
            this.dgvContracts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvContracts.Size = new System.Drawing.Size(762, 305);
            this.dgvContracts.TabIndex = 0;
            this.dgvContracts.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvContracts_CellMouseDoubleClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtSearch);
            this.groupBox2.Controls.Add(this.btnDisplay);
            this.groupBox2.Location = new System.Drawing.Point(13, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(775, 80);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Pretraga";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(6, 38);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(207, 22);
            this.txtSearch.TabIndex = 11;
            // 
            // btnDisplay
            // 
            this.btnDisplay.Location = new System.Drawing.Point(652, 29);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(117, 31);
            this.btnDisplay.TabIndex = 1;
            this.btnDisplay.Text = "Pretraži";
            this.btnDisplay.UseVisualStyleBackColor = true;
            this.btnDisplay.Click += new System.EventHandler(this.btnDisplay_Click);
            // 
            // PropertyTitle
            // 
            this.PropertyTitle.DataPropertyName = "PropertyTitle";
            this.PropertyTitle.HeaderText = "Naslov nekretnine";
            this.PropertyTitle.MinimumWidth = 6;
            this.PropertyTitle.Name = "PropertyTitle";
            // 
            // AgentName
            // 
            this.AgentName.DataPropertyName = "AgentName";
            this.AgentName.HeaderText = "Agent";
            this.AgentName.MinimumWidth = 6;
            this.AgentName.Name = "AgentName";
            // 
            // ClientName
            // 
            this.ClientName.DataPropertyName = "ClientName";
            this.ClientName.HeaderText = "Klijent";
            this.ClientName.MinimumWidth = 6;
            this.ClientName.Name = "ClientName";
            // 
            // PropertyOwnerName
            // 
            this.PropertyOwnerName.DataPropertyName = "PropertyOwnerName";
            this.PropertyOwnerName.HeaderText = "Vlasnik";
            this.PropertyOwnerName.MinimumWidth = 6;
            this.PropertyOwnerName.Name = "PropertyOwnerName";
            // 
            // DateCreatedFormated
            // 
            this.DateCreatedFormated.DataPropertyName = "DateCreatedFormated";
            this.DateCreatedFormated.HeaderText = "Datum potpisivanja";
            this.DateCreatedFormated.MinimumWidth = 6;
            this.DateCreatedFormated.Name = "DateCreatedFormated";
            // 
            // frmDisplayContracts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmDisplayContracts";
            this.Text = "Ugovori";
            this.Load += new System.EventHandler(this.frmDisplayContracts_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvContracts)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvContracts;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnDisplay;
        private System.Windows.Forms.DataGridViewTextBoxColumn PropertyTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn AgentName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClientName;
        private System.Windows.Forms.DataGridViewTextBoxColumn PropertyOwnerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateCreatedFormated;
    }
}