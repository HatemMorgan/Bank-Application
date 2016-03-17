namespace BankCustomerApplication
{
    partial class InsertNewCustomer
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.NewCustomerBalance = new System.Windows.Forms.TextBox();
            this.NewCustomerAge = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.NewCustomerName = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.NewCustomerBalance, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.NewCustomerAge, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.NewCustomerName, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.button1, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(155, 71);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(508, 358);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // NewCustomerBalance
            // 
            this.NewCustomerBalance.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewCustomerBalance.Location = new System.Drawing.Point(257, 203);
            this.NewCustomerBalance.Margin = new System.Windows.Forms.Padding(3, 25, 3, 3);
            this.NewCustomerBalance.MaximumSize = new System.Drawing.Size(250, 50);
            this.NewCustomerBalance.MaxLength = 1000;
            this.NewCustomerBalance.MinimumSize = new System.Drawing.Size(250, 50);
            this.NewCustomerBalance.Name = "NewCustomerBalance";
            this.NewCustomerBalance.Size = new System.Drawing.Size(250, 50);
            this.NewCustomerBalance.TabIndex = 7;
            // 
            // NewCustomerAge
            // 
            this.NewCustomerAge.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewCustomerAge.Location = new System.Drawing.Point(257, 114);
            this.NewCustomerAge.Margin = new System.Windows.Forms.Padding(3, 25, 3, 3);
            this.NewCustomerAge.MaximumSize = new System.Drawing.Size(250, 50);
            this.NewCustomerAge.MaxLength = 1000;
            this.NewCustomerAge.MinimumSize = new System.Drawing.Size(250, 50);
            this.NewCustomerAge.Name = "NewCustomerAge";
            this.NewCustomerAge.Size = new System.Drawing.Size(250, 50);
            this.NewCustomerAge.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 178);
            this.label5.MaximumSize = new System.Drawing.Size(500, 100);
            this.label5.MinimumSize = new System.Drawing.Size(250, 85);
            this.label5.Name = "label5";
            this.label5.Padding = new System.Windows.Forms.Padding(20, 10, 0, 0);
            this.label5.Size = new System.Drawing.Size(250, 85);
            this.label5.TabIndex = 4;
            this.label5.Text = "Customer Balance";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 89);
            this.label3.MaximumSize = new System.Drawing.Size(500, 100);
            this.label3.MinimumSize = new System.Drawing.Size(250, 85);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(20, 10, 0, 0);
            this.label3.Size = new System.Drawing.Size(250, 85);
            this.label3.TabIndex = 2;
            this.label3.Text = "Customer Age";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NewCustomerName
            // 
            this.NewCustomerName.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewCustomerName.Location = new System.Drawing.Point(257, 25);
            this.NewCustomerName.Margin = new System.Windows.Forms.Padding(3, 25, 3, 3);
            this.NewCustomerName.MaximumSize = new System.Drawing.Size(250, 50);
            this.NewCustomerName.MaxLength = 1000;
            this.NewCustomerName.MinimumSize = new System.Drawing.Size(250, 50);
            this.NewCustomerName.Name = "NewCustomerName";
            this.NewCustomerName.Size = new System.Drawing.Size(250, 50);
            this.NewCustomerName.TabIndex = 5;
            // 
            // button1
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.button1, 2);
            this.button1.Location = new System.Drawing.Point(130, 270);
            this.button1.Margin = new System.Windows.Forms.Padding(130, 3, 3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(250, 85);
            this.button1.TabIndex = 8;
            this.button1.Text = "Submit Customer Information";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.insertNewCustomer);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.MaximumSize = new System.Drawing.Size(500, 100);
            this.label1.MinimumSize = new System.Drawing.Size(250, 85);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(20, 10, 0, 0);
            this.label1.Size = new System.Drawing.Size(250, 85);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customer Name";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // InsertNewCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(818, 500);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "InsertNewCustomer";
            this.Text = "InsertNewCustomer";
            this.Load += new System.EventHandler(this.InsertNewCustomer_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox NewCustomerBalance;
        private System.Windows.Forms.TextBox NewCustomerAge;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox NewCustomerName;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
    }
}