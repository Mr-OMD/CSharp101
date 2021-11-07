using System;
namespace TelefonRehberiProjesi
{
    public class KisiSil
    {
        public static void kisiSilmeEkranı(){
            Console.Write("Lütfen numarasını silmek istediğiniz kişinin adını ya da soyadını giriniz: ");
            string str = Console.ReadLine();
            bool f=true;
            foreach(Kisiler kisi in Kisiler.KisiList){
                if (kisi.Isim == str || kisi.Soyisim == str)
                {
                    silmeOnay(str,kisi);
                    f = false;
                    break;
                }
            }
            if(f)
                kisiBulunamadi();
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
                    kisiSilmeEkranı();
                    break;
                default:
                    Console.WriteLine("Yanlış karakter girdiniz");
                    kisiBulunamadi();
                    break;
            }
        }
        public static void silmeOnay(string str,Kisiler kisi)
        {
            Console.WriteLine("{0} isimli kişi rehberden silinmek üzere, onaylıyor musunuz ?(y/n)",(kisi.Isim+" "+kisi.Soyisim));
            
            string cevap = Console.ReadLine();

            switch (cevap)
            {
                case "y":
                    Console.WriteLine("***{0} {1} kişisi başarıyla silinmiştir.***\n",kisi.Isim,kisi.Soyisim);
                    Kisiler.KisiList.Remove(kisi);
                    Menu.menuYazdir();
                    break;
                case "n":
                    Console.WriteLine("***{0} {1} kişisi silinemedi. Menüye dönülüyor...***\n",kisi.Isim,kisi.Soyisim);
                    Menu.menuYazdir();
                    break;
                default:
                    Console.WriteLine("Yanlış karakter girdiniz");
                    silmeOnay(str,kisi);
                    break;
            }

        }

    }
}