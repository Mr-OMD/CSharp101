using System;
using System.Collections.Generic;

namespace ToDo_Projesi
{
    public static class BoardKartSilme
    {
        public static void boardKartSilmeEkrani()
        {
            Console.WriteLine("Öncelikle silmek istediğiniz kartı seçmeniz gerekiyor.");
            Console.Write("Lütfen kart başlığını yazınız:  ");
            string baslik = Console.ReadLine();
            bool found = false;
            foreach (Kart kart1 in Kolonlar.toDoLine.Keys)
            {
                if (baslik == kart1.Baslik)
                {
                    found = true;
                    kartiSil(kart1,Kolonlar.doneLine);
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
                        kartiSil(kart2,Kolonlar.inProgressLine);
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
                            kartiSil(kart3,Kolonlar.doneLine);
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
        static void kartiSil(Kart kart,Dictionary<Kart,string> kolon)
        {
            kolon.Remove(kart);
            Console.WriteLine("***Kart silindi***");
            Console.WriteLine("\nAna ekrana dönmek için    : (Enter)");
            Console.ReadLine();
            Program.AnaMenu();
        }

        static void kartBulunamadi()
        {
            Console.WriteLine("\nAradığınız krtiterlere uygun kart board'da bulunamadı. Lütfen bir seçim yapınız.");
            Console.WriteLine("* Silmeyi sonlandırmak için : (1)");
            Console.WriteLine("* Yeniden denemek için : (2)");
            switch (Console.ReadLine())
            {
                case "1":
                    Program.AnaMenu();
                    break;
                case "2":
                    boardKartSilmeEkrani();
                    break;
                default:
                    Console.WriteLine("Yanlış giriş yaptınız. Lütfen tekrar deneyin");
                    kartBulunamadi();
                    break;
            }
        }
    }
}