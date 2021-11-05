using System;

namespace ODEV2
{
    class Program
    {
        /*Bir konsol uygulamasında kullanıcıdan pozitif iki sayı girmesini isteyin (n, m). 
        Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. 
        Kullanıcının girmiş olduğu sayılardan m'e eşit yada tam bölünenleri console'a yazdırın.
        */
        static void Main(string[] args)
        {
            Console.Write("Pozitif sayı giriniz: ");
            int n=Convert.ToInt32(Console.ReadLine());
             Console.Write("Pozitif sayı giriniz: ");
            int m=Convert.ToInt32(Console.ReadLine());
            int[] sayilar=new int[n];
            Console.WriteLine("{0} adet sayi giriniz",n);

            for(int i=0;i<n;i++){
                Console.Write("Lutfen {0}. sayiyi giriniz: ",i+1);
                sayilar[i]=int.Parse(Console.ReadLine());
            }
            Console.WriteLine("{0}'e eşit ve tam bölünen sayilar Bunlardır : ",m);
            foreach (var sayi in sayilar)
            {
                if(sayi%m==0&&sayi>0)
                {
                    Console.WriteLine(sayi);
                }
            }
        }
    }
}
