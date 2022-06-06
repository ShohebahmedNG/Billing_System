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

namespace Billing_System
{
    public partial class RemoveUser : Form
    {
        public RemoveUser()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"|DataDirectory|\\Database.mdf\";Integrated Security=True");

        private void SearchProduct_Button_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("RemoveUser_SP", con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@Property", ProductID_Textbox.Text);

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
        }

        private void RemoveUser_Load(object sender, EventArgs e)
        {

        }
    }
}
