namespace Billing_System
{
    partial class AppBody
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AppBody));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.ContentPanel = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.EmployeeTab_Button = new System.Windows.Forms.Button();
            this.AboutTab_Button = new System.Windows.Forms.Button();
            this.TransactionsTab_Button = new System.Windows.Forms.Button();
            this.ProductTab_Button = new System.Windows.Forms.Button();
            this.CustomerTab_Button = new System.Windows.Forms.Button();
            this.OrdersTab_Button = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Home_Button = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Settings_Button = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 25;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ContentPanel
            // 
            this.ContentPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.ContentPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ContentPanel.Location = new System.Drawing.Point(320, 40);
            this.ContentPanel.Name = "ContentPanel";
            this.ContentPanel.Size = new System.Drawing.Size(880, 760);
            this.ContentPanel.TabIndex = 2;
            this.ContentPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.ContentPanel_Paint);
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.Controls.Add(this.EmployeeTab_Button);
            this.panel2.Controls.Add(this.AboutTab_Button);
            this.panel2.Controls.Add(this.TransactionsTab_Button);
            this.panel2.Controls.Add(this.ProductTab_Button);
            this.panel2.Controls.Add(this.CustomerTab_Button);
            this.panel2.Controls.Add(this.OrdersTab_Button);
            this.panel2.Controls.Add(this.button4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 40);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(320, 760);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // EmployeeTab_Button
            // 
            this.EmployeeTab_Button.BackColor = System.Drawing.Color.Transparent;
            this.EmployeeTab_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EmployeeTab_Button.Font = new System.Drawing.Font("Oxygen", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmployeeTab_Button.ForeColor = System.Drawing.Color.White;
            this.EmployeeTab_Button.Image = global::Billing_System.Properties.Resources.employee1;
            this.EmployeeTab_Button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.EmployeeTab_Button.Location = new System.Drawing.Point(0, 500);
            this.EmployeeTab_Button.Name = "EmployeeTab_Button";
            this.EmployeeTab_Button.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.EmployeeTab_Button.Size = new System.Drawing.Size(320, 100);
            this.EmployeeTab_Button.TabIndex = 6;
            this.EmployeeTab_Button.Text = "EMPLOYEE";
            this.EmployeeTab_Button.UseVisualStyleBackColor = false;
            this.EmployeeTab_Button.Click += new System.EventHandler(this.EmployeeTab_Button_Click);
            // 
            // AboutTab_Button
            // 
            this.AboutTab_Button.BackColor = System.Drawing.Color.Transparent;
            this.AboutTab_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AboutTab_Button.Font = new System.Drawing.Font("Oxygen", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AboutTab_Button.ForeColor = System.Drawing.Color.White;
            this.AboutTab_Button.Image = ((System.Drawing.Image)(resources.GetObject("AboutTab_Button.Image")));
            this.AboutTab_Button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AboutTab_Button.Location = new System.Drawing.Point(0, 600);
            this.AboutTab_Button.Name = "AboutTab_Button";
            this.AboutTab_Button.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.AboutTab_Button.Size = new System.Drawing.Size(320, 100);
            this.AboutTab_Button.TabIndex = 5;
            this.AboutTab_Button.Text = "ABOUT";
            this.AboutTab_Button.UseVisualStyleBackColor = false;
            this.AboutTab_Button.Click += new System.EventHandler(this.AboutTab_Button_Click);
            // 
            // TransactionsTab_Button
            // 
            this.TransactionsTab_Button.BackColor = System.Drawing.Color.Transparent;
            this.TransactionsTab_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TransactionsTab_Button.Font = new System.Drawing.Font("Oxygen", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TransactionsTab_Button.ForeColor = System.Drawing.Color.White;
            this.TransactionsTab_Button.Image = ((System.Drawing.Image)(resources.GetObject("TransactionsTab_Button.Image")));
            this.TransactionsTab_Button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.TransactionsTab_Button.Location = new System.Drawing.Point(0, 400);
            this.TransactionsTab_Button.Name = "TransactionsTab_Button";
            this.TransactionsTab_Button.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.TransactionsTab_Button.Size = new System.Drawing.Size(320, 100);
            this.TransactionsTab_Button.TabIndex = 4;
            this.TransactionsTab_Button.Text = "TRANSACTIONS";
            this.TransactionsTab_Button.UseVisualStyleBackColor = false;
            this.TransactionsTab_Button.Click += new System.EventHandler(this.TransactionsTab_Button_Click);
            // 
            // ProductTab_Button
            // 
            this.ProductTab_Button.BackColor = System.Drawing.Color.Transparent;
            this.ProductTab_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ProductTab_Button.Font = new System.Drawing.Font("Oxygen", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductTab_Button.ForeColor = System.Drawing.Color.White;
            this.ProductTab_Button.Image = ((System.Drawing.Image)(resources.GetObject("ProductTab_Button.Image")));
            this.ProductTab_Button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ProductTab_Button.Location = new System.Drawing.Point(0, 300);
            this.ProductTab_Button.Name = "ProductTab_Button";
            this.ProductTab_Button.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.ProductTab_Button.Size = new System.Drawing.Size(320, 100);
            this.ProductTab_Button.TabIndex = 3;
            this.ProductTab_Button.Text = "PRODUCT";
            this.ProductTab_Button.UseVisualStyleBackColor = false;
            this.ProductTab_Button.Click += new System.EventHandler(this.ProductTab_Button_Click);
            // 
            // CustomerTab_Button
            // 
            this.CustomerTab_Button.BackColor = System.Drawing.Color.Transparent;
            this.CustomerTab_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CustomerTab_Button.Font = new System.Drawing.Font("Oxygen", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerTab_Button.ForeColor = System.Drawing.Color.White;
            this.CustomerTab_Button.Image = ((System.Drawing.Image)(resources.GetObject("CustomerTab_Button.Image")));
            this.CustomerTab_Button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CustomerTab_Button.Location = new System.Drawing.Point(0, 200);
            this.CustomerTab_Button.Name = "CustomerTab_Button";
            this.CustomerTab_Button.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.CustomerTab_Button.Size = new System.Drawing.Size(320, 100);
            this.CustomerTab_Button.TabIndex = 2;
            this.CustomerTab_Button.Text = "CUSTOMER";
            this.CustomerTab_Button.UseVisualStyleBackColor = false;
            this.CustomerTab_Button.Click += new System.EventHandler(this.CustomerTab_Button_Click);
            // 
            // OrdersTab_Button
            // 
            this.OrdersTab_Button.BackColor = System.Drawing.Color.Transparent;
            this.OrdersTab_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OrdersTab_Button.Font = new System.Drawing.Font("Oxygen", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrdersTab_Button.ForeColor = System.Drawing.Color.White;
            this.OrdersTab_Button.Image = ((System.Drawing.Image)(resources.GetObject("OrdersTab_Button.Image")));
            this.OrdersTab_Button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.OrdersTab_Button.Location = new System.Drawing.Point(0, 100);
            this.OrdersTab_Button.Name = "OrdersTab_Button";
            this.OrdersTab_Button.Size = new System.Drawing.Size(320, 100);
            this.OrdersTab_Button.TabIndex = 1;
            this.OrdersTab_Button.Text = "ORDERS";
            this.OrdersTab_Button.UseVisualStyleBackColor = false;
            this.OrdersTab_Button.Click += new System.EventHandler(this.OrdersTab_Button_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Transparent;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.Location = new System.Drawing.Point(0, 0);
            this.button4.Name = "button4";
            this.button4.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.button4.Size = new System.Drawing.Size(320, 100);
            this.button4.TabIndex = 0;
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.Settings_Button);
            this.panel1.Controls.Add(this.Home_Button);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1200, 40);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // Home_Button
            // 
            this.Home_Button.BackColor = System.Drawing.Color.Transparent;
            this.Home_Button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Home_Button.BackgroundImage")));
            this.Home_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Home_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Home_Button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Home_Button.Location = new System.Drawing.Point(10, 0);
            this.Home_Button.Name = "Home_Button";
            this.Home_Button.Size = new System.Drawing.Size(50, 40);
            this.Home_Button.TabIndex = 3;
            this.Home_Button.UseVisualStyleBackColor = false;
            this.Home_Button.Click += new System.EventHandler(this.Home_Button_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(16)))), ((int)(((byte)(42)))));
            this.button3.Location = new System.Drawing.Point(1055, 5);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(32, 28);
            this.button3.TabIndex = 2;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(16)))), ((int)(((byte)(42)))));
            this.button2.Location = new System.Drawing.Point(1100, 6);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(32, 28);
            this.button2.TabIndex = 1;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(16)))), ((int)(((byte)(42)))));
            this.button1.Location = new System.Drawing.Point(1140, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(36, 32);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Settings_Button
            // 
            this.Settings_Button.BackColor = System.Drawing.Color.Transparent;
            this.Settings_Button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Settings_Button.BackgroundImage")));
            this.Settings_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Settings_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Settings_Button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Settings_Button.Location = new System.Drawing.Point(66, 3);
            this.Settings_Button.Name = "Settings_Button";
            this.Settings_Button.Size = new System.Drawing.Size(50, 35);
            this.Settings_Button.TabIndex = 4;
            this.Settings_Button.UseVisualStyleBackColor = false;
            this.Settings_Button.Click += new System.EventHandler(this.Settings_Button_Click);
            // 
            // AppBody
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 800);
            this.Controls.Add(this.ContentPanel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AppBody";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AppBody";
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button AboutTab_Button;
        private System.Windows.Forms.Button TransactionsTab_Button;
        private System.Windows.Forms.Button ProductTab_Button;
        private System.Windows.Forms.Button CustomerTab_Button;
        private System.Windows.Forms.Button OrdersTab_Button;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel ContentPanel;
        private System.Windows.Forms.Button EmployeeTab_Button;
        private System.Windows.Forms.Button Home_Button;
        private System.Windows.Forms.Button Settings_Button;
    }
}