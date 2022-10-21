using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.List();
            Console.ReadLine();
            Product product = new Product { Id = 1, Name = "Laptop" };
        }

    }
    class CustomerManager
    {
        private int _count = 15;
        public CustomerManager(int count)
        {
            _count = count;
        }
        public CustomerManager()
        {

        }
        public void List()
        {
            Console.WriteLine("listed {0} items", _count);
        }
        public void Add()
        {
            Console.WriteLine("Added!");
        }

    }
    class Product()

    {
        public Product()
    {
    }
    private int _ İd;
    private string _Name;
        public Product(int id,string name)
        {
        _Id = id;
        _Name=name
        }
        public int Id { get; set; }
        public String Name { get; set; }

    }
    
    
    


}
