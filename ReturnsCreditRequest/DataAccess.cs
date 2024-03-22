using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Text;
using System.Text.RegularExpressions;
using System.Data.SqlClient;
using System.Configuration;
using System.IO;
using System.Runtime.InteropServices;
using System;
using System.Windows.Forms;

namespace ReturnsCreditRequest
{
    class DataAccess
    {
        public void Regenerate()
        {
            try
            {
                String connectionString = ConfigurationManager.ConnectionStrings["ubsInterimTestDB"].ConnectionString;
                SqlConnection conn = new SqlConnection(connectionString);
                SqlCommand cmd = new SqlCommand("p_Returns_Insert_Credit_Requests", conn);

                conn.Open();
                cmd.CommandTimeout = 1000;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Clear();

                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message.ToString());
            }
        }

        public DataTable Get_Credit_Requests(int xlOrderNumber, int xlType)
        {
            DataTable poCreditRequests = new DataTable();
            try
            {
                String connectionString = ConfigurationManager.ConnectionStrings["ubsInterimTestDB"].ConnectionString;
                SqlConnection conn = new SqlConnection(connectionString);
                SqlCommand cmd = new SqlCommand("p_Returns_Get_Credit_Requests", conn);

                conn.Open();
                cmd.CommandTimeout = 90;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Clear();

                cmd.Parameters.AddWithValue("@OrderNumber", xlOrderNumber);
                cmd.Parameters.AddWithValue("@Types", xlType);

                SqlDataAdapter sqlDataAdap = new SqlDataAdapter(cmd);
                sqlDataAdap.Fill(poCreditRequests);
                conn.Close();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message.ToString());
            }
            return poCreditRequests;
        }


        public DataTable Get_Status()
        {
            DataTable poStatus = new DataTable();
            try
            {
                String connectionString = ConfigurationManager.ConnectionStrings["ubsInterimTestDB"].ConnectionString;
                SqlConnection conn = new SqlConnection(connectionString);
                SqlCommand cmd = new SqlCommand("p_Returns_Get_Credit_Status", conn);

                conn.Open();
                cmd.CommandTimeout = 90;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Clear();

                SqlDataAdapter sqlDataAdap = new SqlDataAdapter(cmd);
                sqlDataAdap.Fill(poStatus);
                conn.Close();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message.ToString());
            }
            return poStatus;
        }


        public DataTable Get_Credit_Requests_Quick(int xlOrderNumber, int xlType)
        {
            DataTable poCreditRequests = new DataTable();
            try
            {
                String connectionString = ConfigurationManager.ConnectionStrings["ubsInterimTestDB"].ConnectionString;
                SqlConnection conn = new SqlConnection(connectionString);
                SqlCommand cmd = new SqlCommand("p_Returns_Get_Credit_Requests_Quick", conn);

                conn.Open();
                cmd.CommandTimeout = 90;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Clear();

                cmd.Parameters.AddWithValue("@OrderNumber", xlOrderNumber);
                cmd.Parameters.AddWithValue("@Types", xlType);

                SqlDataAdapter sqlDataAdap = new SqlDataAdapter(cmd);
                sqlDataAdap.Fill(poCreditRequests);
                conn.Close();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message.ToString());
            }
            return poCreditRequests;
        }

        public DataTable Get_Email_Templete_List()
        {
            DataTable poTempleteList = new DataTable();
            try
            {
                String connectionString = ConfigurationManager.ConnectionStrings["ubsInterimTestDB"].ConnectionString;
                SqlConnection conn = new SqlConnection(connectionString);
                SqlCommand cmd = new SqlCommand("p_Returns_Get_Email_Credit_Request_List", conn);

                conn.Open();
                cmd.CommandTimeout = 90;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Clear();

                SqlDataAdapter sqlDataAdap = new SqlDataAdapter(cmd);
                sqlDataAdap.Fill(poTempleteList);
                conn.Close();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message.ToString());
            }
            return poTempleteList;
        }

        public DataTable Get_Manual_Suppliers()
        {
            //07/15/2022 - JR\\\\
            DataTable poManualSuppliers = new DataTable();
            try
            {
                String connectionString = ConfigurationManager.ConnectionStrings["ubsInterimTestDB"].ConnectionString;
                SqlConnection conn = new SqlConnection(connectionString);
                SqlCommand cmd = new SqlCommand("p_Returns_Get_Manual_Suppliers", conn);

                conn.Open();
                cmd.CommandTimeout = 90;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Clear();

                SqlDataAdapter sqlDataAdap = new SqlDataAdapter(cmd);
                sqlDataAdap.Fill(poManualSuppliers);
                conn.Close();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message.ToString());
            }
            return poManualSuppliers;
        }

        public DataTable Get_Manual_Supplier(string xsSupplierName, string xsSearchParam, string xsSupplier)
        {
            //07/15/2022 - JR\\\\
            DataTable poManualSupplier = new DataTable();
            try
            {
                String connectionString = ConfigurationManager.ConnectionStrings["ubsInterimTestDB"].ConnectionString;
                SqlConnection conn = new SqlConnection(connectionString);
                SqlCommand cmd = new SqlCommand("p_Returns_Get_Manual_Supplier", conn);

                conn.Open();
                cmd.CommandTimeout = 90;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Clear();

                cmd.Parameters.AddWithValue("@SupplierName", xsSupplierName);
                cmd.Parameters.AddWithValue("@SearchParam", xsSearchParam);
                cmd.Parameters.AddWithValue("@Supplier", xsSupplier);

                SqlDataAdapter sqlDataAdap = new SqlDataAdapter(cmd);
                sqlDataAdap.Fill(poManualSupplier);
                conn.Close();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message.ToString());
            }
            return poManualSupplier;
        }

        public DataTable Get_Supplier_List(string xsSupplier)
        {
            //07/15/2022 - JR\\\\
            DataTable poSupplierList = new DataTable();
            try
            {
                String connectionString = ConfigurationManager.ConnectionStrings["ubsInterimTestDB"].ConnectionString;
                SqlConnection conn = new SqlConnection(connectionString);
                SqlCommand cmd = new SqlCommand("p_Returns_Get_Suppliers", conn);

                conn.Open();
                cmd.CommandTimeout = 90;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Clear();

                cmd.Parameters.AddWithValue("@Supplier", xsSupplier);

                SqlDataAdapter sqlDataAdap = new SqlDataAdapter(cmd);
                sqlDataAdap.Fill(poSupplierList);
                conn.Close();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message.ToString());
            }
            return poSupplierList;
        }


        public void Update_Manual_Supplier(int xlSupplierID, string xsSupplier)
        {
            try
            {
                String connectionString = ConfigurationManager.ConnectionStrings["ubsInterimTestDB"].ConnectionString;
                SqlConnection conn = new SqlConnection(connectionString);
                SqlCommand cmd = new SqlCommand("p_Returns_Change_Manual_Supplier", conn);

                conn.Open();
                cmd.CommandTimeout = 1000;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Clear();

                cmd.Parameters.AddWithValue("@Supplier", xsSupplier);
                cmd.Parameters.AddWithValue("@SupplierID", xlSupplierID);

                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message.ToString());
            }
        }


        public DataTable Get_Manual_Suppliers_Over_X()
        {
            //07/15/2022 - JR\\\\
            DataTable poManualSuppliers = new DataTable();
            try
            {
                String connectionString = ConfigurationManager.ConnectionStrings["ubsInterimTestDB"].ConnectionString;
                SqlConnection conn = new SqlConnection(connectionString);
                SqlCommand cmd = new SqlCommand("p_Returns_Get_Manual_Suppliers_Over_X", conn);

                conn.Open();
                cmd.CommandTimeout = 90;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Clear();

                SqlDataAdapter sqlDataAdap = new SqlDataAdapter(cmd);
                sqlDataAdap.Fill(poManualSuppliers);
                conn.Close();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message.ToString());
            }
            return poManualSuppliers;
        }



        public DataTable Get_Manual_Suppliers_Detail(int xlSupplierID, string xsStatus)
        {
            //07/15/2022 - JR\\\\
            DataTable poManualSuppliersDetail = new DataTable();
            try
            {
                String connectionString = ConfigurationManager.ConnectionStrings["ubsInterimTestDB"].ConnectionString;
                SqlConnection conn = new SqlConnection(connectionString);
                SqlCommand cmd = new SqlCommand("p_Returns_Get_Manual_Requests", conn);

                conn.Open();
                cmd.CommandTimeout = 90;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Clear();

                cmd.Parameters.AddWithValue("@SupplierID", xlSupplierID);
                cmd.Parameters.AddWithValue("@Status", xsStatus);

                SqlDataAdapter sqlDataAdap = new SqlDataAdapter(cmd);
                sqlDataAdap.Fill(poManualSuppliersDetail);
                conn.Close();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message.ToString());
            }
            return poManualSuppliersDetail;
        }



        public void Update_Note(int xlOrderNumber, string xsNote, bool xbCompuerGenerated)
        {
            try
            {
                String connectionString = ConfigurationManager.ConnectionStrings["ubsInterimTestDB"].ConnectionString;
                SqlConnection conn = new SqlConnection(connectionString);
                SqlCommand cmd = new SqlCommand("p_Returns_UpdateNotes", conn);

                conn.Open();
                cmd.CommandTimeout = 1000;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Clear();

                cmd.Parameters.AddWithValue("@ID", 0);
                cmd.Parameters.AddWithValue("@OrderNumber", xlOrderNumber);
                cmd.Parameters.AddWithValue("@Operator", UserInfo.OpName);
                cmd.Parameters.AddWithValue("@Note", xsNote);
                cmd.Parameters.AddWithValue("@ComputerGenerated", xbCompuerGenerated);
                cmd.Parameters.AddWithValue("@QtyReturned", 0);

                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message.ToString());
            }
        }



        public string Get_Order_Status(int xlOrderNumber)
        {
            string psOrderStatus = "";
            try
            {
                String connectionString = ConfigurationManager.ConnectionStrings["ubsInterimTestDB"].ConnectionString;
                SqlConnection conn = new SqlConnection(connectionString);
                SqlCommand cmd = new SqlCommand("p_Returns_Get_Credit_Requests_Status", conn);

                conn.Open();
                cmd.CommandTimeout = 90;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Clear();

                cmd.Parameters.AddWithValue("@OrderNumber", xlOrderNumber);

                cmd.Parameters.Add("@Status", SqlDbType.VarChar, 1).Direction = ParameterDirection.Output;

                cmd.ExecuteNonQuery();
                psOrderStatus = cmd.Parameters["@Status"].Value.ToString();
                if (psOrderStatus == "A")
                {
                    psOrderStatus = "Active";
                }
                if (psOrderStatus == "H")
                {
                    psOrderStatus = "On Hold";
                }
                if (psOrderStatus == "G")
                {
                    psOrderStatus = "Given Up";
                }
                conn.Close();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message.ToString());
            }
            return psOrderStatus;
        }

        public string Get_Email_From(string xsStatus)
        {
            string psEmailFrom = "";
            try
            {
                String connectionString = ConfigurationManager.ConnectionStrings["ubsInterimTestDB"].ConnectionString;
                SqlConnection conn = new SqlConnection(connectionString);
                SqlCommand cmd = new SqlCommand("p_Returns_Get_Email_From", conn);

                conn.Open();
                cmd.CommandTimeout = 90;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Clear();

                cmd.Parameters.AddWithValue("@Status", xsStatus);

                cmd.Parameters.Add("@From", SqlDbType.VarChar, 250).Direction = ParameterDirection.Output;

                cmd.ExecuteNonQuery();
                psEmailFrom = cmd.Parameters["@From"].Value.ToString();
                conn.Close();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message.ToString());
            }
            return psEmailFrom;
        }



        public DataTable Get_Fields_To_Edit(int xlOrderNumber)
        {
            DataTable poEdit = new DataTable();
            try
            {
                String connectionString = ConfigurationManager.ConnectionStrings["ubsInterimTestDB"].ConnectionString;
                SqlConnection conn = new SqlConnection(connectionString);
                SqlCommand cmd = new SqlCommand("p_Returns_Get_Fields_To_Edit", conn);

                conn.Open();
                cmd.CommandTimeout = 90;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Clear();

                cmd.Parameters.AddWithValue("@OrderNumber", UserInfo.OrderNumber);
                cmd.Parameters.AddWithValue("@ID", UserInfo.ID);

                SqlDataAdapter sqlDataAdap = new SqlDataAdapter(cmd);
                sqlDataAdap.Fill(poEdit);
                conn.Close();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message.ToString());
            }
            return poEdit;
        }

        public DataTable Get_Email_Logs(int xlSupplierID)
        {
            DataTable poEmailLogs = new DataTable();
            try
            {
                String connectionString = ConfigurationManager.ConnectionStrings["ubsInterimTestDB"].ConnectionString;
                SqlConnection conn = new SqlConnection(connectionString);
                SqlCommand cmd = new SqlCommand("p_Returns_Credit_Get_Supplier_Email_Logs", conn);

                conn.Open();
                cmd.CommandTimeout = 90;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Clear();

                cmd.Parameters.AddWithValue("@SupplierID", xlSupplierID);

                SqlDataAdapter sqlDataAdap = new SqlDataAdapter(cmd);
                sqlDataAdap.Fill(poEmailLogs);
                conn.Close();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message.ToString());
            }
            return poEmailLogs;
        }


        public DataTable Get_Notes(int xlOrderNumber)
        {
            DataTable poNotes = new DataTable();
            try
            {
                String connectionString = ConfigurationManager.ConnectionStrings["ubsInterimTestDB"].ConnectionString;
                SqlConnection conn = new SqlConnection(connectionString);
                SqlCommand cmd = new SqlCommand("p_Returns_GetNotes", conn);

                conn.Open();
                cmd.CommandTimeout = 90;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Clear();

                cmd.Parameters.AddWithValue("@OrderNumber", xlOrderNumber);

                SqlDataAdapter sqlDataAdap = new SqlDataAdapter(cmd);
                sqlDataAdap.Fill(poNotes);
                conn.Close();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message.ToString());
            }
            return poNotes;
        }

        public void Update_EmailTemplate(string xsCode, string xsEmailTemplate, string xsSubject,
            string xsCategory, int xlNotice, byte xbCC)
        {
            try
            {
                String connectionString = ConfigurationManager.ConnectionStrings["ubsInterimTestDB"].ConnectionString;
                SqlConnection conn = new SqlConnection(connectionString);
                SqlCommand cmd = new SqlCommand("p_Returns_Update_Email_Template_Credit_Request", conn);

                conn.Open();
                cmd.CommandTimeout = 100;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Clear();

                cmd.Parameters.AddWithValue("@Code", xsCode);
                cmd.Parameters.AddWithValue("@EmailTemplate", xsEmailTemplate);
                cmd.Parameters.AddWithValue("@Subject", xsSubject);
                cmd.Parameters.AddWithValue("@Notice", xlNotice);
                cmd.Parameters.AddWithValue("@Category", xsCategory);
                cmd.Parameters.AddWithValue("@CC", xbCC);

                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message.ToString());
            }
        }

        public void Delete_Email_Template(string xsCode, string xsEmailTemplate, string xsSubject,
            string xsCategory, int xlNotice, byte xbCC)
        {
            try
            {
                String connectionString = ConfigurationManager.ConnectionStrings["ubsInterimTestDB"].ConnectionString;
                SqlConnection conn = new SqlConnection(connectionString);
                SqlCommand cmd = new SqlCommand("p_Returns_Delete_Email_Template", conn);

                conn.Open();
                cmd.CommandTimeout = 100;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Clear();

                cmd.Parameters.AddWithValue("@Code", xsCode);
                cmd.Parameters.AddWithValue("@NoticeNumber", xlNotice);
                cmd.Parameters.AddWithValue("@Category", xsCategory);
                cmd.Parameters.AddWithValue("@Template", xsEmailTemplate);
                cmd.Parameters.AddWithValue("@Subject", xsSubject);
                cmd.Parameters.AddWithValue("@CC", xbCC);

                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message.ToString());
            }
        }


        public List<string> GetSupplier(string xsSupplierName, string xsSearchParam, int xlSupplierID)
        {
            List<string> poSupplier = new List<string>();
            try
            {

                String connectionString = ConfigurationManager.ConnectionStrings["ubsInterimTestDB"].ConnectionString;
                SqlConnection conn = new SqlConnection(connectionString);
                SqlCommand cmd = new SqlCommand("p_Returns_Update_Credit_Request_GetSupplier", conn);

                conn.Open();
                cmd.CommandTimeout = 90;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Clear();

                cmd.Parameters.AddWithValue("@SupplierIDX", xlSupplierID);
                cmd.Parameters.AddWithValue("@SupplierName", xsSupplierName);
                cmd.Parameters.AddWithValue("@SearchParam", xsSearchParam);

                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        for (int x = 0; x <= reader.FieldCount - 1; x++)
                        {
                            poSupplier.Add(reader.GetValue(x).ToString());
                        }
                    }
                }
                reader.Close();
                conn.Close();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message.ToString());
            }
            return poSupplier;
        }


        public void Insert_Tracking(string xsTrackingNumber, string xsCarrier)
        {
            try
            {
                String connectionString = ConfigurationManager.ConnectionStrings["ubsInterimTestDB"].ConnectionString;
                SqlConnection conn = new SqlConnection(connectionString);
                SqlCommand cmd = new SqlCommand("p_Returns_Update_Credit_Request_Tracking_Numbers", conn);

                conn.Open();
                cmd.CommandTimeout = 100;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Clear();

                cmd.Parameters.AddWithValue("@OrderNumber", UserInfo.OrderNumber);
                cmd.Parameters.AddWithValue("@TrackingNumber", xsTrackingNumber);
                cmd.Parameters.AddWithValue("@Carrier", xsCarrier);
                cmd.Parameters.AddWithValue("@Operator", UserInfo.OpName);

                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message.ToString());
            }
        }

        public void Insert_Email_Log(int xlSupplierID, int xlOrderNumber, int xlNoticeNumber, 
            string xsFrom, string xsTo, string xsSubject, string xsBody)
        {
            try
            {
                String connectionString = ConfigurationManager.ConnectionStrings["ubsInterimTestDB"].ConnectionString;
                SqlConnection conn = new SqlConnection(connectionString);
                SqlCommand cmd = new SqlCommand("p_Returns_Insert_Credit_Request_Email_Log", conn);

                conn.Open();
                cmd.CommandTimeout = 100;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Clear();

                cmd.Parameters.AddWithValue("@SupplierID", xlSupplierID);
                cmd.Parameters.AddWithValue("@OrderNumber", xlOrderNumber);
                cmd.Parameters.AddWithValue("@NoticeNumber", xlNoticeNumber);
                cmd.Parameters.AddWithValue("@FromEmai", xsFrom);
                cmd.Parameters.AddWithValue("@ToEmail", xsTo);
                cmd.Parameters.AddWithValue("@Subject", xsSubject);
                cmd.Parameters.AddWithValue("@Body", xsBody);
                cmd.Parameters.AddWithValue("@Operator", UserInfo.OpName);


                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message.ToString());
            }
        }


        public void Insert_OnHold_OrGiveUp(int xlOrderNumber, int xlWhichOne, string xsReason)
        {
            try
            {
                String connectionString = ConfigurationManager.ConnectionStrings["ubsInterimTestDB"].ConnectionString;
                SqlConnection conn = new SqlConnection(connectionString);
                SqlCommand cmd = new SqlCommand("p_Returns_Update_Credit_OnHold_Or_GiveUp", conn);

                conn.Open();
                cmd.CommandTimeout = 100;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Clear();

                cmd.Parameters.AddWithValue("@OrderNumber", xlOrderNumber);
                cmd.Parameters.AddWithValue("@ID", UserInfo.ID);
                cmd.Parameters.AddWithValue("@WhichOne", xlWhichOne);
                cmd.Parameters.AddWithValue("@Reason", xsReason);
                cmd.Parameters.AddWithValue("@Operator", UserInfo.OpName);

                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message.ToString());
            }
        }

        public void Update_Edit_Lines(int xlOrderNumber, string xsRA, string xsMemo)
        {
            try
            {
                String connectionString = ConfigurationManager.ConnectionStrings["ubsInterimTestDB"].ConnectionString;
                SqlConnection conn = new SqlConnection(connectionString);
                SqlCommand cmd = new SqlCommand("p_Returns_Update_Fields_To_Edit", conn);

                conn.Open();
                cmd.CommandTimeout = 100;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Clear();

                cmd.Parameters.AddWithValue("@OrderNumber", xlOrderNumber);
                cmd.Parameters.AddWithValue("@ID", UserInfo.ID);
                cmd.Parameters.AddWithValue("@Operator", UserInfo.OpName);
                cmd.Parameters.AddWithValue("@RANumber", xsRA);
                cmd.Parameters.AddWithValue("@Memo", xsMemo);

                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message.ToString());
            }
        }


        public DataTable Get_Email_Template(string xsCode, string xsParam, int xlField)
        {
            DataTable poTemplate = new DataTable();
            try
            {
                String connectionString = ConfigurationManager.ConnectionStrings["ubsInterimTestDB"].ConnectionString;
                SqlConnection conn = new SqlConnection(connectionString);
                SqlCommand cmd = new SqlCommand("p_Returns_Get_Email_Credit_Request", conn);

                conn.Open();
                cmd.CommandTimeout = 90;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Clear();

                cmd.Parameters.AddWithValue("@Code", xsCode);
                cmd.Parameters.AddWithValue("@SearchParam", xsParam);
                cmd.Parameters.AddWithValue("@Field", xlField);

                SqlDataAdapter sqlDataAdap = new SqlDataAdapter(cmd);
                sqlDataAdap.Fill(poTemplate);
                conn.Close();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message.ToString());
            }
            return poTemplate;
        }

        public DataTable Get_Email_Template_Record()
        {
            DataTable poTemplate = new DataTable();
            try
            {
                String connectionString = ConfigurationManager.ConnectionStrings["ubsInterimTestDB"].ConnectionString;
                SqlConnection conn = new SqlConnection(connectionString);
                SqlCommand cmd = new SqlCommand("p_Returns_Get_Email_Credit_Request_Record", conn);

                conn.Open();
                cmd.CommandTimeout = 90;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Clear();

                cmd.Parameters.AddWithValue("@Code", UserInfo.Code);
                cmd.Parameters.AddWithValue("@Category", UserInfo.Category);
                cmd.Parameters.AddWithValue("@Notice", UserInfo.Notice);
                cmd.Parameters.AddWithValue("@Subject", UserInfo.Subject);
                cmd.Parameters.AddWithValue("@CC", UserInfo.CC);

                SqlDataAdapter sqlDataAdap = new SqlDataAdapter(cmd);
                sqlDataAdap.Fill(poTemplate);
                conn.Close();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message.ToString());
            }
            return poTemplate;
        }

        public string Get_Carrier(int xlOrderNumber, string xsTrackingNumber)
        {
            //03/15/2024 - JR\\\\
            string psCarrier = "";
            try
            {
                String connectionString = ConfigurationManager.ConnectionStrings["ubsInterimTestDB"].ConnectionString;
                SqlConnection conn = new SqlConnection(connectionString);
                SqlCommand cmd = new SqlCommand("p_Returns_Get_Credit_Request_Carrier", conn);

                conn.Open();
                cmd.CommandTimeout = 100;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Clear();

                cmd.Parameters.AddWithValue("@OrderNumber", xlOrderNumber);
                cmd.Parameters.AddWithValue("@TrackingNumber", xsTrackingNumber);

                cmd.Parameters.Add("@Carrier", SqlDbType.VarChar, 250).Direction = ParameterDirection.Output;

                cmd.ExecuteNonQuery();
                psCarrier = cmd.Parameters["@Carrier"].Value.ToString();
                conn.Close();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message.ToString());
            }
            return psCarrier;
        }


        public string Get_InvoiceNumber(int xlOrderNumber, string xsSKU, int xlSupplierID)
        {
            //03/15/2024 - JR\\\\
            string psInvoiceNumber = "";
            try
            {
                String connectionString = ConfigurationManager.ConnectionStrings["ubsInterimTestDB"].ConnectionString;
                SqlConnection conn = new SqlConnection(connectionString);
                SqlCommand cmd = new SqlCommand("p_Returns_Get_Credit_Request_Invoice_Number", conn);

                conn.Open();
                cmd.CommandTimeout = 100;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Clear();

                cmd.Parameters.AddWithValue("@OrderNumber", xlOrderNumber);
                cmd.Parameters.AddWithValue("@SupplierID", xlSupplierID);
                cmd.Parameters.AddWithValue("@Sku", xsSKU);

                cmd.Parameters.Add("@InvoiceNumber", SqlDbType.VarChar, 250).Direction = ParameterDirection.Output;

                cmd.ExecuteNonQuery();
                psInvoiceNumber = cmd.Parameters["@InvoiceNumber"].Value.ToString();
                conn.Close();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message.ToString());
            }
            return psInvoiceNumber;
        }

        public DataTable Get_Email_Template(int xlNoticeNumber, int xlTracking, string xsCategory
            ,string xsReturnStatus, string xsTerms)
        {

            DataTable poTemplate = new DataTable();
            try
            {
                String connectionString = ConfigurationManager.ConnectionStrings["ubsInterimTestDB"].ConnectionString;
                SqlConnection conn = new SqlConnection(connectionString);
                SqlCommand cmd = new SqlCommand("p_Returns_Get_Email_Credit_Request_To_Send", conn);

                conn.Open();
                cmd.CommandTimeout = 90;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Clear();

                cmd.Parameters.AddWithValue("@NoticeNumber", xlNoticeNumber);
                cmd.Parameters.AddWithValue("@Tracking", xlTracking);
                cmd.Parameters.AddWithValue("@Category", xsCategory);
                cmd.Parameters.AddWithValue("@ReturnStatus", xsReturnStatus);
                cmd.Parameters.AddWithValue("@Terms", xsTerms);

                SqlDataAdapter sqlDataAdap = new SqlDataAdapter(cmd);
                sqlDataAdap.Fill(poTemplate);
                conn.Close();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message.ToString());
            }
            return poTemplate;
        }

        public DataTable Get_Supplier_Info(int xlSupplierID)
        {

            DataTable poSupplierInfo = new DataTable();
            try
            {
                String connectionString = ConfigurationManager.ConnectionStrings["ubsInterimTestDB"].ConnectionString;
                SqlConnection conn = new SqlConnection(connectionString);
                SqlCommand cmd = new SqlCommand("p_Returns_Get_Supplier_Info", conn);

                conn.Open();
                cmd.CommandTimeout = 90;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Clear();

                cmd.Parameters.AddWithValue("@SupplierID", xlSupplierID);

                SqlDataAdapter sqlDataAdap = new SqlDataAdapter(cmd);
                sqlDataAdap.Fill(poSupplierInfo);
                conn.Close();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message.ToString());
            }
            return poSupplierInfo;
        }

        public DataTable Get_Order_Ship_Info(int xlOrderNumber)
        {

            DataTable poOrderShipInfo = new DataTable();
            try
            {
                String connectionString = ConfigurationManager.ConnectionStrings["ubsInterimTestDB"].ConnectionString;
                SqlConnection conn = new SqlConnection(connectionString);
                SqlCommand cmd = new SqlCommand("p_Returns_Get_Order_Ship_Info", conn);

                conn.Open();
                cmd.CommandTimeout = 90;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Clear();

                cmd.Parameters.AddWithValue("@OrderNumber", xlOrderNumber);

                SqlDataAdapter sqlDataAdap = new SqlDataAdapter(cmd);
                sqlDataAdap.Fill(poOrderShipInfo);
                conn.Close();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message.ToString());
            }
            return poOrderShipInfo;
        }

        public DataTable Get_Order_Charge(int xlOrderNumber)
        {

            DataTable poCharge = new DataTable();
            try
            {
                String connectionString = ConfigurationManager.ConnectionStrings["ubsInterimTestDB"].ConnectionString;
                SqlConnection conn = new SqlConnection(connectionString);
                SqlCommand cmd = new SqlCommand("p_Returns_Get_Charge", conn);

                conn.Open();
                cmd.CommandTimeout = 90;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Clear();

                cmd.Parameters.AddWithValue("@OrderNumber", xlOrderNumber);

                SqlDataAdapter sqlDataAdap = new SqlDataAdapter(cmd);
                sqlDataAdap.Fill(poCharge);
                conn.Close();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message.ToString());
            }
            return poCharge;
        }



        public DataTable Get_Tracking_Numbers(int xlOrderNumber)
        {
            DataTable poTrackingNumbers = new DataTable();
            try
            {
                String connectionString = ConfigurationManager.ConnectionStrings["ubsInterimTestDB"].ConnectionString;
                SqlConnection conn = new SqlConnection(connectionString);
                SqlCommand cmd = new SqlCommand("p_Returns_Get_Credit_Request_Tracking_Numbers", conn);

                conn.Open();
                cmd.CommandTimeout = 90;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Clear();

                cmd.Parameters.AddWithValue("@OrderNumber", xlOrderNumber);

                SqlDataAdapter sqlDataAdap = new SqlDataAdapter(cmd);
                sqlDataAdap.Fill(poTrackingNumbers);
                conn.Close();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message.ToString());
            }
            return poTrackingNumbers;
        }

        public DataTable Get_Audit_Tracking_Number(int xlOrderNumber)
        {
            DataTable poAuditTrackingNumber = new DataTable();
            try
            {
                String connectionString = ConfigurationManager.ConnectionStrings["ubsInterimTestDB"].ConnectionString;
                SqlConnection conn = new SqlConnection(connectionString);
                SqlCommand cmd = new SqlCommand("p_Returns_Get_Tracking_From_Audit", conn);

                conn.Open();
                cmd.CommandTimeout = 90;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Clear();

                cmd.Parameters.AddWithValue("@OrderNumber", xlOrderNumber);

                SqlDataAdapter sqlDataAdap = new SqlDataAdapter(cmd);
                sqlDataAdap.Fill(poAuditTrackingNumber);
                conn.Close();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message.ToString());
            }
            return poAuditTrackingNumber;
        }


        public List<string> Get_Level(string xsPassword)
        {
            List<string> poLevel = new List<string>();
            try
            {
                String connectionString = ConfigurationManager.ConnectionStrings["ubsInterimTestDB"].ConnectionString;
                SqlConnection conn = new SqlConnection(connectionString);
                SqlCommand cmd = new SqlCommand("P_Returns_GetLevel", conn);

                conn.Open();
                cmd.CommandTimeout = 100;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Clear();

                cmd.Parameters.AddWithValue("@Password", xsPassword);

                cmd.Parameters.Add("@Level", SqlDbType.VarChar, 200).Direction = ParameterDirection.Output;
                cmd.Parameters.Add("@Name", SqlDbType.VarChar, 200).Direction = ParameterDirection.Output;


                cmd.ExecuteNonQuery();
                poLevel.Add(cmd.Parameters["@Level"].Value.ToString());
                poLevel.Add(cmd.Parameters["@Name"].Value.ToString());
                conn.Close();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message.ToString());
            }
            return poLevel;
        }


        public bool Get_FoundOperator(string xsPassword)
        {
            bool pbFound = false;
            try
            {
                String connectionString = ConfigurationManager.ConnectionStrings["ubsInterimTestDB"].ConnectionString;
                SqlConnection conn = new SqlConnection(connectionString);
                SqlCommand cmd = new SqlCommand("p_Returns_GetOperator", conn);

                conn.Open();
                cmd.CommandTimeout = 100;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Clear();

                cmd.Parameters.AddWithValue("@Password", xsPassword);

                cmd.Parameters.Add("@Operator_Exists", SqlDbType.VarChar, 200).Direction = ParameterDirection.Output;

                cmd.ExecuteNonQuery();
                pbFound = (cmd.Parameters["@Operator_Exists"].Value.ToString().Length > 0);
                conn.Close();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message.ToString());
            }
            return pbFound;
        }


        public DataTable Get_NotesSE(int xlOrderNumber)
        {
            DataTable poNotesSE = new DataTable();
            try
            {
                String connectionString = ConfigurationManager.ConnectionStrings["ubsInterimTestDB"].ConnectionString;
                SqlConnection conn = new SqlConnection(connectionString);
                SqlCommand cmd = new SqlCommand("p_Returns_GetNotesSE", conn);

                conn.Open();
                cmd.CommandTimeout = 90;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Clear();

                cmd.Parameters.AddWithValue("@OrderNumber", xlOrderNumber);

                SqlDataAdapter sqlDataAdap = new SqlDataAdapter(cmd);
                sqlDataAdap.Fill(poNotesSE);
                conn.Close();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message.ToString());
            }
            return poNotesSE;
        }


    }
}
