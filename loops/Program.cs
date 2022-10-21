using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loops
{
    class Program
    {
        static void Main(string[] args)
        {
            //forloop();
            //whileloops();
            //DowWhileLoop
            //foreachLoop();
            if (IsPrimeNumber(6))
            {
                Console.WriteLine("this is prime number");
            }
            else
            {
                Console.WriteLine("this is not a prime number");
            }

            Console.ReadLine();
        }

            private static bool IsPrimeNumber(int number)
            {
                bool result = true;
                for (int i = 2; i < number - 1; i++)
                {
                    if (number % i == 0)
                    {
                        result = false;
                        i = number;
                    }
                }
                return result;
                Console.ReadLine();
            }



            private static void foreachLoop()
            {
                string[] students = new string[3] { "ahmet", "derin", "salih" };
                foreach (var student in students)
                {
                    Console.WriteLine(student);
                }
            }

            private static void DowWhileLoop() //DowWhileLoop
            {
                int number = 10;
                do
                {
                    Console.WriteLine(number);
                    number--;
                } while (number >= -0);
            }

            private static void WhileLoops() //whileloop
            {
                int number = 100;
                while (number >= 0)
                {
                    Console.WriteLine(number);
                    number--;
                }
                Console.WriteLine("now number is {0}", number);
            }

            private static void forloop() //forloop
            {
                //for (int i = 2; i <= 100; i = i + 2)
                //tersden sayma için
                for (int i = 100; i >= 0; i = i - 2)
                {
                    Console.WriteLine(i);

                }
                Console.WriteLine("finished!!");
            }
        
    }
}
