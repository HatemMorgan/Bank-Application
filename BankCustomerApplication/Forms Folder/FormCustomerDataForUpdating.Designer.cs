namespace BankCustomerApplication
{
    partial class FormCustomerDataForUpdating
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
            this.ToolBoxCustomerBalance = new System.Windows.Forms.TextBox();
            this.ToolBoxCustomerAge = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ToolBoxCustomerName = new System.Windows.Forms.TextBox();
            this.UpdateBtn = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.ToolBoxCustomerBalance, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.ToolBoxCustomerAge, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.ToolBoxCustomerName, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.UpdateBtn, 0, 3);
            this.tableLayoutPanel1.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(134, 44);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(508, 358);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // ToolBoxCustomerBalance
            // 
            this.ToolBoxCustomerBalance.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToolBoxCustomerBalance.Location = new System.Drawing.Point(257, 203);
            this.ToolBoxCustomerBalance.Margin = new System.Windows.Forms.Padding(3, 25, 3, 3);
            this.ToolBoxCustomerBalance.MaximumSize = new System.Drawing.Size(250, 50);
            this.ToolBoxCustomerBalance.MaxLength = 1000;
            this.ToolBoxCustomerBalance.MinimumSize = new System.Drawing.Size(250, 50);
            this.ToolBoxCustomerBalance.Name = "ToolBoxCustomerBalance";
            this.ToolBoxCustomerBalance.Size = new System.Drawing.Size(250, 50);
            this.ToolBoxCustomerBalance.TabIndex = 7;
            // 
            // ToolBoxCustomerAge
            // 
            this.ToolBoxCustomerAge.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToolBoxCustomerAge.Location = new System.Drawing.Point(257, 114);
            this.ToolBoxCustomerAge.Margin = new System.Windows.Forms.Padding(3, 25, 3, 3);
            this.ToolBoxCustomerAge.MaximumSize = new System.Drawing.Size(250, 50);
            this.ToolBoxCustomerAge.MaxLength = 1000;
            this.ToolBoxCustomerAge.MinimumSize = new System.Drawing.Size(250, 50);
            this.ToolBoxCustomerAge.Name = "ToolBoxCustomerAge";
            this.ToolBoxCustomerAge.Size = new System.Drawing.Size(250, 50);
            this.ToolBoxCustomerAge.TabIndex = 6;
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
            // ToolBoxCustomerName
            // 
            this.ToolBoxCustomerName.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToolBoxCustomerName.Location = new System.Drawing.Point(257, 25);
            this.ToolBoxCustomerName.Margin = new System.Windows.Forms.Padding(3, 25, 3, 3);
            this.ToolBoxCustomerName.MaximumSize = new System.Drawing.Size(250, 50);
            this.ToolBoxCustomerName.MaxLength = 1000;
            this.ToolBoxCustomerName.MinimumSize = new System.Drawing.Size(250, 50);
            this.ToolBoxCustomerName.Name = "ToolBoxCustomerName";
            this.ToolBoxCustomerName.Size = new System.Drawing.Size(250, 50);
            this.ToolBoxCustomerName.TabIndex = 5;
            // 
            // UpdateBtn
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.UpdateBtn, 2);
            this.UpdateBtn.Location = new System.Drawing.Point(130, 270);
            this.UpdateBtn.Margin = new System.Windows.Forms.Padding(130, 3, 3, 3);
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.Size = new System.Drawing.Size(250, 85);
            this.UpdateBtn.TabIndex = 8;
            this.UpdateBtn.Text = "Update";
            this.UpdateBtn.UseVisualStyleBackColor = true;
            this.UpdateBtn.Click += new System.EventHandler(this.UpdateBtn_Click);
            // 
            // FormCustomerDataForUpdating
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(777, 447);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FormCustomerDataForUpdating";
            this.Text = "FormCustomerDataForUpdating";
            this.Load += new System.EventHandler(this.FormCustomerDataForUpdating_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox ToolBoxCustomerBalance;
        private System.Windows.Forms.TextBox ToolBoxCustomerAge;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ToolBoxCustomerName;
        private System.Windows.Forms.Button UpdateBtn;
    }
}