using System;

namespace ToDo_Projesi
{
    public static class BoardKartEkleme
    {
        public static void BoardKartEklemeEkrani()
        {
            
            Console.Write("Başlık Giriniz                                  : ");
            string baslik = Console.ReadLine();
            Console.Write("İçerik Giriniz                                  : ");
            string icerik = Console.ReadLine();
            
            
            Enum buyukluk = boyutSec();

            string atananKisi = kisiSec();
            
            

            Kart yeniKart = new Kart(baslik,icerik,atananKisi,buyukluk);
            Kolonlar.toDoLine.Add(yeniKart,yeniKart.AtananKisi);
            Console.WriteLine("***Board'a kart eklendi***");
            Console.WriteLine("\nAna ekrana dönmek için    : (Enter)");
            Console.ReadLine();

            Program.AnaMenu();
        }

        static Enum boyutSec()
        {
            Console.Write("Büyüklük Seçiniz -> XS(1),S(2),M(3),L(4),XL(5)  : ");
            Enum boyut = null;
            switch (int.Parse(Console.ReadLine()))
            {
                case 1:
                    boyut = Boyutlar.XS;
                    break;
                case 2:
                    boyut = Boyutlar.S;
                    break;
                case 3:
                    boyut = Boyutlar.M;
                    break;
                case 4:
                    boyut = Boyutlar.L;
                    break;
                case 5:
                    boyut = Boyutlar.S;
                    break;
                default:
                    Console.WriteLine("Hatalı giriş yaptınız.\n");
                    boyutSec();
                    break;
            }
            return boyut;
        }

        static string kisiSec()
        {
            Console.Write("Kişi Seçiniz                                    : ");
            string id = Console.ReadLine();
            
            if (Kisiler.takimUyeleri.ContainsKey(id))
            {   
                if (Kolonlar.toDoLine.ContainsValue(Kisiler.takimUyeleri[id]) || Kolonlar.inProgressLine.ContainsValue(Kisiler.takimUyeleri[id]) || Kolonlar.doneLine.ContainsValue(Kisiler.takimUyeleri[id]))
                {
                    Console.Write("Bu kişi zaten Board'da mevcut. Tekrar deneyin.\n");
                    return kisiSec();
                }
                else
                {
                    string atananKisi = Kisiler.takimUyeleri[id];
                    return atananKisi;
                }
                
            }
            else
            {
                Console.WriteLine("Hatalı girişler yaptınız. Lütfen tekrar deneyin\n");
                return kisiSec();
            }
        }
    }
}