namespace ReturnsCreditRequest
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnSendEmails = new System.Windows.Forms.Button();
            this.grdTracking = new System.Windows.Forms.DataGridView();
            this.btnEmailTemplate = new System.Windows.Forms.Button();
            this.btnNotes = new System.Windows.Forms.Button();
            this.btnSENotes = new System.Windows.Forms.Button();
            this.btnTrackingNumbers = new System.Windows.Forms.Button();
            this.lblOrderNumber = new System.Windows.Forms.Label();
            this.txtOrderNumber = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnOnHold = new System.Windows.Forms.Button();
            this.btnGivenUp = new System.Windows.Forms.Button();
            this.btnHoldOrGiveUp = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnSent = new System.Windows.Forms.Button();
            this.btnSendEmailManually = new System.Windows.Forms.Button();
            this.btnEmailLogs = new System.Windows.Forms.Button();
            this.btnCheckAll = new System.Windows.Forms.Button();
            this.btnUncheckAll = new System.Windows.Forms.Button();
            this.btnTestEmails = new System.Windows.Forms.Button();
            this.btnRegenerate = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.cboStatus = new System.Windows.Forms.ComboBox();
            this.lblOrderStatus = new System.Windows.Forms.Label();
            this.btnManualSuppliers = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdTracking)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTotal
            // 
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTotal.Location = new System.Drawing.Point(21, 701);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(175, 41);
            this.lblTotal.TabIndex = 1001;
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnSendEmails
            // 
            this.btnSendEmails.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSendEmails.ForeColor = System.Drawing.Color.Red;
            this.btnSendEmails.Location = new System.Drawing.Point(336, 704);
            this.btnSendEmails.Name = "btnSendEmails";
            this.btnSendEmails.Size = new System.Drawing.Size(126, 38);
            this.btnSendEmails.TabIndex = 1000;
            this.btnSendEmails.Text = "Send Emails";
            this.btnSendEmails.UseVisualStyleBackColor = true;
            this.btnSendEmails.Click += new System.EventHandler(this.btnSendEmails_Click);
            // 
            // grdTracking
            // 
            this.grdTracking.AllowUserToAddRows = false;
            this.grdTracking.AllowUserToDeleteRows = false;
            this.grdTracking.AllowUserToResizeColumns = false;
            this.grdTracking.AllowUserToResizeRows = false;
            this.grdTracking.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdTracking.DefaultCellStyle = dataGridViewCellStyle2;
            this.grdTracking.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.grdTracking.Location = new System.Drawing.Point(17, 85);
            this.grdTracking.MultiSelect = false;
            this.grdTracking.Name = "grdTracking";
            this.grdTracking.Size = new System.Drawing.Size(1415, 613);
            this.grdTracking.TabIndex = 999;
            this.grdTracking.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdTracking_CellClick);
            this.grdTracking.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdTracking_CellContentDoubleClick);
            // 
            // btnEmailTemplate
            // 
            this.btnEmailTemplate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmailTemplate.ForeColor = System.Drawing.Color.Red;
            this.btnEmailTemplate.Location = new System.Drawing.Point(21, 19);
            this.btnEmailTemplate.Name = "btnEmailTemplate";
            this.btnEmailTemplate.Size = new System.Drawing.Size(146, 54);
            this.btnEmailTemplate.TabIndex = 1006;
            this.btnEmailTemplate.Text = "Emails Templates";
            this.btnEmailTemplate.UseVisualStyleBackColor = true;
            this.btnEmailTemplate.Click += new System.EventHandler(this.btnEmailTemplate_Click);
            // 
            // btnNotes
            // 
            this.btnNotes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnNotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNotes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnNotes.Location = new System.Drawing.Point(1238, 704);
            this.btnNotes.Name = "btnNotes";
            this.btnNotes.Size = new System.Drawing.Size(110, 38);
            this.btnNotes.TabIndex = 1013;
            this.btnNotes.Text = "Return Notes";
            this.btnNotes.UseVisualStyleBackColor = true;
            this.btnNotes.Click += new System.EventHandler(this.btnNotes_Click);
            // 
            // btnSENotes
            // 
            this.btnSENotes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSENotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSENotes.ForeColor = System.Drawing.Color.Red;
            this.btnSENotes.Location = new System.Drawing.Point(1350, 704);
            this.btnSENotes.Name = "btnSENotes";
            this.btnSENotes.Size = new System.Drawing.Size(82, 38);
            this.btnSENotes.TabIndex = 1014;
            this.btnSENotes.Text = "SE Notes";
            this.btnSENotes.UseVisualStyleBackColor = true;
            this.btnSENotes.Click += new System.EventHandler(this.btnSENotes_Click);
            // 
            // btnTrackingNumbers
            // 
            this.btnTrackingNumbers.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnTrackingNumbers.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTrackingNumbers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnTrackingNumbers.Location = new System.Drawing.Point(1141, 704);
            this.btnTrackingNumbers.Name = "btnTrackingNumbers";
            this.btnTrackingNumbers.Size = new System.Drawing.Size(93, 38);
            this.btnTrackingNumbers.TabIndex = 1015;
            this.btnTrackingNumbers.Text = "Tracking#s";
            this.btnTrackingNumbers.UseVisualStyleBackColor = true;
            this.btnTrackingNumbers.Click += new System.EventHandler(this.btnTrackingNumbers_Click);
            // 
            // lblOrderNumber
            // 
            this.lblOrderNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderNumber.Location = new System.Drawing.Point(769, 43);
            this.lblOrderNumber.Name = "lblOrderNumber";
            this.lblOrderNumber.Size = new System.Drawing.Size(90, 20);
            this.lblOrderNumber.TabIndex = 1087;
            this.lblOrderNumber.Text = "Enter Order#:";
            this.lblOrderNumber.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtOrderNumber
            // 
            this.txtOrderNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOrderNumber.Location = new System.Drawing.Point(865, 43);
            this.txtOrderNumber.Name = "txtOrderNumber";
            this.txtOrderNumber.Size = new System.Drawing.Size(73, 20);
            this.txtOrderNumber.TabIndex = 1086;
            this.txtOrderNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtOrderNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtOrderNumber_KeyPress);
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.Red;
            this.btnSearch.Location = new System.Drawing.Point(944, 39);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 28);
            this.btnSearch.TabIndex = 1088;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.Color.Navy;
            this.btnRefresh.Location = new System.Drawing.Point(1368, 39);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(58, 28);
            this.btnRefresh.TabIndex = 1089;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnOnHold
            // 
            this.btnOnHold.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOnHold.ForeColor = System.Drawing.Color.Navy;
            this.btnOnHold.Location = new System.Drawing.Point(1291, 39);
            this.btnOnHold.Name = "btnOnHold";
            this.btnOnHold.Size = new System.Drawing.Size(75, 28);
            this.btnOnHold.TabIndex = 1090;
            this.btnOnHold.Text = "On Hold";
            this.btnOnHold.UseVisualStyleBackColor = true;
            this.btnOnHold.Click += new System.EventHandler(this.btnOnHold_Click);
            // 
            // btnGivenUp
            // 
            this.btnGivenUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGivenUp.ForeColor = System.Drawing.Color.Navy;
            this.btnGivenUp.Location = new System.Drawing.Point(1213, 39);
            this.btnGivenUp.Name = "btnGivenUp";
            this.btnGivenUp.Size = new System.Drawing.Size(75, 28);
            this.btnGivenUp.TabIndex = 1091;
            this.btnGivenUp.Text = "Given Up";
            this.btnGivenUp.UseVisualStyleBackColor = true;
            this.btnGivenUp.Click += new System.EventHandler(this.btnGivenUp_Click);
            // 
            // btnHoldOrGiveUp
            // 
            this.btnHoldOrGiveUp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnHoldOrGiveUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHoldOrGiveUp.ForeColor = System.Drawing.Color.Red;
            this.btnHoldOrGiveUp.Location = new System.Drawing.Point(963, 704);
            this.btnHoldOrGiveUp.Name = "btnHoldOrGiveUp";
            this.btnHoldOrGiveUp.Size = new System.Drawing.Size(175, 38);
            this.btnHoldOrGiveUp.TabIndex = 1092;
            this.btnHoldOrGiveUp.Text = "Hold/Give Up/Reactivate";
            this.btnHoldOrGiveUp.UseVisualStyleBackColor = true;
            this.btnHoldOrGiveUp.Click += new System.EventHandler(this.btnHoldOrGiveUp_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.Color.Red;
            this.btnEdit.Location = new System.Drawing.Point(895, 704);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(67, 38);
            this.btnEdit.TabIndex = 1093;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnSent
            // 
            this.btnSent.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSent.ForeColor = System.Drawing.Color.Navy;
            this.btnSent.Location = new System.Drawing.Point(1145, 39);
            this.btnSent.Name = "btnSent";
            this.btnSent.Size = new System.Drawing.Size(62, 28);
            this.btnSent.TabIndex = 1095;
            this.btnSent.Text = "Sent";
            this.btnSent.UseVisualStyleBackColor = true;
            this.btnSent.Click += new System.EventHandler(this.btnSent_Click);
            // 
            // btnSendEmailManually
            // 
            this.btnSendEmailManually.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSendEmailManually.ForeColor = System.Drawing.Color.Navy;
            this.btnSendEmailManually.Location = new System.Drawing.Point(468, 704);
            this.btnSendEmailManually.Name = "btnSendEmailManually";
            this.btnSendEmailManually.Size = new System.Drawing.Size(135, 38);
            this.btnSendEmailManually.TabIndex = 1096;
            this.btnSendEmailManually.Text = "Manual Emails";
            this.btnSendEmailManually.UseVisualStyleBackColor = true;
            this.btnSendEmailManually.Click += new System.EventHandler(this.btnSendEmailManually_Click);
            // 
            // btnEmailLogs
            // 
            this.btnEmailLogs.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEmailLogs.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmailLogs.ForeColor = System.Drawing.Color.Red;
            this.btnEmailLogs.Location = new System.Drawing.Point(801, 704);
            this.btnEmailLogs.Name = "btnEmailLogs";
            this.btnEmailLogs.Size = new System.Drawing.Size(89, 38);
            this.btnEmailLogs.TabIndex = 1097;
            this.btnEmailLogs.Text = "Email Logs";
            this.btnEmailLogs.UseVisualStyleBackColor = true;
            this.btnEmailLogs.Click += new System.EventHandler(this.btnEmailLogs_Click);
            // 
            // btnCheckAll
            // 
            this.btnCheckAll.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCheckAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckAll.ForeColor = System.Drawing.Color.Red;
            this.btnCheckAll.Location = new System.Drawing.Point(612, 704);
            this.btnCheckAll.Name = "btnCheckAll";
            this.btnCheckAll.Size = new System.Drawing.Size(91, 38);
            this.btnCheckAll.TabIndex = 1098;
            this.btnCheckAll.Text = "Check All";
            this.btnCheckAll.UseVisualStyleBackColor = true;
            this.btnCheckAll.Click += new System.EventHandler(this.btnCheckAll_Click);
            // 
            // btnUncheckAll
            // 
            this.btnUncheckAll.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnUncheckAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUncheckAll.ForeColor = System.Drawing.Color.Red;
            this.btnUncheckAll.Location = new System.Drawing.Point(708, 704);
            this.btnUncheckAll.Name = "btnUncheckAll";
            this.btnUncheckAll.Size = new System.Drawing.Size(91, 38);
            this.btnUncheckAll.TabIndex = 1099;
            this.btnUncheckAll.Text = "Uncheck All";
            this.btnUncheckAll.UseVisualStyleBackColor = true;
            this.btnUncheckAll.Click += new System.EventHandler(this.btnUncheckAll_Click);
            // 
            // btnTestEmails
            // 
            this.btnTestEmails.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTestEmails.ForeColor = System.Drawing.Color.Blue;
            this.btnTestEmails.Location = new System.Drawing.Point(202, 704);
            this.btnTestEmails.Name = "btnTestEmails";
            this.btnTestEmails.Size = new System.Drawing.Size(126, 38);
            this.btnTestEmails.TabIndex = 1101;
            this.btnTestEmails.Text = "Test Emails";
            this.btnTestEmails.UseVisualStyleBackColor = true;
            this.btnTestEmails.Click += new System.EventHandler(this.btnTestEmails_Click);
            // 
            // btnRegenerate
            // 
            this.btnRegenerate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegenerate.ForeColor = System.Drawing.Color.Red;
            this.btnRegenerate.Location = new System.Drawing.Point(167, 19);
            this.btnRegenerate.Name = "btnRegenerate";
            this.btnRegenerate.Size = new System.Drawing.Size(125, 54);
            this.btnRegenerate.TabIndex = 1102;
            this.btnRegenerate.Text = "Regenerate";
            this.btnRegenerate.UseVisualStyleBackColor = true;
            this.btnRegenerate.Click += new System.EventHandler(this.btnRegenerate_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblStatus.Location = new System.Drawing.Point(304, 42);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(136, 24);
            this.lblStatus.TabIndex = 1104;
            this.lblStatus.Text = "Select Status:";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cboStatus
            // 
            this.cboStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboStatus.FormattingEnabled = true;
            this.cboStatus.Location = new System.Drawing.Point(439, 42);
            this.cboStatus.Name = "cboStatus";
            this.cboStatus.Size = new System.Drawing.Size(315, 28);
            this.cboStatus.TabIndex = 1103;
            this.cboStatus.TextChanged += new System.EventHandler(this.cboStatus_TextChanged);
            // 
            // lblOrderStatus
            // 
            this.lblOrderStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblOrderStatus.Location = new System.Drawing.Point(865, 10);
            this.lblOrderStatus.Name = "lblOrderStatus";
            this.lblOrderStatus.Size = new System.Drawing.Size(233, 24);
            this.lblOrderStatus.TabIndex = 1105;
            this.lblOrderStatus.Text = "xxxxxxxxxxxxxxxx";
            this.lblOrderStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblOrderStatus.Visible = false;
            // 
            // btnManualSuppliers
            // 
            this.btnManualSuppliers.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManualSuppliers.ForeColor = System.Drawing.Color.Navy;
            this.btnManualSuppliers.Location = new System.Drawing.Point(1025, 39);
            this.btnManualSuppliers.Name = "btnManualSuppliers";
            this.btnManualSuppliers.Size = new System.Drawing.Size(114, 28);
            this.btnManualSuppliers.TabIndex = 1106;
            this.btnManualSuppliers.Text = "Manual Suppliers";
            this.btnManualSuppliers.UseVisualStyleBackColor = true;
            this.btnManualSuppliers.Click += new System.EventHandler(this.btnManualSuppliers_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1448, 761);
            this.Controls.Add(this.btnManualSuppliers);
            this.Controls.Add(this.lblOrderStatus);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.cboStatus);
            this.Controls.Add(this.btnRegenerate);
            this.Controls.Add(this.btnTestEmails);
            this.Controls.Add(this.btnUncheckAll);
            this.Controls.Add(this.btnCheckAll);
            this.Controls.Add(this.btnEmailLogs);
            this.Controls.Add(this.btnSendEmailManually);
            this.Controls.Add(this.btnSent);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnHoldOrGiveUp);
            this.Controls.Add(this.btnGivenUp);
            this.Controls.Add(this.btnOnHold);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.lblOrderNumber);
            this.Controls.Add(this.txtOrderNumber);
            this.Controls.Add(this.btnTrackingNumbers);
            this.Controls.Add(this.btnSENotes);
            this.Controls.Add(this.btnNotes);
            this.Controls.Add(this.btnEmailTemplate);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.btnSendEmails);
            this.Controls.Add(this.grdTracking);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Returns Credit Request";
            ((System.ComponentModel.ISupportInitialize)(this.grdTracking)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnSendEmails;
        private System.Windows.Forms.DataGridView grdTracking;
        private System.Windows.Forms.Button btnEmailTemplate;
        private System.Windows.Forms.Button btnNotes;
        private System.Windows.Forms.Button btnSENotes;
        private System.Windows.Forms.Button btnTrackingNumbers;
        private System.Windows.Forms.Label lblOrderNumber;
        private System.Windows.Forms.TextBox txtOrderNumber;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnOnHold;
        private System.Windows.Forms.Button btnGivenUp;
        private System.Windows.Forms.Button btnHoldOrGiveUp;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnSent;
        private System.Windows.Forms.Button btnSendEmailManually;
        private System.Windows.Forms.Button btnEmailLogs;
        private System.Windows.Forms.Button btnCheckAll;
        private System.Windows.Forms.Button btnUncheckAll;
        private System.Windows.Forms.Button btnTestEmails;
        private System.Windows.Forms.Button btnRegenerate;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ComboBox cboStatus;
        private System.Windows.Forms.Label lblOrderStatus;
        private System.Windows.Forms.Button btnManualSuppliers;
    }
}

