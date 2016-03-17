using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankCustomerApplication.DOT_Folder
{
  public  class Customer
    {
        private int _id;
        private string _name;
        private int _age;
        private int _balance;



        public Customer()
        {
            this._id =0;
            this._name =null;
            this._age =0;
            this._balance = 0;
        }

        public int getId()
        {
            return _id;
        }

        public void setID(int value)
        {
            _id = value;
        }

        public string getName()
        {
            return _name;
        }

        public void setName(string value)
        {
            _name = value;
        }

        public int getAge()
        {
            return _age;
        }

        public void setAge(int value)
        {
            _age = value;
        }

        public int getBalance()
        {
            return _balance;
        }

        public void setBalance(int value)
        {
            _balance = value;
        }
    }
}
