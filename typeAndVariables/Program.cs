using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace typeAndVariables
{
    class Program
    {
        static void Main(string[] args)
        {
            //value types
            //Console.WriteLine("hello world");
            //var degişken tutmak için yarar
            var number7 = 10;
            

            // decimal veri türü , den sonra 29 tane değer tutabiliyor
            // decimal number6 = 9,02;

            //ondalıklı sayıları tutmak için
            Double number5 = 10.4;
            //char karakter veri tipi
            Char character = 'A';
            // mantıksal bir veri tipidir tuttugu veri tipi "true" yada "false"
            bool condition = false;
            //byte tipi ise 0 ile 255  sayı tutar
            byte number4 = 255;
            short number3 = -32678;
            int number1 = 10;
            //sayi yüksek oldugunda long ile yapabiliriz ve hata vermez"19" karakter
            long number2 = 121313213213;
            Console.WriteLine("Number1 is {0}", number1);
            Console.WriteLine("Number2 is {0}", number2);
            Console.WriteLine("Number3 is {0}", number3);
            Console.WriteLine("Number4 is {0}", number4);
            Console.WriteLine("Number5 is {0}", number5);
            Console.WriteLine("Character is  : {0}", character);
            Console.ReadLine();

        }
           
        
    }
}
