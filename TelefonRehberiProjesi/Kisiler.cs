using System;
using System.Collections.Generic;
namespace TelefonRehberiProjesi{

    public class Kisiler{

        public Kisiler(string isim , string soyisim, string telNo){
            Isim = isim;
            Soyisim = soyisim;
            TelNo = telNo;
        }
        public string Isim { get => _isim; set => _isim = value; }
        public string Soyisim { get => _soyisim; set => _soyisim = value; }
        public string TelNo { get => _telNo; set => _telNo = value; }

        private string _isim;
        private string _soyisim;
        private string _telNo;

        public static List<Kisiler> KisiList;
        
    }
}