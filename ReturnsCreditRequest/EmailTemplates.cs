using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ReturnsCreditRequest
{
    public partial class EmailTemplates : Form
    {
        public EmailTemplates()
        {
            InitializeComponent();
            Setup_Grid();
            Load_Grid();
        }
        private void Setup_Grid()
        {
            try
            {
                grdTemplates.DefaultCellStyle.SelectionBackColor = Color.DimGray;
                grdTemplates.DefaultCellStyle.SelectionForeColor = Color.Yellow;

                grdTemplates.SelectionMode = DataGridViewSelectionMode.ColumnHeaderSelect;

                grdTemplates.DefaultCellStyle.WrapMode = DataGridViewTriState.False;

                grdTemplates.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                grdTemplates.AllowUserToResizeColumns = true;
            }

            catch (Exception exec)
            {
                MessageBox.Show(exec.Message.ToString());
            }
        }

        private void Load_Grid()
        {
            try
            {
                DataAccess da = new DataAccess();
                grdTemplates.DataSource = da.Get_Email_Templete_List();
                lblTotal.Text = "Total: " + grdTemplates.RowCount;



                ////Code
                DataGridViewColumn c0 = grdTemplates.Columns[0];
                c0.Width = 250;

                ///Category
                DataGridViewColumn c1 = grdTemplates.Columns[1];
                c1.Width = 250;

                ////Notice
                DataGridViewColumn c2 = grdTemplates.Columns[2];
                c2.Width = 50;

                ////CC
                DataGridViewColumn c3 = grdTemplates.Columns[3];
                c3.Width = 50;

                ////Subject
                DataGridViewColumn c4 = grdTemplates.Columns[4];
                c4.Width = 500;

            }
            catch (Exception exec)
            {
                MessageBox.Show(exec.Message.ToString());
            }
        }

        private void grdTemplates_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex == -1)
                {
                    return;
                }
                UserInfo.Code = grdTemplates.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();
                UserInfo.Category = grdTemplates.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
                UserInfo.Notice = Convert.ToInt32(grdTemplates.Rows[e.RowIndex].Cells[2].FormattedValue.ToString());
                UserInfo.Subject = grdTemplates.Rows[e.RowIndex].Cells[4].FormattedValue.ToString();
                UserInfo.CC = Convert.ToByte(grdTemplates.Rows[e.RowIndex].Cells[3].FormattedValue);
                Close();
            }
            catch (Exception exec)
            {
                MessageBox.Show(exec.Message.ToString());
            }
        }
    }
}