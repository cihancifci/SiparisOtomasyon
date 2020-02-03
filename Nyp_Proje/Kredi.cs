using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nyp_Proje
{
    public class Kredi : Odeme
    {
        public string krediKartNo { get; set; }
        public string krediKartTur { get; set; }
        public DateTime sonKullanmaTarihi { get; set; }
        public string guvenlikKodu { get; set; }
    }
}
