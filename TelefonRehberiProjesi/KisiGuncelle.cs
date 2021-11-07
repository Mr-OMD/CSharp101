using System;
namespace TelefonRehberiProjesi
{
    public class KisiGuncelle
    {
        public static void kisiGuncellemeEkranı()
        {
            Console.WriteLine("Lütfen numarasını güncellemek istediğiniz kişinin adını ya da soyadını giriniz: ");
            string str = Console.ReadLine();
            bool f = true;
            foreach (Kisiler kisi in Kisiler.KisiList)
            {
                if (kisi.Isim == str || kisi.Soyisim == str)
                {
                    guncellemeTuruSec(str,kisi);
                    f = false;
                    break;
                }
            }
            if (f)
            {
                kisiBulunamadi();
            }
        }

        public static void kisiBulunamadi()
        {
            Console.WriteLine("Aradığınız krtiterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.");
            Console.WriteLine("* Silmeyi sonlandırmak için : (1)");
            Console.WriteLine("* Yeniden denemek için      : (2)");
            string cevap = Console.ReadLine();
            switch (cevap)
            {
                case "1":
                    Menu.menuYazdir();
                    break;
                case "2":
                    kisiGuncellemeEkranı();
                    break;
                default:
                    Console.WriteLine("Yanlış karakter girdiniz");
                    kisiBulunamadi();
                    break;
            }

        }

        public static void guncellemeTuruSec(string metin,Kisiler kisi)
        {
            Console.WriteLine("* {0} kişisinin adını güncellemek için         : (1)",kisi.Isim+" "+kisi.Soyisim);
            Console.WriteLine("* {0} kişisinin soyadını güncellemek için      : (2)",kisi.Isim+" "+kisi.Soyisim);
            Console.WriteLine("* {0} kişisinin numarasını güncellemek için    : (3)",kisi.Isim+" "+kisi.Soyisim);
            string cevap = Console.ReadLine();
            switch (cevap)
            {
                case "1":
                    Console.Write("Yeni adı giriniz: ");
                    kisi.Isim = Console.ReadLine();
                    Kisiler.KisiList.Sort((x,y)=> x.Isim.CompareTo(y.Isim));
                    Console.WriteLine("***İşlem başarıyla tamamlandı***.\n");
                    Menu.menuYazdir();
                    break;
                case "2":
                    Console.Write("Yeni soyadı giriniz: ");
                    kisi.Soyisim = Console.ReadLine();
                    Kisiler.KisiList.Sort((x,y)=> x.Isim.CompareTo(y.Isim));
                    Console.WriteLine("***İşlem başarıyla tamamlandı.***\n");
                    Menu.menuYazdir();
                    break;
                case "3":
                    Console.Write("Yeni numarayı giriniz: ");
                    kisi.TelNo = Console.ReadLine();
                    Console.WriteLine("***İşlem başarıyla tamamlandı.***\n");
                    Menu.menuYazdir();
                    break;
                default:
                    Console.WriteLine("Yanlış karakter girdiniz");
                    kisiBulunamadi();
                    break;
            }
        }
    }
}