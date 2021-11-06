using System;
using System.Collections.Generic;
using System.Linq;

namespace Koleksiyon3
{
    /* Klavyeden girilen cümle içerisindeki sesli harfleri bir dizi içerisinde saklayan
    ve dizinin elemanlarını sıralayan programı yazınız.
    */
    class Program
    {
        static void Main(string[] args)
        {
            List<Char> sesliList = new List<char>();
            string sesliharf = "aeıioöuü";
            Console.Write("Bir cümle giriniz: ");
            string myStr = Console.ReadLine();
            foreach (char karakter in myStr)
            {
                foreach (char sesli in sesliharf)
                {
                    if (karakter == sesli)
                    {
                        sesliList.Add(karakter);
                    }
                }
            }
            sesliList.Sort();
            sesliList.ForEach(s => Console.Write(s+" "));
            //List<char> harfler=str.ToList<char>();
        }
    }
}
