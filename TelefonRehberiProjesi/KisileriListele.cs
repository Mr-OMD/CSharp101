using System;
namespace TelefonRehberiProjesi
{
    public class KisileriListele
    {
        public static void rehberListele(){
            Console.WriteLine("Telefon Rehberi");
            Console.WriteLine("**********************************************");
            

            foreach (Kisiler kisi in Kisiler.KisiList)
            {
                Console.WriteLine("İsim: {0}",kisi.Isim);
                Console.WriteLine("Soyisim: {0}",kisi.Soyisim);
                Console.WriteLine("Telefon Numarası: {0}",kisi.TelNo);
                Console.WriteLine("-----------");
            }

            Console.WriteLine("\n* Ana ekrana dönmek için herhangi bir tuşa basınız...");
            Console.ReadLine();
            Menu.menuYazdir();
        }
    }
}