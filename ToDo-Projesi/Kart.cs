using System;

namespace ToDo_Projesi
{
    public class Kart
    {
        private string baslik;
        private string icerik;
        private string atananKisi;
        private Enum boyut;

        public Kart(string _baslik, string _icerik, string _atananKisi, Enum _buyukluk)
        {
            Baslik = _baslik;
            Icerik = _icerik;
            AtananKisi = _atananKisi;
            Boyut = _buyukluk;
        }

        public string Baslik { get => baslik; set => baslik = value; }
        public string Icerik { get => icerik; set => icerik = value; }
        public string AtananKisi { get => atananKisi; set => atananKisi = value; }
        public Enum Boyut { get => boyut; set => boyut = value; }
    }

    public enum Boyutlar
    {
        XS = 1,
        S,
        M,
        L,
        XL
    }
}