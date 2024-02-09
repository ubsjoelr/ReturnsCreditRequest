using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ReturnsCreditRequest
{
    public partial class SuppliersList : Form
    {
        public SuppliersList()
        {
            InitializeComponent();
            if (UserInfo.SupplierType=="M")
            {
                lblTitle.Text = "List Of Manual Suppliers";
            }
            else
            {
                lblTitle.Text = "List Of Suppliers";
            }
            Setup_Grid();
            Load_Grid();
        }

        private void Setup_Grid()
        {
            try
            {
                grdSuppliers.DefaultCellStyle.SelectionBackColor = Color.DimGray;
                grdSuppliers.DefaultCellStyle.SelectionForeColor = Color.Yellow;

                grdSuppliers.SelectionMode = DataGridViewSelectionMode.ColumnHeaderSelect;

                grdSuppliers.DefaultCellStyle.WrapMode = DataGridViewTriState.False;

                grdSuppliers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                grdSuppliers.AllowUserToResizeColumns = true;
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
                grdSuppliers.DataSource = da.Get_Supplier_List(UserInfo.SupplierType);
                lblTotal.Text = "Total: " + grdSuppliers.RowCount;



                ////Supplier Name
                DataGridViewColumn c0 = grdSuppliers.Columns[0];
                c0.Width = 350;

                ///SupplierID
                DataGridViewColumn c1 = grdSuppliers.Columns[1];
                c1.Width = 75;

                ////Address
                DataGridViewColumn c2 = grdSuppliers.Columns[2];
                c2.Width = 275;

                ////City
                DataGridViewColumn c3 = grdSuppliers.Columns[3];
                c3.Width = 250;

                ////State
                DataGridViewColumn c4 = grdSuppliers.Columns[4];
                c4.Width = 75;

                ////Zip
                DataGridViewColumn c5 = grdSuppliers.Columns[5];
                c5.Width = 75;

            }
            catch (Exception exec)
            {
                MessageBox.Show(exec.Message.ToString());
            }
        }

        private void grdSuppliers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex == -1)
                {
                    return;
                }
                UserInfo.SupplierName = grdSuppliers.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();
                Close();
            }
            catch (Exception exec)
            {
                MessageBox.Show(exec.Message.ToString());
            }

        }


    }
}
