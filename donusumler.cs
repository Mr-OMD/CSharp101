using System;

namespace tip_donusumleri
{
    class Program
    {
        static void Main(string[] args)
        {
            //  implicit Conversion (Bilinçsiz Dönüşüm) 

            byte a = 5;
            byte b = 30;
            short c = 10;

            int d = a+b+c;
            Console.WriteLine("d:" + d);

            long h = d;
            Console.WriteLine("h:" + h);

            float i = h;
            Console.WriteLine("i:" + i);

            string k = "kemal";
            char f = 'k';
            object g = k+f+d;
            Console.WriteLine("g:" + g);

            //Explicit Conversion (Bilinçli Dönüşüm)

            int x = 4;
            byte y = (byte)x;
            Console.WriteLine("y:" + y);
            
            int z = 100;
            byte t = (byte)z;
            Console.WriteLine("z:" +z);

            float w = 10.3f;
            byte v = (byte)w;
            Console.WriteLine("v:" +v);


            // ToString metodu
            
            int xx = 6;
            string yy = xx.ToString();
            Console.WriteLine("yy:" +yy);

            // System Convert 

            string s1="10", s2="20";
            int sayi1, sayi2;
            int toplam;
            
            sayi1 = Convert.ToInt32(s1);
            sayi2 = Convert.ToInt32(s2);

            toplam = sayi1 + sayi2;
            Console.WriteLine("toplam:" + toplam);
            
            //Parse Metod
            ParseMethod();
        }

        public static void ParseMethod()
        {
            string met1 = "10";
            string met2 = "20.25"; 
            int rak1;
            double dou1;

            rak1 = Int32.Parse(met1);
            dou1 = double.Parse(met2);

            Console.WriteLine("rak1:" + rak1);
            Console.WriteLine("rak2:" + dou1);


        }

    }
}
