using System;
using System.Collections.Generic;
using System.Linq;

namespace Koleksiyon1
{
    /*Soru - 1: Klavyeden girilen 20 adet pozitif sayının asal ve asal olmayan olarak 2 ayrı listeye atın.
     (ArrayList sınıfını kullanara yazınız.)

        Negatif ve numeric olmayan girişleri engelleyin.
        Her bir dizinin elemanlarını büyükten küçüğe olacak şekilde ekrana yazdırın.
        Her iki dizinin eleman sayısını ve ortalamasını ekrana yazdırın.
    */
    class Program
    {
        static void Main(string[] args)
        {
            List<int> asalSayilar=new List<int>();
            List<int> asalOlmayanSayilar=new List<int>();
            int sayi=0;
            bool Flag=false;
            for(int i=1;i<=20;i++){
                while(Flag==false){
                    Console.Write("{0}. sayiyi giriniz: ",i);
                    Flag=Int32.TryParse(Console.ReadLine(),out sayi);
                    if(sayi<0 || Flag==false){
                        Flag=false;
                        Console.WriteLine("!!!HATA!!! Negatif veya non-numeric değer girmeden tekrar deneyiniz!");
                    }
                }
                Flag=false;
                if (asalBul(sayi)){
                        asalSayilar.Add(sayi);
                }
                else{
                        asalOlmayanSayilar.Add(sayi);
                }
            }         
            Console.WriteLine("---ASAL SAYILAR---");
            asalSayilar.Reverse();
            asalSayilar.ForEach(n => Console.Write(n+"-"));
            Console.WriteLine("");
            Console.WriteLine("Asal Sayilar Count:"+ asalSayilar.Count);
            Console.WriteLine("Asal Sayilar Average:"+ asalSayilar.Average());

            Console.WriteLine("---ASAL OLMAYAN SAYILAR---");
            asalOlmayanSayilar.Reverse();
            asalOlmayanSayilar.ForEach(n => Console.Write(n+"-"));
            Console.WriteLine("");
            Console.WriteLine("Asal Olmayan Sayilar Count:"+ asalOlmayanSayilar.Count);
            Console.WriteLine("Asal Olmayan Sayilar Average:"+ asalOlmayanSayilar.Average());
        }

        static bool asalBul(int s){
            if (s < 2){
                return false;
            }
            for (int i = 2; i <=s/2; i++){
                if (s % i == 0){
                    return false;
                }
            }
            return true;
        }
    }
}
