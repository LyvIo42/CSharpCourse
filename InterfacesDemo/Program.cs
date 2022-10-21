using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesDemo
    //solid interface segregation
{
    class Program
    {
        static void Main(string[] args)
        {
            IWorker[] workers = new IWorker[3]
               {
                new Manager(),
                new Worker(),
                new Robot()
               };
            foreach (var worker in workers)
            {
                worker.Work();
            }
            IEat[] eats = new IEat[2]
            {
                new Manager(),
                new Worker()
            };
            foreach (var eat in eats)

            {
                eat.Eat();
            }
            ISalary[] salarys = new ISalary[2]
            {
                new Manager(),
                new Worker()
            };
            foreach (var salary in salarys)
            {
                salary.Salary();
            }
            Console.ReadLine();
        }
        
    }
    interface IWorker
    {
        void Work();
    }
    interface IEat
    {
        void Eat();
        
    }
    interface ISalary
    {
        void Salary();
    }
    class Manager : ISalary, IEat, IWorker
    {
        public void Eat()
        {
            Console.WriteLine("ahmet");
        }

        public void Salary()
        {
            Console.WriteLine("ahmet");
        }

        public void Work()
        {
            Console.WriteLine("ahmet");
        }
    }

    class Worker : IWorker, IEat, ISalary
    {
        public void Eat()
        {
            Console.WriteLine("ahmet");
        }

        public void Salary()
        {
            Console.WriteLine("ahmet");
        }

        public void Work()
        {
            Console.WriteLine("ahmet");
        }
    }
    class Robot : IWorker
    {
        public void Work()
        {
            Console.WriteLine("ahmet");
        }
    }
    


}
