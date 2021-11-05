using System;

namespace ODEV3
{
    class Program
    /*Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin (n).
    Sonrasında kullanıcıdan n adet kelime girmesi isteyin.
    Kullanıcının girişini yaptığı kelimeleri sondan başa doğru console'a yazdırın.
    */
    {
        static void Main(string[] args)
        {
            Console.Write("Lutfen pozitif bir sayi giriniz: ");
            int n = int.Parse(Console.ReadLine());
            string [] metinler = new string [n];
            int ct=0;
            for (int i = n-1; i >= 0; i--)
            {
                ct++;
                Console.Write("Lutfen {0}. kelimenizi giriniz:",ct);
                metinler[i] = Console.ReadLine(); 
            }
            Console.WriteLine("Girdiginiz kelimeler:");
            foreach (var kelime in metinler)
            {
                Console.WriteLine(kelime);
            }
        }
    }
}
