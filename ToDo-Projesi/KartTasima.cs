using System;
using System.Collections.Generic;

namespace ToDo_Projesi
{
    public static class KartTasima
    {
        public static void kartTasimaEkrani()
        {
            Console.WriteLine("Öncelikle taşımak istediğiniz kartı seçmeniz gerekiyor.");
            Console.Write("Lütfen kart başlığını yazınız:  ");
            string baslik = Console.ReadLine();

            bool found = false;
            foreach (Kart kart1 in Kolonlar.toDoLine.Keys)
            {
                if (baslik == kart1.Baslik)
                {
                    found = true;
                    kartiTasi(kart1,Kolonlar.toDoLine,"TODO");
                    break;
                }
            }
            if (found == false)
            {
                foreach (Kart kart2 in Kolonlar.inProgressLine.Keys)
                {
                   if (baslik == kart2.Baslik)
                    {
                        found = true;
                        kartiTasi(kart2,Kolonlar.inProgressLine,"IN PROGRESS");
                        break;
                    } 
                }
                if (found == false)
                {
                    foreach (Kart kart3 in Kolonlar.doneLine.Keys)
                    {
                        if (baslik == kart3.Baslik)
                        {
                            found = true;
                            kartiTasi(kart3,Kolonlar.doneLine,"DONE");
                            break;
                        }
                    }
                    if (found == false)
                    {
                        kartBulunamadi();
                    }
                }
            }
        }

        static void kartiTasi(Kart kart,Dictionary<Kart,string> kolon,string kolonİsmi)
        {
            
            Console.WriteLine("\nBulunan Kart Bilgileri:");
            Console.WriteLine("**************************************");
            Console.WriteLine("Başlık      : {0}",kart.Baslik);
            Console.WriteLine("İçerik      : {0}",kart.Icerik);
            Console.WriteLine("Atanan Kişi : {0}",kart.AtananKisi);
            Console.WriteLine("Büyüklük    : {0}",kart.Boyut);
            Console.WriteLine("Line        : {0}",kolonİsmi);

            Console.WriteLine("\nLütfen taşımak istediğiniz Line'ı seçiniz:\n(1) TODO\n(2) IN PROGRESS\n(3) DONE");
            switch (Console.ReadLine())
            {
                case "1":
                    kolon.Remove(kart);
                    Kolonlar.toDoLine.Add(kart,kart.AtananKisi);
                    Console.WriteLine("***İşlem tamamlandı***\nYeni liste şu şekilde:\n");
                    BoardListeleme.boardListelemeEkrani();
                    break;
                case "2":
                    kolon.Remove(kart);
                    Kolonlar.inProgressLine.Add(kart,kart.AtananKisi);
                    Console.WriteLine("***İşlem tamamlandı***\nYeni liste şu şekilde:\n");
                    BoardListeleme.boardListelemeEkrani();
                    break;
                case "3":
                    kolon.Remove(kart);
                    Kolonlar.doneLine.Add(kart,kart.AtananKisi);
                    Console.WriteLine("***İşlem tamamlandı***\nYeni liste şu şekilde:\n");
                    BoardListeleme.boardListelemeEkrani();
                    break;
                default:
                    Console.WriteLine("Hatalı seçim yaptınız. Lütfen tekrar deneyin");
                    kartiTasi(kart,kolon,kolonİsmi);
                    break;
                
            }
        }

        static void kartBulunamadi()
        {
            Console.WriteLine("\nAradığınız krtiterlere uygun kart board'da bulunamadı. Lütfen bir seçim yapınız.");
            Console.WriteLine("* İşlemi sonlandırmak için : (1)");
            Console.WriteLine("* Yeniden denemek için : (2)");
            switch (Console.ReadLine())
            {
                case "1":
                    Program.AnaMenu();
                    break;
                case "2":
                    kartTasimaEkrani();
                    break;
                default:
                    Console.WriteLine("Yanlış giriş yaptınız. Lütfen tekrar deneyin");
                    kartBulunamadi();
                    break;
            }
        }
    }
}