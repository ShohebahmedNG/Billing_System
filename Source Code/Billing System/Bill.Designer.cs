namespace Billing_System
{
    partial class Bill
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bill));
            this.CustomerID_Label = new System.Windows.Forms.Label();
            this.CustomerID_Textbox = new System.Windows.Forms.TextBox();
            this.CustomerID_Panel = new System.Windows.Forms.Panel();
            this.PurchaseDate_Label = new System.Windows.Forms.Label();
            this.PurchaseDate_Panel = new System.Windows.Forms.Panel();
            this.PurchaseDate_Textbox = new System.Windows.Forms.TextBox();
            this.Bill_dataGridView = new System.Windows.Forms.DataGridView();
            this.SaveBill_Button = new System.Windows.Forms.Button();
            this.GenerateBill_Button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Bill_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // CustomerID_Label
            // 
            resources.ApplyResources(this.CustomerID_Label, "CustomerID_Label");
            this.CustomerID_Label.Name = "CustomerID_Label";
            // 
            // CustomerID_Textbox
            // 
            this.CustomerID_Textbox.BackColor = System.Drawing.SystemColors.Control;
            this.CustomerID_Textbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.CustomerID_Textbox, "CustomerID_Textbox");
            this.CustomerID_Textbox.Name = "CustomerID_Textbox";
            // 
            // CustomerID_Panel
            // 
            this.CustomerID_Panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(18)))), ((int)(((byte)(42)))));
            resources.ApplyResources(this.CustomerID_Panel, "CustomerID_Panel");
            this.CustomerID_Panel.Name = "CustomerID_Panel";
            // 
            // PurchaseDate_Label
            // 
            resources.ApplyResources(this.PurchaseDate_Label, "PurchaseDate_Label");
            this.PurchaseDate_Label.Name = "PurchaseDate_Label";
            // 
            // PurchaseDate_Panel
            // 
            this.PurchaseDate_Panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(18)))), ((int)(((byte)(42)))));
            resources.ApplyResources(this.PurchaseDate_Panel, "PurchaseDate_Panel");
            this.PurchaseDate_Panel.Name = "PurchaseDate_Panel";
            // 
            // PurchaseDate_Textbox
            // 
            this.PurchaseDate_Textbox.BackColor = System.Drawing.SystemColors.Control;
            this.PurchaseDate_Textbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.PurchaseDate_Textbox, "PurchaseDate_Textbox");
            this.PurchaseDate_Textbox.Name = "PurchaseDate_Textbox";
            // 
            // Bill_dataGridView
            // 
            this.Bill_dataGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.Bill_dataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Bill_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(this.Bill_dataGridView, "Bill_dataGridView");
            this.Bill_dataGridView.Name = "Bill_dataGridView";
            this.Bill_dataGridView.RowTemplate.Height = 24;
            // 
            // SaveBill_Button
            // 
            this.SaveBill_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(18)))), ((int)(((byte)(42)))));
            resources.ApplyResources(this.SaveBill_Button, "SaveBill_Button");
            this.SaveBill_Button.ForeColor = System.Drawing.Color.White;
            this.SaveBill_Button.Name = "SaveBill_Button";
            this.SaveBill_Button.UseVisualStyleBackColor = false;
            this.SaveBill_Button.Click += new System.EventHandler(this.SaveBill_Button_Click);
            // 
            // GenerateBill_Button
            // 
            this.GenerateBill_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(18)))), ((int)(((byte)(42)))));
            resources.ApplyResources(this.GenerateBill_Button, "GenerateBill_Button");
            this.GenerateBill_Button.ForeColor = System.Drawing.Color.White;
            this.GenerateBill_Button.Name = "GenerateBill_Button";
            this.GenerateBill_Button.UseVisualStyleBackColor = false;
            this.GenerateBill_Button.Click += new System.EventHandler(this.GenerateBill_Button_Click);
            // 
            // Bill
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.GenerateBill_Button);
            this.Controls.Add(this.SaveBill_Button);
            this.Controls.Add(this.Bill_dataGridView);
            this.Controls.Add(this.PurchaseDate_Textbox);
            this.Controls.Add(this.PurchaseDate_Panel);
            this.Controls.Add(this.PurchaseDate_Label);
            this.Controls.Add(this.CustomerID_Panel);
            this.Controls.Add(this.CustomerID_Textbox);
            this.Controls.Add(this.CustomerID_Label);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Bill";
            this.Load += new System.EventHandler(this.Bill_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Bill_dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CustomerID_Label;
        private System.Windows.Forms.TextBox CustomerID_Textbox;
        private System.Windows.Forms.Panel CustomerID_Panel;
        private System.Windows.Forms.Label PurchaseDate_Label;
        private System.Windows.Forms.Panel PurchaseDate_Panel;
        private System.Windows.Forms.TextBox PurchaseDate_Textbox;
        private System.Windows.Forms.DataGridView Bill_dataGridView;
        private System.Windows.Forms.Button SaveBill_Button;
        private System.Windows.Forms.Button GenerateBill_Button;
    }
}