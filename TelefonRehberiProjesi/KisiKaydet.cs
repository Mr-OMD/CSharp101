using System;
namespace TelefonRehberiProjesi
{
    public class KisiKaydet
    {
        public static void kisiKaydetmeEkranı(){
            Console.Write("Lütfen isim giriniz: ");
            string isim = Console.ReadLine();
            Console.Write("Lütfen soyisim giriniz: ");
            string soyisim = Console.ReadLine();
            Console.Write("Lütfen telefon numarası giriniz: ");
            string telno = Console.ReadLine();
            KisiEkle(isim,soyisim,telno);
     
        }
        public static void KisiEkle(string isim , string soyisim, string telNo)
        { 
            Kisiler.KisiList.Add(new Kisiler(isim,soyisim,telNo));
            Console.WriteLine("***{0} {1} kişisi başarıyla eklenmiştir.***\n",isim,soyisim);
            Kisiler.KisiList.Sort((x,y)=> x.Isim.CompareTo(y.Isim));
            Menu.menuYazdir();

        }
    }
}