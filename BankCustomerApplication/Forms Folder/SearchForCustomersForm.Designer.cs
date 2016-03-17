namespace BankCustomerApplication
{
    partial class SearchForCustomersForm
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
            this.button4 = new System.Windows.Forms.Button();
            this.GVCustomers = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.TextBoxIDSearchStament = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TextBoxNameSearchStament = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TextBoxAgeSearchStament = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TextBoxBalanceSearchStament = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.GVCustomers)).BeginInit();
            this.SuspendLayout();
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(684, 103);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(122, 23);
            this.button4.TabIndex = 13;
            this.button4.Text = "Load All Data";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.loadBTN);
            // 
            // GVCustomers
            // 
            this.GVCustomers.AllowUserToAddRows = false;
            this.GVCustomers.AllowUserToDeleteRows = false;
            this.GVCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GVCustomers.Location = new System.Drawing.Point(117, 147);
            this.GVCustomers.Name = "GVCustomers";
            this.GVCustomers.ReadOnly = true;
            this.GVCustomers.RowTemplate.Height = 24;
            this.GVCustomers.Size = new System.Drawing.Size(619, 402);
            this.GVCustomers.TabIndex = 12;
            this.GVCustomers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GVCustomers_CellContentClick);
            this.GVCustomers.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.GVCustomers_CellContentClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(582, 103);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.SearchForCustomer);
            // 
            // TextBoxIDSearchStament
            // 
            this.TextBoxIDSearchStament.Location = new System.Drawing.Point(48, 25);
            this.TextBoxIDSearchStament.Name = "TextBoxIDSearchStament";
            this.TextBoxIDSearchStament.Size = new System.Drawing.Size(75, 22);
            this.TextBoxIDSearchStament.TabIndex = 10;
            this.TextBoxIDSearchStament.TextChanged += new System.EventHandler(this.SearchStament_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 17);
            this.label1.TabIndex = 14;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(150, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 16;
            this.label2.Text = "Name";
            // 
            // TextBoxNameSearchStament
            // 
            this.TextBoxNameSearchStament.Location = new System.Drawing.Point(201, 25);
            this.TextBoxNameSearchStament.Name = "TextBoxNameSearchStament";
            this.TextBoxNameSearchStament.Size = new System.Drawing.Size(75, 22);
            this.TextBoxNameSearchStament.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 17);
            this.label3.TabIndex = 18;
            this.label3.Text = "Age";
            // 
            // TextBoxAgeSearchStament
            // 
            this.TextBoxAgeSearchStament.Location = new System.Drawing.Point(48, 74);
            this.TextBoxAgeSearchStament.Name = "TextBoxAgeSearchStament";
            this.TextBoxAgeSearchStament.Size = new System.Drawing.Size(75, 22);
            this.TextBoxAgeSearchStament.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(136, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 17);
            this.label4.TabIndex = 20;
            this.label4.Text = "Balance";
            // 
            // TextBoxBalanceSearchStament
            // 
            this.TextBoxBalanceSearchStament.Location = new System.Drawing.Point(201, 77);
            this.TextBoxBalanceSearchStament.Name = "TextBoxBalanceSearchStament";
            this.TextBoxBalanceSearchStament.Size = new System.Drawing.Size(75, 22);
            this.TextBoxBalanceSearchStament.TabIndex = 19;
            // 
            // SearchForCustomersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(909, 588);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TextBoxBalanceSearchStament);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TextBoxAgeSearchStament);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TextBoxNameSearchStament);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.GVCustomers);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TextBoxIDSearchStament);
            this.Name = "SearchForCustomersForm";
            this.Text = "SearchForCustomers";
            this.Load += new System.EventHandler(this.CustomerData_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GVCustomers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridView GVCustomers;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox TextBoxIDSearchStament;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TextBoxNameSearchStament;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TextBoxAgeSearchStament;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TextBoxBalanceSearchStament;
        //private BankCustomerApplication.HRDataSet hRDataSet;
    }
}