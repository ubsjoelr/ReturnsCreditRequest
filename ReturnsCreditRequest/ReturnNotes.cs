using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ReturnsCreditRequest
{
    public partial class ReturnNotes : Form
    {
        public ReturnNotes()
        {
            InitializeComponent();
            lblOperator.Text = "Order#: " + UserInfo.OrderNumber.ToString();
            Setup_Grid();
            Load_Grid();
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

        private void Load_Grid()
        {
            try
            {
                DataAccess da = new DataAccess();
                grdNotes.DataSource = da.Get_Notes(UserInfo.OrderNumber);

                DataGridViewColumn c0 = grdNotes.Columns[0];
                c0.Width = 0;
                c0.Visible = false;
                DataGridViewColumn c1 = grdNotes.Columns[1];
                c1.Width = 135;
                DataGridViewColumn c2 = grdNotes.Columns[2];
                c2.Width = 150;
                DataGridViewColumn c3 = grdNotes.Columns[3];
                c3.Width = 1000;
                DataGridViewColumn c4 = grdNotes.Columns[4];
                c4.Width = 0;
            }
            catch (Exception exec)
            {
                MessageBox.Show(exec.Message.ToString());
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddNote An = new AddNote();
            An.ShowDialog();
            Load_Grid();
        }

    }
}