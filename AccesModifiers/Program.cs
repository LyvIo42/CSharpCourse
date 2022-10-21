using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesModifiers
{
    class Program
    {
        static void Main(string[] args)
        {
        }



    }
    class Customer
    {
        //private sadece tanımlanan alanda kullanılabilir
        //protected is inheritane yaptıgımız yani örnegin "Sutuden:costumer yaptıgımızda " Student classındada gözükecektir. 
        protected int İd { get; set; }
        public void Save()
        {

        }
        public void Delete()
        {

        }

    }
    
    class Student : Customer

    {
        public void Save2()
        {

        }
    }

    

    public class Course
    {
        public void name{ get; set; }


    }
}
