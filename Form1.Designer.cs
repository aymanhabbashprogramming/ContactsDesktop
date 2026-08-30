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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvAllContacts = new System.Windows.Forms.DataGridView();
            this.cmsContactOptions = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiDeleteContac = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiEditContact = new System.Windows.Forms.ToolStripMenuItem();
            this.lblMode = new System.Windows.Forms.Label();
            this.btnAddNewContact = new System.Windows.Forms.Button();
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAllContacts.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAllContacts.Location = new System.Drawing.Point(12, 90);
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
            // 
            // tsmiEditContact
            // 
            this.tsmiEditContact.Name = "tsmiEditContact";
            this.tsmiEditContact.Size = new System.Drawing.Size(194, 28);
            this.tsmiEditContact.Text = "Edit Contact";
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
            this.btnAddNewContact.Location = new System.Drawing.Point(973, 37);
            this.btnAddNewContact.Name = "btnAddNewContact";
            this.btnAddNewContact.Size = new System.Drawing.Size(172, 43);
            this.btnAddNewContact.TabIndex = 23;
            this.btnAddNewContact.Text = "Add New Contact";
            this.btnAddNewContact.UseVisualStyleBackColor = true;
            this.btnAddNewContact.Click += new System.EventHandler(this.btnAddNewContact_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1157, 379);
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
    }
}

