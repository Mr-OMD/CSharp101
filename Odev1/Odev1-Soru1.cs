using System;

namespace ODEV1
{
    class Program
    {
        /*Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin(n).
        Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin.
        Kullanıcının girmiş olduğu sayılardan çift olanlar console'a yazdırın.*/
        static void Main(string[] args)
        {
            Console.Write("Pozitif sayı giriniz: ");
            int n=Convert.ToInt32(Console.ReadLine());
            int[] sayilar=new int[n];
            Console.WriteLine("{0} adet sayi giriniz",n);

            for(int i=0;i<n;i++){
                Console.Write("Lutfen {0}. sayiyi giriniz: ",i+1);
                sayilar[i]=int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Cift Sayilar Bunlardır : ");
            foreach (var sayi in sayilar)
            {
                if(sayi%2==0)
                {
                    Console.WriteLine(sayi);
                }
            }
        }
    }
}
