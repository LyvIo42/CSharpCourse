using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace  interfaces

{
    interface ICustomerDal
    {
        void Add();
        void Update();
        void Delete();
    }
    class SqlServerCustomerDal : ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("Sql Added");
        }

        public void Delete()
        {
            Console.WriteLine("Sql Update");
        }

        public void Update()
        {
            Console.WriteLine("Sql Delete");
        }
        class OracleCustomerDal : ICustomerDal
        {
            public void Add()
            {
                Console.WriteLine("Oracle Added");
            }

            public void Delete()
            {
                Console.WriteLine("Oracle Update");
            }

            public void Update()
            {
                Console.WriteLine("Oracle Delete");
            }
        }
        class CustomerManager
        {
            public void Add(ICustomerDal customerDal)
            {
                customerDal();
            }
        }


    }
}
