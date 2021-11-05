using System;
using System.Collections;
using System.Collections.Generic;

namespace arrayList
{
    class Program
    {
        static void Main(string[] args)
        {   
            // ArrayList de her türden veriyi depolayabiliyoruz.
            ArrayList list = new ArrayList();
            //list.Add("Ayşe");
            //list.Add(232);
            //list.Add(true);
            //list.Add('A');

            // İçerisinde verilere erişim
            //Console.WriteLine(list[1]);
            //foreach (var item in list)
            //{
            //    Console.WriteLine(item);
            //}
            // AddRange

            Console.WriteLine("******** ADD RANGE ***********");
            //string[] renkler = { "Kırmızı", "Sarı", "Yeşil" };
            //list.AddRange(renkler);

            List<int> sayilar = new List<int> { 1, 2, 5, 6, 8, 123, 3 };
            list.AddRange(sayilar);
            
            Console.WriteLine("==========================");
            foreach (var value in list)
            {
                Console.WriteLine(value);
            }
            //Sort
            Console.WriteLine("******* SORT *******");
            list.Sort();
            foreach (var value in list)
            {
                Console.WriteLine(value);
            }
            // ArrayList risklerinden bir tanesi içini karma karışık verilerle doldurduğumuzda sıralamakda zorlanıcakdır.
            // O yüzden suan sıralarsak patlayacakdır run time'da .

            // Binary Search 

            Console.WriteLine("******* Binary Search *********");
            Console.WriteLine(list.BinarySearch(123));
            // Reverse 
            Console.WriteLine("********* REVERSE ********");
            list.Reverse();
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            //Clear
            Console.WriteLine("******** CLEAR *********");
            list.Clear();
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }     
        }       
    }
}
