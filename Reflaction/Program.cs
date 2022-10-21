using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Reflaction
{
    class Program
    {
        static void Main(string[] args)
        {
            //Dortİslem dortİslem = new Dortİslem(2, 3);
            //Console.WriteLine(dortİslem.Topla(3, 4));
            //Console.WriteLine(dortİslem.Topla2()); 

            var tip = typeof(Dortİslem);

            //Dortİslem dortİslem = (Dortİslem)Activator.CreateInstance(tip,6,7);
            //Console.WriteLine(dortİslem.Topla(4, 5));
            //Console.WriteLine(dortİslem.Topla2());

            var instance = Activator.CreateInstance(tip, 5, 4);
            MethodInfo methodInfo = instance.GetType().GetMethod("Topla2");
            Console.WriteLine(methodInfo.Invoke(instance, null));
            Console.WriteLine("----------------");

            var methodlar =  tip.GetMethods();
            foreach (var info in methodlar)
            {
                Console.WriteLine("Metod adı:{0}", info.Name);
                foreach (var parameterInfo in info.GetParameters())
                {
                    Console.WriteLine("Parametre adı:{0}", parameterInfo.Name);
                }
                foreach (var attribute in info.GetCustomAttributes())
                {
                    Console.WriteLine("Attribute Name:{0}", attribute.GetType().Name);
                }

            }
            
           

            Console.ReadLine();

        }
    }
    public class Dortİslem
    {
        private int _sayi1;
        private int _sayi2;
        public Dortİslem(int sayi1, int sayi2)
        {
            _sayi1 = sayi1;
            _sayi2 = sayi2;
        }
        public Dortİslem()
        {

        }
        public int Topla(int sayi1, int sayi2)
        {
            return sayi1 + sayi2;

        }
        public int Carp(int sayi1, int sayi2)
        {
            return sayi1 * sayi2;
        }
        public int Topla2()
        {
            return _sayi1 + _sayi2;
        }
        [MethodNameAttritube("carpma")]
        public int Carp2()
        {
            return _sayi1 * _sayi2;
        }

    }

    class MethodNameAttritube:Attribute
    {
        public MethodNameAttritube(string name)
        {
                
        }
    }
}
