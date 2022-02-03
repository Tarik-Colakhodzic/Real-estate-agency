
namespace RealEstateAgency.WinUI.Payments
{
    partial class frmPayments
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
            this.dgvPayments = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreatedFormatted = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblUkupno = new System.Windows.Forms.Label();
            this.txtChargeId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCustomerOrTitle = new System.Windows.Forms.TextBox();
            this.btnTrazi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPayments)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPayments
            // 
            this.dgvPayments.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPayments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPayments.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Amount,
            this.Description,
            this.Status,
            this.CreatedFormatted});
            this.dgvPayments.Location = new System.Drawing.Point(12, 86);
            this.dgvPayments.Name = "dgvPayments";
            this.dgvPayments.RowHeadersWidth = 51;
            this.dgvPayments.RowTemplate.Height = 24;
            this.dgvPayments.Size = new System.Drawing.Size(1598, 445);
            this.dgvPayments.TabIndex = 0;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.FillWeight = 20F;
            this.Id.HeaderText = "Id transakcije";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            // 
            // Amount
            // 
            this.Amount.DataPropertyName = "Amount";
            this.Amount.FillWeight = 62.03209F;
            this.Amount.HeaderText = "Iznos (KM)";
            this.Amount.MinimumWidth = 6;
            this.Amount.Name = "Amount";
            // 
            // Description
            // 
            this.Description.DataPropertyName = "Description";
            this.Description.FillWeight = 62.03209F;
            this.Description.HeaderText = "Opis";
            this.Description.MinimumWidth = 6;
            this.Description.Name = "Description";
            // 
            // Status
            // 
            this.Status.DataPropertyName = "Status";
            this.Status.HeaderText = "Status";
            this.Status.MinimumWidth = 6;
            this.Status.Name = "Status";
            // 
            // CreatedFormatted
            // 
            this.CreatedFormatted.DataPropertyName = "CreatedFormatted";
            this.CreatedFormatted.HeaderText = "Datum i vrijeme transakcije";
            this.CreatedFormatted.MinimumWidth = 6;
            this.CreatedFormatted.Name = "CreatedFormatted";
            // 
            // lblUkupno
            // 
            this.lblUkupno.AutoSize = true;
            this.lblUkupno.Location = new System.Drawing.Point(1200, 534);
            this.lblUkupno.Name = "lblUkupno";
            this.lblUkupno.Size = new System.Drawing.Size(241, 17);
            this.lblUkupno.TabIndex = 1;
            this.lblUkupno.Text = "Ukupan iznos uspiješnih transakcija: ";
            // 
            // txtChargeId
            // 
            this.txtChargeId.Location = new System.Drawing.Point(12, 40);
            this.txtChargeId.Name = "txtChargeId";
            this.txtChargeId.Size = new System.Drawing.Size(204, 22);
            this.txtChargeId.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Id transakcije";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(222, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Korisnik ili naslov nekretnine";
            // 
            // txtCustomerOrTitle
            // 
            this.txtCustomerOrTitle.Location = new System.Drawing.Point(222, 40);
            this.txtCustomerOrTitle.Name = "txtCustomerOrTitle";
            this.txtCustomerOrTitle.Size = new System.Drawing.Size(411, 22);
            this.txtCustomerOrTitle.TabIndex = 5;
            // 
            // btnTrazi
            // 
            this.btnTrazi.Location = new System.Drawing.Point(1495, 29);
            this.btnTrazi.Name = "btnTrazi";
            this.btnTrazi.Size = new System.Drawing.Size(115, 33);
            this.btnTrazi.TabIndex = 7;
            this.btnTrazi.Text = "Traži";
            this.btnTrazi.UseVisualStyleBackColor = true;
            this.btnTrazi.Click += new System.EventHandler(this.btnTrazi_Click);
            // 
            // frmPayments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1622, 565);
            this.Controls.Add(this.btnTrazi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCustomerOrTitle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtChargeId);
            this.Controls.Add(this.lblUkupno);
            this.Controls.Add(this.dgvPayments);
            this.Name = "frmPayments";
            this.Text = "Uplate";
            this.Load += new System.EventHandler(this.frmPayments_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPayments)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPayments;
        private System.Windows.Forms.Label lblUkupno;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreatedFormatted;
        private System.Windows.Forms.TextBox txtChargeId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCustomerOrTitle;
        private System.Windows.Forms.Button btnTrazi;
    }
}