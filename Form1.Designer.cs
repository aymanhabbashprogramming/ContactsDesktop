namespace ContactsDesktopPresentation
{
    partial class Form1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvAllContacts = new System.Windows.Forms.DataGridView();
            this.cmsContactOptions = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiDeleteContac = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiEditContact = new System.Windows.Forms.ToolStripMenuItem();
            this.lblMode = new System.Windows.Forms.Label();
            this.btnAddNewContact = new System.Windows.Forms.Button();
            this.btnResfreshList = new System.Windows.Forms.Button();
            this.btnFindContact = new System.Windows.Forms.Button();
            this.txtContactID = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllContacts)).BeginInit();
            this.cmsContactOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvAllContacts
            // 
            this.dgvAllContacts.AllowUserToAddRows = false;
            this.dgvAllContacts.AllowUserToDeleteRows = false;
            this.dgvAllContacts.AllowUserToOrderColumns = true;
            this.dgvAllContacts.AllowUserToResizeColumns = false;
            this.dgvAllContacts.AllowUserToResizeRows = false;
            this.dgvAllContacts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAllContacts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAllContacts.ContextMenuStrip = this.cmsContactOptions;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAllContacts.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvAllContacts.Location = new System.Drawing.Point(12, 73);
            this.dgvAllContacts.MultiSelect = false;
            this.dgvAllContacts.Name = "dgvAllContacts";
            this.dgvAllContacts.ReadOnly = true;
            this.dgvAllContacts.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvAllContacts.RowHeadersVisible = false;
            this.dgvAllContacts.RowHeadersWidth = 51;
            this.dgvAllContacts.RowTemplate.Height = 24;
            this.dgvAllContacts.Size = new System.Drawing.Size(1133, 266);
            this.dgvAllContacts.TabIndex = 0;
            // 
            // cmsContactOptions
            // 
            this.cmsContactOptions.BackColor = System.Drawing.SystemColors.Info;
            this.cmsContactOptions.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmsContactOptions.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsContactOptions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiDeleteContac,
            this.tsmiEditContact});
            this.cmsContactOptions.Name = "cmsContactOptions";
            this.cmsContactOptions.Size = new System.Drawing.Size(195, 60);
            // 
            // tsmiDeleteContac
            // 
            this.tsmiDeleteContac.Name = "tsmiDeleteContac";
            this.tsmiDeleteContac.Size = new System.Drawing.Size(194, 28);
            this.tsmiDeleteContac.Text = "Delete Contact";
            this.tsmiDeleteContac.Click += new System.EventHandler(this.tsmiDeleteContac_Click);
            // 
            // tsmiEditContact
            // 
            this.tsmiEditContact.Name = "tsmiEditContact";
            this.tsmiEditContact.Size = new System.Drawing.Size(194, 28);
            this.tsmiEditContact.Text = "Edit Contact";
            this.tsmiEditContact.Click += new System.EventHandler(this.tsmiEditContact_Click);
            // 
            // lblMode
            // 
            this.lblMode.AutoSize = true;
            this.lblMode.Font = new System.Drawing.Font("Microsoft Tai Le", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMode.Location = new System.Drawing.Point(546, 9);
            this.lblMode.Name = "lblMode";
            this.lblMode.Size = new System.Drawing.Size(110, 23);
            this.lblMode.TabIndex = 2;
            this.lblMode.Text = "Contacts List";
            // 
            // btnAddNewContact
            // 
            this.btnAddNewContact.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNewContact.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNewContact.Location = new System.Drawing.Point(954, 26);
            this.btnAddNewContact.Name = "btnAddNewContact";
            this.btnAddNewContact.Size = new System.Drawing.Size(191, 41);
            this.btnAddNewContact.TabIndex = 23;
            this.btnAddNewContact.Text = "Add New Contact";
            this.btnAddNewContact.UseVisualStyleBackColor = true;
            this.btnAddNewContact.Click += new System.EventHandler(this.btnAddNewContact_Click);
            // 
            // btnResfreshList
            // 
            this.btnResfreshList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResfreshList.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResfreshList.Location = new System.Drawing.Point(820, 26);
            this.btnResfreshList.Name = "btnResfreshList";
            this.btnResfreshList.Size = new System.Drawing.Size(128, 41);
            this.btnResfreshList.TabIndex = 25;
            this.btnResfreshList.Text = "Refresh List";
            this.btnResfreshList.UseVisualStyleBackColor = true;
            this.btnResfreshList.Click += new System.EventHandler(this.btnResfreshList_Click);
            // 
            // btnFindContact
            // 
            this.btnFindContact.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFindContact.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFindContact.Location = new System.Drawing.Point(12, 26);
            this.btnFindContact.Name = "btnFindContact";
            this.btnFindContact.Size = new System.Drawing.Size(140, 41);
            this.btnFindContact.TabIndex = 26;
            this.btnFindContact.Text = "Find Contact";
            this.btnFindContact.UseVisualStyleBackColor = true;
            this.btnFindContact.Click += new System.EventHandler(this.btnFindContact_Click);
            // 
            // txtContactID
            // 
            this.txtContactID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContactID.Location = new System.Drawing.Point(158, 26);
            this.txtContactID.Multiline = true;
            this.txtContactID.Name = "txtContactID";
            this.txtContactID.Size = new System.Drawing.Size(118, 41);
            this.txtContactID.TabIndex = 27;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1157, 356);
            this.Controls.Add(this.txtContactID);
            this.Controls.Add(this.btnFindContact);
            this.Controls.Add(this.btnResfreshList);
            this.Controls.Add(this.btnAddNewContact);
            this.Controls.Add(this.lblMode);
            this.Controls.Add(this.dgvAllContacts);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllContacts)).EndInit();
            this.cmsContactOptions.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAllContacts;
        private System.Windows.Forms.ContextMenuStrip cmsContactOptions;
        private System.Windows.Forms.ToolStripMenuItem tsmiDeleteContac;
        private System.Windows.Forms.ToolStripMenuItem tsmiEditContact;
        private System.Windows.Forms.Label lblMode;
        private System.Windows.Forms.Button btnAddNewContact;
        private System.Windows.Forms.Button btnResfreshList;
        private System.Windows.Forms.Button btnFindContact;
        private System.Windows.Forms.TextBox txtContactID;
    }
}

