
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
            this.PropertyTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AgentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClientName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PropertyOwnerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateCreatedFormated = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbOwner = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbClient = new System.Windows.Forms.ComboBox();
            this.lblAgent = new System.Windows.Forms.Label();
            this.cmbAgent = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPropertyTitle = new System.Windows.Forms.TextBox();
            this.btnDisplay = new System.Windows.Forms.Button();
            this.btnGenerateReport = new System.Windows.Forms.Button();
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnClearDates = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContracts)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvContracts);
            this.groupBox1.Location = new System.Drawing.Point(13, 188);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(861, 333);
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
            this.dgvContracts.Size = new System.Drawing.Size(854, 305);
            this.dgvContracts.TabIndex = 0;
            this.dgvContracts.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvContracts_CellMouseDoubleClick);
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
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnClearDates);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.dtpEnd);
            this.groupBox2.Controls.Add(this.dtpStart);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.cmbOwner);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.cmbClient);
            this.groupBox2.Controls.Add(this.lblAgent);
            this.groupBox2.Controls.Add(this.cmbAgent);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtPropertyTitle);
            this.groupBox2.Controls.Add(this.btnDisplay);
            this.groupBox2.Location = new System.Drawing.Point(13, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(861, 153);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Pretraga";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(310, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 17);
            this.label4.TabIndex = 18;
            this.label4.Text = "Vlasnik";
            // 
            // cmbOwner
            // 
            this.cmbOwner.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOwner.FormattingEnabled = true;
            this.cmbOwner.Location = new System.Drawing.Point(310, 59);
            this.cmbOwner.Name = "cmbOwner";
            this.cmbOwner.Size = new System.Drawing.Size(161, 24);
            this.cmbOwner.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(146, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 17);
            this.label3.TabIndex = 16;
            this.label3.Text = "Klijent";
            // 
            // cmbClient
            // 
            this.cmbClient.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbClient.FormattingEnabled = true;
            this.cmbClient.Location = new System.Drawing.Point(146, 59);
            this.cmbClient.Name = "cmbClient";
            this.cmbClient.Size = new System.Drawing.Size(158, 24);
            this.cmbClient.TabIndex = 15;
            // 
            // lblAgent
            // 
            this.lblAgent.AutoSize = true;
            this.lblAgent.Location = new System.Drawing.Point(477, 36);
            this.lblAgent.Name = "lblAgent";
            this.lblAgent.Size = new System.Drawing.Size(45, 17);
            this.lblAgent.TabIndex = 14;
            this.lblAgent.Text = "Agent";
            // 
            // cmbAgent
            // 
            this.cmbAgent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAgent.FormattingEnabled = true;
            this.cmbAgent.Location = new System.Drawing.Point(477, 59);
            this.cmbAgent.Name = "cmbAgent";
            this.cmbAgent.Size = new System.Drawing.Size(168, 24);
            this.cmbAgent.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "Naslov";
            // 
            // txtPropertyTitle
            // 
            this.txtPropertyTitle.Location = new System.Drawing.Point(7, 59);
            this.txtPropertyTitle.Name = "txtPropertyTitle";
            this.txtPropertyTitle.Size = new System.Drawing.Size(133, 22);
            this.txtPropertyTitle.TabIndex = 11;
            // 
            // btnDisplay
            // 
            this.btnDisplay.Location = new System.Drawing.Point(738, 109);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(117, 31);
            this.btnDisplay.TabIndex = 1;
            this.btnDisplay.Text = "Pretraži";
            this.btnDisplay.UseVisualStyleBackColor = true;
            this.btnDisplay.Click += new System.EventHandler(this.btnDisplay_Click);
            // 
            // btnGenerateReport
            // 
            this.btnGenerateReport.Location = new System.Drawing.Point(719, 521);
            this.btnGenerateReport.Name = "btnGenerateReport";
            this.btnGenerateReport.Size = new System.Drawing.Size(155, 31);
            this.btnGenerateReport.TabIndex = 19;
            this.btnGenerateReport.Text = "Generiši izvještaj";
            this.btnGenerateReport.UseVisualStyleBackColor = true;
            this.btnGenerateReport.Click += new System.EventHandler(this.btnGenerateReport_Click);
            // 
            // dtpStart
            // 
            this.dtpStart.Location = new System.Drawing.Point(7, 111);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(200, 22);
            this.dtpStart.TabIndex = 19;
            this.dtpStart.ValueChanged += new System.EventHandler(this.dtpStart_ValueChanged);
            // 
            // dtpEnd
            // 
            this.dtpEnd.Location = new System.Drawing.Point(213, 111);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(200, 22);
            this.dtpEnd.TabIndex = 20;
            this.dtpEnd.ValueChanged += new System.EventHandler(this.dtpEnd_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 17);
            this.label2.TabIndex = 21;
            this.label2.Text = "Od";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(210, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 17);
            this.label5.TabIndex = 22;
            this.label5.Text = "Do";
            // 
            // btnClearDates
            // 
            this.btnClearDates.Location = new System.Drawing.Point(419, 109);
            this.btnClearDates.Name = "btnClearDates";
            this.btnClearDates.Size = new System.Drawing.Size(117, 24);
            this.btnClearDates.TabIndex = 23;
            this.btnClearDates.Text = "Očisti datume";
            this.btnClearDates.UseVisualStyleBackColor = true;
            this.btnClearDates.Click += new System.EventHandler(this.btnClearDates_Click);
            // 
            // frmDisplayContracts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 569);
            this.Controls.Add(this.btnGenerateReport);
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
        private System.Windows.Forms.TextBox txtPropertyTitle;
        private System.Windows.Forms.Button btnDisplay;
        private System.Windows.Forms.DataGridViewTextBoxColumn PropertyTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn AgentName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClientName;
        private System.Windows.Forms.DataGridViewTextBoxColumn PropertyOwnerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateCreatedFormated;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbOwner;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbClient;
        private System.Windows.Forms.Label lblAgent;
        private System.Windows.Forms.ComboBox cmbAgent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGenerateReport;
        private System.Windows.Forms.Button btnClearDates;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpEnd;
        private System.Windows.Forms.DateTimePicker dtpStart;
    }
}