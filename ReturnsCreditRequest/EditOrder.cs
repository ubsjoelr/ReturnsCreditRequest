using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ReturnsCreditRequest
{
    public partial class EditOrder : Form
    {
        public EditOrder()
        {
            InitializeComponent();
            FindOrder();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void Forms_Field_Load(DataTable xoEdit)
        {
            try
            {
                if (xoEdit.Rows.Count == 0)
                {
                    return;
                }
                DataRow poRow = xoEdit.Rows[0];
                txtRA.Text = poRow["ReturnAuth"].ToString();
                txtMemo.Text = poRow["RA_Email_Memo"].ToString();
            }
            catch (Exception exec)
            {
                MessageBox.Show(exec.Message.ToString());
            }
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtMemo.Text.Trim().Length == 0 && txtRA.Text.Trim().Length == 0)
            {
                MessageBox.Show("You MUST Enter Values");
                return;
            }
            DataAccess da = new DataAccess();
            da.Update_Edit_Lines(Convert.ToInt32(txtOrderNumber.Text), txtRA.Text, txtMemo.Text);
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

        private void FindOrder()
        {
            txtOrderNumber.Text = UserInfo.OrderNumber.ToString();
            if (txtOrderNumber.Text.Trim().Length == 0)
            {
                MessageBox.Show("You MUST Enter Values");
                return;
            }
            DataAccess da = new DataAccess();
            DataTable poEdit = da.Get_Fields_To_Edit(Convert.ToInt32(txtOrderNumber.Text));
            Forms_Field_Load(poEdit);
        }
      }
}