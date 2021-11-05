using System;

namespace StringMetodlari
{
    class Program
    {
        static void Main(string[] args)
        {
            string degisken = "Dersimiz CSharp, Hos Geldiniz";
            string degisken2 = "Dersimiz CSharp";
            // Length;
            Console.WriteLine(degisken.Length);

            // ToUpper, ToLower 
            Console.WriteLine(degisken.ToUpper());
            Console.WriteLine(degisken.ToLower());

            // Concat (Bağlar)
            Console.WriteLine(String.Concat(degisken,"Merhaba"));

            // Compare, CompareTo (Karşılaştırır)
            Console.WriteLine(degisken.CompareTo(degisken2)); // 0,1,-1
            Console.WriteLine(String.Compare(degisken,degisken2,true));
            Console.WriteLine(String.Compare(degisken,degisken2,false));

            // Contains (İçinde varmı yokmu bakar)
            Console.WriteLine(degisken.Contains(degisken2));
            Console.WriteLine(degisken.EndsWith("Hos geldiniz"));
            Console.WriteLine(degisken.StartsWith("Merhaba"));

            //IndexOf (verilen değerin indexini döndürür)
            Console.WriteLine(degisken.IndexOf("CS"));
            Console.WriteLine(degisken.LastIndexOf("i")); // sona en yakın i yi bul.


            //Insert
            Console.WriteLine(degisken.Insert(0,"Hello Darling"));

            //PadLeft , PadRight
            Console.WriteLine(degisken2.PadLeft(30, '*'));


            // Remove 
            Console.WriteLine(degisken.Remove(10));
            Console.WriteLine(degisken.Remove(5,3));
            Console.WriteLine(degisken.Remove(0,1));

            // Replace
            Console.WriteLine(degisken.Replace("CSharp","C#"));
            Console.WriteLine(degisken.Replace(" ","()"));

            //Split 
            Console.WriteLine(degisken.Split(' ')[1]);

            //Substring
            Console.WriteLine(degisken.Substring(4));
            Console.WriteLine(degisken.Substring(4,6));
        }
    }
}
