using System;
namespace TelefonRehberiProjesi
{
    public class AramaYap
    {
        public static void aramaYapmaEkranı()
        {
            Console.WriteLine("Arama yapmak istediğiniz tipi seçiniz.");
            Console.WriteLine("**********************************************\n");
            Console.WriteLine("İsim veya soyisime göre arama yapmak için: (1)");
            Console.WriteLine("Telefon numarasına göre arama yapmak için: (2)");
            string cevap = Console.ReadLine();
            switch (cevap)
            {
                case "1":
                    Console.Write("Lütfen isim veya soyisim giriniz: ");
                    kisiBulma(Console.ReadLine());
                    break;
                case "2":
                    Console.Write("Lütfen telefon numarasını giriniz: ");
                    numaraBulma(Console.ReadLine());
                    break;
                default:
                    Console.WriteLine("Yanlış karakter girdiniz");
                    aramaYapmaEkranı();
                    break;
            }
        }

        public static void kisiBulma(string str)
        {
        
            bool f = true;
            foreach (Kisiler kisi in Kisiler.KisiList)
            {
                if (kisi.Isim == str || kisi.Soyisim == str)
                {   
                    if (f)
                    {
                        Console.WriteLine("Arama Sonuçlarınız:");
                        Console.WriteLine("**********************************************");
                    }
                    Console.WriteLine("İsim: {0}",kisi.Isim);
                    Console.WriteLine("Soyisim: {0}",kisi.Soyisim);
                    Console.WriteLine("Telefon Numarası: {0}",kisi.TelNo);
                    Console.WriteLine("-----------");
                    f = false;
                }
                
            }
            if (f)
            {
                kisiBulunamadi();
            }
            Console.WriteLine("\n* Ana ekrana dönmek için herhangi bir tuşa basınız...");
            Console.ReadLine();
            Menu.menuYazdir();
        }

        public static void numaraBulma(string numara)
        {
        
            bool f = true;
            foreach (Kisiler kisi in Kisiler.KisiList)
            {
                if (kisi.TelNo == numara )
                {   
                    if (f)
                    {
                        Console.WriteLine("Arama Sonuçlarınız:");
                        Console.WriteLine("**********************************************");
                    }
                    Console.WriteLine("İsim: {0}",kisi.Isim);
                    Console.WriteLine("Soyisim: {0}",kisi.Soyisim);
                    Console.WriteLine("Telefon Numarası: {0}",kisi.TelNo);
                    Console.WriteLine("-----------");
                    f = false;
                }
                
            }
            if (f)
            {
                kisiBulunamadi();
            }
            Console.WriteLine("\n* Ana ekrana dönmek için herhangi bir tuşa basınız...");
            Console.ReadLine();
            Menu.menuYazdir();
        }

        public static void kisiBulunamadi()
        {
            Console.WriteLine("Aradığınız krtiterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.");
            Console.WriteLine("* Aramayı sonlandırmak için : (1)");
            Console.WriteLine("* Yeniden denemek için      : (2)");
            string cevap = Console.ReadLine();
            switch (cevap)
            {
                case "1":
                    Menu.menuYazdir();
                    break;
                case "2":
                    aramaYapmaEkranı();
                    break;
                default:
                    Console.WriteLine("Yanlış karakter girdiniz");
                    kisiBulunamadi();
                    break;
            }

        }
    }
}