using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace ReturnsCreditRequest
{
    public partial class ManualSuppliers : Form
    {
        public ManualSuppliers()
        {
            this.KeyPreview = true;
            InitializeComponent();
            lblOperator.Text = "Manual Suppliers";
            DataAccess da = new DataAccess();
            DataTable poSupplierName = da.Get_Manual_Supplier("0", "GE","M");
            Forms_Field_Load(poSupplierName);
        }

        private void Forms_Field_Load(DataTable xoSupplierName)
        {
            try
            {
                DataRow poRow = xoSupplierName.Rows[0];
                txtSupplierID.Text = poRow["SupplierID"].ToString();
                txtName.Text = poRow["SupplierName"].ToString();
                txtAddr1.Text = poRow["Address1"].ToString();
                txtAddr2.Text = poRow["Address2"].ToString();
                txtCity.Text = poRow["City"].ToString();
                txtState.Text = poRow["State"].ToString();
                txtZip.Text = poRow["Zip"].ToString();
                txtCountry.Text = poRow["Country"].ToString();
                txtCompanyPhone.Text = poRow["Phone"].ToString();
                txtEmail.Text = poRow["Email"].ToString();
                txtMainContact.Text = poRow["MainContact"].ToString();
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
                if (txtName.Text.Length == 0)
                {
                    txtName.Text = "0";
                }
                string psSupplierType = "M";
                if (optSuppliers.Checked)
                {
                    psSupplierType = "R";
                }
                DataAccess da = new DataAccess();
                DataTable poSupplierName = da.Get_Manual_Supplier(txtName.Text, "GT", psSupplierType);
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
                if (txtName.Text.Length == 0)
                {
                    txtName.Text = "zzzzzzzzzzzzzzzzzzzzz";
                }

                string psSupplierType = "M";
                if (optSuppliers.Checked)
                {
                    psSupplierType = "R";
                }
                DataAccess da = new DataAccess();
                DataTable poSupplierName = da.Get_Manual_Supplier(txtName.Text, "LT", psSupplierType);
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
                string psSupplierType = "M";
                if (optSuppliers.Checked)
                {
                    psSupplierType = "R";
                }

                DataAccess da = new DataAccess();
                if (e.KeyCode.ToString() == "F6" || e.KeyValue == 13)
                {
                    DataTable poSupplierName = da.Get_Manual_Supplier(txtName.Text, "GE", psSupplierType);
                    Forms_Field_Load(poSupplierName);
                }

                if (e.KeyCode.ToString() == "F7")
                {
                    if (txtName.Text.Length == 0)
                    {
                        txtName.Text = "0";
                    }
                    DataTable poSupplierName = da.Get_Manual_Supplier(txtName.Text, "GT", psSupplierType);
                    Forms_Field_Load(poSupplierName);
                }

                if (e.KeyCode.ToString() == "F8")
                {
                    if (txtName.Text.Length == 0)
                    {
                        txtName.Text = "zzzzzzzzzzzzzzzzzzzzz";
                    }
                    DataTable poSupplierName = da.Get_Manual_Supplier(txtName.Text, "LT", psSupplierType);
                    Forms_Field_Load(poSupplierName);
                }
            }
            catch (Exception exec)
            {
                MessageBox.Show(exec.Message.ToString());
            }

        }

        private void optMaanual_CheckedChanged(object sender, EventArgs e)
        {
            lblOperator.Text = "Manual Suppliers";
            btnRemove.Text = "Remove as manual";
            DataAccess da = new DataAccess();
            DataTable poSupplierName = da.Get_Manual_Supplier("0", "GE", "M");
            Forms_Field_Load(poSupplierName);
        }

        private void optSuppliers_CheckedChanged(object sender, EventArgs e)
        {
            lblOperator.Text = "Regular Suppliers";
            btnRemove.Text = "Assign as manual";
            DataAccess da = new DataAccess();
            DataTable poSupplierName = da.Get_Manual_Supplier("0", "GE", "R");
            Forms_Field_Load(poSupplierName);
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            DialogResult poResult = MessageBox.Show("Are you sure you want to proceed?", "", MessageBoxButtons.YesNo);
            if (poResult == DialogResult.No)
            {
                return;
            }

            int plSupplierID = Convert.ToInt32(txtSupplierID.Text);
            DataAccess da = new DataAccess();
            if (optMaanual.Checked)
            {
                da.Update_Manual_Supplier(plSupplierID, "M");
                DataTable poSupplierName = da.Get_Manual_Supplier("0", "GE", "M");
                Forms_Field_Load(poSupplierName);
            }

            if (optSuppliers.Checked)
            {
                da.Update_Manual_Supplier(plSupplierID, "R");
                optMaanual.Checked = true;
            }

        }

        private void btnSupplierList_Click(object sender, EventArgs e)
        {
            if (optMaanual.Checked)
            {
                UserInfo.SupplierType = "M";
            }
            else
            {
                UserInfo.SupplierType = "R";
            }
            DataAccess da = new DataAccess();
            UserInfo.SupplierName = "";
            SuppliersList sl = new SuppliersList();
            sl.ShowDialog();
            if (UserInfo.SupplierName.Trim().Length >0  && optMaanual.Checked)
            {
                DataTable poSupplierName = da.Get_Manual_Supplier(UserInfo.SupplierName, "GE", "M");
                Forms_Field_Load(poSupplierName);
            }
            if (UserInfo.SupplierName.Trim().Length > 0 && optSuppliers.Checked)
            {
                DataTable poSupplierName = da.Get_Manual_Supplier(UserInfo.SupplierName, "GE", "R");
                Forms_Field_Load(poSupplierName);
            }

        }

    }
}
