using System;

namespace InterfaceDeneme
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            OracleCustomerDal oracle = new OracleCustomerDal(); //ICustomerDal olarak tutulabilir.
            SqlServerCustomerDal sql = new SqlServerCustomerDal(); //ICustomerDal olarak tutulabilir.
            customerManager.Add(oracle);

            ICustomerDal[] customerDals = new ICustomerDal[] { new SqlServerCustomerDal(), new OracleCustomerDal(), new MySqlCustomerDal() };

            foreach (var customerDal in customerDals)
            {
                customerDal.Add();
            }
        }
    }
}