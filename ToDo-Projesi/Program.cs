using System;


namespace ToDo_Projesi
{
    class Program
    {
        public Program()
        {
        }

        static void Main(string[] args)
        {
            Kart kart1 = new Kart("Evi Boya","25 Ekim'de evi boya","Recep Şahin",Boyutlar.XL);
            Kart kart2 = new Kart("Matematik Sınavına Çalış","26 Ekim'de matematik sınavına çalış","Ömer Reis",Boyutlar.M);
            Kart kart3 = new Kart("Faturaları öde","27 Ekim'de faturaları öde","Onur Alper",Boyutlar.XS);
            Kolonlar.inProgressLine.Add(kart1,kart1.AtananKisi);
            Kolonlar.toDoLine.Add(kart2,kart2.AtananKisi);
            Kolonlar.toDoLine.Add(kart3,kart3.AtananKisi);
            AnaMenu();    
        }

        public static void AnaMenu()
        {
            Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz :)");
            Console.WriteLine("*******************************************");
            Console.WriteLine("(1) Board Listelemek");
            Console.WriteLine("(2) Board'a Kart Eklemek");
            Console.WriteLine("(3) Board'dan Kart Silmek");
            Console.WriteLine("(4) Kart Taşımak");
            
            switch (Console.ReadLine())
            {
                case "1":
                    BoardListeleme.boardListelemeEkrani();
                    break;
                case "2":
                    BoardKartEkleme.BoardKartEklemeEkrani();
                    break;
                case "3":
                    BoardKartSilme.boardKartSilmeEkrani();
                    break;
                case "4":
                    KartTasima.kartTasimaEkrani();
                    break;
                
                default:
                    Console.WriteLine("Yanlış veri girdiniz. Lütfen tekrar deneyiniz.");
                    break;
            }
        }  
    }
}
