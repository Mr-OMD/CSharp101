using System;

namespace Siniflar
{
    class Program
    {
        static void Main(string[] args)
        {
            Calisan calisan1 = new Calisan();
            calisan1.Adi = "Ayşe";
            calisan1.Soyadi = "Sancak";
            calisan1.TelNo = 2354576;
            calisan1.Departman = "Insan Kaynaklari";
            calisan1.CalisanBilgileri();

            Calisan calisan2 = new Calisan();
            calisan2.Adi = "Deniz";
            calisan2.Soyadi = "Arda";
            calisan2.TelNo = 2394578;
            calisan2.Departman = "Satın Alma Departmanı";
            calisan2.CalisanBilgileri();
        }
        class Calisan
        {
            public string Adi;
            public string Soyadi;
            public int TelNo;
            public string Departman;
            public void CalisanBilgileri()
            {
                Console.WriteLine("Calışanın Adi: {0}", Adi);
                Console.WriteLine("Calışanın Soyadi: {0}", Soyadi);
                Console.WriteLine("Calışanın TelNo: {0}", TelNo);
                Console.WriteLine("Çalışanın Departmanı: {0}", Departman);
                
            }
        }
    }
}
