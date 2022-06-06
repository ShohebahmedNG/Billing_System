namespace Billing_System
{
    partial class Home_Page
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SuperMarket_Textbox = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.SuspendLayout();
            // 
            // SuperMarket_Textbox
            // 
            this.SuperMarket_Textbox.BackColor = System.Drawing.SystemColors.Control;
            this.SuperMarket_Textbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SuperMarket_Textbox.Font = new System.Drawing.Font("Oxygen", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SuperMarket_Textbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(18)))), ((int)(((byte)(42)))));
            this.SuperMarket_Textbox.Location = new System.Drawing.Point(170, 150);
            this.SuperMarket_Textbox.Name = "SuperMarket_Textbox";
            this.SuperMarket_Textbox.Size = new System.Drawing.Size(550, 76);
            this.SuperMarket_Textbox.TabIndex = 2;
            this.SuperMarket_Textbox.Text = "XYZ Supermarket\r\n";
            this.SuperMarket_Textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Control;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Oxygen", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(18)))), ((int)(((byte)(42)))));
            this.textBox1.Location = new System.Drawing.Point(200, 230);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(500, 26);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = "Always Providing Quality Products ...";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.monthCalendar1.Location = new System.Drawing.Point(300, 400);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 4;
            this.monthCalendar1.TitleBackColor = System.Drawing.SystemColors.Control;
            // 
            // Home_Page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.SuperMarket_Textbox);
            this.Name = "Home_Page";
            this.Size = new System.Drawing.Size(880, 760);
            this.Load += new System.EventHandler(this.Home_Page_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox SuperMarket_Textbox;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
    }
}
