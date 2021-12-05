
namespace RealEstateAgency.WinUI.Visit
{
    partial class frmVisitsDisplay
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtPropertyTitle = new System.Windows.Forms.TextBox();
            this.btnDisplay = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvVisits = new System.Windows.Forms.DataGridView();
            this.PropertyTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClientName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateTimeFormated = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Approved = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btnDelete = new System.Windows.Forms.Button();
            this.cmbClient = new System.Windows.Forms.ComboBox();
            this.chbApporeved = new System.Windows.Forms.CheckBox();
            this.chbNotApproved = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVisits)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.chbNotApproved);
            this.groupBox2.Controls.Add(this.chbApporeved);
            this.groupBox2.Controls.Add(this.cmbClient);
            this.groupBox2.Controls.Add(this.txtPropertyTitle);
            this.groupBox2.Controls.Add(this.btnDisplay);
            this.groupBox2.Location = new System.Drawing.Point(13, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(775, 111);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Pretraga";
            // 
            // txtPropertyTitle
            // 
            this.txtPropertyTitle.Location = new System.Drawing.Point(6, 62);
            this.txtPropertyTitle.Name = "txtPropertyTitle";
            this.txtPropertyTitle.Size = new System.Drawing.Size(148, 22);
            this.txtPropertyTitle.TabIndex = 11;
            // 
            // btnDisplay
            // 
            this.btnDisplay.Location = new System.Drawing.Point(652, 53);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(117, 31);
            this.btnDisplay.TabIndex = 1;
            this.btnDisplay.Text = "Pretraži";
            this.btnDisplay.UseVisualStyleBackColor = true;
            this.btnDisplay.Click += new System.EventHandler(this.btnDisplay_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvVisits);
            this.groupBox1.Location = new System.Drawing.Point(19, 129);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(775, 333);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Posjete";
            // 
            // dgvVisits
            // 
            this.dgvVisits.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvVisits.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVisits.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PropertyTitle,
            this.ClientName,
            this.DateTimeFormated,
            this.Approved});
            this.dgvVisits.Location = new System.Drawing.Point(7, 22);
            this.dgvVisits.Name = "dgvVisits";
            this.dgvVisits.RowHeadersWidth = 51;
            this.dgvVisits.RowTemplate.Height = 24;
            this.dgvVisits.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVisits.Size = new System.Drawing.Size(762, 305);
            this.dgvVisits.TabIndex = 0;
            this.dgvVisits.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVisits_CellContentClick);
            // 
            // PropertyTitle
            // 
            this.PropertyTitle.DataPropertyName = "PropertyTitle";
            this.PropertyTitle.HeaderText = "Naslov nekretnine";
            this.PropertyTitle.MinimumWidth = 6;
            this.PropertyTitle.Name = "PropertyTitle";
            // 
            // ClientName
            // 
            this.ClientName.DataPropertyName = "ClientName";
            this.ClientName.HeaderText = "Klijent";
            this.ClientName.MinimumWidth = 6;
            this.ClientName.Name = "ClientName";
            // 
            // DateTimeFormated
            // 
            this.DateTimeFormated.DataPropertyName = "DateTimeFormated";
            this.DateTimeFormated.HeaderText = "Vrijeme";
            this.DateTimeFormated.MinimumWidth = 6;
            this.DateTimeFormated.Name = "DateTimeFormated";
            // 
            // Approved
            // 
            this.Approved.DataPropertyName = "Approved";
            this.Approved.HeaderText = "Odobren";
            this.Approved.MinimumWidth = 6;
            this.Approved.Name = "Approved";
            this.Approved.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Approved.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(665, 468);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(117, 31);
            this.btnDelete.TabIndex = 12;
            this.btnDelete.Text = "Obriši";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // cmbClient
            // 
            this.cmbClient.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbClient.FormattingEnabled = true;
            this.cmbClient.Location = new System.Drawing.Point(160, 62);
            this.cmbClient.Name = "cmbClient";
            this.cmbClient.Size = new System.Drawing.Size(150, 24);
            this.cmbClient.TabIndex = 12;
            // 
            // chbApporeved
            // 
            this.chbApporeved.AutoSize = true;
            this.chbApporeved.Location = new System.Drawing.Point(326, 62);
            this.chbApporeved.Name = "chbApporeved";
            this.chbApporeved.Size = new System.Drawing.Size(94, 21);
            this.chbApporeved.TabIndex = 13;
            this.chbApporeved.Text = "Odobrena";
            this.chbApporeved.UseVisualStyleBackColor = true;
            // 
            // chbNotApproved
            // 
            this.chbNotApproved.AutoSize = true;
            this.chbNotApproved.Location = new System.Drawing.Point(430, 62);
            this.chbNotApproved.Name = "chbNotApproved";
            this.chbNotApproved.Size = new System.Drawing.Size(109, 21);
            this.chbNotApproved.TabIndex = 14;
            this.chbNotApproved.Text = "Neodobrena";
            this.chbNotApproved.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 17);
            this.label1.TabIndex = 15;
            this.label1.Text = "Naslov";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(157, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 16;
            this.label2.Text = "Klijent";
            // 
            // frmVisitsDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 511);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "frmVisitsDisplay";
            this.Text = "Posjete";
            this.Load += new System.EventHandler(this.frmVisitsDisplay_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVisits)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtPropertyTitle;
        private System.Windows.Forms.Button btnDisplay;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvVisits;
        private System.Windows.Forms.DataGridViewTextBoxColumn PropertyTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClientName;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateTimeFormated;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Approved;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chbNotApproved;
        private System.Windows.Forms.CheckBox chbApporeved;
        private System.Windows.Forms.ComboBox cmbClient;
    }
}