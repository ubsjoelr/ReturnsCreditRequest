using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Configuration;

namespace ReturnsCreditRequest
{
    public partial class EmailTemplate : Form
    {
        public EmailTemplate()
        {
            this.KeyPreview = true;
            InitializeComponent();
            txtCode.Focus();
        }

        private void Forms_Field_Load(DataTable xoEmail)
        {
            try
            {
                if (xoEmail.Rows.Count==0)
                {
                    return;
                }

                DataRow poRow = xoEmail.Rows[0];
                txtCode.Text = poRow["Code"].ToString();
                txtNotice.Text = poRow["Notice"].ToString();
                txtEmailSubject.Text = poRow["Subject"].ToString();
                txtEmailTemplate.Text = poRow["Template"].ToString();
                txtCategory.Text = poRow["Caregory"].ToString();
                //chkNoRefund.Checked = Convert.ToBoolean(poLine[28]);
                chkCC.Checked = Convert.ToBoolean(poRow["CC"]);
            }
            catch (Exception exec)
            {
                MessageBox.Show(exec.Message.ToString());
            }
        }



        private void ClearScreen()
        {
            txtCategory.Clear();
            txtCode.Clear();
            txtEmailSubject.Clear();
            txtEmailTemplate.Clear();
            txtNotice.Clear();            
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearScreen();
        }

        private void lblNameNext_Click(object sender, EventArgs e)
        {
            DataAccess da = new DataAccess();
            DataTable poEmail = da.Get_Email_Template(txtCode.Text, "GT", 1);
            Forms_Field_Load(poEmail);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtCode.Text.Length == 0)
            {
                MessageBox.Show("You MUST Enter a Code");
                return;
            }
            if (txtNotice.Text.Length == 0)
            {
                MessageBox.Show("You MUST Enter a Number in Notice");
                return;
            }
            DataAccess da = new DataAccess();
            da.Update_EmailTemplate(txtCode.Text, txtEmailTemplate.Text, txtEmailSubject.Text, txtCategory.Text, Convert.ToInt32(txtNotice.Text), Convert.ToByte(chkCC.Checked));
        }

        private void lblNamePrevious_Click(object sender, EventArgs e)
        {
            DataAccess da = new DataAccess();
            DataTable poEmail = da.Get_Email_Template(txtCode.Text, "LT", 1);
            Forms_Field_Load(poEmail);
        }

        private void txtCode_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                DataAccess da = new DataAccess();
                DataTable poEmail = null;
                if (e.KeyCode.ToString() == "F6" || e.KeyValue == 13)
                {
                    poEmail = da.Get_Email_Template(txtCode.Text, "GE", 1);
                    Forms_Field_Load(poEmail);
                }
                if (e.KeyCode.ToString() == "F7")
                {
                    poEmail = da.Get_Email_Template(txtCode.Text, "GT", 1);
                    Forms_Field_Load(poEmail);
                }
                if (e.KeyCode.ToString() == "F8")
                {
                    poEmail = da.Get_Email_Template(txtCode.Text, "LT",1);
                    Forms_Field_Load(poEmail);
                }
            }
            catch (Exception exec)
            {
                MessageBox.Show(exec.Message.ToString());
            }                
        }

        private void txtNotice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back) || (e.KeyChar == 46)))
            {
                e.Handled = true;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblCatNext_Click(object sender, EventArgs e)
        {
            DataAccess da = new DataAccess();
            DataTable poEmail = da.Get_Email_Template(txtCategory.Text, "GT", 2);
            Forms_Field_Load(poEmail);
        }

        private void lblCatPrevious_Click(object sender, EventArgs e)
        {
            DataAccess da = new DataAccess();
            DataTable poEmail = da.Get_Email_Template(txtCategory.Text, "LT", 2);
            Forms_Field_Load(poEmail);
        }

        private void txtCategory_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                DataAccess da = new DataAccess();
                DataTable poEmail = null;
                if (e.KeyCode.ToString() == "F6" || e.KeyValue == 13)
                {
                    poEmail = da.Get_Email_Template(txtCategory.Text, "GE", 2);
                    Forms_Field_Load(poEmail);
                }
                if (e.KeyCode.ToString() == "F7")
                {
                    poEmail = da.Get_Email_Template(txtCategory.Text, "GT", 2);
                    Forms_Field_Load(poEmail);
                }
                if (e.KeyCode.ToString() == "F8")
                {
                    poEmail = da.Get_Email_Template(txtCategory.Text, "LT", 2);
                    Forms_Field_Load(poEmail);
                }
            }
            catch (Exception exec)
            {
                MessageBox.Show(exec.Message.ToString());
            }                
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                Console.Beep();
                DialogResult poResult = MessageBox.Show("Are you sure you want to delete this template?", "", MessageBoxButtons.YesNo);
                if (poResult == DialogResult.No)
                {
                    return;
                }
                DataAccess da = new DataAccess();
                da.Delete_Email_Template(txtCode.Text, txtEmailTemplate.Text, txtEmailSubject.Text, txtCategory.Text, Convert.ToInt32(txtNotice.Text), Convert.ToByte(chkCC.Checked));
                ClearScreen();
            }
            catch (Exception exec)
            {
                MessageBox.Show(exec.Message.ToString());
            }
        }

        private void btnEmailTemplateList_Click(object sender, EventArgs e)
        {
            UserInfo.Code = "";
            EmailTemplates et = new EmailTemplates();
            et.ShowDialog();
            if (UserInfo.Code.Length>0)
            {
                DataAccess da = new DataAccess();
                DataTable poEmail = null;
                poEmail = da.Get_Email_Template_Record();
                Forms_Field_Load(poEmail);
            }
        }
    }
}