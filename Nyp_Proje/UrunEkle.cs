using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nyp_Proje
{
    public partial class UrunEkle : Form
    {
        public UrunEkle()
        {
            InitializeComponent();
        }

        private void btn_Ekle_Click(object sender, EventArgs e)
        {
            Urun urun = new Urun() { isim = txt_isim.Text,
                kargoAgırlık = double.Parse(txt_agirlik.Text),
                Fiyat = int.Parse(txt_fiyat.Text),
                acıklama = txt_aciklama.Text, stokSayisi = int.Parse(txt_stok.Text) };
            Program.urunler.Add(urun);
           
        }
    }
}
