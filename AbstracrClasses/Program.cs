using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstracrClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Databese databese = new Oracle();
            databese.Add();
            databese.Delete();
            Databese databese2 = new SqlServer();
            databese2.Add();
            databese2.Delete();
            Console.ReadLine();
        }
        abstract class Databese
        {
            public void Add()
            {
                Console.WriteLine("Added By Default ");
            }
            public abstract void Delete();
        }
        class SqlServer : Databese
        {
            public override void Delete()
            {
                Console.WriteLine("Deleted By Sql");
            }
        }
        class Oracle : Databese
        {
            public override void Delete()
            {
                Console.WriteLine("Deleted By Oracle");
            }
        }
    }
}
