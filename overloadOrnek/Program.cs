using System;
using System.Collections.Generic;

namespace overloadOrnek
{
    class Program
    {
        public static void bol(int a, int b)
        {
            if (a > b)
                Console.WriteLine(a / b);
            else
                Console.WriteLine(b / a);
        }

        public static void bol(string a)
        {
            int i = 0;
            string yeni = "";
            while (i < (a.Length / 2))
            {
                yeni += a[i].ToString();
                i++;
            }
            
            Console.WriteLine(yeni);
        }

        static void Main(string[] args)
        {
            string cevap;
            Console.WriteLine("Bir islem secin: \n 1-> Cumleyi Bol \n 2-> Sayilari Bol");
            cevap = Console.ReadLine();
            if(cevap == "1")
            {
                Console.WriteLine("Bir Cumle Girin:");
                string cumle = Console.ReadLine();
                bol(cumle);
            }
            else if(cevap == "2")
            {
                int a, b;
                Console.WriteLine("Ilk Sayiyi Girin:");
                a = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Ikinci Sayiyi Girin:");
                b = Convert.ToInt32(Console.ReadLine());
                bol(a, b);
            }
            Console.ReadLine();     
        }
    }
}