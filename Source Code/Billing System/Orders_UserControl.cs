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
    public partial class Orders_UserControl : UserControl
    {
        private static Orders_UserControl _instance;

        public static Orders_UserControl Instance
        {
            get
            {
                if(_instance == null)
                {
                    _instance = new Orders_UserControl();
                }
                return _instance;
            }
        }
        public Orders_UserControl()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"|DataDirectory|\\Database.mdf\";Integrated Security=True");

        private void Orders_UserControl_Load(object sender, EventArgs e)
        {
            refresh_DataGridView();
        }

        public void refresh_DataGridView()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("ShowOrdersData_SP", con);
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

                Orders_DataGrid.DataSource = DS.Tables[0];
                this.Orders_DataGrid.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                this.Orders_DataGrid.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                this.Orders_DataGrid.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                this.Orders_DataGrid.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                this.Orders_DataGrid.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                this.Orders_DataGrid.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                this.Orders_DataGrid.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                this.Orders_DataGrid.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
        }
        private void AddOrders_Button_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("AddOrders_SP", con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@Order_ID", OrderID_Textbox.Text);
            cmd.Parameters.AddWithValue("@Emp_ID", EmployeeID_Textbox.Text);
            cmd.Parameters.AddWithValue("@Cust_ID", CustomerID_Textbox.Text);
            cmd.Parameters.AddWithValue("@Product_ID", ProductID_Textbox.Text);
            cmd.Parameters.AddWithValue("@Quantity", Quantity_Textbox.Text);
            cmd.Parameters.AddWithValue("@Purchase_Date", PurchaseDate_Textbox.Text);


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

        private void DeleteOrders_Button_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("DeleteOrders_SP", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Order_ID", OrderID_Textbox.Text);

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

        private void SearchOrders_Button_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("SearchOrders_SP", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Order_ID", SearchOrders_Textbox.Text);

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

                Orders_DataGrid.DataSource = DS.Tables[0];
                this.Orders_DataGrid.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                this.Orders_DataGrid.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                this.Orders_DataGrid.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                this.Orders_DataGrid.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                this.Orders_DataGrid.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                this.Orders_DataGrid.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                this.Orders_DataGrid.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                this.Orders_DataGrid.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
        }

        private void ClearOrders_Button_Click(object sender, EventArgs e)
        {
            SearchOrders_Textbox.Text = "";
            OrderID_Textbox.Text = "";
            CustomerID_Textbox.Text = "";
            ProductID_Textbox.Text = "";
            Quantity_Textbox.Text = "";
            PurchaseDate_Textbox.Text = "";

            refresh_DataGridView();
        }
    }
}
