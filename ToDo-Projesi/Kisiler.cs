using System.Collections.Generic;

namespace ToDo_Projesi
{
    public static class Kisiler
    {
        public static Dictionary<string,string> takimUyeleri;
        static Kisiler()
        {
            takimUyeleri  = new Dictionary<string, string>()
            {
                {"2019-1","Ömer Mert Demirel"},
                {"2019-2","Cenk Tosun"},
                {"2020-1","İsmail Köybaşı"},
                {"2020-2","Atiba Hutchinson"},
                {"2021-1","Derviş Karaboğa"},
                {"2022-1","Mete Çelik"},
                {"2022-2","Bilal Babayiğit"}
            };
        }
                
            
    }
}