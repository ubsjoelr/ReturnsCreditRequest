namespace ReturnsCreditRequest
{
    partial class ManualSuppliers
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
            this.btnRemove = new System.Windows.Forms.Button();
            this.lblSupplierID = new System.Windows.Forms.Label();
            this.txtSupplierID = new System.Windows.Forms.TextBox();
            this.lblNamePrevious = new System.Windows.Forms.Label();
            this.lblNameNext = new System.Windows.Forms.Label();
            this.txtMainContact = new System.Windows.Forms.TextBox();
            this.lblMainContact = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtCompanyPhone = new System.Windows.Forms.TextBox();
            this.lblCompanyPhone = new System.Windows.Forms.Label();
            this.txtCountry = new System.Windows.Forms.TextBox();
            this.lblCountry = new System.Windows.Forms.Label();
            this.txtZip = new System.Windows.Forms.TextBox();
            this.txtState = new System.Windows.Forms.TextBox();
            this.lblCSZ = new System.Windows.Forms.Label();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.lblAddr2 = new System.Windows.Forms.Label();
            this.txtAddr2 = new System.Windows.Forms.TextBox();
            this.lblAddr1 = new System.Windows.Forms.Label();
            this.txtAddr1 = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblOperator = new System.Windows.Forms.Label();
            this.optSuppliers = new System.Windows.Forms.RadioButton();
            this.optMaanual = new System.Windows.Forms.RadioButton();
            this.grpMode = new System.Windows.Forms.GroupBox();
            this.btnSupplierList = new System.Windows.Forms.Button();
            this.grpMode.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRemove
            // 
            this.btnRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.Location = new System.Drawing.Point(611, 457);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(313, 81);
            this.btnRemove.TabIndex = 1096;
            this.btnRemove.Text = "Remove as manual";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // lblSupplierID
            // 
            this.lblSupplierID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSupplierID.Location = new System.Drawing.Point(558, 130);
            this.lblSupplierID.Name = "lblSupplierID";
            this.lblSupplierID.Size = new System.Drawing.Size(107, 20);
            this.lblSupplierID.TabIndex = 1091;
            this.lblSupplierID.Text = "ID";
            this.lblSupplierID.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtSupplierID
            // 
            this.txtSupplierID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSupplierID.Location = new System.Drawing.Point(670, 129);
            this.txtSupplierID.Name = "txtSupplierID";
            this.txtSupplierID.Size = new System.Drawing.Size(81, 20);
            this.txtSupplierID.TabIndex = 1090;
            this.txtSupplierID.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblNamePrevious
            // 
            this.lblNamePrevious.AutoSize = true;
            this.lblNamePrevious.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNamePrevious.ForeColor = System.Drawing.Color.Red;
            this.lblNamePrevious.Location = new System.Drawing.Point(498, 132);
            this.lblNamePrevious.Name = "lblNamePrevious";
            this.lblNamePrevious.Size = new System.Drawing.Size(28, 13);
            this.lblNamePrevious.TabIndex = 1089;
            this.lblNamePrevious.Text = "<<<";
            this.lblNamePrevious.Click += new System.EventHandler(this.lblNamePrevious_Click);
            // 
            // lblNameNext
            // 
            this.lblNameNext.AutoSize = true;
            this.lblNameNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameNext.ForeColor = System.Drawing.Color.Red;
            this.lblNameNext.Location = new System.Drawing.Point(465, 132);
            this.lblNameNext.Name = "lblNameNext";
            this.lblNameNext.Size = new System.Drawing.Size(28, 13);
            this.lblNameNext.TabIndex = 1088;
            this.lblNameNext.Text = ">>>";
            this.lblNameNext.Click += new System.EventHandler(this.lblNameNext_Click);
            // 
            // txtMainContact
            // 
            this.txtMainContact.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMainContact.Location = new System.Drawing.Point(161, 359);
            this.txtMainContact.Name = "txtMainContact";
            this.txtMainContact.Size = new System.Drawing.Size(298, 20);
            this.txtMainContact.TabIndex = 1086;
            // 
            // lblMainContact
            // 
            this.lblMainContact.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMainContact.Location = new System.Drawing.Point(48, 360);
            this.lblMainContact.Name = "lblMainContact";
            this.lblMainContact.Size = new System.Drawing.Size(107, 20);
            this.lblMainContact.TabIndex = 1087;
            this.lblMainContact.Text = "Main Contact Phone";
            this.lblMainContact.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(161, 326);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(504, 20);
            this.txtEmail.TabIndex = 1084;
            // 
            // lblEmail
            // 
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(48, 327);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(107, 20);
            this.lblEmail.TabIndex = 1085;
            this.lblEmail.Text = "EMail";
            this.lblEmail.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtCompanyPhone
            // 
            this.txtCompanyPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCompanyPhone.Location = new System.Drawing.Point(161, 295);
            this.txtCompanyPhone.Name = "txtCompanyPhone";
            this.txtCompanyPhone.Size = new System.Drawing.Size(504, 20);
            this.txtCompanyPhone.TabIndex = 1082;
            // 
            // lblCompanyPhone
            // 
            this.lblCompanyPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompanyPhone.Location = new System.Drawing.Point(48, 296);
            this.lblCompanyPhone.Name = "lblCompanyPhone";
            this.lblCompanyPhone.Size = new System.Drawing.Size(107, 20);
            this.lblCompanyPhone.TabIndex = 1083;
            this.lblCompanyPhone.Text = "Company Phone";
            this.lblCompanyPhone.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtCountry
            // 
            this.txtCountry.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCountry.Location = new System.Drawing.Point(161, 265);
            this.txtCountry.Name = "txtCountry";
            this.txtCountry.Size = new System.Drawing.Size(298, 20);
            this.txtCountry.TabIndex = 1080;
            // 
            // lblCountry
            // 
            this.lblCountry.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCountry.Location = new System.Drawing.Point(48, 266);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(107, 20);
            this.lblCountry.TabIndex = 1081;
            this.lblCountry.Text = "Country";
            this.lblCountry.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtZip
            // 
            this.txtZip.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtZip.Location = new System.Drawing.Point(329, 231);
            this.txtZip.Name = "txtZip";
            this.txtZip.Size = new System.Drawing.Size(88, 20);
            this.txtZip.TabIndex = 1079;
            // 
            // txtState
            // 
            this.txtState.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtState.Location = new System.Drawing.Point(294, 231);
            this.txtState.Name = "txtState";
            this.txtState.Size = new System.Drawing.Size(27, 20);
            this.txtState.TabIndex = 1078;
            // 
            // lblCSZ
            // 
            this.lblCSZ.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCSZ.Location = new System.Drawing.Point(48, 232);
            this.lblCSZ.Name = "lblCSZ";
            this.lblCSZ.Size = new System.Drawing.Size(107, 20);
            this.lblCSZ.TabIndex = 1077;
            this.lblCSZ.Text = "City/State/Zip";
            this.lblCSZ.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtCity
            // 
            this.txtCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCity.Location = new System.Drawing.Point(161, 231);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(129, 20);
            this.txtCity.TabIndex = 1076;
            // 
            // lblAddr2
            // 
            this.lblAddr2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddr2.Location = new System.Drawing.Point(48, 199);
            this.lblAddr2.Name = "lblAddr2";
            this.lblAddr2.Size = new System.Drawing.Size(107, 20);
            this.lblAddr2.TabIndex = 1075;
            this.lblAddr2.Text = "Address 2";
            this.lblAddr2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtAddr2
            // 
            this.txtAddr2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddr2.Location = new System.Drawing.Point(161, 198);
            this.txtAddr2.Name = "txtAddr2";
            this.txtAddr2.Size = new System.Drawing.Size(298, 20);
            this.txtAddr2.TabIndex = 1074;
            // 
            // lblAddr1
            // 
            this.lblAddr1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddr1.Location = new System.Drawing.Point(48, 161);
            this.lblAddr1.Name = "lblAddr1";
            this.lblAddr1.Size = new System.Drawing.Size(107, 20);
            this.lblAddr1.TabIndex = 1073;
            this.lblAddr1.Text = "Address 1";
            this.lblAddr1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtAddr1
            // 
            this.txtAddr1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddr1.Location = new System.Drawing.Point(161, 160);
            this.txtAddr1.Name = "txtAddr1";
            this.txtAddr1.Size = new System.Drawing.Size(298, 20);
            this.txtAddr1.TabIndex = 1072;
            // 
            // lblName
            // 
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(48, 129);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(107, 20);
            this.lblName.TabIndex = 1071;
            this.lblName.Text = "Name";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(161, 128);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(298, 20);
            this.txtName.TabIndex = 1070;
            this.txtName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtName_KeyDown);
            // 
            // lblOperator
            // 
            this.lblOperator.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOperator.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblOperator.Location = new System.Drawing.Point(193, 20);
            this.lblOperator.Name = "lblOperator";
            this.lblOperator.Size = new System.Drawing.Size(494, 38);
            this.lblOperator.TabIndex = 1069;
            this.lblOperator.Text = "label1";
            this.lblOperator.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // optSuppliers
            // 
            this.optSuppliers.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.optSuppliers.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optSuppliers.Location = new System.Drawing.Point(158, 15);
            this.optSuppliers.Name = "optSuppliers";
            this.optSuppliers.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.optSuppliers.Size = new System.Drawing.Size(104, 17);
            this.optSuppliers.TabIndex = 0;
            this.optSuppliers.Text = "Suppliers";
            this.optSuppliers.UseVisualStyleBackColor = true;
            this.optSuppliers.CheckedChanged += new System.EventHandler(this.optSuppliers_CheckedChanged);
            // 
            // optMaanual
            // 
            this.optMaanual.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.optMaanual.Checked = true;
            this.optMaanual.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optMaanual.Location = new System.Drawing.Point(15, 15);
            this.optMaanual.Name = "optMaanual";
            this.optMaanual.Size = new System.Drawing.Size(126, 17);
            this.optMaanual.TabIndex = 1;
            this.optMaanual.TabStop = true;
            this.optMaanual.Text = "Manual";
            this.optMaanual.UseVisualStyleBackColor = true;
            this.optMaanual.CheckedChanged += new System.EventHandler(this.optMaanual_CheckedChanged);
            // 
            // grpMode
            // 
            this.grpMode.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.grpMode.Controls.Add(this.optMaanual);
            this.grpMode.Controls.Add(this.optSuppliers);
            this.grpMode.Location = new System.Drawing.Point(163, 72);
            this.grpMode.Name = "grpMode";
            this.grpMode.Size = new System.Drawing.Size(268, 40);
            this.grpMode.TabIndex = 1118;
            this.grpMode.TabStop = false;
            // 
            // btnSupplierList
            // 
            this.btnSupplierList.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSupplierList.Location = new System.Drawing.Point(51, 457);
            this.btnSupplierList.Name = "btnSupplierList";
            this.btnSupplierList.Size = new System.Drawing.Size(313, 81);
            this.btnSupplierList.TabIndex = 1119;
            this.btnSupplierList.Text = "View Supplier List";
            this.btnSupplierList.UseVisualStyleBackColor = true;
            this.btnSupplierList.Click += new System.EventHandler(this.btnSupplierList_Click);
            // 
            // ManualSuppliers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(963, 550);
            this.Controls.Add(this.btnSupplierList);
            this.Controls.Add(this.grpMode);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.lblSupplierID);
            this.Controls.Add(this.txtSupplierID);
            this.Controls.Add(this.lblNamePrevious);
            this.Controls.Add(this.lblNameNext);
            this.Controls.Add(this.txtMainContact);
            this.Controls.Add(this.lblMainContact);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtCompanyPhone);
            this.Controls.Add(this.lblCompanyPhone);
            this.Controls.Add(this.txtCountry);
            this.Controls.Add(this.lblCountry);
            this.Controls.Add(this.txtZip);
            this.Controls.Add(this.txtState);
            this.Controls.Add(this.lblCSZ);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.lblAddr2);
            this.Controls.Add(this.txtAddr2);
            this.Controls.Add(this.lblAddr1);
            this.Controls.Add(this.txtAddr1);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblOperator);
            this.Name = "ManualSuppliers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Manual Suppliers";
            this.grpMode.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Label lblSupplierID;
        private System.Windows.Forms.TextBox txtSupplierID;
        private System.Windows.Forms.Label lblNamePrevious;
        private System.Windows.Forms.Label lblNameNext;
        private System.Windows.Forms.TextBox txtMainContact;
        private System.Windows.Forms.Label lblMainContact;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtCompanyPhone;
        private System.Windows.Forms.Label lblCompanyPhone;
        private System.Windows.Forms.TextBox txtCountry;
        private System.Windows.Forms.Label lblCountry;
        private System.Windows.Forms.TextBox txtZip;
        private System.Windows.Forms.TextBox txtState;
        private System.Windows.Forms.Label lblCSZ;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.Label lblAddr2;
        private System.Windows.Forms.TextBox txtAddr2;
        private System.Windows.Forms.Label lblAddr1;
        private System.Windows.Forms.TextBox txtAddr1;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblOperator;
        public System.Windows.Forms.RadioButton optSuppliers;
        public System.Windows.Forms.RadioButton optMaanual;
        private System.Windows.Forms.GroupBox grpMode;
        private System.Windows.Forms.Button btnSupplierList;
    }
}