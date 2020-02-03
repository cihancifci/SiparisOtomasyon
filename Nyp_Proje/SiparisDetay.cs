using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nyp_Proje
{
    public class SiparisDetay : Siparis
    {
        public string[,] urunDetay = new string[50,50] ;
        public List<Urun> urunDetaylar = new List<Urun>();
        public int vergiDurum { get; set; }
        public string odemetürü;
        public string satinAlanAd;
        public float vergi;

        public Urun Urun
        {
            get => default(Urun);
            set
            {
            }
        }
    }
}
