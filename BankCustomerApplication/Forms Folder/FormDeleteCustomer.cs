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
    public partial class FormDeleteCustomer : Form
    {
        ToolStripStatusLabel ToolStripStatusLabel;
        public FormDeleteCustomer(ToolStripStatusLabel ToolStripStatusLabel)
        {
            InitializeComponent();
            this.ToolStripStatusLabel = ToolStripStatusLabel;
        }

        private void DeleteCustomer(object sender, EventArgs e)
        {
            try
            {
                Customer customer = new Customer();
                string StringID = SearchForCustomersForm.TargetCustomerID;
                int ID;
                bool check = Int32.TryParse(StringID, out ID);
                if (check == true)
                {
                    customer.setID(ID);
                }
                else
                {
                    throw new Exception();
                }
                BusinessLayer.DeleteCustomer(customer);
                string message="The Customer with ID = '"+ StringID + "' is Deleted";
                MessageBox.Show(message);
                ToolStripStatusLabel.BackColor = Color.Green;
                ToolStripStatusLabel.Text = "The Deleting process completed successfully";
            }
            catch (Exception ex)
            {
                ToolStripStatusLabel.BackColor = Color.Red;
                ToolStripStatusLabel.Text = "The Deleting process Failed";
                MessageBox.Show(ex.Message);
            }
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
