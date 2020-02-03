using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nyp_Proje
{
    public class Urun
    {
        public string isim { get; set; }
        public int Fiyat { get; set; }
        public double kargoAgırlık { get; set; }
        public string acıklama { get; set; }
        public int adet { get; set; }
        public string beden { get; set; }
        public int stokSayisi { get; set; }


        public void StokDus(int adet)
        {
            this.stokSayisi -= adet;
        }

        public void StokEkle(int adet)
        {
            this.stokSayisi += adet;
        }
    }
}
