using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using BankCustomerApplication.DOT_Folder;

namespace BankCustomerApplication
{
    public partial class Connection : Component
    {
        SqlConnection connection;
        public Connection()
        {
            InitializeComponent();
            string connectionString = ConfigurationManager.ConnectionStrings["ConnectionTOHRDatabase"].ConnectionString;
            connection = new SqlConnection(connectionString);
        }

        public Connection(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

        public DataSet DataAdapterReader(string query, string TabelName)
        {
            DataSet DataSet;
            try
            {
                SqlDataAdapter SqlDataAdapter = new SqlDataAdapter(query, connection);
                DataSet = new DataSet();
                SqlDataAdapter.Fill(DataSet, TabelName);
                if (DataSet.Tables[TabelName].Rows.Count <= 0)
                {
                    EmptyDataSetException exception = new EmptyDataSetException();
                    throw exception;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return DataSet;
        }

        public int ExecuteNonQuery(string query)
        {
            int RowsAffected;
            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(query,connection);
                RowsAffected = cmd.ExecuteNonQuery();
                if (RowsAffected == 0)
                {
                    ZeroRowsAffectedException exception = new ZeroRowsAffectedException();
                    throw exception;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();
            }
            return RowsAffected;
        }

        public string ExecuteQuery(string query,string OutputDataType,string outputName)
        {
            string result;
            try
            {
                SqlCommand cmd = new SqlCommand(query, connection);
                SqlParameter outputParameter = new SqlParameter();
                outputParameter.ParameterName = outputName;
                switch (OutputDataType)
                {
                    case "Int": outputParameter.DbType = DbType.Int32; break;
                    case "Nvarchar": outputParameter.DbType = DbType.String; break;
                    case "Double": outputParameter.DbType = DbType.Double; break;
                    case "DateTime": outputParameter.DbType = DbType.DateTime; break;
                    case "double": outputParameter.DbType = DbType.Double; break;
                }
                outputParameter.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(outputParameter);
                connection.Open();
                cmd.ExecuteReader();
                result = outputParameter.Value.ToString();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();
            }
            return result;
        }

        public Boolean ExecuteTransaction(string[] queries)
        {
            Boolean CheckForCompletedTransaction=false;
            connection.Open();
            SqlTransaction transaction = connection.BeginTransaction();
            try {
                
                
                for(int i = 0; i < queries.Length; i++)
                {
                    SqlCommand cmd = new SqlCommand(queries[i], connection,transaction);
                    int x=cmd.ExecuteNonQuery();
                    if (x == 0)
                    {
                        ZeroRowsAffectedException exception = new ZeroRowsAffectedException("No Rows Affected");
                        throw exception;
                    }
                }
                CheckForCompletedTransaction = true;
                transaction.Commit();
            }
            catch (Exception ex)
            {
                transaction.Rollback();
                throw ex;
            }
            finally
            {
                connection.Close();
            }
            return CheckForCompletedTransaction;
            }

        public  DataSet ExecuteSearchStoredProcedures(String StoredProcedureName,Customer customer)
        {
            DataSet DataSet = new DataSet();
            SqlCommand command = new SqlCommand(StoredProcedureName, connection);
            command.CommandType = CommandType.StoredProcedure;
            if (customer.getId() == 0)
            {
                command.Parameters.AddWithValue("@ID",null);
            }
            else
            {
                command.Parameters.AddWithValue("@ID", customer.getId());
            }

            command.Parameters.AddWithValue("@Name", customer.getName());

            if (customer.getAge() == 0)
            {
                command.Parameters.AddWithValue("@Age", null);
            }
            else
            {
                command.Parameters.AddWithValue("@Age", customer.getAge());
            }

            if (customer.getBalance() == 0)
            {
                command.Parameters.AddWithValue("@Balance",null);
            }
            else
            {
                command.Parameters.AddWithValue("@Balance", customer.getBalance());
            }
                SqlDataAdapter SqlDataAdapter = new SqlDataAdapter(command);

            try {
     

                SqlDataAdapter.Fill(DataSet, "Customers");
                if (DataSet.Tables["Customers"].Rows.Count <= 0)
                {
                    EmptyDataSetException exception = new EmptyDataSetException();
                    throw exception;
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
            return DataSet;
        }
    }
    }
