using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attributes
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer { Id = 1, LastName = "Demirog", Age = 32 };
            CustomerDal customerDal = new CustomerDal();
            customerDal.Add(customer);
            Console.ReadLine();
        }
    }
    [ToTable("Customers")]
    [ToTable("TblCustomer")]
    class Customer
    {  
        
        public int Id { get; set; }
        [RequiredProperty]//zorunlu anlamına geliyor
        public string Firstname { get; set; }
        [RequiredProperty]
        public string LastName { get; set; }
        [RequiredProperty]
        public int Age { get; set; }
    }
    class CustomerDal
    {
        //bunu kullanmamak için uyarı
        [Obsolete("Dont use Add,insted use Addnew Method")]
        public void Add(Customer customer)
        {

            Console.WriteLine("{0},{1},{2},{3} Added!", customer.Id, customer.Firstname, customer.LastName, customer.Age);

        }
        public void AddNew(Customer customer)
        {
            Console.WriteLine("{0},{1},{2},{3} Added!", customer.Id, customer.Firstname, customer.LastName, customer.Age);
        }

    }                                        //iki kere kullanabilmeyi aktif yapmak içim"true" kapatmak için"false" yapabiliriz
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = true)]//| yaptıgımız şekilde farklı şeylerde yazabiliriz
    class RequiredPropertyAttribute : Attribute
    {

    }
    [AttributeUsage(AttributeTargets.Class,AllowMultiple =true)]
    class ToTableAttribute : Attribute
    {
        private string _tableName;

        public ToTableAttribute(string tableName)
        {
            _tableName = tableName;
        }
    }
}
