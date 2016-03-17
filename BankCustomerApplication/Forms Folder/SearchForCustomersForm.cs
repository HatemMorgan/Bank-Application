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
    public partial class SearchForCustomersForm : Form
    {
        ToolStripStatusLabel statusStripLabel;
        public static string TargetCustomerID;
        public SearchForCustomersForm(ToolStripStatusLabel statusStripLabel)
        {
            InitializeComponent();
            this.statusStripLabel = statusStripLabel;
        }


        private void loadBTN(object sender, EventArgs e)
        {
            try
            {
                DataSet dataset = BusinessLayer.ReloadCustomerData();
                BindingSource bindingsource = new BindingSource();
                bindingsource.DataSource = dataset.Tables["Customers"];
                GVCustomers.DataSource = bindingsource;
                GVCustomers.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                GVCustomers.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                GVCustomers.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                GVCustomers.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                statusStripLabel.BackColor = Color.Green;
                statusStripLabel.Text = "Customers Data are loaded successfully";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void SearchForCustomer(object sender, EventArgs e)
        {
            try
            {
                Customer customer = new Customer();
                if (!string.IsNullOrEmpty(TextBoxIDSearchStament.Text))
                {
                    string StringID = TextBoxIDSearchStament.Text;
                    int ID;
                    bool check = Int32.TryParse(StringID, out ID);
                    if (check == true)
                    {
                        customer.setID(ID);
                    }
                    else
                    {
                        string message = "ID must be a number format";
                        throw new Exception(message);
                    }
                }


                if (!string.IsNullOrEmpty(TextBoxNameSearchStament.Text))
                {
                    string StringName = TextBoxNameSearchStament.Text;
                    customer.setName(StringName);
                   
                }
                
                if (!string.IsNullOrEmpty(TextBoxAgeSearchStament.Text))
                {
                    string StringAge = TextBoxAgeSearchStament.Text;
                    int Age;
                    bool check = Int32.TryParse(StringAge, out Age);
                    if (check == true)
                    {
                        customer.setAge(Age);
                    }
                    else
                    {
                        string message = "Age must be a number format";
                        throw new Exception(message);
                    }
                }

                if (!string.IsNullOrEmpty(TextBoxBalanceSearchStament.Text))
                {
                    
                    string StringBalance = TextBoxBalanceSearchStament.Text;
                    int Balance;
                    bool check = Int32.TryParse(StringBalance, out Balance);
                    if (check == true)
                    {
                        customer.setID(Balance);
                    }
                    else
                    {
                        string message = "Balance must be a number format";
                        throw new Exception(message);
                    }
                }
             
                    DataSet dataset = BusinessLayer.SearchForCustomers(customer);
                    BindingSource bindingsource = new BindingSource();
                    bindingsource.DataSource = dataset.Tables["Customers"];
                    GVCustomers.DataSource = bindingsource;
                    GVCustomers.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    GVCustomers.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                    GVCustomers.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    GVCustomers.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    statusStripLabel.BackColor = Color.Green;
                    statusStripLabel.Text = "Customer Data is loaded successfully";
               

            }
            catch (Exception ex)
            {
                statusStripLabel.BackColor = Color.Red;
                statusStripLabel.Text = "Customer Data loading failed ";
                MessageBox.Show(ex.Message);
            }
            finally
            {
                TextBoxIDSearchStament.Text = null;
                TextBoxNameSearchStament.Text = null;
                TextBoxAgeSearchStament.Text = null;
                TextBoxBalanceSearchStament.Text = null;
            }
        }

        private void CustomerData_Load(object sender, EventArgs e)
        {


        }

        private void GVCustomers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataSet ds = BusinessLayer.ReloadCustomerData();
            DataRow dr = ds.Tables["Customers"].Rows[e.RowIndex];
             TargetCustomerID = dr[0].ToString();
            BankCustomerApplication.ToolStripButtonDeleteustomer.Visible = true;
            BankCustomerApplication.ToolStripButtonUpdateCustomer.Visible = true;

        }

        private void SearchStament_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
