using System;

namespace Kurucu_Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("");
            Console.WriteLine("******Calisan 1*******");
           
            Calisan calisan1 = new Calisan();
            calisan1.Adi = "Ayşe";
            calisan1.Soyadi = "Kara";
            calisan1.TelNo = 2354576;
            calisan1.Departman = "Insan Kaynaklari";
            calisan1.CalisanBilgileri();

            Console.WriteLine("");
            Console.WriteLine("******Calisan 2*******");
            Calisan calisan2 = new Calisan();
            calisan2.Adi = "Deniz";
            calisan2.Soyadi = "Arda";
            calisan2.TelNo = 2394578;
            calisan2.Departman = "Satın Alma Dep";
            calisan2.CalisanBilgileri();

            Console.WriteLine("");
            Console.WriteLine("******Calisan 3*******");
            Calisan calisan3 = new Calisan("Omer", "Mert", 354502727, "DevOps");
            calisan3.CalisanBilgileri();

            Console.WriteLine("");
            Console.WriteLine("******Calisan 4*******");
            Calisan calisan4 = new Calisan("Zikriye", "Ürkmez");
            calisan4.CalisanBilgileri();
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

            public Calisan()
            {}

            public Calisan(string ad, string soyad)
            {
                Adi = ad;
                Soyadi = soyad;
            }
            public Calisan(string ad,string soyad,int telno,string departman)
            {
                Adi = ad;
                Soyadi = soyad;
                TelNo = telno;
                Departman = departman;

            }
        }
    }
}
