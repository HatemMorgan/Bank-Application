using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using BankCustomerApplication.DOT_Folder;

namespace BankCustomerApplication
{
    public partial class BusinessLayer : Component
    {
        public BusinessLayer()
        {
            InitializeComponent();
        }

        public BusinessLayer(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
        public static DataSet SearchForCustomersByID(int ID)
        {
            DataSet dataset;
            try
            {
                Connection connection = new Connection();
                if (!string.IsNullOrEmpty(ID + ""))
                {
                    string query = "select * from tblBankAccounts where ID='" + ID + "'";
                    dataset = connection.DataAdapterReader(query, "Customers");
                }
                else
                {
                    string s = "You must insert an ID or press the Reload Button";
                    Exception exception = new Exception(s);
                    throw exception;
                }
            }
            catch (EmptyDataSetException ex)
            {
                string s = "There is No Customer with this ID";
                ex = new EmptyDataSetException(s);
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return dataset;
        }

        public static DataSet SearchForCustomers(Customer customer)
        {
            DataSet dataset;
            try
            {
                Connection connection = new Connection();
         
                if (customer.getId() != 0 || customer.getName() != null || customer.getAge() != 0 || customer.getBalance() != 0)
                {
                    string StoredProcedureName = "sp_SearchForCustomer";
                    dataset = connection.ExecuteSearchStoredProcedures(StoredProcedureName, customer);
                }
                else
                {
                    string s = "You must insert a criteria in the search boxes or press the Load All Data Button";
                    Exception exception = new Exception(s);
                    throw exception;
                }
            }
            catch (EmptyDataSetException ex)
            {
                string s = "There is No Customer with this Name";
                ex = new EmptyDataSetException(s);
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return dataset;
        }


        public static DataSet SearchForCustomersByAge(int age)
        {
            DataSet dataset;
            try
            {
                Connection connection = new Connection();
                if (!string.IsNullOrEmpty(age + ""))
                {
                    string query = "select * from tblBankAccounts where age='" + age + "'";
                    dataset = connection.DataAdapterReader(query, "Customers");
                }
                else
                {
                    string s = "You must insert an Age or press the Reload Button";
                    Exception exception = new Exception(s);
                    throw exception;
                }
            }
            catch (EmptyDataSetException ex)
            {
                string s = "There is No Customer with this Age";
                ex = new EmptyDataSetException(s);
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return dataset;
        }



        public static DataSet SearchForCustomersByBalance(int balance)
        {
            DataSet dataset;
            try
            {
                Connection connection = new Connection();
                if (!string.IsNullOrEmpty(balance + ""))
                {
                    string query = "select * from tblBankAccounts where Balance='" + balance + "'";
                    dataset = connection.DataAdapterReader(query, "Customers");
                }
                else
                {
                    string s = "You must insert an Balance or press the Reload Button";
                    Exception exception = new Exception(s);
                    throw exception;
                }
            }
            catch (EmptyDataSetException ex)
            {
                string s = "There is No Customer with this Balance";
                ex = new EmptyDataSetException(s);
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return dataset;
        }



        public static DataSet ReloadCustomerData()
        {
            DataSet dataset;
            try
            {
                string query = "select * from tblBankAccounts;";
                Connection connection = new Connection();
                dataset = connection.DataAdapterReader(query, "Customers");

            }
            catch (EmptyDataSetException ex)
            {
                string s = "Reload again OR check the server connection";
                ex = new EmptyDataSetException(s);
                throw ex;
            }
            return dataset;
        }

        public static string InsertNewCustomer(Customer customer)
        {
            string StringID;
            try
            {
                Connection connection = new Connection();
                string query = "insert into tblBankAccounts values ('" + customer.getName() + "','" + customer.getAge() + "','" + customer.getBalance() + "')";
                connection.ExecuteNonQuery(query);
                query = "select @ID=ID from tblBankAccounts where Name='" + customer.getName() + "' and Age='" + customer.getAge() + "' and Balance='" + customer.getBalance() + "'";
                StringID = connection.ExecuteQuery(query, "Int", "ID");
                int ID;
                bool check = int.TryParse(StringID, out ID);
                if (check == true)
                {
                    customer.setID(ID);
                }
                else
                {
                    throw new ZeroRowsAffectedException();
                }
            }
            catch (ZeroRowsAffectedException ex)
            {
                string s = "The Customer has not been inserted ";
                ex = new ZeroRowsAffectedException(s);
                throw ex;
            }
            return StringID;
        }

        public static void DeleteCustomer(Customer customer)
        {
            try
            {
                string query = "delete from tblBankAccounts where ID='" + customer.getId() + "'";
                Connection connection = new Connection();
                connection.ExecuteNonQuery(query);
            }
            catch (ZeroRowsAffectedException ex)
            {
                string s = "There is NO Customer with ID = '" + customer.getId() + "'";
                ex = new ZeroRowsAffectedException(s);
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void UpdateCusomterData(Customer customer)
        {
            try
            {
                string query = "update tblBankAccounts set Name='" + customer.getName() + "', Age='" + customer.getAge() + "',Balance='" + customer.getBalance() + "' where ID='" + customer.getId() + "'";
                Connection connection = new Connection();
                connection.ExecuteNonQuery(query);
            }
            catch (ZeroRowsAffectedException ex)
            {
                string s = "No Customer with ID = '" + customer.getId() + "'";
                ex = new ZeroRowsAffectedException(s);
                throw ex;
            }
        }

        public static void TransferMoney(string TransferingID, string receivingID, string Amount)
        {
            try
            {
                string[] queries = new string[2];
                string query = "update tblBankAccounts set Balance=Balance-'" + Amount + "' where ID='" + TransferingID + "'";
                queries[0] = query;

                string query2 = "update tblBankAccounts set Balance=Balance+'" + Amount + "' where ID='" + receivingID + "'";
                queries[1] = query2;

                Connection connection = new Connection();
                connection.ExecuteTransaction(queries);

            }
            catch (ZeroRowsAffectedException ex)
            {
                ex = new ZeroRowsAffectedException("Transfer Failed Due to wrong ID number entered");
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
    }
}
