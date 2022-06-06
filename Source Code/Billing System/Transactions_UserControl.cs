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
    public partial class Transactions_UserControl : UserControl
    {
        private static Transactions_UserControl _instance;

        public static Transactions_UserControl Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Transactions_UserControl();
                }
                return _instance;
            }
        }
        public Transactions_UserControl()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"|DataDirectory|\\Database.mdf\";Integrated Security=True");

        private void Transactions_UserControl_Load(object sender, EventArgs e)
        {
            refresh_DataGridView();
        }

        public void refresh_DataGridView()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("ShowPaymentData_SP", con);
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

                Payment_DataGrid.DataSource = DS.Tables[0];
                this.Payment_DataGrid.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                this.Payment_DataGrid.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                this.Payment_DataGrid.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                this.Payment_DataGrid.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
        }
        private void AddPayments_Button_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("AddPayment_SP", con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@Payment_ID", PaymentID_Textbox.Text);
            cmd.Parameters.AddWithValue("@Total_Amount", TotalAmount_Textbox.Text);
            cmd.Parameters.AddWithValue("@Payment_Mode", PaymentMode_Textbox.Text);
            cmd.Parameters.AddWithValue("@Payment_Status", PaymentStatus_Textbox.Text);


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

        private void DeletePayments_Button_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("DeletePayment_SP", con);
                cmd.CommandType = CommandType.StoredProcedure;

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
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
        }

        private void SearchPayments_Button_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("SearchPayments_SP", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Payment_ID", SearchPayments_Textbox.Text);

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

                Payment_DataGrid.DataSource = DS.Tables[0];
                this.Payment_DataGrid.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                this.Payment_DataGrid.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                this.Payment_DataGrid.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                this.Payment_DataGrid.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
        }

        private void ClearPayments_Button_Click(object sender, EventArgs e)
        {
            SearchPayments_Textbox.Text = "";
            PaymentID_Textbox.Text = "";
            TotalAmount_Textbox.Text = "";
            PaymentMode_Textbox.Text = "";
            PaymentStatus_Textbox.Text = "";

            refresh_DataGridView();
        }
    }
}
