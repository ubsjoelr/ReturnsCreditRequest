namespace ReturnsCreditRequest
{
    partial class EmailTemplate
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
            this.lblEmailSubject = new System.Windows.Forms.Label();
            this.txtEmailSubject = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtEmailTemplate = new System.Windows.Forms.TextBox();
            this.lblNamePrevious = new System.Windows.Forms.Label();
            this.lblNameNext = new System.Windows.Forms.Label();
            this.lblCode = new System.Windows.Forms.Label();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblCategory = new System.Windows.Forms.Label();
            this.txtCategory = new System.Windows.Forms.TextBox();
            this.lblNotice = new System.Windows.Forms.Label();
            this.txtNotice = new System.Windows.Forms.TextBox();
            this.lblCatPrevious = new System.Windows.Forms.Label();
            this.lblCatNext = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.chkCC = new System.Windows.Forms.CheckBox();
            this.btnEmailTemplateList = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblEmailSubject
            // 
            this.lblEmailSubject.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmailSubject.Location = new System.Drawing.Point(346, 95);
            this.lblEmailSubject.Name = "lblEmailSubject";
            this.lblEmailSubject.Size = new System.Drawing.Size(107, 20);
            this.lblEmailSubject.TabIndex = 1064;
            this.lblEmailSubject.Text = "Subject";
            this.lblEmailSubject.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtEmailSubject
            // 
            this.txtEmailSubject.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmailSubject.Location = new System.Drawing.Point(458, 94);
            this.txtEmailSubject.Name = "txtEmailSubject";
            this.txtEmailSubject.Size = new System.Drawing.Size(413, 20);
            this.txtEmailSubject.TabIndex = 1063;
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnExit.Location = new System.Drawing.Point(958, 675);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(244, 56);
            this.btnExit.TabIndex = 1062;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(73, 675);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(244, 56);
            this.btnSave.TabIndex = 1061;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtEmailTemplate
            // 
            this.txtEmailTemplate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmailTemplate.Location = new System.Drawing.Point(73, 164);
            this.txtEmailTemplate.Multiline = true;
            this.txtEmailTemplate.Name = "txtEmailTemplate";
            this.txtEmailTemplate.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtEmailTemplate.Size = new System.Drawing.Size(1130, 476);
            this.txtEmailTemplate.TabIndex = 1060;
            // 
            // lblNamePrevious
            // 
            this.lblNamePrevious.AutoSize = true;
            this.lblNamePrevious.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNamePrevious.ForeColor = System.Drawing.Color.Red;
            this.lblNamePrevious.Location = new System.Drawing.Point(715, 43);
            this.lblNamePrevious.Name = "lblNamePrevious";
            this.lblNamePrevious.Size = new System.Drawing.Size(28, 13);
            this.lblNamePrevious.TabIndex = 1057;
            this.lblNamePrevious.Text = "<<<";
            this.lblNamePrevious.Click += new System.EventHandler(this.lblNamePrevious_Click);
            // 
            // lblNameNext
            // 
            this.lblNameNext.AutoSize = true;
            this.lblNameNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameNext.ForeColor = System.Drawing.Color.Red;
            this.lblNameNext.Location = new System.Drawing.Point(682, 43);
            this.lblNameNext.Name = "lblNameNext";
            this.lblNameNext.Size = new System.Drawing.Size(28, 13);
            this.lblNameNext.TabIndex = 1056;
            this.lblNameNext.Text = ">>>";
            this.lblNameNext.Click += new System.EventHandler(this.lblNameNext_Click);
            // 
            // lblCode
            // 
            this.lblCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCode.Location = new System.Drawing.Point(346, 38);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(107, 20);
            this.lblCode.TabIndex = 1055;
            this.lblCode.Text = "Code";
            this.lblCode.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtCode
            // 
            this.txtCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCode.Location = new System.Drawing.Point(458, 39);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(213, 20);
            this.txtCode.TabIndex = 1054;
            this.txtCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCode_KeyDown);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnClear.Location = new System.Drawing.Point(663, 675);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(244, 56);
            this.btnClear.TabIndex = 1065;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lblCategory
            // 
            this.lblCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategory.Location = new System.Drawing.Point(346, 62);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(107, 20);
            this.lblCategory.TabIndex = 1067;
            this.lblCategory.Text = "Category";
            this.lblCategory.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtCategory
            // 
            this.txtCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCategory.Location = new System.Drawing.Point(458, 63);
            this.txtCategory.Name = "txtCategory";
            this.txtCategory.Size = new System.Drawing.Size(213, 20);
            this.txtCategory.TabIndex = 1066;
            this.txtCategory.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCategory_KeyDown);
            // 
            // lblNotice
            // 
            this.lblNotice.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotice.Location = new System.Drawing.Point(787, 62);
            this.lblNotice.Name = "lblNotice";
            this.lblNotice.Size = new System.Drawing.Size(107, 20);
            this.lblNotice.TabIndex = 1069;
            this.lblNotice.Text = "Notice#";
            this.lblNotice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtNotice
            // 
            this.txtNotice.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNotice.Location = new System.Drawing.Point(899, 63);
            this.txtNotice.Name = "txtNotice";
            this.txtNotice.Size = new System.Drawing.Size(52, 20);
            this.txtNotice.TabIndex = 1068;
            this.txtNotice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNotice_KeyPress);
            // 
            // lblCatPrevious
            // 
            this.lblCatPrevious.AutoSize = true;
            this.lblCatPrevious.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCatPrevious.ForeColor = System.Drawing.Color.Red;
            this.lblCatPrevious.Location = new System.Drawing.Point(715, 64);
            this.lblCatPrevious.Name = "lblCatPrevious";
            this.lblCatPrevious.Size = new System.Drawing.Size(28, 13);
            this.lblCatPrevious.TabIndex = 1071;
            this.lblCatPrevious.Text = "<<<";
            this.lblCatPrevious.Click += new System.EventHandler(this.lblCatPrevious_Click);
            // 
            // lblCatNext
            // 
            this.lblCatNext.AutoSize = true;
            this.lblCatNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCatNext.ForeColor = System.Drawing.Color.Red;
            this.lblCatNext.Location = new System.Drawing.Point(682, 64);
            this.lblCatNext.Name = "lblCatNext";
            this.lblCatNext.Size = new System.Drawing.Size(28, 13);
            this.lblCatNext.TabIndex = 1070;
            this.lblCatNext.Text = ">>>";
            this.lblCatNext.Click += new System.EventHandler(this.lblCatNext_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.Red;
            this.btnDelete.Location = new System.Drawing.Point(368, 675);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(244, 56);
            this.btnDelete.TabIndex = 1072;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // chkCC
            // 
            this.chkCC.AutoSize = true;
            this.chkCC.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkCC.Location = new System.Drawing.Point(886, 94);
            this.chkCC.Name = "chkCC";
            this.chkCC.Size = new System.Drawing.Size(113, 22);
            this.chkCC.TabIndex = 1073;
            this.chkCC.Text = "Credit Card";
            this.chkCC.UseVisualStyleBackColor = true;
            // 
            // btnEmailTemplateList
            // 
            this.btnEmailTemplateList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmailTemplateList.ForeColor = System.Drawing.Color.Red;
            this.btnEmailTemplateList.Location = new System.Drawing.Point(73, 39);
            this.btnEmailTemplateList.Name = "btnEmailTemplateList";
            this.btnEmailTemplateList.Size = new System.Drawing.Size(146, 54);
            this.btnEmailTemplateList.TabIndex = 1074;
            this.btnEmailTemplateList.Text = "Template List";
            this.btnEmailTemplateList.UseVisualStyleBackColor = true;
            this.btnEmailTemplateList.Click += new System.EventHandler(this.btnEmailTemplateList_Click);
            // 
            // EmailTemplate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1277, 768);
            this.Controls.Add(this.btnEmailTemplateList);
            this.Controls.Add(this.chkCC);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.lblCatPrevious);
            this.Controls.Add(this.lblCatNext);
            this.Controls.Add(this.lblNotice);
            this.Controls.Add(this.txtNotice);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.txtCategory);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lblEmailSubject);
            this.Controls.Add(this.txtEmailSubject);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtEmailTemplate);
            this.Controls.Add(this.lblNamePrevious);
            this.Controls.Add(this.lblNameNext);
            this.Controls.Add(this.lblCode);
            this.Controls.Add(this.txtCode);
            this.Name = "EmailTemplate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Email Template";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEmailSubject;
        private System.Windows.Forms.TextBox txtEmailSubject;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtEmailTemplate;
        private System.Windows.Forms.Label lblNamePrevious;
        private System.Windows.Forms.Label lblNameNext;
        private System.Windows.Forms.Label lblCode;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.TextBox txtCategory;
        private System.Windows.Forms.Label lblNotice;
        private System.Windows.Forms.TextBox txtNotice;
        private System.Windows.Forms.Label lblCatPrevious;
        private System.Windows.Forms.Label lblCatNext;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.CheckBox chkCC;
        private System.Windows.Forms.Button btnEmailTemplateList;
    }
}