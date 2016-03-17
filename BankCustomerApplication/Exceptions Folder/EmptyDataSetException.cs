using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankCustomerApplication
{
    class EmptyDataSetException : Exception
    {
       
        public EmptyDataSetException():base()
        {

        }
        public EmptyDataSetException(string message) : base(message)
        {

        }
    }
}
