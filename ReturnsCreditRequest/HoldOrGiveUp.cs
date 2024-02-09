using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ReturnsCreditRequest
{
    public partial class HoldOrGiveUp : Form
    {
        public HoldOrGiveUp()
        {
            InitializeComponent();
            txtOrderNumber.Text = UserInfo.OrderNumber.ToString();
            txtOrderNumber.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtOrderNumber.Text.Length==0 || txtWhy.Text.Length==0)
            {
                MessageBox.Show("You MUST Enter Values");
                if (txtOrderNumber.Text.Length == 0)
                {
                    txtOrderNumber.Focus();
                    return;
                }
                if (txtWhy.Text.Length == 0)
                {
                    txtWhy.Focus();
                }
                return;
            }
            int plWhichOne=0;
            if (optOnHold.Checked)
            {
                plWhichOne=1;
            }
            if (optGiveUp.Checked)
            {
                plWhichOne=2;
            }
            if (optReactivate.Checked)
            {
                plWhichOne = 3;
            }
            DataAccess da = new DataAccess();
            da.Insert_OnHold_OrGiveUp(Convert.ToInt32(txtOrderNumber.Text), plWhichOne, txtWhy.Text);
            this.Close();
        }

        private void txtOrderNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar)
            && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            
        }
    }
}