using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace strings
{
    class Program
    {
        static void Main(string[] args)
        {
            //intro();
            string sentence = "My name is samet kocak";
            var result = sentence.Length;
            var result2 = sentence.Clone();

            sentence="My name is samett kocak";
            //metin arasında Ğ yazan yeri bulur
            bool result3 = sentence.EndsWith("s");
            // My name ile başlıyormu buna bakar
            bool result4 = sentence.StartsWith("My name");
            
            // metin içinde name yazısını arar
            var result5 = sentence.IndexOf("namee");
            //boşluk aramak için bulduğu ilk oşlugu sayar
            var result6 = sentence.IndexOf(" ");
            //aramaya sondan başlar
            var result7 = sentence.LastIndexOf(" ");
            //yazımızın başına yazı yazmak için yada başına koyduğumuz sayıya göre
            var result8 = sentence.Insert(0, "Hello,");
            // verilen sayıdan sonrasını al demek eğer sonrasını almak istiyorsak (3,4) şeklinde yazmalıyız
            var result9 = sentence.Substring(3);
            //bütün karakterleri küçüge çevirir
            var result10 = sentence.ToLower();
            //bütün karakterlerin büyük yazmasını saglar
            var result11 = sentence.ToUpper();
            // yazının boşluklara tanımladıgımız şeyleri koyar
            var result12 = sentence.Replace(" ", "-");
            //yazdıgımız sayıdansonra atmaya yarar
            var result13 = sentence.Remove(3,7);
           
       

            Console.WriteLine(result13);
            Console.ReadLine();
        }

        //private static void Intro()
        //{
        //    string city = "Ankara";
        //    foreach (var item in city)
        //    {
        //        Console.WriteLine(item);

        //    }
        //    string city2 = "İstanbul";
        //    string result = city + city2;
        //    Console.WriteLine(string.Format({0},{ 1},city,city2);
            
        //}

        
    }
}
