using System;
using System.Collections.Generic;

namespace TelefonRehberiProjesi
{
    class Program
    {
        static void Main(string[] args)
        {
            Kisiler.KisiList = new List<Kisiler>()
            {
                new Kisiler("Ömer Mert","Demirel","5335153369"),
                new Kisiler("Cenk","Tosun","5553469216"),
                new Kisiler("İsmail","Köybaşı","5316663346"),
                new Kisiler("Necip","Uysal","5420987887"),
                new Kisiler("Atiba","Hutchinson","5053874904")
            };

            Kisiler.KisiList.Sort((x,y)=> x.Isim.CompareTo(y.Isim));
            Menu.menuYazdir();

        }
    }
}
