
namespace RealEstateAgency.WinUI.User
{
    partial class frmUsersDetails
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
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtConfirmedPassword = new System.Windows.Forms.TextBox();
            this.btnSaveUser = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.clbRoles = new System.Windows.Forms.CheckedListBox();
            this.lblSalary = new System.Windows.Forms.Label();
            this.txtSalary = new System.Windows.Forms.TextBox();
            this.dtpHireDate = new System.Windows.Forms.DateTimePicker();
            this.lblHireDate = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblKM = new System.Windows.Forms.Label();
            this.btnIncrease = new System.Windows.Forms.Button();
            this.lblPercentage = new System.Windows.Forms.Label();
            this.txtIncreaseSalaryBy = new System.Windows.Forms.TextBox();
            this.lblIncrease = new System.Windows.Forms.Label();
            this.btnUploadImage = new System.Windows.Forms.Button();
            this.pbAgentImage = new System.Windows.Forms.PictureBox();
            this.lblNoAgent = new System.Windows.Forms.Label();
            this.btnSaveAgent = new System.Windows.Forms.Button();
            this.ofdImageUpload = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAgentImage)).BeginInit();
            this.SuspendLayout();
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(6, 46);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(290, 22);
            this.txtFirstName.TabIndex = 0;
            this.txtFirstName.Validating += new System.ComponentModel.CancelEventHandler(this.txtFirstName_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ime";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Prezime";
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(6, 110);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(290, 22);
            this.txtLastName.TabIndex = 2;
            this.txtLastName.Validating += new System.ComponentModel.CancelEventHandler(this.txtLastName_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Email";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(6, 171);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(290, 22);
            this.txtEmail.TabIndex = 4;
            this.txtEmail.Validating += new System.ComponentModel.CancelEventHandler(this.txtEmail_Validating);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 213);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Broj telefona";
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new System.Drawing.Point(6, 236);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(290, 22);
            this.txtPhoneNumber.TabIndex = 6;
            this.txtPhoneNumber.Validating += new System.ComponentModel.CancelEventHandler(this.txtPhoneNumber_Validating);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 280);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Korisničko ime";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(6, 303);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(290, 22);
            this.txtUsername.TabIndex = 8;
            this.txtUsername.Validating += new System.ComponentModel.CancelEventHandler(this.txtUsername_Validating);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 347);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "Lozinka";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(6, 370);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(290, 22);
            this.txtPassword.TabIndex = 10;
            this.txtPassword.UseSystemPasswordChar = true;
            this.txtPassword.Validating += new System.ComponentModel.CancelEventHandler(this.txtPassword_Validating);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 412);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 17);
            this.label7.TabIndex = 13;
            this.label7.Text = "Potvrda lozinke";
            // 
            // txtConfirmedPassword
            // 
            this.txtConfirmedPassword.Location = new System.Drawing.Point(6, 435);
            this.txtConfirmedPassword.Name = "txtConfirmedPassword";
            this.txtConfirmedPassword.Size = new System.Drawing.Size(290, 22);
            this.txtConfirmedPassword.TabIndex = 12;
            this.txtConfirmedPassword.UseSystemPasswordChar = true;
            this.txtConfirmedPassword.Validating += new System.ComponentModel.CancelEventHandler(this.txtConfirmedPassword_Validating);
            // 
            // btnSaveUser
            // 
            this.btnSaveUser.Location = new System.Drawing.Point(442, 427);
            this.btnSaveUser.Name = "btnSaveUser";
            this.btnSaveUser.Size = new System.Drawing.Size(96, 38);
            this.btnSaveUser.TabIndex = 16;
            this.btnSaveUser.Text = "Sačuvaj";
            this.btnSaveUser.UseVisualStyleBackColor = true;
            this.btnSaveUser.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // clbRoles
            // 
            this.clbRoles.FormattingEnabled = true;
            this.clbRoles.Location = new System.Drawing.Point(338, 46);
            this.clbRoles.Name = "clbRoles";
            this.clbRoles.Size = new System.Drawing.Size(220, 123);
            this.clbRoles.TabIndex = 17;
            this.clbRoles.SelectedIndexChanged += new System.EventHandler(this.clbRoles_SelectedIndexChanged);
            // 
            // lblSalary
            // 
            this.lblSalary.AutoSize = true;
            this.lblSalary.Location = new System.Drawing.Point(9, 37);
            this.lblSalary.Name = "lblSalary";
            this.lblSalary.Size = new System.Drawing.Size(40, 17);
            this.lblSalary.TabIndex = 19;
            this.lblSalary.Text = "Plata";
            this.lblSalary.Visible = false;
            // 
            // txtSalary
            // 
            this.txtSalary.Location = new System.Drawing.Point(9, 60);
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.Size = new System.Drawing.Size(102, 22);
            this.txtSalary.TabIndex = 18;
            this.txtSalary.Visible = false;
            // 
            // dtpHireDate
            // 
            this.dtpHireDate.Location = new System.Drawing.Point(9, 144);
            this.dtpHireDate.Name = "dtpHireDate";
            this.dtpHireDate.Size = new System.Drawing.Size(290, 22);
            this.dtpHireDate.TabIndex = 20;
            this.dtpHireDate.Visible = false;
            // 
            // lblHireDate
            // 
            this.lblHireDate.AutoSize = true;
            this.lblHireDate.Location = new System.Drawing.Point(9, 124);
            this.lblHireDate.Name = "lblHireDate";
            this.lblHireDate.Size = new System.Drawing.Size(121, 17);
            this.lblHireDate.TabIndex = 21;
            this.lblHireDate.Text = "Datum zaposlenja";
            this.lblHireDate.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtFirstName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtLastName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtEmail);
            this.groupBox1.Controls.Add(this.clbRoles);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnSaveUser);
            this.groupBox1.Controls.Add(this.txtPhoneNumber);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtConfirmedPassword);
            this.groupBox1.Controls.Add(this.txtUsername);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtPassword);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(566, 497);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Korisnik";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblKM);
            this.groupBox2.Controls.Add(this.btnIncrease);
            this.groupBox2.Controls.Add(this.lblPercentage);
            this.groupBox2.Controls.Add(this.txtIncreaseSalaryBy);
            this.groupBox2.Controls.Add(this.lblIncrease);
            this.groupBox2.Controls.Add(this.btnUploadImage);
            this.groupBox2.Controls.Add(this.pbAgentImage);
            this.groupBox2.Controls.Add(this.lblNoAgent);
            this.groupBox2.Controls.Add(this.btnSaveAgent);
            this.groupBox2.Controls.Add(this.dtpHireDate);
            this.groupBox2.Controls.Add(this.txtSalary);
            this.groupBox2.Controls.Add(this.lblHireDate);
            this.groupBox2.Controls.Add(this.lblSalary);
            this.groupBox2.Location = new System.Drawing.Point(12, 516);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(566, 305);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Agent";
            // 
            // lblKM
            // 
            this.lblKM.AutoSize = true;
            this.lblKM.Location = new System.Drawing.Point(117, 63);
            this.lblKM.Name = "lblKM";
            this.lblKM.Size = new System.Drawing.Size(28, 17);
            this.lblKM.TabIndex = 29;
            this.lblKM.Text = "KM";
            this.lblKM.Visible = false;
            // 
            // btnIncrease
            // 
            this.btnIncrease.Location = new System.Drawing.Point(218, 200);
            this.btnIncrease.Name = "btnIncrease";
            this.btnIncrease.Size = new System.Drawing.Size(85, 28);
            this.btnIncrease.TabIndex = 28;
            this.btnIncrease.Text = "Povećaj";
            this.btnIncrease.UseVisualStyleBackColor = true;
            this.btnIncrease.Visible = false;
            this.btnIncrease.Click += new System.EventHandler(this.btnIncrease_Click);
            // 
            // lblPercentage
            // 
            this.lblPercentage.AutoSize = true;
            this.lblPercentage.Location = new System.Drawing.Point(192, 206);
            this.lblPercentage.Name = "lblPercentage";
            this.lblPercentage.Size = new System.Drawing.Size(20, 17);
            this.lblPercentage.TabIndex = 27;
            this.lblPercentage.Text = "%";
            this.lblPercentage.Visible = false;
            // 
            // txtIncreaseSalaryBy
            // 
            this.txtIncreaseSalaryBy.Location = new System.Drawing.Point(132, 203);
            this.txtIncreaseSalaryBy.Name = "txtIncreaseSalaryBy";
            this.txtIncreaseSalaryBy.Size = new System.Drawing.Size(54, 22);
            this.txtIncreaseSalaryBy.TabIndex = 26;
            this.txtIncreaseSalaryBy.Visible = false;
            // 
            // lblIncrease
            // 
            this.lblIncrease.AutoSize = true;
            this.lblIncrease.Location = new System.Drawing.Point(10, 203);
            this.lblIncrease.Name = "lblIncrease";
            this.lblIncrease.Size = new System.Drawing.Size(116, 17);
            this.lblIncrease.TabIndex = 25;
            this.lblIncrease.Text = "Povećaj platu za:";
            this.lblIncrease.Visible = false;
            // 
            // btnUploadImage
            // 
            this.btnUploadImage.Location = new System.Drawing.Point(381, 203);
            this.btnUploadImage.Name = "btnUploadImage";
            this.btnUploadImage.Size = new System.Drawing.Size(177, 28);
            this.btnUploadImage.TabIndex = 24;
            this.btnUploadImage.Text = "Učitaj sliku";
            this.btnUploadImage.UseVisualStyleBackColor = true;
            this.btnUploadImage.Visible = false;
            this.btnUploadImage.Click += new System.EventHandler(this.btnUploadImage_Click);
            // 
            // pbAgentImage
            // 
            this.pbAgentImage.Location = new System.Drawing.Point(381, 13);
            this.pbAgentImage.Name = "pbAgentImage";
            this.pbAgentImage.Size = new System.Drawing.Size(177, 184);
            this.pbAgentImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAgentImage.TabIndex = 23;
            this.pbAgentImage.TabStop = false;
            this.pbAgentImage.Visible = false;
            // 
            // lblNoAgent
            // 
            this.lblNoAgent.AutoSize = true;
            this.lblNoAgent.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoAgent.Location = new System.Drawing.Point(8, 99);
            this.lblNoAgent.Name = "lblNoAgent";
            this.lblNoAgent.Size = new System.Drawing.Size(268, 20);
            this.lblNoAgent.TabIndex = 22;
            this.lblNoAgent.Text = "Korisnik ne posjeduje ulogu agenta";
            this.lblNoAgent.Visible = false;
            // 
            // btnSaveAgent
            // 
            this.btnSaveAgent.Location = new System.Drawing.Point(462, 251);
            this.btnSaveAgent.Name = "btnSaveAgent";
            this.btnSaveAgent.Size = new System.Drawing.Size(96, 38);
            this.btnSaveAgent.TabIndex = 18;
            this.btnSaveAgent.Text = "Sačuvaj";
            this.btnSaveAgent.UseVisualStyleBackColor = true;
            this.btnSaveAgent.Visible = false;
            this.btnSaveAgent.Click += new System.EventHandler(this.btnSaveAgent_Click);
            // 
            // ofdImageUpload
            // 
            this.ofdImageUpload.FileName = "openFileDialog1";
            // 
            // frmUsersDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 833);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmUsersDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Detalji korisnika";
            this.Load += new System.EventHandler(this.frmUsersDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAgentImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtConfirmedPassword;
        private System.Windows.Forms.Button btnSaveUser;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.CheckedListBox clbRoles;
        private System.Windows.Forms.Label lblHireDate;
        private System.Windows.Forms.DateTimePicker dtpHireDate;
        private System.Windows.Forms.Label lblSalary;
        private System.Windows.Forms.TextBox txtSalary;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnSaveAgent;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblNoAgent;
        private System.Windows.Forms.Button btnUploadImage;
        private System.Windows.Forms.PictureBox pbAgentImage;
        private System.Windows.Forms.OpenFileDialog ofdImageUpload;
        private System.Windows.Forms.Button btnIncrease;
        private System.Windows.Forms.Label lblPercentage;
        private System.Windows.Forms.TextBox txtIncreaseSalaryBy;
        private System.Windows.Forms.Label lblIncrease;
        private System.Windows.Forms.Label lblKM;
    }
}