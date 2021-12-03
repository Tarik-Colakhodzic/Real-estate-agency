
namespace RealEstateAgency.WinUI.Contract
{
    partial class frmContractDetails
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
            this.cmbProperty = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtOwner = new System.Windows.Forms.TextBox();
            this.Vlasnik = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbClient = new System.Windows.Forms.ComboBox();
            this.dtmDateCreated = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.txtContractNumber = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbProperty
            // 
            this.cmbProperty.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProperty.FormattingEnabled = true;
            this.cmbProperty.Location = new System.Drawing.Point(13, 42);
            this.cmbProperty.Name = "cmbProperty";
            this.cmbProperty.Size = new System.Drawing.Size(193, 24);
            this.cmbProperty.TabIndex = 0;
            this.cmbProperty.SelectedIndexChanged += new System.EventHandler(this.cmbProperty_SelectedIndexChanged);
            this.cmbProperty.Validating += new System.ComponentModel.CancelEventHandler(this.cmbProperty_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nekretnina";
            // 
            // txtOwner
            // 
            this.txtOwner.Location = new System.Drawing.Point(13, 112);
            this.txtOwner.Name = "txtOwner";
            this.txtOwner.ReadOnly = true;
            this.txtOwner.Size = new System.Drawing.Size(193, 22);
            this.txtOwner.TabIndex = 2;
            // 
            // Vlasnik
            // 
            this.Vlasnik.AutoSize = true;
            this.Vlasnik.Location = new System.Drawing.Point(13, 92);
            this.Vlasnik.Name = "Vlasnik";
            this.Vlasnik.Size = new System.Drawing.Size(53, 17);
            this.Vlasnik.TabIndex = 3;
            this.Vlasnik.Text = "Vlasnik";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Klijent";
            // 
            // cmbClient
            // 
            this.cmbClient.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbClient.FormattingEnabled = true;
            this.cmbClient.Location = new System.Drawing.Point(13, 183);
            this.cmbClient.Name = "cmbClient";
            this.cmbClient.Size = new System.Drawing.Size(193, 24);
            this.cmbClient.TabIndex = 4;
            this.cmbClient.Validating += new System.ComponentModel.CancelEventHandler(this.cmbClient_Validating);
            // 
            // dtmDateCreated
            // 
            this.dtmDateCreated.Location = new System.Drawing.Point(13, 259);
            this.dtmDateCreated.MinDate = new System.DateTime(2009, 1, 1, 0, 0, 0, 0);
            this.dtmDateCreated.Name = "dtmDateCreated";
            this.dtmDateCreated.Size = new System.Drawing.Size(200, 22);
            this.dtmDateCreated.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 239);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Datum potpisivanja";
            // 
            // txtContractNumber
            // 
            this.txtContractNumber.Location = new System.Drawing.Point(265, 44);
            this.txtContractNumber.Name = "txtContractNumber";
            this.txtContractNumber.Size = new System.Drawing.Size(200, 22);
            this.txtContractNumber.TabIndex = 8;
            this.txtContractNumber.Validating += new System.ComponentModel.CancelEventHandler(this.txtContractNumber_Validating);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(265, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Broj ugovora";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(265, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Cijena";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(265, 112);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(200, 22);
            this.txtPrice.TabIndex = 10;
            this.txtPrice.Validating += new System.ComponentModel.CancelEventHandler(this.txtPrice_Validating);
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(268, 183);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(197, 98);
            this.txtDescription.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(265, 160);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "Napomene";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(357, 319);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(108, 34);
            this.btnSave.TabIndex = 14;
            this.btnSave.Text = "Sačuvaj";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // frmContractDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 388);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtContractNumber);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtmDateCreated);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbClient);
            this.Controls.Add(this.Vlasnik);
            this.Controls.Add(this.txtOwner);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbProperty);
            this.Name = "frmContractDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmContractDetails";
            this.Load += new System.EventHandler(this.frmContractDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbProperty;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtOwner;
        private System.Windows.Forms.Label Vlasnik;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbClient;
        private System.Windows.Forms.DateTimePicker dtmDateCreated;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtContractNumber;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}