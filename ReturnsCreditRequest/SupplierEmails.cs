using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ReturnsCreditRequest
{
    public partial class SupplierEmails : Form
    {
        public SupplierEmails()
        {
            this.KeyPreview = true;
            InitializeComponent();
            Setup_Grid();
            if (UserInfo.SupplierID > 0)
            {
                DataAccess da = new DataAccess();
                List<string> poSupplierName;
                poSupplierName = da.GetSupplier("", "", UserInfo.SupplierID);
                UserInfo.SupplierID = 0;
                Forms_Field_Load(poSupplierName);

            }
            txtName.Focus();
        }

        private void Setup_Grid()
        {
            try
            {
                grdEmails.DefaultCellStyle.SelectionBackColor = Color.DimGray;
                grdEmails.DefaultCellStyle.SelectionForeColor = Color.Yellow;

                grdEmails.SelectionMode = DataGridViewSelectionMode.ColumnHeaderSelect;

                grdEmails.DefaultCellStyle.WrapMode = DataGridViewTriState.False;

                grdEmails.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                grdEmails.AllowUserToResizeColumns = true;
            }

            catch (Exception exec)
            {
                MessageBox.Show(exec.Message.ToString());
            }
        }

        private void Load_Grid(int xlSupplierID)
        {
            try
            {
                DataAccess da = new DataAccess();
                grdEmails.DataSource = da.Get_Email_Logs(xlSupplierID);
                lblTotal.Text = "Total: " + grdEmails.RowCount;

                //Order#
                DataGridViewColumn c0 = grdEmails.Columns[0];
                c0.Width = 60;

                //Email Date
                DataGridViewColumn c1 = grdEmails.Columns[1];
                c1.Width = 120;

                //Notice#
                DataGridViewColumn c2 = grdEmails.Columns[2];
                c2.Width = 50;
                grdEmails.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                grdEmails.Columns[2].DefaultCellStyle.Format = "######0.";

                //From
                DataGridViewColumn c3 = grdEmails.Columns[3];
                c3.Width = 130;

                //To
                DataGridViewColumn c4 = grdEmails.Columns[4];
                c4.Width = 130;

                //Subject
                DataGridViewColumn c5 = grdEmails.Columns[5];
                c5.Width = 300;

                //Body
                DataGridViewColumn c6 = grdEmails.Columns[6];
                c6.Width = 800;

            }
            catch (Exception exec)
            {
                MessageBox.Show(exec.Message.ToString());
            }
        }


        private void Forms_Field_Load(List<string> xoSupplierName)
        {
            try
            {
                ClearScreen();
                if (xoSupplierName[0].Length == 0)
                {
                    return;
                }
                txtSupplierID.Text = xoSupplierName[0];
                txtName.Text = xoSupplierName[1];
                Load_Grid(Convert.ToInt32(xoSupplierName[0]));
                grdEmails_CellContentClick(grdEmails, new DataGridViewCellEventArgs(0, 0));
            }
            catch (Exception exec)
            {
                MessageBox.Show(exec.Message.ToString());
            }
        }

        private void lblNameNext_Click(object sender, EventArgs e)
        {
            try
            {
                DataAccess da = new DataAccess();
                List<string> poSupplierName;

                if (txtName.Text.Length == 0)
                {
                    txtName.Text = "0";
                }

                poSupplierName = da.GetSupplier(txtName.Text, "GT", 0);
                Forms_Field_Load(poSupplierName);
            }
            catch (Exception exec)
            {
                MessageBox.Show(exec.Message.ToString());
            }
        }

        private void lblNamePrevious_Click(object sender, EventArgs e)
        {
            try
            {
                DataAccess da = new DataAccess();
                List<string> poSupplierName;
                if (txtName.Text.Length == 0)
                {
                    txtName.Text = "zzzzzzzzzzzzzzzzzzzzz";
                }
                poSupplierName = da.GetSupplier(txtName.Text, "LT", 0);
                Forms_Field_Load(poSupplierName);
            }
            catch (Exception exec)
            {
                MessageBox.Show(exec.Message.ToString());
            }
        }

        private void txtName_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                DataAccess da = new DataAccess();
                List<string> poSupplierName;
                if (e.KeyCode.ToString() == "F6" || e.KeyValue == 13)
                {
                    poSupplierName = da.GetSupplier(txtName.Text, "GE", 0);
                    Forms_Field_Load(poSupplierName);
                }

                if (e.KeyCode.ToString() == "F7")
                {
                    if (txtName.Text.Length == 0)
                    {
                        txtName.Text = "0";
                    }
                    poSupplierName = da.GetSupplier(txtName.Text, "GT", 0);
                    Forms_Field_Load(poSupplierName);
                }

                if (e.KeyCode.ToString() == "F8")
                {
                    if (txtName.Text.Length == 0)
                    {
                        txtName.Text = "zzzzzzzzzzzzzzzzzzzzz";
                    }
                    poSupplierName = da.GetSupplier(txtName.Text, "LT", 0);
                    Forms_Field_Load(poSupplierName);
                }
            }
            catch (Exception exec)
            {
                MessageBox.Show(exec.Message.ToString());
            }
        }

        private void grdEmails_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }
            if (grdEmails.Rows.Count == 0)
            {
                return;
            }
            btnNotes.Enabled = true;
            txtFrom.Text = grdEmails.Rows[e.RowIndex].Cells[3].FormattedValue.ToString();
            txtTo.Text = grdEmails.Rows[e.RowIndex].Cells[4].FormattedValue.ToString();
            txtEmailSubject.Text = grdEmails.Rows[e.RowIndex].Cells[5].FormattedValue.ToString();
            txtBody.Text = grdEmails.Rows[e.RowIndex].Cells[6].FormattedValue.ToString();
            txtOrderNumber.Text = grdEmails.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();
            txtDate.Text = grdEmails.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
        }

        private void ClearScreen()
        {
            txtEmailSubject.Clear();
            txtFrom.Clear();
            txtName.Clear();
            txtTo.Clear();
            txtOrderNumber.Clear();
            txtDate.Clear();
            txtBody.Clear();
            grdEmails.DataSource = null;
            btnNotes.Enabled = false;
        }

        private void btnNotes_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in grdEmails.Rows)
            {
                if (row.Selected)
                {
                    UserInfo.OrderNumber = Convert.ToInt32(row.Cells[0].FormattedValue.ToString());
                }                
            }
            ReturnNotes rn = new ReturnNotes();
            rn.ShowDialog();
        }
    }
}