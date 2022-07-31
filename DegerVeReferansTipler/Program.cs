using System;

namespace DegerVeReferansTipler
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Referans Tip Örneği
            //int sayi1 = 10;
            //int sayi2 = 20;
            //sayi1 = sayi2;
            //sayi2 = 100;
            //Console.WriteLine(sayi1);

            //int[] sayilar1 = new int[] { 1, 2, 3 };
            //int[] sayilar2 = new int[] { 10, 20, 30 };
            //sayilar1 = sayilar2;
            //sayilar2[0] = 500;
            //Console.WriteLine(sayilar1[0]);
            #endregion
            #region C# İyi Programcı Serisi Referans Videosu
            Person person1 = new Person();
            Person person2 = new Person();
            person1.FirstName = "Engin";
            person2 = person1;
            person1.FirstName = "Derin";
            Console.WriteLine(person2.FirstName);

            Customer customer = new Customer();
            customer.FirstName = "Salih";
            customer.CreditCardNumber = "11111111111";
            Employee employee = new Employee();
            employee.FirstName = "İsmet";
            employee.LastName = "Dikici";
            employee.EmployeeNumber = 689;

            Person person3 = customer;
            customer.FirstName = "Ahmet";
            Person person4 = employee;

            Console.WriteLine(((Customer)person3).CreditCardNumber);
            Console.WriteLine(person4.FirstName + " " + person4.LastName + " " + ((Employee)person4).EmployeeNumber);

            PersonManager personManager = new PersonManager();
            personManager.Add(customer);
            #endregion


        }
    }

    class Person
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

    class Customer:Person
    {
        public string CreditCardNumber { get; set; }
    }

    class Employee:Person
    {
        public int EmployeeNumber { get; set; }
    }

    class PersonManager
    {
        public void Add(Person person)
        {
            Console.WriteLine(person.FirstName);
        }
    }
}