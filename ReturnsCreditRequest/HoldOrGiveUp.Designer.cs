namespace ReturnsCreditRequest
{
    partial class HoldOrGiveUp
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
            this.grpMode = new System.Windows.Forms.GroupBox();
            this.optGiveUp = new System.Windows.Forms.RadioButton();
            this.optOnHold = new System.Windows.Forms.RadioButton();
            this.btnHoldOrGiveUp = new System.Windows.Forms.Button();
            this.lblOrderNumber = new System.Windows.Forms.Label();
            this.txtOrderNumber = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lblWhy = new System.Windows.Forms.Label();
            this.txtWhy = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.optReactivate = new System.Windows.Forms.RadioButton();
            this.grpMode.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpMode
            // 
            this.grpMode.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.grpMode.Controls.Add(this.optReactivate);
            this.grpMode.Controls.Add(this.optGiveUp);
            this.grpMode.Controls.Add(this.optOnHold);
            this.grpMode.Location = new System.Drawing.Point(384, 74);
            this.grpMode.Name = "grpMode";
            this.grpMode.Size = new System.Drawing.Size(420, 40);
            this.grpMode.TabIndex = 988;
            this.grpMode.TabStop = false;
            // 
            // optGiveUp
            // 
            this.optGiveUp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.optGiveUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optGiveUp.Location = new System.Drawing.Point(171, 13);
            this.optGiveUp.Name = "optGiveUp";
            this.optGiveUp.Size = new System.Drawing.Size(75, 17);
            this.optGiveUp.TabIndex = 1;
            this.optGiveUp.Text = "Give Up";
            this.optGiveUp.UseVisualStyleBackColor = true;
            // 
            // optOnHold
            // 
            this.optOnHold.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.optOnHold.Checked = true;
            this.optOnHold.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optOnHold.Location = new System.Drawing.Point(49, 13);
            this.optOnHold.Name = "optOnHold";
            this.optOnHold.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.optOnHold.Size = new System.Drawing.Size(75, 17);
            this.optOnHold.TabIndex = 0;
            this.optOnHold.TabStop = true;
            this.optOnHold.Text = "On Hold";
            this.optOnHold.UseVisualStyleBackColor = true;
            // 
            // btnHoldOrGiveUp
            // 
            this.btnHoldOrGiveUp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnHoldOrGiveUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHoldOrGiveUp.ForeColor = System.Drawing.Color.Red;
            this.btnHoldOrGiveUp.Location = new System.Drawing.Point(412, 508);
            this.btnHoldOrGiveUp.Name = "btnHoldOrGiveUp";
            this.btnHoldOrGiveUp.Size = new System.Drawing.Size(126, 38);
            this.btnHoldOrGiveUp.TabIndex = 1095;
            this.btnHoldOrGiveUp.Text = "Hold/Give Up";
            this.btnHoldOrGiveUp.UseVisualStyleBackColor = true;
            // 
            // lblOrderNumber
            // 
            this.lblOrderNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderNumber.Location = new System.Drawing.Point(124, 172);
            this.lblOrderNumber.Name = "lblOrderNumber";
            this.lblOrderNumber.Size = new System.Drawing.Size(90, 20);
            this.lblOrderNumber.TabIndex = 1094;
            this.lblOrderNumber.Text = "Enter Order#:";
            this.lblOrderNumber.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtOrderNumber
            // 
            this.txtOrderNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOrderNumber.Location = new System.Drawing.Point(232, 172);
            this.txtOrderNumber.Name = "txtOrderNumber";
            this.txtOrderNumber.Size = new System.Drawing.Size(96, 20);
            this.txtOrderNumber.TabIndex = 1093;
            this.txtOrderNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtOrderNumber_KeyPress);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(364, 844);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(164, 38);
            this.button1.TabIndex = 1098;
            this.button1.Text = "Hold/Give Up";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // lblWhy
            // 
            this.lblWhy.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWhy.Location = new System.Drawing.Point(86, 212);
            this.lblWhy.Name = "lblWhy";
            this.lblWhy.Size = new System.Drawing.Size(128, 20);
            this.lblWhy.TabIndex = 1097;
            this.lblWhy.Text = "Enter Reason Why:";
            this.lblWhy.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtWhy
            // 
            this.txtWhy.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWhy.Location = new System.Drawing.Point(232, 212);
            this.txtWhy.Name = "txtWhy";
            this.txtWhy.Size = new System.Drawing.Size(702, 20);
            this.txtWhy.TabIndex = 1096;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.Red;
            this.btnSave.Location = new System.Drawing.Point(86, 321);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(126, 38);
            this.btnSave.TabIndex = 1099;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.Red;
            this.btnExit.Location = new System.Drawing.Point(808, 321);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(126, 38);
            this.btnExit.TabIndex = 1100;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // optReactivate
            // 
            this.optReactivate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.optReactivate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optReactivate.Location = new System.Drawing.Point(293, 12);
            this.optReactivate.Name = "optReactivate";
            this.optReactivate.Size = new System.Drawing.Size(107, 17);
            this.optReactivate.TabIndex = 2;
            this.optReactivate.Text = "Reactivate";
            this.optReactivate.UseVisualStyleBackColor = true;
            // 
            // HoldOrGiveUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1010, 382);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblWhy);
            this.Controls.Add(this.txtWhy);
            this.Controls.Add(this.btnHoldOrGiveUp);
            this.Controls.Add(this.lblOrderNumber);
            this.Controls.Add(this.txtOrderNumber);
            this.Controls.Add(this.grpMode);
            this.Name = "HoldOrGiveUp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Hold Or GiveUp";
            this.grpMode.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpMode;
        public System.Windows.Forms.RadioButton optGiveUp;
        public System.Windows.Forms.RadioButton optOnHold;
        private System.Windows.Forms.Button btnHoldOrGiveUp;
        private System.Windows.Forms.Label lblOrderNumber;
        private System.Windows.Forms.TextBox txtOrderNumber;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblWhy;
        private System.Windows.Forms.TextBox txtWhy;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnExit;
        public System.Windows.Forms.RadioButton optReactivate;
    }
}