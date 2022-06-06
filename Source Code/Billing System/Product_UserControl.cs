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
    public partial class Product_UserControl : UserControl
    {
        private static Product_UserControl _instance;

        public static Product_UserControl Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Product_UserControl();
                }
                return _instance;
            }
        }
        public Product_UserControl()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"|DataDirectory|\\Database.mdf\";Integrated Security=True");

        private void AddProduct_Button_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("AddProduct_SP", con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@Product_ID", ProductID_Textbox.Text);
            cmd.Parameters.AddWithValue("@Product_Name", ProductName_Textbox.Text);
            cmd.Parameters.AddWithValue("@Price", Price_Textbox.Text); 
            cmd.Parameters.AddWithValue("@Expiry_Date", ExpiryDate_Textbox.Text);

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

        public void refresh_DataGridView()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("ShowProduct_SP", con);
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

                Product_DataGrid.DataSource = DS.Tables[0];
                this.Product_DataGrid.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                this.Product_DataGrid.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                this.Product_DataGrid.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                this.Product_DataGrid.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
        }

        private void Product_UserControl_Load(object sender, EventArgs e)
        {
            refresh_DataGridView();
        }

        private void ClearProduct_Button_Click(object sender, EventArgs e)
        {
            SearchProduct_Textbox.Text = "";
            ProductID_Textbox.Text = "";
            ProductName_Textbox.Text = "";
            Price_Textbox.Text = "";
            ExpiryDate_Textbox.Text = "";

            refresh_DataGridView();
        }

        private void DeleteProduct_Button_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("DeleteProduct_SP", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Product_ID", ProductID_Textbox.Text);

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

        private void SearchProduct_Button_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("SearchProduct_SP", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Product_ID", SearchProduct_Textbox.Text);

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

                Product_DataGrid.DataSource = DS.Tables[0];
                this.Product_DataGrid.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                this.Product_DataGrid.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                this.Product_DataGrid.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                this.Product_DataGrid.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
        }
    }
}
