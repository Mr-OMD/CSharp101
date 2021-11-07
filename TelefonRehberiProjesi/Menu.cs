using System;

namespace TelefonRehberiProjesi{

    public static class Menu{
        public static void menuYazdir(){
            Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz :)");
            Console.WriteLine("***********************************************");
            Console.WriteLine("(1) Yeni Numara Kaydet");
            Console.WriteLine("(2) Varolan Numarayı Sil");
            Console.WriteLine("(3) Varolan Numarayı Güncelle");
            Console.WriteLine("(4) Rehberi Listele");
            Console.WriteLine("(5) Rehberde Arama Yap");
            Console.WriteLine("Seçiminiz: ");
            menuSecimi();
        }

        public static void menuSecimi(){
            int secilenSayi=0;
            bool f=false;
            while (f==false){
                f=Int32.TryParse(Console.ReadLine(),out secilenSayi);
                if(f==false)
                    Console.WriteLine("Geçersiz giriş yaptınız. Lütfen tekrar deneyiniz! Seçiminiz: ");
            }
            menuGecis(secilenSayi);
            
        }
        public static void menuGecis(int sayi){
            switch(sayi){
                case 1:
                    KisiKaydet.kisiKaydetmeEkranı();
                    break;
                case 2:
                    KisiSil.kisiSilmeEkranı();
                    break;
                case 3:
                    KisiGuncelle.kisiGuncellemeEkranı();
                    break;
                case 4:
                    KisileriListele.rehberListele();
                    break;
                case 5:
                    AramaYap.aramaYapmaEkranı();
                    break;
                default:
                    Console.WriteLine("Geçersiz giriş yaptınız. Lütfen tekrar deneyiniz! Seçiminiz: ");
                    menuSecimi();
                    break;
            }
        }

        

    }
}