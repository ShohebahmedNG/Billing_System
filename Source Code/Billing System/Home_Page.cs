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
    public partial class Home_Page : UserControl
    {
        private static Home_Page _instance;

        public static Home_Page Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Home_Page();
                }
                return _instance;
            }
        }
        public Home_Page()
        {
            InitializeComponent();
        }

        private void Home_Page_Load(object sender, EventArgs e)
        {

        }
    }
}
