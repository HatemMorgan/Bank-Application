using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankCustomerApplication
{
    class ZeroRowsAffectedException : Exception
    {
        public ZeroRowsAffectedException(string ExceptionMessage) : base(ExceptionMessage)
        {

        }
        public ZeroRowsAffectedException() : base()
        {

        }
    }
}
