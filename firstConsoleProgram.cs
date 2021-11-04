using System;

namespace Console_Programming
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Adı: ");
            string name=Console.ReadLine();
            Console.WriteLine("Soyadı: ");
            string surname=Console.ReadLine();

            Console.WriteLine("hello detective " + name + " " + surname);
        }
        
    }
}
