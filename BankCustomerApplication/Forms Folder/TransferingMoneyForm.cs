using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankCustomerApplication
{
    public partial class TransferingMoneyForm : Form
    {
        ToolStripStatusLabel ToolStripStatusLabel;
        public TransferingMoneyForm(ToolStripStatusLabel ToolStripStatusLabel)
        {
            InitializeComponent();
            this.ToolStripStatusLabel = ToolStripStatusLabel;
        }

        private void TransferingMoney(object sender, EventArgs e)
        {
            try
            {
                BusinessLayer.TransferMoney(TextBoxTransfererCustomerID.Text, TextBoxReceiverCustomerTwoID.Text, TextBoxBalanceTransfered.Text);
                MessageBox.Show("The Money has been transfered from Customer with ID= '" + TextBoxTransfererCustomerID.Text + "' to customer with ID= '" + TextBoxReceiverCustomerTwoID.Text + "'");
                DataSet ds = null;
                string CustomerID = TextBoxTransfererCustomerID.Text;
                int ID;
                bool check = Int32.TryParse(CustomerID,out ID);
                if (check == true)
                {
                    ds= BusinessLayer.SearchForCustomersByID(ID);
                }
               
                string BalanceAmount = ds.Tables["Customers"].Rows[0]["Balance"].ToString();
                MessageBox.Show("Customer with ID = '" + TextBoxTransfererCustomerID.Text + "' has now Balance = " + BalanceAmount);

                string Customer2ID = TextBoxReceiverCustomerTwoID.Text;
                int ID2;
                 check = Int32.TryParse(Customer2ID, out ID2);
                if (check == true)
                {
                    ds = BusinessLayer.SearchForCustomersByID(ID2);
                }
        
                BalanceAmount = ds.Tables["Customers"].Rows[0]["Balance"].ToString();
                MessageBox.Show("Customer with ID = '" + TextBoxReceiverCustomerTwoID.Text + "' has now Balance = " + BalanceAmount);
             
                ToolStripStatusLabel.BackColor = Color.Green;
                ToolStripStatusLabel.Text = "The Transfer process completed successfully";
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                ToolStripStatusLabel.BackColor = Color.Red;
                ToolStripStatusLabel.Text = "The Transfer process Failed";
            }
        }
    }
}
