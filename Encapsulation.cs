using System;

namespace Encapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            Ogrenci ogr1 = new Ogrenci();
            ogr1.Adi = "Ayse";
            ogr1.Soyadi = "Yılmaz";
            ogr1.OgrenciNo = 057;
            ogr1.Sinif = 3;
            ogr1.OgrenciBilgileriniGetir();
            ogr1.SınıfAtlat();
            ogr1.OgrenciBilgileriniGetir();

            Ogrenci ogr2 = new Ogrenci("Deniz","Arda",256,1);
            ogr2.SınıfDusur();
            ogr2.SınıfDusur();
            ogr2.OgrenciBilgileriniGetir();
        }
    }

    class Ogrenci
    {
        private string _adi;
        private string _soyadi;
        private int _ogrenciNo;
        private int _sinif;

        public string Adi {
            get { return _adi; }
            set { _adi = value; }
        }
        public string Soyadi { get => _soyadi; set => _soyadi = value; }
        public int OgrenciNo { get => _ogrenciNo; set => _ogrenciNo = value; }
        public int Sinif { get => _sinif;

            set {

                if (value < 1)
                {
                    Console.WriteLine("Sınıf en fazla 1 olabilir");
                    _sinif = 1;
                }
                else
                {
                    _sinif = value;
                }

            }
            }

        public Ogrenci(string adi, string soyAdi, int ogrenciNo, int sinif)
        {
            Adi = adi;
            Soyadi = soyAdi;
            OgrenciNo = ogrenciNo;
            Sinif = sinif;
        }

        public Ogrenci()
        {
        }
        public void OgrenciBilgileriniGetir()
        {
            Console.WriteLine("********Ogrenci Bilgileri**********");
            Console.WriteLine("Ogrenci Adı         :{0}", this.Adi);
            Console.WriteLine("Ogrenci SoyAdı      :{0}", this.Soyadi);
            Console.WriteLine("Ogrenci No          :{0}", this.OgrenciNo);
            Console.WriteLine("Ogrenci Sınıfı      :{0}", this.Sinif);
        }
        public void SınıfAtlat()
        {
            this.Sinif = this.Sinif + 1;
        }
        public void SınıfDusur()
        {
            this.Sinif = this.Sinif -1;
        }
    }
}
