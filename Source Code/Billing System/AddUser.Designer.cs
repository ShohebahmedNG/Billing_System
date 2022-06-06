namespace Billing_System
{
    partial class AddUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddUser));
            this.ProductID_Textbox = new System.Windows.Forms.TextBox();
            this.ProductID_Panel = new System.Windows.Forms.Panel();
            this.Username_Label = new System.Windows.Forms.Label();
            this.Password_label = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SearchProduct_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ProductID_Textbox
            // 
            this.ProductID_Textbox.BackColor = System.Drawing.SystemColors.Control;
            this.ProductID_Textbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ProductID_Textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductID_Textbox.Location = new System.Drawing.Point(215, 91);
            this.ProductID_Textbox.Name = "ProductID_Textbox";
            this.ProductID_Textbox.Size = new System.Drawing.Size(140, 23);
            this.ProductID_Textbox.TabIndex = 40;
            this.ProductID_Textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ProductID_Panel
            // 
            this.ProductID_Panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(18)))), ((int)(((byte)(42)))));
            this.ProductID_Panel.Font = new System.Drawing.Font("Oxygen", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductID_Panel.Location = new System.Drawing.Point(210, 116);
            this.ProductID_Panel.Name = "ProductID_Panel";
            this.ProductID_Panel.Size = new System.Drawing.Size(150, 2);
            this.ProductID_Panel.TabIndex = 41;
            // 
            // Username_Label
            // 
            this.Username_Label.AutoSize = true;
            this.Username_Label.Font = new System.Drawing.Font("Oxygen", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Username_Label.Location = new System.Drawing.Point(105, 91);
            this.Username_Label.Name = "Username_Label";
            this.Username_Label.Size = new System.Drawing.Size(104, 21);
            this.Username_Label.TabIndex = 42;
            this.Username_Label.Text = "Username : ";
            this.Username_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Password_label
            // 
            this.Password_label.AutoSize = true;
            this.Password_label.Font = new System.Drawing.Font("Oxygen", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password_label.Location = new System.Drawing.Point(110, 173);
            this.Password_label.Name = "Password_label";
            this.Password_label.Size = new System.Drawing.Size(94, 21);
            this.Password_label.TabIndex = 45;
            this.Password_label.Text = "Password :";
            this.Password_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(18)))), ((int)(((byte)(42)))));
            this.panel1.Font = new System.Drawing.Font("Oxygen", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(210, 198);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(150, 2);
            this.panel1.TabIndex = 44;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Control;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(215, 173);
            this.textBox1.Name = "textBox1";
            this.textBox1.PasswordChar = '*';
            this.textBox1.Size = new System.Drawing.Size(140, 23);
            this.textBox1.TabIndex = 43;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // SearchProduct_Button
            // 
            this.SearchProduct_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(18)))), ((int)(((byte)(42)))));
            this.SearchProduct_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SearchProduct_Button.Font = new System.Drawing.Font("Oxygen", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchProduct_Button.ForeColor = System.Drawing.Color.White;
            this.SearchProduct_Button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SearchProduct_Button.Location = new System.Drawing.Point(180, 248);
            this.SearchProduct_Button.Name = "SearchProduct_Button";
            this.SearchProduct_Button.Padding = new System.Windows.Forms.Padding(3, 1, 0, 0);
            this.SearchProduct_Button.Size = new System.Drawing.Size(120, 40);
            this.SearchProduct_Button.TabIndex = 46;
            this.SearchProduct_Button.Text = "Submit";
            this.SearchProduct_Button.UseVisualStyleBackColor = false;
            this.SearchProduct_Button.Click += new System.EventHandler(this.SearchProduct_Button_Click);
            // 
            // AddUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 353);
            this.Controls.Add(this.SearchProduct_Button);
            this.Controls.Add(this.Password_label);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Username_Label);
            this.Controls.Add(this.ProductID_Panel);
            this.Controls.Add(this.ProductID_Textbox);
            this.Font = new System.Drawing.Font("Oxygen", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AddUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddUser";
            this.Load += new System.EventHandler(this.AddUser_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ProductID_Textbox;
        private System.Windows.Forms.Panel ProductID_Panel;
        private System.Windows.Forms.Label Username_Label;
        private System.Windows.Forms.Label Password_label;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button SearchProduct_Button;
    }
}