using System;
using System.Collections.Generic;

namespace GenericCollectionsAndList
{
    class Program
    {
        static void Main(string[] args)
        {
            // List<T> class
            // System.Collections.Generic
            // T -> object türündedir.

            List<int> sayiListesi = new List<int>();
            sayiListesi.Add(23);
            sayiListesi.Add(10);
            sayiListesi.Add(4);
            sayiListesi.Add(5);
            sayiListesi.Add(92);
            sayiListesi.Add(34);

            List<string> renkListesi = new List<string>();
            renkListesi.Add("Kırımızı");
            renkListesi.Add("Mavi");
            renkListesi.Add("Turuncu");
            renkListesi.Add("Sarı");
            renkListesi.Add("Yeşil");

            // Count
            Console.WriteLine(renkListesi.Count);
            Console.WriteLine(sayiListesi.Count);
            foreach (var sayi in sayiListesi)
            {
                Console.Write(sayi+",");
            }
            Console.WriteLine();
            foreach (var renk in renkListesi)
            {
                Console.WriteLine(renk);
            }
            sayiListesi.ForEach(sayi => Console.WriteLine(sayi));
            renkListesi.ForEach(renk => Console.WriteLine(renk));

            // Listeden Eleman Çıkarma (Değer'e göre) 
            sayiListesi.Remove(4);
            renkListesi.Remove("Yeşil");

            // İndex'e göre Eleman çıkarma
            sayiListesi.RemoveAt(0);
            sayiListesi.RemoveAt(1);
            renkListesi.RemoveAt(0);

            //Liste içerisinde arama
            if (sayiListesi.Contains(10))
            {
                Console.WriteLine("10 Liste içerisinde bulundu!");
            }
            // Eleman ile index'e erişme
            Console.WriteLine(renkListesi.BinarySearch("Kırımızı"));

            //Diziyi List'e Çevirme
            string[] hayvanlar = { "Kedi", "Köpek", "Kuş" };
            List<string> hayvanListesi = new List<string>(hayvanlar);

            hayvanListesi.ForEach(hayvan => Console.WriteLine(hayvan));
            List<Users> userList = new List<Users>();

            Users user1 = new Users();
            user1.Isim = "Ayşe";
            user1.Soyisim = "Yılaz";
            user1.Yas = 26;

            Users user2 = new Users();
            user1.Isim = "Yelda";
            user1.Soyisim = "Terlikçi";
            user1.Yas = 30;

            userList.Add(user1);
            userList.Add(user2);
        }
        public class Users
        {   
            //Encapsulation 
            // Değerleri private hale getirdik.Dışardan ulaşılamaması için.
            private string isim;
            private string soyisim;
            private int yas;

            public string Isim { get => isim; set => isim = value; }
            public string Soyisim { get => soyisim; set => soyisim = value; }
            public int Yas { get => yas; set => yas = value; }
        }
    }
}
