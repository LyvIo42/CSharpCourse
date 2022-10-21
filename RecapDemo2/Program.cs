using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecapDemo2
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager costumerManager = new CustomerManager();
            costumerManager.Logger = new Sms();
            costumerManager.Add();
            Console.ReadLine();

        }
    }
    class CustomerManager

    {
        public ILogger Logger { get; set; }
        public void Add()

        {
            Logger.Log();

            Console.WriteLine("Customer Adedd!!");
        }



    }
    class DatabaseLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Logged Database!");
        }
    }
    class FileLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Logged File!");
        }
    }
    class SmsLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Logged Sms!");
        }
    }
    interface ILogger
    {
        void Log();
    }


}
