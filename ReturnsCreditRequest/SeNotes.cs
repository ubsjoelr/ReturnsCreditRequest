using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ReturnsCreditRequest
{
    public partial class SeNotes : Form
    {
        public SeNotes()
        {
            InitializeComponent();
            lblOperator.Text = "Order#: " + UserInfo.OrderNumber.ToString();
            Setup_Grid();
            Load_Grid_SE();
        }

        private void Setup_Grid()
        {
            try
            {
                grdNotes.DefaultCellStyle.SelectionBackColor = Color.DimGray;
                grdNotes.DefaultCellStyle.SelectionForeColor = Color.Yellow;

                grdNotes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                grdNotes.AllowUserToResizeColumns = true;
            }
            catch (Exception exec)
            {
                MessageBox.Show(exec.Message.ToString());
            }
        }

        private void Load_Grid_SE()
        {
            try
            {
                DataAccess da = new DataAccess();
                grdNotes.DataSource = da.Get_NotesSE(UserInfo.OrderNumber);
                lblTotal.Text = "Total: " + grdNotes.RowCount;

                DataGridViewColumn c0 = grdNotes.Columns[0];
                c0.Width = 0;
                DataGridViewColumn c1 = grdNotes.Columns[1];
                c1.Width = 130;
                DataGridViewColumn c2 = grdNotes.Columns[2];
                c2.Width = 100;
                DataGridViewColumn c3 = grdNotes.Columns[3];
                c3.Width = 3000;
            }

            catch (Exception exec)
            {
                MessageBox.Show(exec.Message.ToString());
            }
        }
    }
}