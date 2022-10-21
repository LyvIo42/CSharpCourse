using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrays
{
    class Program
    {
        private static bool student;

        static void Main(string[] args)
        {
            string[] students = new string[3] { "engin", "derin", "salih" };
            //string[] students2 = { "engin", "derin", "salih" };

            //foreach (var student in students2)
            //{
            //    Console.WriteLine(student);

            //}

            string[,] regions = new string[5, 3]
            {
                {"istanbul","koceli","edirne" },
                { "ankara","konya","kırıkkale" },
                { "rize","trabzon","giresun" },
                { "antalya","adana","mersin" },
                { "izmir","mugla","manisa" },

            };
            for (int i = 0; i <= regions.GetUpperBound(0); i++) 
            {
                for (int j = 0; j <= regions.GetUpperBound(1); j++)
                {
                    Console.WriteLine(regions[i, j]);
                }
                Console.WriteLine("*********");

            }

            
            Console.ReadLine();

        }
    }
}
