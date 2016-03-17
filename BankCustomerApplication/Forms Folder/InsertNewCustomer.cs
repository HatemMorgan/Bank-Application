using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BankCustomerApplication.DOT_Folder;
namespace BankCustomerApplication
{
    public partial class InsertNewCustomer : Form
    {
        ToolStripStatusLabel statusStripLabel;
        public InsertNewCustomer(ToolStripStatusLabel statusStripLabel)
        {
            InitializeComponent();
            this.statusStripLabel = statusStripLabel;
        }

        private void insertNewCustomer(object sender, EventArgs e)
        {
            try {
                Customer customer = new Customer();
                customer.setName(NewCustomerName.Text);
                string StringAge= NewCustomerAge.Text;
                int age;
                bool check = Int32.TryParse(StringAge, out age);
                if (check == true)
                {
                    customer.setAge(age);
                }
                else
                {
                    string message = "Age must be a number format";
                    throw new Exception(message);
                }

                string StringBalance = NewCustomerBalance.Text;
                int balance;
                check = Int32.TryParse(StringBalance, out balance);
                if (check == true)
                {
                    customer.setBalance(balance);
                }
                else
                {
                    string message = "Balance must be a number format";
                    throw new Exception(message);
                }
                string ID = BusinessLayer.InsertNewCustomer(customer);
                statusStripLabel.BackColor = Color.Green;
                statusStripLabel.Text = "The Customer has been inserted successfully";
                MessageBox.Show("The Customer ID is " + ID);
            }
            catch (Exception ex)
            {
                statusStripLabel.BackColor = Color.Red;
                statusStripLabel.Text = "The insertion process Failed ";
                MessageBox.Show(ex.Message);
            }
        }

        private void InsertNewCustomer_Load(object sender, EventArgs e)
        {

        }
    }
}
