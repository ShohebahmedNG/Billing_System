using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Billing_System
{
    public partial class Customer_UserControl : UserControl
    {
        private static Customer_UserControl _instance;

        public static Customer_UserControl Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Customer_UserControl();
                }
                return _instance;
            }
        }
        public Customer_UserControl()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"|DataDirectory|\\Database.mdf\";Integrated Security=True");

        private void Customer_UserControl_Load(object sender, EventArgs e)
        {
            refresh_DataGridView();
        }
        public void refresh_DataGridView()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("ShowCustomerData_SP", con);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter DA = new SqlDataAdapter(cmd);
                DataSet DS = new DataSet();
                DA.Fill(DS);

                con.Open();
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("           <<<INVALID SQL OPERATION>>>:  \n" + ex);
                }
                con.Close();

                Customer_DataGrid.DataSource = DS.Tables[0];
                this.Customer_DataGrid.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                this.Customer_DataGrid.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                this.Customer_DataGrid.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                this.Customer_DataGrid.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                this.Customer_DataGrid.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
        }

        private void AddCustomer_Button_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("AddCustomerData_SP", con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@Cust_ID", CustomerID_Textbox.Text);
            cmd.Parameters.AddWithValue("@Customer_Name", CustomerName_Textbox.Text);
            cmd.Parameters.AddWithValue("@Phone_No", PhoneNo_Textbox.Text);
            cmd.Parameters.AddWithValue("@Address", Address_Textbox.Text);
            cmd.Parameters.AddWithValue("@Payment_ID", PaymentID_Textbox.Text);


            con.Open();
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("           <<<INVALID SQL OPERATION>>>:  \n" + ex);
            }
            con.Close();

            refresh_DataGridView();
        }

        private void DeleteCustomer_Button_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("DeleteCustomer_SP", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Cust_ID", CustomerID_Textbox.Text);

                con.Open();
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("           <<<INVALID SQL OPERATION>>>:  \n" + ex);
                }
                con.Close();

                refresh_DataGridView();

            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
        }

        private void SearchCustomer_Button_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("SearchCustomer_SP", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Cust_ID", SearchCustomer_Textbox.Text);

                SqlDataAdapter DA = new SqlDataAdapter(cmd);
                DataSet DS = new DataSet();
                DA.Fill(DS);

                con.Open();
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("           <<<INVALID SQL OPERATION>>>:  \n" + ex);
                }
                con.Close();

                Customer_DataGrid.DataSource = DS.Tables[0];
                this.Customer_DataGrid.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                this.Customer_DataGrid.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                this.Customer_DataGrid.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                this.Customer_DataGrid.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                this.Customer_DataGrid.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
        }

        private void ClearCustomer_Button_Click(object sender, EventArgs e)
        {
            CustomerID_Textbox.Text = "";
            CustomerName_Textbox.Text = "";
            PhoneNo_Textbox.Text = "";
            Address_Textbox.Text = "";
            PaymentID_Textbox.Text = "";
            SearchCustomer_Textbox.Text = "";

            refresh_DataGridView();
        }

        private void GenerateBill_Button_Click(object sender, EventArgs e)
        {
            Bill obj = new Bill();
            obj.Show();
        }
    }
}
