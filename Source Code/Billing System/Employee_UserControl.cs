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
    public partial class Employee_UserControl : UserControl
    {
        private static Employee_UserControl _instance;

        public static Employee_UserControl Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Employee_UserControl();
                }
                return _instance;
            }
        }
        public Employee_UserControl()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"|DataDirectory|\\Database.mdf\";Integrated Security=True");

        private void Employee_UserControl_Load(object sender, EventArgs e)
        {
            refresh_DataGridView();
        }

        private void AddEmployee_Button_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("AddEmployee_SP", con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@Emp_ID", EmployeeID_Textbox.Text);
            cmd.Parameters.AddWithValue("@Emp_Name", EmployeeName_Textbox.Text);
            cmd.Parameters.AddWithValue("@Salary", Salary_Textbox.Text);
            cmd.Parameters.AddWithValue("@Emp_Phno", EmpPhoneNo_Textbox.Text);

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
                SqlCommand cmd = new SqlCommand("ShowEmployeeData_SP", con);
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

                Employee_DataGrid.DataSource = DS.Tables[0];
                this.Employee_DataGrid.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                this.Employee_DataGrid.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                this.Employee_DataGrid.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                this.Employee_DataGrid.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
        }

        private void ClearEmployee_Button_Click(object sender, EventArgs e)
        {
            SearchEmployee_Textbox.Text = "";
            EmployeeID_Textbox.Text = "";
            EmployeeName_Textbox.Text = "";
            Salary_Textbox.Text = "";
            EmpPhoneNo_Textbox.Text = "";

            refresh_DataGridView();
        }

        private void SearchEmployee_Button_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("SearchEmployee_SP", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Emp_ID", SearchEmployee_Textbox.Text);

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

                Employee_DataGrid.DataSource = DS.Tables[0];
                this.Employee_DataGrid.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                this.Employee_DataGrid.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                this.Employee_DataGrid.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                this.Employee_DataGrid.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
        }

        private void DeleteEmployee_Button_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("DeleteEmployee_SP", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Emp_ID", EmployeeID_Textbox.Text);

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
    }
}
