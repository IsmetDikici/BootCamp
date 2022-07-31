using System;

namespace Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer { ID=1, FirstName="İsmet", LastName= "Dikici", City="İstanbul" };

            Customer customer2 = new Customer (2,"Hayrullah","Doğan","Bolu");

            Console.WriteLine(customer1.FirstName);
            Console.WriteLine(customer2.FirstName);
        }
    }

    class Customer
    {
        public Customer()
        {

        }
        public Customer(int id, string firstName, string lastName, string city)
        {
            ID = id;
            FirstName = firstName;
            LastName = lastName;
            City = city;
            
        }
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }

    }
}