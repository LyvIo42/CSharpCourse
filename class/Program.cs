using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @class
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManger customerManager = new CustomerManger();
            customerManager.Add();
            customerManager.Update();


            ProducManger producManager = new ProducManger();
            producManager.Add();
            producManager.Update();

            Customer customer = new Customer();
            customer.City = "Ankara";
            customer.Id = 1;
            customer.FirstName = "ahmet";
            customer.LastName = "çelik";


            Customer customer2 = new Customer()
            
            {
                Id = 2, City = "İstanbul", FirstName = "Samet" , LastName = "kocak"
            };
            Console.WriteLine(customer2.FirstName);



            Console.ReadLine();
        }
       



         
    
    }



    
}

