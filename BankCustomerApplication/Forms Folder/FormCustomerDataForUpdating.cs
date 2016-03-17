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
    public partial class FormCustomerDataForUpdating : Form
    {
        ToolStripStatusLabel ToolStripStatusLabel;
        public FormCustomerDataForUpdating(ToolStripStatusLabel ToolStripStatusLabel)
        {
            InitializeComponent();
            this.ToolStripStatusLabel = ToolStripStatusLabel;
        }

        private void FormCustomerDataForUpdating_Load(object sender, EventArgs e)
        {
            try {
                string StringID = SearchForCustomersForm.TargetCustomerID;
          
                int ID;
                bool check = Int32.TryParse(StringID, out ID);
                if (check == true)
                {
                    DataSet ds = BusinessLayer.SearchForCustomersByID(ID);
                    ToolBoxCustomerName.Text = ds.Tables["Customers"].Rows[0]["Name"].ToString();
                    ToolBoxCustomerAge.Text = ds.Tables["Customers"].Rows[0]["Age"].ToString();
                    ToolBoxCustomerBalance.Text = ds.Tables["Customers"].Rows[0]["Balance"].ToString();
                }
                else
                {
                    string message = "The ID must be an Integer ";
                    
                    throw new Exception(message);
                }
              

                
            }
            catch(EmptyDataSetException )
            {
                string s = "There is no Customer with this ID";
                MessageBox.Show(s);
                ToolStripStatusLabel.BackColor = Color.Red;
                ToolStripStatusLabel.Text = "Updating Process Failed";
                
            }
            catch(Exception ex)
            {
                string s =ex.Message;
                MessageBox.Show(s);
                ToolStripStatusLabel.BackColor = Color.Red;
                ToolStripStatusLabel.Text = "Updating Process Failed";
            }
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            try {
                Customer customer = new Customer();
                customer.setID(int.Parse(SearchForCustomersForm.TargetCustomerID));
                customer.setName(ToolBoxCustomerName.Text);
                customer.setAge(int.Parse(ToolBoxCustomerAge.Text));
                customer.setBalance(int.Parse(ToolBoxCustomerBalance.Text));
                BusinessLayer.UpdateCusomterData(customer);
                MessageBox.Show("The Customer Data has been Updated");
                ToolStripStatusLabel.BackColor = Color.Green;
                ToolStripStatusLabel.Text = "Updating Process Completed successfully";
            }
            catch (Exception ex)
            {
                ToolStripStatusLabel.BackColor = Color.Red;
                ToolStripStatusLabel.Text = "Updating Process Failed";
                MessageBox.Show(ex.Message);
            }
        }
    }
}
