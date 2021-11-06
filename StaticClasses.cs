using System;

namespace StaticClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calisan Sayisi: {0}",Calisan.CalisanSayisi);
            Calisan calisan = new Calisan("Ayse","Yılmaz","IK");
            Console.WriteLine("Calisan Sayisi: {0}", Calisan.CalisanSayisi);
            Calisan calisan1 = new Calisan("Deniz", "Arda", "IK");
            Calisan calisan2 = new Calisan("Bekir", "Sancak", "IK");

            Console.WriteLine("Calisan Sayisi: {0}", Calisan.CalisanSayisi);

            Console.WriteLine("Toplama İşleminin Sonucu: {0}", Islemler.Topla(100, 200));
            Console.WriteLine("Çıkarma İşleminin Sonucu: {0}", Islemler.Cikar(400, 200));
        }
    }
    class Calisan
    {
        private static int calisanSayisi;

        public static int CalisanSayisi { get => calisanSayisi;}

        private string Ad;

        private string Soyad;

        private string Departman;

        static Calisan()
        {
            calisanSayisi = 0;
        }

        public Calisan(string ad, string soyad, string departman)
        {
            Ad = ad;
            Soyad = soyad;
            Departman = departman;
            calisanSayisi ++;
        }
    }

    static class Islemler
    {
        public static long Topla(int sayi1, int sayi2)
        {
            return sayi1 + sayi2;
        }

        public static long Cikar(int sayi1, int sayi2)
        {
            return sayi1 - sayi2;
        }
    }
}
