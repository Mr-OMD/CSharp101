using System;

namespace hata_yonetimi
{
    class Program
    {
        static void Main(string[] args)
        {
           //try
           //{
            //   Console.WriteLine("bir sayı gir:");
            //    int sayi = Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine("Girmiş olduğun sayı bu:" + sayi);
           //}
           //catch(Exception ex)
           //{
           //    Console.WriteLine("hata:"+ex.Message.ToString());
           //}
           //finally
           //{
             //  Console.WriteLine("İşlem tamamlandı.");
           //}    
            try
            {
               // int a = int.Parse(null);
               // int a = int.Parse("test");
                 int a = int.Parse("-20000000000");
            }
            catch (ArgumentNullException ex) 
            {
                Console.WriteLine("boş değer girdin.");
                Console.WriteLine(ex);
            }
            catch (FormatException ex) 
            {
                Console.WriteLine("veri tipi uygun değil.");
                Console.WriteLine(ex);
            }
            catch (OverflowException ex) 
            {
                Console.WriteLine("çok küçük yada çok büyük bir değer girdiniz.");
                Console.WriteLine(ex);
            }
            finally{
                Console.WriteLine("işlem başarıyla tamamlandı.");
            }
        }
    }
}
