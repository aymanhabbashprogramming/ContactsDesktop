namespace ContactsDesktopPresentation
{
    partial class frmCountriesList
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvAllCountries = new System.Windows.Forms.DataGridView();
            this.txtCountrytID = new System.Windows.Forms.TextBox();
            this.btnFindCountry = new System.Windows.Forms.Button();
            this.btnResfreshList = new System.Windows.Forms.Button();
            this.btnAddNewCountry = new System.Windows.Forms.Button();
            this.lblMode = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllCountries)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAllCountries
            // 
            this.dgvAllCountries.AllowUserToAddRows = false;
            this.dgvAllCountries.AllowUserToDeleteRows = false;
            this.dgvAllCountries.AllowUserToOrderColumns = true;
            this.dgvAllCountries.AllowUserToResizeColumns = false;
            this.dgvAllCountries.AllowUserToResizeRows = false;
            this.dgvAllCountries.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAllCountries.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvAllCountries.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAllCountries.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvAllCountries.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgvAllCountries.Location = new System.Drawing.Point(12, 93);
            this.dgvAllCountries.MultiSelect = false;
            this.dgvAllCountries.Name = "dgvAllCountries";
            this.dgvAllCountries.ReadOnly = true;
            this.dgvAllCountries.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvAllCountries.RowHeadersVisible = false;
            this.dgvAllCountries.RowHeadersWidth = 51;
            this.dgvAllCountries.RowTemplate.Height = 24;
            this.dgvAllCountries.Size = new System.Drawing.Size(551, 281);
            this.dgvAllCountries.TabIndex = 1;
            // 
            // txtCountrytID
            // 
            this.txtCountrytID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCountrytID.Location = new System.Drawing.Point(149, 51);
            this.txtCountrytID.Multiline = true;
            this.txtCountrytID.Name = "txtCountrytID";
            this.txtCountrytID.Size = new System.Drawing.Size(83, 35);
            this.txtCountrytID.TabIndex = 32;
            // 
            // btnFindCountry
            // 
            this.btnFindCountry.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFindCountry.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFindCountry.Location = new System.Drawing.Point(12, 52);
            this.btnFindCountry.Name = "btnFindCountry";
            this.btnFindCountry.Size = new System.Drawing.Size(131, 35);
            this.btnFindCountry.TabIndex = 31;
            this.btnFindCountry.Text = "Find Country";
            this.btnFindCountry.UseVisualStyleBackColor = true;
            this.btnFindCountry.Click += new System.EventHandler(this.btnFindCountry_Click);
            // 
            // btnResfreshList
            // 
            this.btnResfreshList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResfreshList.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResfreshList.Location = new System.Drawing.Point(260, 52);
            this.btnResfreshList.Name = "btnResfreshList";
            this.btnResfreshList.Size = new System.Drawing.Size(119, 35);
            this.btnResfreshList.TabIndex = 30;
            this.btnResfreshList.Text = "Refresh List";
            this.btnResfreshList.UseVisualStyleBackColor = true;
            this.btnResfreshList.Click += new System.EventHandler(this.btnResfreshList_Click);
            // 
            // btnAddNewCountry
            // 
            this.btnAddNewCountry.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNewCountry.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNewCountry.Location = new System.Drawing.Point(385, 52);
            this.btnAddNewCountry.Name = "btnAddNewCountry";
            this.btnAddNewCountry.Size = new System.Drawing.Size(178, 35);
            this.btnAddNewCountry.TabIndex = 29;
            this.btnAddNewCountry.Text = "Add New Country";
            this.btnAddNewCountry.UseVisualStyleBackColor = true;
            this.btnAddNewCountry.Click += new System.EventHandler(this.btnAddNewCountry_Click);
            // 
            // lblMode
            // 
            this.lblMode.AutoSize = true;
            this.lblMode.Font = new System.Drawing.Font("Microsoft Tai Le", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMode.Location = new System.Drawing.Point(222, 9);
            this.lblMode.Name = "lblMode";
            this.lblMode.Size = new System.Drawing.Size(129, 23);
            this.lblMode.TabIndex = 28;
            this.lblMode.Text = "Contactries List";
            // 
            // frmCountriesList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(575, 391);
            this.Controls.Add(this.txtCountrytID);
            this.Controls.Add(this.btnFindCountry);
            this.Controls.Add(this.btnResfreshList);
            this.Controls.Add(this.btnAddNewCountry);
            this.Controls.Add(this.lblMode);
            this.Controls.Add(this.dgvAllCountries);
            this.Name = "frmCountriesList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCountriesList";
            this.Load += new System.EventHandler(this.frmCountriesList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllCountries)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAllCountries;
        private System.Windows.Forms.TextBox txtCountrytID;
        private System.Windows.Forms.Button btnFindCountry;
        private System.Windows.Forms.Button btnResfreshList;
        private System.Windows.Forms.Button btnAddNewCountry;
        private System.Windows.Forms.Label lblMode;
    }
}