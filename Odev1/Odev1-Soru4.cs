using System;

namespace ODEV4
{
    class Program
    {
        /*Bir konsol uygulamasında kullanıcıdan bir cümle yazması isteyin.
         Cümledeki toplam kelime ve harf sayısını console'a yazdırın.
        */
        static void Main(string[] args)
        {
            Console.Write("Lutfen bir cumle giriniz: ");
            string cumlem = Console.ReadLine();
            int toplamHarf = 0;
            foreach (var karakter in cumlem)
            {
                toplamHarf++;
            }
            string [] kelimeler = cumlem.Split(' ');
            toplamHarf-=kelimeler.Length-1;
            Console.WriteLine("Kelime sayisi: "+kelimeler.Length);
            Console.WriteLine("Harf sayisi: "+toplamHarf);
        }
    }
}
