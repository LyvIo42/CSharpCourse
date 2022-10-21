using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlServer sqlServers = new SqlServer();
            sqlServers.Add();
            MySql mySqls = new MySql();
            mySqls.Add();

            Console.ReadLine();
        }

    }


    class MySql : DataBase
    {
    }

    class DataBase
    {

        public virtual void Add()
        {
            Console.WriteLine("Added By Default");

        }
        public virtual void Delete()
        {
            Console.WriteLine("Deleted By Default");
        }
    }
    class SqlServer : DataBase
    {
        public override void Add()
        {
            Console.WriteLine(" Sql Added By Default");
        }


    }
}


