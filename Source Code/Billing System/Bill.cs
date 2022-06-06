using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace Billing_System
{
    public partial class Bill : Form
    {
        public Bill()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"|DataDirectory|\\Database.mdf\";Integrated Security=True");

        private void Bill_Load(object sender, EventArgs e)
        {

        }

        private void SaveBill_Button_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            foreach (DataGridViewTextBoxColumn column in Bill_dataGridView.Columns)
            {
                dt.Columns.Add(column.Name, column.ValueType);
            }
            foreach (DataGridViewRow row in Bill_dataGridView.Rows)
            {
                DataRow dr = dt.NewRow();
                foreach (DataGridViewTextBoxColumn column in Bill_dataGridView.Columns)
                {
                    if (row.Cells[column.Name].Value != null)
                    {
                        dr[column.Name] = row.Cells[column.Name].Value.ToString();
                    }
                }
                dt.Rows.Add(dr);
            }
            string filePath = "C:\\Users\\Shoaib-PC\\OneDrive\\Desktop\\Projects";
            DataTableToTextFile(dt, filePath);
        }

        private void GenerateBill_Button_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("GenerateBill_SP", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Cust_ID", CustomerID_Textbox.Text);
                cmd.Parameters.AddWithValue("@Purchase_Date", PurchaseDate_Textbox.Text);

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

                Bill_dataGridView.DataSource = DS.Tables[0];
                this.Bill_dataGridView.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                this.Bill_dataGridView.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                this.Bill_dataGridView.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                this.Bill_dataGridView.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                this.Bill_dataGridView.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
        }
        private void DataTableToTextFile(DataTable dt, string outputFilePath)
        {
            int[] maxLengths = new int[dt.Columns.Count];

            for (int i = 0; i < dt.Columns.Count; i++)
            {
                maxLengths[i] = dt.Columns[i].ColumnName.Length;
                foreach (DataRow row in dt.Rows)
                {
                    if (!row.IsNull(i))
                    {
                        int length = row[i].ToString().Length;
                        if (length > maxLengths[i])
                        {
                            maxLengths[i] = length;
                        }
                    }
                }
            }

            using (StreamWriter sw = new StreamWriter(outputFilePath, false))
            {
                for (int i = 0; i < dt.Columns.Count; i++)
                {
                    sw.Write(dt.Columns[i].ColumnName.PadRight(maxLengths[i] + 2));
                }

                sw.WriteLine();

                foreach (DataRow row in dt.Rows)
                {
                    for (int i = 0; i < dt.Columns.Count; i++)
                    {
                        if (!row.IsNull(i))
                        {
                            sw.Write(row[i].ToString().PadRight(maxLengths[i] + 2));
                        }
                        else
                        {
                            sw.Write(new string(' ', maxLengths[i] + 2));
                        }
                    }
                    sw.WriteLine();
                }
                sw.Close();
            }
        }
    }
}
