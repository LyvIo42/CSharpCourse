using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfaces
{
    class Program
    {


        static void Main(string[] args)
        {
            //IntarfacesIntro();
            //Demo();

            ICustomerDal[] customerDals = new ICustomerDal[2]
                {
                    new SqlServerCustomerDal(),
                    new OracleCustomerDAl(),

                };
            foreach ( var customerDal in customerDals)
            {
                customerDal.Add ();
            }


            Console.ReadLine();

        }

    internal class OracleCustomerDAl
    {
        public OracleCustomerDAl()
        {
        }
    }

    private static void Demo()
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(new OracleCustomer());
        }

        private static void IntarfacesIntro()
        {
            PersonManager manager = new PersonManager();
            Customer customer = new Customer
            {
                Id = 1,
                FirstName = "Samet",
                LastName = "Kocak",
                Adress = "Konya"
            };

            Student student = new Student
            {
                Id = 1,
                FirstName = "derin",
                LastName = "Kocak",
                departmant = "Computer Scienes"
            };
            manager.Add(customer);
            manager.Add(student);
        }

        interface IPerson
        {
            int Id { get; set; }
            string FirstName { get; set; }
            string LastName { get; set; }
        }
        class Customer : IPerson
        {
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Adress { get; set; }
        }
        class Student : IPerson
        {
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string departmant { get; set; }
        }
        class Worker : IPerson
        {
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Adress { get; set; }
            public string departmant { get; set; }
        }
        class PersonManager
        {
            public void Add (IPerson person)
            {
                Console.WriteLine(person.FirstName);
            }
        }


    }

    internal class OracleCuctomer
    {
        public OracleCuctomer()
        {
        }
    }
}
