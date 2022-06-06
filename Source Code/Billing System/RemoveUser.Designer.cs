namespace Billing_System
{
    partial class RemoveUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RemoveUser));
            this.SearchProduct_Button = new System.Windows.Forms.Button();
            this.Username_Label = new System.Windows.Forms.Label();
            this.ProductID_Panel = new System.Windows.Forms.Panel();
            this.ProductID_Textbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // SearchProduct_Button
            // 
            this.SearchProduct_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(18)))), ((int)(((byte)(42)))));
            this.SearchProduct_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SearchProduct_Button.Font = new System.Drawing.Font("Oxygen", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchProduct_Button.ForeColor = System.Drawing.Color.White;
            this.SearchProduct_Button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SearchProduct_Button.Location = new System.Drawing.Point(182, 235);
            this.SearchProduct_Button.Name = "SearchProduct_Button";
            this.SearchProduct_Button.Padding = new System.Windows.Forms.Padding(3, 1, 0, 0);
            this.SearchProduct_Button.Size = new System.Drawing.Size(120, 40);
            this.SearchProduct_Button.TabIndex = 50;
            this.SearchProduct_Button.Text = "Remove";
            this.SearchProduct_Button.UseVisualStyleBackColor = false;
            this.SearchProduct_Button.Click += new System.EventHandler(this.SearchProduct_Button_Click);
            // 
            // Username_Label
            // 
            this.Username_Label.AutoSize = true;
            this.Username_Label.Font = new System.Drawing.Font("Oxygen", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Username_Label.Location = new System.Drawing.Point(108, 127);
            this.Username_Label.Name = "Username_Label";
            this.Username_Label.Size = new System.Drawing.Size(104, 21);
            this.Username_Label.TabIndex = 49;
            this.Username_Label.Text = "Username : ";
            this.Username_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ProductID_Panel
            // 
            this.ProductID_Panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(18)))), ((int)(((byte)(42)))));
            this.ProductID_Panel.Font = new System.Drawing.Font("Oxygen", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductID_Panel.Location = new System.Drawing.Point(213, 152);
            this.ProductID_Panel.Name = "ProductID_Panel";
            this.ProductID_Panel.Size = new System.Drawing.Size(150, 2);
            this.ProductID_Panel.TabIndex = 48;
            // 
            // ProductID_Textbox
            // 
            this.ProductID_Textbox.BackColor = System.Drawing.SystemColors.Control;
            this.ProductID_Textbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ProductID_Textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductID_Textbox.Location = new System.Drawing.Point(218, 127);
            this.ProductID_Textbox.Name = "ProductID_Textbox";
            this.ProductID_Textbox.Size = new System.Drawing.Size(140, 23);
            this.ProductID_Textbox.TabIndex = 47;
            this.ProductID_Textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // RemoveUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 353);
            this.Controls.Add(this.SearchProduct_Button);
            this.Controls.Add(this.Username_Label);
            this.Controls.Add(this.ProductID_Panel);
            this.Controls.Add(this.ProductID_Textbox);
            this.Font = new System.Drawing.Font("Oxygen", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "RemoveUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RemoveUser";
            this.Load += new System.EventHandler(this.RemoveUser_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SearchProduct_Button;
        private System.Windows.Forms.Label Username_Label;
        private System.Windows.Forms.Panel ProductID_Panel;
        private System.Windows.Forms.TextBox ProductID_Textbox;
    }
}