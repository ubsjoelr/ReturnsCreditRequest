using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ReturnsCreditRequest
{
    public partial class TrackingNumbers : Form
    {
        public TrackingNumbers()
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
                grdTrackingNumbers.DefaultCellStyle.SelectionBackColor = Color.DimGray;
                grdTrackingNumbers.DefaultCellStyle.SelectionForeColor = Color.Yellow;

                grdTrackingNumbers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                grdTrackingNumbers.AllowUserToResizeColumns = true;
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
                grdTrackingNumbers.DataSource = da.Get_Tracking_Numbers(UserInfo.OrderNumber);

                DataGridViewColumn c0 = grdTrackingNumbers.Columns[0];
                c0.Width = 50;
                DataGridViewColumn c1 = grdTrackingNumbers.Columns[1];
                c1.Width = 700;
                DataGridViewColumn c2 = grdTrackingNumbers.Columns[2];
                c2.Width = 150;
                DataGridViewColumn c3 = grdTrackingNumbers.Columns[3];
                c3.Width = 200;
                DataGridViewColumn c4 = grdTrackingNumbers.Columns[4];
                c4.Width = 100;
            }
            catch (Exception exec)
            {
                MessageBox.Show(exec.Message.ToString());
            }
        }

        private void ClearScreen()
        {
            txtCarrier.Clear();
            txtTrackingNumber.Clear();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearScreen();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            txtTrackingNumber.Text = txtTrackingNumber.Text.Trim().Replace(" ","").ToUpper();
            txtCarrier.Text = txtCarrier.Text.Trim().ToUpper();
            if (txtCarrier.Text.Length == 0 || txtTrackingNumber.Text.Length == 0)
            {
                MessageBox.Show("You MUST Enter Values");
                if (txtTrackingNumber.Text.Length == 0)
                {
                    txtTrackingNumber.Focus();
                    return;
                }
                if (txtCarrier.Text.Length == 0)
                {
                    txtCarrier.Focus();
                }
                return;
            }
            DataAccess da = new DataAccess();
            da.Insert_Tracking(txtTrackingNumber.Text, txtCarrier.Text);
            ClearScreen();
            Load_Grid();
        }

        private void grdTrackingNumbers_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //06/01/2022 - JR\\\\
            string psURL = "";
            if (grdTrackingNumbers.Rows[e.RowIndex].Cells[2].FormattedValue.ToString() == "UPS")
            {
                psURL = "https://wwwapps.ups.com/WebTracking/track?track=yes&trackNums=" + grdTrackingNumbers.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
            }
            if (grdTrackingNumbers.Rows[e.RowIndex].Cells[2].FormattedValue.ToString() == "USPS")
            {
                psURL = "https://tools.usps.com/go/TrackConfirmAction?tLabels=" + grdTrackingNumbers.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
            }

            if (grdTrackingNumbers.Rows[e.RowIndex].Cells[2].FormattedValue.ToString() == "FX")
            {
                psURL = "https://www.fedex.com/apps/fedextrack/?tracknumbers=" + grdTrackingNumbers.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
            }
            if (psURL.Length > 0)
            {
                System.Diagnostics.Process.Start(psURL);
            }
        }
    }
}