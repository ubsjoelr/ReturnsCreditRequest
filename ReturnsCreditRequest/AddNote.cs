using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ReturnsCreditRequest
{
    public partial class AddNote : Form
    {
        public AddNote()
        {
            InitializeComponent();
            btnSaveNote.Enabled = false;
            lblOperator.Text = "Operator: " + UserInfo.OpName;
        }

        private void btnSaveNote_Click(object sender, EventArgs e)
        {
            DataAccess da = new DataAccess();
            da.Update_Note(UserInfo.OrderNumber, txtNote.Text, false);
            this.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtNote_TextChanged(object sender, EventArgs e)
        {
            btnSaveNote.Enabled = (txtNote.Text.Length > 0);
        }
    }
}