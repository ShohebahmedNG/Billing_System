using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Billing_System
{
    public partial class Settings_UserControl : UserControl
    {
        private static Settings_UserControl _instance;

        public static Settings_UserControl Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Settings_UserControl();
                }
                return _instance;
            }
        }
        public Settings_UserControl()
        {
            InitializeComponent();
        }

        

        private void Settings_UserControl_Load(object sender, EventArgs e)
        {

        }

        private void AddUser_Button_Click(object sender, EventArgs e)
        {
            AddUser obj = new AddUser();
            obj.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RemoveUser obj = new RemoveUser();
            obj.Show();
        }
    }
}
