using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Configuration;
using System.IO;



namespace ReturnsCreditRequest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CreateFolders();
            Setup_Grid();
            Setup_Status();
            //Load_Grid(0, 0);
        }

        private void Setup_Status()
        {
            try
            {
                DataAccess da = new DataAccess();
                cboStatus.DataSource = da.Get_Status();
                cboStatus.DisplayMember = "Status";
                this.cboStatus.TextUpdate -= new System.EventHandler(this.cboStatus_TextChanged);
                cboStatus.SelectedIndex = -1;
                this.cboStatus.TextUpdate += new System.EventHandler(this.cboStatus_TextChanged);
            }

            catch (Exception exec)
            {
                MessageBox.Show(exec.Message.ToString());
            }
        }
        private void Setup_Grid()
        {
            try
            {
                DataGridViewCheckBoxColumn chk = new DataGridViewCheckBoxColumn();
                grdTracking.Columns.Add(chk);

                grdTracking.DefaultCellStyle.SelectionBackColor = Color.DimGray;
                grdTracking.DefaultCellStyle.SelectionForeColor = Color.Yellow;

                grdTracking.SelectionMode = DataGridViewSelectionMode.ColumnHeaderSelect;

                grdTracking.DefaultCellStyle.WrapMode = DataGridViewTriState.False;

                grdTracking.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                grdTracking.MultiSelect = true;
                grdTracking.AllowUserToResizeColumns = true;
            }

            catch (Exception exec)
            {
                MessageBox.Show(exec.Message.ToString());
            }
        }

        private void Load_Grid(int xlOrderNumber, int xlType)
        {
            try
            {
                DataAccess da = new DataAccess();
                grdTracking.DataSource = da.Get_Credit_Requests_Quick(xlOrderNumber, xlType);
                //da.Get_Credit_Requests(xlOrderNumber, xlType);

                if (cboStatus.Text.Length > 0)
                {
                    string rowFilter = string.Format("[{0}] = '{1}'", "Status", cboStatus.Text);
                    (grdTracking.DataSource as DataTable).DefaultView.RowFilter = rowFilter;
                }

                lblTotal.Text = "Total: " + grdTracking.RowCount;


                DataGridViewColumn c0 = grdTracking.Columns[0];
                c0.Width = 50;
                c0.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 9, FontStyle.Bold);

                //SupplierID
                DataGridViewColumn c1 = grdTracking.Columns[1];
                c1.Width = 0;

                //ID
                DataGridViewColumn c2 = grdTracking.Columns[2];
                c2.Width = 0;

                //Order#
                DataGridViewColumn c3 = grdTracking.Columns[3];
                c3.Width = 70;

                //Date
                DataGridViewColumn c4 = grdTracking.Columns[4];
                c4.Width = 100;

                //Supplier Name
                DataGridViewColumn c5 = grdTracking.Columns[5];
                c5.Width = 200;

                //Sku
                DataGridViewColumn c6 = grdTracking.Columns[6];
                c6.Width = 100;

                //Supplier Sku
                DataGridViewColumn c7 = grdTracking.Columns[7];
                c7.Width = 100;

                //Description
                DataGridViewColumn c8 = grdTracking.Columns[8];
                c8.Width = 200;

                //Auth
                DataGridViewColumn c9 = grdTracking.Columns[9];
                c9.Width = 80;

                //Reason
                DataGridViewColumn c10 = grdTracking.Columns[10];
                c10.Width = 200;

                //01/24/2024 - JR\\\\
                //Qty Ret
                DataGridViewColumn c11 = grdTracking.Columns[11];
                //c11.Width = 40;
                c11.Width = 0;
                c11.Visible = false;
                grdTracking.Columns[11].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                grdTracking.Columns[11].DefaultCellStyle.Format = "######0.";

                //Cost
                DataGridViewColumn c12 = grdTracking.Columns[12];
                c12.Width = 70;
                grdTracking.Columns[12].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                grdTracking.Columns[12].DefaultCellStyle.Format = "######0.00";

                //Ship Name
                DataGridViewColumn c13 = grdTracking.Columns[13];
                c13.Width = 200;


                //Tracking#
                DataGridViewColumn c14 = grdTracking.Columns[14];
                c14.Width = 150;

                //Notices
                DataGridViewColumn c15 = grdTracking.Columns[15];
                c15.Width = 50;
                grdTracking.Columns[15].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                grdTracking.Columns[15].DefaultCellStyle.Format = "######0.";

                //Last Notice
                DataGridViewColumn c16 = grdTracking.Columns[16];
                c16.Width = 90;

                //Email Memo
                DataGridViewColumn c17 = grdTracking.Columns[17];
                c17.Width = 200;

                //Reason For Hold/Give Up
                DataGridViewColumn c18 = grdTracking.Columns[18];
                c18.Width = 200;

                //Credit
                DataGridViewColumn c19 = grdTracking.Columns[19];
                c19.Width = 60;
                grdTracking.Columns[19].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                grdTracking.Columns[19].DefaultCellStyle.Format = "######0.00";

                //Terms
                DataGridViewColumn c20 = grdTracking.Columns[20];
                c20.Width = 40;

                //Status
                DataGridViewColumn c21 = grdTracking.Columns[21];
                c21.Width = 200;


            }
            catch (Exception exec)
            {
                MessageBox.Show(exec.Message.ToString());
            }
        }

         private void btnEmailTemplate_Click(object sender, EventArgs e)
        {
            EmailTemplate et = new EmailTemplate();
            et.ShowDialog();
        }

        private void btnNotes_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in grdTracking.Rows)
            {
                if (row.Selected)
                {
                    UserInfo.OrderNumber = Convert.ToInt32(row.Cells[3].FormattedValue.ToString());
                }
            }
            ReturnNotes rn = new ReturnNotes();
            rn.ShowDialog();
        }

        private void btnSENotes_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in grdTracking.Rows)
            {
                if (row.Selected)
                {
                    UserInfo.OrderNumber = Convert.ToInt32(row.Cells[3].FormattedValue.ToString());
                }
            }
            SeNotes Se = new SeNotes();
            Se.ShowDialog();
        }

        private void btnTrackingNumbers_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in grdTracking.Rows)
            {
                if (row.Selected)
                {
                    UserInfo.OrderNumber = Convert.ToInt32(row.Cells[3].FormattedValue.ToString());
                }
            }
            TrackingNumbers tn = new TrackingNumbers();
            tn.ShowDialog();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            btnCheckAll.Enabled = true;
            btnUncheckAll.Enabled = true;
            btnSendEmails.Enabled = true;
            btnSendEmailManually.Enabled = true;
            lblOrderStatus.Visible = false;
            txtOrderNumber.Clear();
            Setup_Status();
            //Load_Grid(0, 0);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtOrderNumber.Text.Trim().Length > 0)
            {
                //foreach (DataGridViewRow row in grdTracking.Rows)
                //{
                //    if (row.Cells["Order#"].Value.ToString().Trim() == txtOrderNumber.Text.Trim())
                //    {
                //        for (int i = 0; i < 21; i++)
                //        {
                //            row.Cells[i].Style.BackColor = Color.Red;
                //        }
                //    }
                //}
                Load_Grid(Convert.ToInt32(txtOrderNumber.Text), 0);
                DataAccess da = new DataAccess();
                int plOrderNumber = Convert.ToInt32(txtOrderNumber.Text);
                lblOrderStatus.Text = da.Get_Order_Status(plOrderNumber);
                lblOrderStatus.Visible = true;
            }
        }

        private void txtOrderNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back) || (e.KeyChar == 46)))
            {
                e.Handled = true;
            }
        }

        private void btnOnHold_Click(object sender, EventArgs e)
        {
            btnCheckAll.Enabled = false;
            btnUncheckAll.Enabled = false;
            btnSendEmails.Enabled = false;
            btnSendEmailManually.Enabled = false;
            lblOrderStatus.Visible = false;
            Load_Grid(0, 1);
        }

        private void btnGivenUp_Click(object sender, EventArgs e)
        {
            btnCheckAll.Enabled = false;
            btnUncheckAll.Enabled = false;
            btnSendEmails.Enabled = false;
            btnSendEmailManually.Enabled = false;
            lblOrderStatus.Visible = false;
            txtOrderNumber.Clear();
            Load_Grid(0, 2);

        }

        private void btnHoldOrGiveUp_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in grdTracking.Rows)
            {
                if (row.Selected)
                {
                    UserInfo.OrderNumber = Convert.ToInt32(row.Cells[3].FormattedValue.ToString());
                    UserInfo.ID = Convert.ToInt32(row.Cells[2].FormattedValue.ToString());
                }
            }
            btnCheckAll.Enabled = false;
            btnUncheckAll.Enabled = false;
            btnSendEmails.Enabled = false;
            btnSendEmailManually.Enabled = false;
            txtOrderNumber.Clear();
            HoldOrGiveUp hg = new HoldOrGiveUp();
            hg.ShowDialog();
        }

        private void btnTestEmails_Click(object sender, EventArgs e)
        {
            Console.Beep();
            DialogResult poResult = MessageBox.Show("Are you sure you want to TEST Emails?", "", MessageBoxButtons.YesNo);
            if (poResult == DialogResult.No)
            {
                return;
            }

            btnCheckAll.Enabled = false;
            btnUncheckAll.Enabled = false;
            btnSendEmails.Enabled = false;
            btnSendEmailManually.Enabled = false;
            SendEmails(false, true);
            Load_Grid(0, 0);
            btnCheckAll.Enabled = true;
            btnUncheckAll.Enabled = true;
            btnSendEmails.Enabled = true;
            btnSendEmailManually.Enabled = true;
        }

        private void btnSendEmails_Click(object sender, EventArgs e)
        {
            Console.Beep();
            DialogResult poResult = MessageBox.Show("Are you sure you want to SEND Emails?", "", MessageBoxButtons.YesNo);
            if (poResult == DialogResult.No)
            {
                return;
            }

            btnCheckAll.Enabled = false;
            btnUncheckAll.Enabled = false;
            btnSendEmails.Enabled = false;
            btnSendEmailManually.Enabled = false;
            SendEmails(false, false);
            Load_Grid(0, 0);
            btnCheckAll.Enabled = true;
            btnUncheckAll.Enabled = true;
            btnSendEmails.Enabled = true;
            btnSendEmailManually.Enabled = true;
        }

        private void SendEmails(bool xbManually, bool xbTest)
        {
            try
            {

                if (xbManually)
                {
                    if (!Directory.Exists(@ConfigurationManager.AppSettings["ManualEmails"]))
                    {
                        Directory.CreateDirectory(@ConfigurationManager.AppSettings["ManualEmails"]);
                    }
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message.ToString());
                return;
            }
            

            string psDateTime = DateTime.Now.ToString("yyyyMMdd-HHmmss");
            DataAccess da = new DataAccess();

            //07/15/2022 - JR\\\\
            if (xbManually)
            {
                string psFile = "Credit_Requests";
                //01/19/2024 - JR\\\\
                //for (int i = 0; i < 1; i++)
                {
                    DataTable poManualSuppliers = da.Get_Manual_Suppliers_Over_X();
                    int plSupplierID = 0;
                    string psSupplierName = "";
                    string psOrderNumber = "";
                    foreach (DataRow poRow in poManualSuppliers.Rows)
                    {
                        bool pbFirst = true;
                        plSupplierID = Convert.ToInt32(poRow["SupplierID"].ToString());
                        psSupplierName = poRow["SupplierName"].ToString();
                        DataTable poManualSuppliersDetail = da.Get_Manual_Suppliers_Detail(plSupplierID, cboStatus.Text);
                        foreach (DataRow poRow1 in poManualSuppliersDetail.Rows)
                        {
                            string psAuth = poRow1["Auth#"].ToString();
                            string psTrackingNumber = poRow1["Tracking#"].ToString();
                            string psNoticeNumber = poRow1["Notices"].ToString();
                            psOrderNumber = poRow1["Order#"].ToString();
                            string psSupplier = poRow1["Supplier"].ToString();
                            string psDescription = poRow1["Description"].ToString();
                            string psSupplierSku = poRow1["Supplier Sku"].ToString();
                            string psDateAuth = poRow1["Date Of RA"].ToString();
                            string psShipTo = poRow1["Ship To"].ToString();
                            string psQty = poRow1["Ret Qty"].ToString();
                            string psRetDate = poRow1["Date Of RA"].ToString();
                            string psTerms = poRow1["Terms"].ToString();
                            string psReason = poRow1["Reason"].ToString();
                            //07/21/2022 - JR\\\\
                            decimal pdCost = 0;
                            if (poRow1["Cost"].ToString().Trim().Length > 0)
                            {
                                pdCost = Convert.ToDecimal(poRow1["Cost"].ToString());
                            }
                            decimal pdExteneded = 0;
                            if (psQty.Trim().Length>0)
                            {
                                pdExteneded = Convert.ToDecimal(psQty) * pdCost;
                            }
                            //01/19/2024 - JR\\\\
                            using (StreamWriter poFile = File.AppendText(@ConfigurationManager.AppSettings["ManualEmails"] + psFile + "_" + psSupplierName + "_" + psDateTime + ".csv"))
                            {
                                if (pbFirst)
                                {
                                    poFile.Write("Supplier" + ",");
                                    poFile.Write("Order Number" + ",");
                                    poFile.Write("Sku" + ",");
                                    poFile.Write("Qty" + ",");
                                    //07/21/2022 - JR\\\\
                                    poFile.Write("Cost" + ",");
                                    poFile.Write("Extended" + ",");
                                    poFile.Write("RA Number" + ",");
                                    poFile.Write("Return Date" + ",");
                                    poFile.Write("Ship To" + ",");
                                    poFile.Write("Tracking Number" + ",");
                                    poFile.WriteLine("Reason");

                                }
                                pbFirst = false;
                                poFile.Write("\"" + psSupplier + "\"" + ",");
                                poFile.Write("\"" + psOrderNumber + "\"" + ",");
                                poFile.Write("\"" + psSupplierSku + "\"" + ",");
                                poFile.Write("\"" + psQty + "\"" + ",");
                                //07/21/2022 - JR\\\\
                                poFile.Write("\"" + pdCost.ToString("N2") + "\"" + ",");
                                poFile.Write("\"" + pdExteneded.ToString("N2") + "\"" + ",");
                                poFile.Write("\"" + psAuth + "\"" + ",");
                                poFile.Write("\"" + psRetDate + "\"" + ",");
                                poFile.Write("\"" + psShipTo + "\"" + ",");
                                poFile.Write("\"" + psTrackingNumber + "\"" + ",");
                                poFile.WriteLine("\"" + psReason + "\"" + ",");
                                poFile.Close();
                            }
                        }
                        //01/20/2024 - JR\\\\
                        //continue;
                        int plNoticeNumber = 1;
                        DataTable poTemplate = da.Get_Email_Template(1, 0, "MANUAL", "MANUAL", "MANUAL");
                        DataTable poSupplierInfo = da.Get_Supplier_Info(plSupplierID);
                        //DataTable poOrderShipInfo = da.Get_Order_Ship_Info(Convert.ToInt32(psOrderNumber));

                        if (poTemplate.Rows.Count > 0)
                        {
                            DataRow poDataRow = poTemplate.Rows[0];
                            DataRow poDataRow1 = poSupplierInfo.Rows[0];
                            //DataRow poDataRow2 = poOrderShipInfo.Rows[0];

                            List<string> poAttch = new List<string>();
                            poAttch.Add(@ConfigurationManager.AppSettings["ManualEmails"] + psFile + "_" + psSupplierName + "_" + psDateTime + ".csv");

                            string psSubject = poDataRow["Subject"].ToString();
                            string psBody = poDataRow["Template"].ToString();

                            string psFrom = @ConfigurationManager.AppSettings["EmailFrom"];
                            List<string> poBC = new List<string>();
                            //poBC.Add(@ConfigurationManager.AppSettings["bccEmail"]);
                            string psTo = poDataRow1["Text4"].ToString().Trim();
                            psTo = psTo.Replace(";", ",");
                            if (psTo.Length < 5)
                            {
                                psTo = poDataRow1["Email"].ToString().Trim();
                            }
                            try
                            {
                                bool pbSent = false;
                                if (xbTest)                                
                                {
                                    pbSent = EmailLogger.SendEmail(@ConfigurationManager.AppSettings["EmailTo"], psSubject, psBody, poAttch, null, null, "");
                                }
                                else
                                {
                                    //01/28/2024 - JR\\\\
                                    bool pbSent1 = false;
                                    string[] psEmails = psTo.Split(',');
                                    foreach (string psEmail in psEmails)
                                    {
                                        //pbSent = EmailLogger.SendEmail("joelr@unbeatablesale.com", psSubject, psBody, null, poAttch, poBC, psFrom);
                                        pbSent = EmailLogger.SendEmail(psEmail, psSubject, psBody, null, poAttch, poBC, psFrom);
                                        if (pbSent)
                                        {
                                            pbSent1 = true;
                                        }
                                    }

                                    if (pbSent1 && !xbTest)
                                    {
                                        da.Insert_Email_Log(plSupplierID, Convert.ToInt32(psOrderNumber), 1, "MANUAL", "MANUAL", "MANUAL", "MANUAL");
                                    }
                                    else
                                    {
                                        if (!xbTest)
                                        {
                                            EmailLogger.SendEmail(@ConfigurationManager.AppSettings["EmailTo"], "NOT SENT: " + psSubject, psBody, null, null, null, psFrom);
                                        }
                                    }
                                } 
                            }
                            catch (Exception exc)
                            {
                                MessageBox.Show(exc.Message.ToString());
                            }
                        }
                    }                    
                }
                return;
            }

            foreach (DataGridViewRow poRow in grdTracking.Rows)
            {
                try
                {
                    DataGridViewCheckBoxCell chkchecking = poRow.Cells[0] as DataGridViewCheckBoxCell;
                    //07/15/2022 - JR\\\\
                    if (Convert.ToBoolean(chkchecking.Value) == true)
                    {
                        string psAuth = poRow.Cells[9].FormattedValue.ToString();
                        string psTrackingNumber = poRow.Cells[14].FormattedValue.ToString();
                        string psNoticeNumber = poRow.Cells[15].FormattedValue.ToString();
                        string psOrderNumber = poRow.Cells[3].FormattedValue.ToString();
                        string psSupplier = poRow.Cells[5].FormattedValue.ToString();
                        string psDescription = poRow.Cells[8].FormattedValue.ToString();
                        string psSupplierSku = poRow.Cells[7].FormattedValue.ToString();
                        string psDateAuth = poRow.Cells[4].FormattedValue.ToString();
                        string psSupplierID = poRow.Cells[1].FormattedValue.ToString();
                        string psShipTo = poRow.Cells[13].FormattedValue.ToString();
                        string psMemo = poRow.Cells[17].FormattedValue.ToString();
                        string psQty = poRow.Cells[11].FormattedValue.ToString();
                        string psRetDate = poRow.Cells[4].FormattedValue.ToString();
                        string psTerms = poRow.Cells[20].FormattedValue.ToString();
                        string psStatus = poRow.Cells[21].FormattedValue.ToString();

                        string psAuditDate = "";

                        int plNoticeNumber = 1;
                        if (psNoticeNumber.Trim().Length > 0)
                        {
                            plNoticeNumber = Convert.ToInt32(psNoticeNumber.Trim()) + 1;
                        }

                        int plHoldNoticeNumber = plNoticeNumber;

                        string psCategory = psAuth.ToUpper();

                        int plTrackingNumber = 1;
                        if (psTrackingNumber.Trim().Length == 0)
                        {
                            plTrackingNumber = 0;
                        }

                        int plMaxNoticeNumber = Convert.ToInt32(@ConfigurationManager.AppSettings["MaxNoticeNumber"].ToString());

                        //if (plNoticeNumber >= plMaxNoticeNumber || (psStatus == "Never Shipped" && plNoticeNumber>1))

                        DataTable poTemplate = da.Get_Email_Template(plNoticeNumber, plTrackingNumber, psCategory, psStatus, psTerms);
                        plNoticeNumber = plHoldNoticeNumber;
                        DataTable poSupplierInfo = da.Get_Supplier_Info(Convert.ToInt32(psSupplierID));
                        DataTable poOrderShipInfo = da.Get_Order_Ship_Info(Convert.ToInt32(psOrderNumber));
                        //08/03/2023 - JR\\\\
                        DataTable poCharge = da.Get_Order_Charge(Convert.ToInt32(psOrderNumber));

                        if (poTemplate.Rows.Count > 0)
                        {
                            DataRow poDataRow = poTemplate.Rows[0];
                            DataRow poDataRow1 = poSupplierInfo.Rows[0];
                            DataRow poDataRow2 = poOrderShipInfo.Rows[0];
                            DataRow poDataRow3 = poCharge.Rows[0];
                            

                            string psShipCompany = poDataRow2["ShipCompany"].ToString();
                            string psSubject = poDataRow["Subject"].ToString();
                            string psBody = poDataRow["Template"].ToString();
                            string psName = poDataRow1["Text3"].ToString();
                            //08/03/2023 - JR\\\\
                            double pdCharge = Convert.ToDouble(poDataRow3["Charge"].ToString());
                            string psReason = poDataRow3["Reason"].ToString();

                            psBody = psBody.Replace("<PO_Number>", psOrderNumber).Replace("<RaNumber>", psAuth)
                            .Replace("<DateReturnedtoVendor>", psDateAuth).Replace("<Supplier_SKU>", psSupplierSku)
                            .Replace("<Description>", psDescription)
                            .Replace("<SupplierID>", psSupplierID).Replace("<ShipName>", psShipTo)
                            .Replace("<Qty>",psQty)
                            .Replace("<TrackingNumber>", psTrackingNumber).Replace("<Name>", psName).Replace("<SupplierName>", psSupplier)
                            .Replace("<Memo>", psMemo)
                            .Replace("<ShipCompany>", psShipCompany).Replace("<ShipAddress>", poDataRow2["ShipAddress"].ToString())
                            .Replace("<ShipAddress2>", poDataRow2["ShipAddress2"].ToString())
                            .Replace("<ShipCity>", poDataRow2["ShipCity"].ToString())
                            .Replace("<ShipState>", poDataRow2["ShipState"].ToString())
                            .Replace("<ShipZip>", poDataRow2["ShipZip"].ToString())
                            .Replace("<ShipDate>", psAuditDate)
                             //08/03/2023 - JR\\\\
                            .Replace("<Charge>", pdCharge.ToString("####0.00"))
                            //08/08/2023 - JR\\\\
                            .Replace("<Reason>", psReason)
                            .Replace("<ShipCountry>", poDataRow2["ShipCountry"].ToString());

                            string psEmailFrom = da.Get_Email_From(psStatus);
                            psSubject = psSubject.Replace("<PO_Number>", psOrderNumber).Replace("<RaNumber>", psAuth);
                            string psFrom = @ConfigurationManager.AppSettings["EmailFrom"];
                            List<string> poBC = new List<string>();
                            poBC.Add(@ConfigurationManager.AppSettings["bccEmail"]);
                            //poBC.Add(@ConfigurationManager.AppSettings["bccEmail2"]);
                            string psTo = poDataRow1["Text4"].ToString().Trim();
                            psTo = psTo.Replace(";", ",");
                            if (psTo.Length < 5)
                            {
                                psTo = poDataRow1["Email"].ToString().Trim();
                            }
                            try
                            {
                                bool pbSent1 = false;
                                bool pbSent = false;
                                if (xbTest)
                                {
                                    pbSent = EmailLogger.SendEmail(@ConfigurationManager.AppSettings["EmailTo"], psSubject, psBody, null, null, null, psEmailFrom);
                                }
                                else
                                {
                                    //01/28/2024 - JR\\\\
                                    string[] psEmails = psTo.Split(',');
                                    foreach (string psEmail in psEmails)
                                    {
                                        //pbSent = EmailLogger.SendEmail("joelr@unbeatablesale.com", psSubject, psBody, null, poAttch, poBC, psFrom);
                                        pbSent = EmailLogger.SendEmail(psEmail, psSubject, psBody, null, null, poBC, psEmailFrom);
                                        if (pbSent)
                                        {
                                            pbSent1 = true;
                                        }
                                    }
                                }
                                if (pbSent1 && !xbTest)
                                {
                                    da.Insert_Email_Log(Convert.ToInt32(psSupplierID), Convert.ToInt32(psOrderNumber), plNoticeNumber, psFrom, psTo, psSubject, psBody);
                                }
                                else
                                {
                                    if (!xbTest)
                                    {
                                        EmailLogger.SendEmail(@ConfigurationManager.AppSettings["EmailTo"], "NOT SENT: " + psSubject, psBody, null, null, null, psEmailFrom);
                                    }
                                }
                            }
                            catch (Exception exc)
                            {
                                MessageBox.Show(exc.Message.ToString());
                            }
                            txtOrderNumber.Clear();
                        }
                    }
                }
                catch (Exception exc)
                {
                    MessageBox.Show(exc.Message.ToString());
                    return;
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in grdTracking.Rows)
            {
                if (row.Selected)
                {
                    UserInfo.OrderNumber = Convert.ToInt32(row.Cells[3].FormattedValue.ToString());
                    UserInfo.ID = Convert.ToInt32(row.Cells[2].FormattedValue.ToString());
                }
            }
            EditOrder eo = new EditOrder();
            eo.ShowDialog();

            txtOrderNumber.Clear();
            Load_Grid(0, 0);
        }

        private void btnSent_Click(object sender, EventArgs e)
        {
            btnCheckAll.Enabled = false;
            btnUncheckAll.Enabled = false;
            btnSendEmails.Enabled = false;
            btnSendEmailManually.Enabled = false;
            lblOrderStatus.Visible = false;
            txtOrderNumber.Clear();
            Load_Grid(0, 9);
        }

        private void btnSendEmailManually_Click(object sender, EventArgs e)
        {
            Console.Beep();
            DialogResult poResult = MessageBox.Show("Are you sure you want to process MANUAL Emails?", "", MessageBoxButtons.YesNo);
            if (poResult == DialogResult.No)
            {
                return;
            }
            btnCheckAll.Enabled = false;
            btnUncheckAll.Enabled = false;
            btnSendEmails.Enabled = false;
            btnSendEmailManually.Enabled = false;
            SendEmails(true, false);
            btnCheckAll.Enabled = true;
            btnUncheckAll.Enabled = true;
            btnSendEmails.Enabled = true;
            btnSendEmailManually.Enabled = true;
            Load_Grid(0, 0);
        }

        private void btnEmailLogs_Click(object sender, EventArgs e)
        {
            SupplierEmails se = new SupplierEmails();
            se.ShowDialog();
        }

        private void btnCheckAll_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in grdTracking.Rows)
            {
                DataGridViewCheckBoxCell chkchecking = row.Cells[0] as DataGridViewCheckBoxCell;
                chkchecking.Value = true;
            }
        }

        private void btnUncheckAll_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in grdTracking.Rows)
            {
                DataGridViewCheckBoxCell chkchecking = row.Cells[0] as DataGridViewCheckBoxCell;
                chkchecking.Value = false;
            }
        }

        private void grdTracking_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex == -1)
                {
                    return;
                }
                string psOrderNumber = grdTracking.Rows[e.RowIndex].Cells[3].FormattedValue.ToString();
                string psSku = grdTracking.Rows[e.RowIndex].Cells[6].FormattedValue.ToString();
                System.IO.File.WriteAllText(@ConfigurationManager.AppSettings["StoneEdgeRefundPath"], psOrderNumber);
                System.IO.File.WriteAllText(@ConfigurationManager.AppSettings["SEOrderNumber"], psOrderNumber);
                System.IO.File.WriteAllText(@ConfigurationManager.AppSettings["ProductEditorPath"], psSku);
                Clipboard.SetText(psOrderNumber);
            }
            catch (Exception exec)
            {
                MessageBox.Show(exec.Message.ToString());
            }
        }

        private void grdTracking_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }
            UserInfo.SupplierID = Convert.ToInt32(grdTracking.Rows[e.RowIndex].Cells[1].FormattedValue.ToString());
        }

        private static void CreateFolders()
        {
            try
            {
                if (!Directory.Exists(@ConfigurationManager.AppSettings["Errors"]))
                {
                    Directory.CreateDirectory(@ConfigurationManager.AppSettings["Errors"]);
                }
                if (!Directory.Exists(@ConfigurationManager.AppSettings["ManualEmails"]))
                {
                    Directory.CreateDirectory(@ConfigurationManager.AppSettings["ManualEmails"]);
                }
            }
            catch (Exception exc)
            {
                DateTime now = DateTime.Now;
                using (StreamWriter outfile = File.AppendText(@ConfigurationManager.AppSettings["Errors"] + "CreditReturnError.txt"))
                {
                    outfile.WriteLine(now + @" Reason: " + exc.Message.ToString());
                    outfile.Close();
                }
                Console.WriteLine(exc.Message);
            }
        }

        private void btnRegenerate_Click(object sender, EventArgs e)
        {
            lblOrderStatus.Visible = false;
            btnRegenerate.Enabled = false;
            DataAccess da = new DataAccess();
            da.Regenerate();
            btnRegenerate.Enabled = true;
            Setup_Status();
        }

        private void cboStatus_TextChanged(object sender, EventArgs e)
        {
            lblOrderStatus.Visible = false;
            Load_Grid(0, 0);
        }

        private void btnManualSuppliers_Click(object sender, EventArgs e)
        {
            //07/19/2022 - JR\\\\
            ManualSuppliers ms = new ManualSuppliers();
            ms.ShowDialog();
        } 

    }
}