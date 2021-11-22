
namespace RealEstateAgency.WinUI.BookOfComplaints
{
    partial class frmDisplayBooksOfComplaints
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
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnDisplay = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvBooksOfConstraints = new System.Windows.Forms.DataGridView();
            this.PropertyTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AgentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Comment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateCreatedFormated = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooksOfConstraints)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtSearch);
            this.groupBox2.Controls.Add(this.btnDisplay);
            this.groupBox2.Location = new System.Drawing.Point(13, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(775, 80);
            this.groupBox2.TabIndex = 4;
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvBooksOfConstraints);
            this.groupBox1.Location = new System.Drawing.Point(13, 105);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(775, 333);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Konjiga žalbi";
            // 
            // dgvBooksOfConstraints
            // 
            this.dgvBooksOfConstraints.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBooksOfConstraints.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBooksOfConstraints.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PropertyTitle,
            this.AgentName,
            this.Comment,
            this.DateCreatedFormated});
            this.dgvBooksOfConstraints.Location = new System.Drawing.Point(7, 22);
            this.dgvBooksOfConstraints.Name = "dgvBooksOfConstraints";
            this.dgvBooksOfConstraints.RowHeadersWidth = 51;
            this.dgvBooksOfConstraints.RowTemplate.Height = 24;
            this.dgvBooksOfConstraints.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBooksOfConstraints.Size = new System.Drawing.Size(762, 305);
            this.dgvBooksOfConstraints.TabIndex = 0;
            this.dgvBooksOfConstraints.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvBooksOfConstraints_CellMouseDoubleClick);
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
            // Comment
            // 
            this.Comment.DataPropertyName = "Comment";
            this.Comment.HeaderText = "Komentar";
            this.Comment.MinimumWidth = 6;
            this.Comment.Name = "Comment";
            // 
            // DateCreatedFormated
            // 
            this.DateCreatedFormated.DataPropertyName = "DateCreatedFormated";
            this.DateCreatedFormated.HeaderText = "Datum unosa";
            this.DateCreatedFormated.MinimumWidth = 6;
            this.DateCreatedFormated.Name = "DateCreatedFormated";
            // 
            // frmDisplayBooksOfComplaints
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "frmDisplayBooksOfComplaints";
            this.Text = "Knjiga žalbi";
            this.Load += new System.EventHandler(this.frmDisplayBooksOfConstraints_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooksOfConstraints)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnDisplay;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvBooksOfConstraints;
        private System.Windows.Forms.DataGridViewTextBoxColumn PropertyTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn AgentName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Comment;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateCreatedFormated;
    }
}