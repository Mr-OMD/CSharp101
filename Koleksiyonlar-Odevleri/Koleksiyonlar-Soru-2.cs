using System;
using System.Collections.Generic;
using System.Linq;

namespace Koleksiyon2
{
    /* Klavyeden girilen 20 adet sayının en büyük 3 tanesi ve en küçük 3 tanesi bulan,
    her iki grubun kendi içerisinde ortalamalarını alan
    ve bu ortalamaları ve ortalama toplamlarını console'a yazdıran programı yazınız.
    (Array sınıfını kullanarak yazınız.)
    */
    class Program
    {
        static void Main(string[] args)
        {
            List<int> sayilar=new List<int>();
            int sayi=0;
            bool Flag=false;
            for(int i=1;i<=20;i++){
                while(Flag==false){
                    Console.Write("{0}. sayiyi giriniz: ",i);
                    Flag=Int32.TryParse(Console.ReadLine(),out sayi);
                    if(Flag==false){
                        Console.WriteLine("!!!HATA!!! Non-numeric değer girmeden tekrar deneyiniz!");
                    }
                }
                Flag=false;
                sayilar.Add(sayi);
            }  
            sayilar.Sort();
            List<int> kucuk=sayilar.GetRange(0,3);
            sayilar.Reverse();
            List<int> buyuk=sayilar.GetRange(0,3);
            Console.WriteLine("---Kucuk Sayilar---");
            kucuk.ForEach(n =>Console.Write(n+" "));
            Console.WriteLine("");
            Console.WriteLine("Ortalama: "+kucuk.Average());
            Console.WriteLine("---Buyuk Sayilar---");
            buyuk.ForEach(n =>Console.Write(n+" "));
            Console.WriteLine("");
            Console.WriteLine("Ortalama: "+buyuk.Average());

            Console.WriteLine("TOPLAM ORTALAMA: "+(buyuk.Average()+kucuk.Average()));    
        }
    }
}
