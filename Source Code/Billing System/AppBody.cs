using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Billing_System
{
    public partial class AppBody : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd,
            int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        public AppBody()
        {
            InitializeComponent();
            expandSlidigPanelGUI();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 obj = new Form1();
            this.Hide();
            obj.Show();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        public void expandSlidigPanelGUI()
        {
            OrdersTab_Button.Text = "ORDERS";
            CustomerTab_Button.Text = "CUSTOMER";
            ProductTab_Button.Text = "PRODUCT";
            TransactionsTab_Button.Text = "TRANSACTIONS";
            EmployeeTab_Button.Text = "EMPLOYEE";
            AboutTab_Button.Text = "ABOUT";
            button4.ImageAlign = ContentAlignment.MiddleCenter;
            button4.Image = Properties.Resources.Left_arrows;
            OrdersTab_Button.Image = null;
            CustomerTab_Button.Image = null;
            ProductTab_Button.Image = null;
            TransactionsTab_Button.Image = null;
            EmployeeTab_Button.Image = null;
            AboutTab_Button.Image = null;
        }

        public void retractSlidigPanelGUI()
        {
            OrdersTab_Button.Text = "";
            CustomerTab_Button.Text = "";
            ProductTab_Button.Text = "";
            TransactionsTab_Button.Text = "";
            EmployeeTab_Button.Text = "";
            AboutTab_Button.Text = "";
            button4.ImageAlign = ContentAlignment.MiddleLeft;
            button4.Image = Properties.Resources.Right_arrows;
            OrdersTab_Button.Image = Properties.Resources.Orders;
            CustomerTab_Button.Image = Properties.Resources.Customer3;
            ProductTab_Button.Image = Properties.Resources.Product;
            TransactionsTab_Button.Image = Properties.Resources.Transaction2;
            EmployeeTab_Button.Image = Properties.Resources.employee1;
            AboutTab_Button.Image = Properties.Resources.info1;
        }
        bool isSlidingPanelExpanded = true;
        const int MaxSliderWidth = 240;
        const int MinSliderWidth = 90;
        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (isSlidingPanelExpanded)
            {
                panel2.Width -= 20;
                if(panel2.Width <= MinSliderWidth)
                {
                    isSlidingPanelExpanded = false;
                    timer1.Stop();
                    retractSlidigPanelGUI();
                    this.Refresh();
                }
            }
            else
            {
                panel2.Width += 20;
                if (panel2.Width >= MaxSliderWidth)
                {
                    isSlidingPanelExpanded = true;
                    timer1.Stop();
                    expandSlidigPanelGUI();
                    this.Refresh();
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (isSlidingPanelExpanded)
            {
                retractSlidigPanelGUI();
            }
            timer1.Start();
        }

        private void OrdersTab_Button_Click(object sender, EventArgs e)
        {
            if(! ContentPanel.Controls.Contains(Orders_UserControl.Instance))
            {
                ContentPanel.Controls.Add(Orders_UserControl.Instance);
                Orders_UserControl.Instance.Dock = DockStyle.Fill;
                Orders_UserControl.Instance.BringToFront();
            }
            else
            {
                Orders_UserControl.Instance.BringToFront();
            }
        }

        private void CustomerTab_Button_Click(object sender, EventArgs e)
        {
            if (!ContentPanel.Controls.Contains(Customer_UserControl.Instance))
            {
                ContentPanel.Controls.Add(Customer_UserControl.Instance);
                Customer_UserControl.Instance.Dock = DockStyle.Fill;
                Customer_UserControl.Instance.BringToFront();
            }
            else
            {
                Customer_UserControl.Instance.BringToFront();
            }
        }

        private void ProductTab_Button_Click(object sender, EventArgs e)
        {
            if (!ContentPanel.Controls.Contains(Product_UserControl.Instance))
            {
                ContentPanel.Controls.Add(Product_UserControl.Instance);
                Product_UserControl.Instance.Dock = DockStyle.Fill;
                Product_UserControl.Instance.BringToFront();
            }
            else
            {
                Product_UserControl.Instance.BringToFront();
            }
        }

        private void TransactionsTab_Button_Click(object sender, EventArgs e)
        {
            if (!ContentPanel.Controls.Contains(Transactions_UserControl.Instance))
            {
                ContentPanel.Controls.Add(Transactions_UserControl.Instance);
                Transactions_UserControl.Instance.Dock = DockStyle.Fill;
                Transactions_UserControl.Instance.BringToFront();
            }
            else
            {
                Transactions_UserControl.Instance.BringToFront();
            }
        }

        private void AboutTab_Button_Click(object sender, EventArgs e)
        {
            if (!ContentPanel.Controls.Contains(About_UserControl.Instance))
            {
                ContentPanel.Controls.Add(About_UserControl.Instance);
                About_UserControl.Instance.Dock = DockStyle.Fill;
                About_UserControl.Instance.BringToFront();
            }
            else
            {
                About_UserControl.Instance.BringToFront();
            }
        }

        private void ContentPanel_Paint(object sender, PaintEventArgs e)
        {
            if (!ContentPanel.Controls.Contains(Home_Page.Instance))
            {
                ContentPanel.Controls.Add(Home_Page.Instance);
                Home_Page.Instance.Dock = DockStyle.Fill;
                Home_Page.Instance.BringToFront();
            }
            else
            {
                Home_Page.Instance.BringToFront();
            }
        }

        private void EmployeeTab_Button_Click(object sender, EventArgs e)
        {
            if (!ContentPanel.Controls.Contains(Employee_UserControl.Instance))
            {
                ContentPanel.Controls.Add(Employee_UserControl.Instance);
                Employee_UserControl.Instance.Dock = DockStyle.Fill;
                Employee_UserControl.Instance.BringToFront();
            }
            else
            {
                Employee_UserControl.Instance.BringToFront();
            }
        }

        private void Home_Button_Click(object sender, EventArgs e)
        {
            if (!ContentPanel.Controls.Contains(Home_Page.Instance))
            {
                ContentPanel.Controls.Add(Home_Page.Instance);
                Home_Page.Instance.Dock = DockStyle.Fill;
                Home_Page.Instance.BringToFront();
            }
            else
            {
                Home_Page.Instance.BringToFront();
            }
        }

        private void Settings_Button_Click(object sender, EventArgs e)
        {
            if (!ContentPanel.Controls.Contains(Settings_UserControl.Instance))
            {
                ContentPanel.Controls.Add(Settings_UserControl.Instance);
                Settings_UserControl.Instance.Dock = DockStyle.Fill;
                Settings_UserControl.Instance.BringToFront();
            }
            else
            {
                Settings_UserControl.Instance.BringToFront();
            }
        }
    }
}
