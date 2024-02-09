using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ReturnsCreditRequest
{
    public partial class EnterPassword : Form
    {
        public EnterPassword()
        {
            this.KeyPreview = true;
            InitializeComponent();
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                btnOK.PerformClick();
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            DataAccess da = new DataAccess();
            bool pbFound = da.Get_FoundOperator(txtPassword.Text);
            if (pbFound)
            {
                this.Hide();
                List<string> poLevel = new List<string>();
                poLevel = da.Get_Level(txtPassword.Text);
                UserInfo.Level = poLevel[0].ToString();
                UserInfo.OpName = poLevel[1].ToString();
                Form1 f1 = new Form1();
                f1.ShowDialog();
                this.Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}