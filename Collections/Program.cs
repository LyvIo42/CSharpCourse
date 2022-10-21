using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            //ArrayList()
            //List();
            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            dictionary.Add("Book", "Kitap");
            dictionary.Add("Table", "Tablo");
            dictionary.Add("Computer", "Bilgisayar");
            foreach (var item in dictionary)
            {
                Console.WriteLine(item.Value);
            }
            Console.WriteLine(dictionary.ContainsKey("Glass"));
            Console.WriteLine(dictionary.ContainsKey("Table"));




            Console.WriteLine(dictionary["Table"]);
            //Console.WriteLine(dictionary["glass"]); böyle hata verir için olmadığı için
            Console.ReadLine();

        }

        private static void List()
        {
            
            List<string> cities = new List<string>();
            cities.Add("Ankara");
            cities.Add("İstanbul");
            //Console.WriteLine(cities.Contains("Ankara"));
            foreach (var city in cities)
            {
                Console.WriteLine(city);
            }
            //List<Customer> customers = new List<Customer>();
            //customers.Add(new Customer { Id = 1, FirstName = "Engin" });
            //customers.Add(new Customer { Id = 2, FirstName = "Derin" });

            //bu şekildede yazılabilir yukarıdaki

            List<Customer> customers = new List<Customer>
            {
                new Customer{Id=1,FirstName="Engin"},
                new Customer{Id=2,FirstName="Derin"}
            };



            var customer2 = new Customer
            {
                Id = 3,
                FirstName = "Salih"
            };
            customers.Add(customer2);
            customers.AddRange(new Customer[2]
                {
                    new Customer{Id=4,FirstName="Ali"},
                    new Customer{Id=5,FirstName="Ayşe" }
                });
            Console.WriteLine(customers.Contains(new Customer { Id = 1, FirstName = "Engin" }));
            //customers.Clear();

            customers.Insert(0, customer2);
            customers.RemoveAll(c => c.FirstName == "Salih");

            foreach (var customer in customers)
            {
                Console.WriteLine(customer.FirstName);
            }
            var count = customers.Count;
            Console.WriteLine("Count :{0}", count);
        }

        private static void ArrayList()
        {
            ArrayList cities = new ArrayList();
            cities.Add("Anakara");
            cities.Add("Adana");
            cities.Add("İstanbul");
            cities.Add(1);
            cities.Add("A");

            foreach (var city in cities)
            {
                Console.WriteLine(city);
            }
            

            //console.writeline(cities[2]);
        }
    }
    class Customer  
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
    }
}

