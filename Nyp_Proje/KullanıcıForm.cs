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

    public partial class KullanıcıForm : Form
    {

        public KullanıcıForm()
        {
            InitializeComponent();
        }
        
        private void btn_StokGoruntule_Click(object sender, EventArgs e)
        {
            string mesaj = "";
            for (int i = 0; i < Program.urunler.Count; i++)
            {
                mesaj += Program.urunler[i].isim + " -------> " + Program.urunler[i].stokSayisi + "\n";

            }
            MessageBox.Show(mesaj);

        }

        private void btn_StokEkle_Click(object sender, EventArgs e)
        {
            StokEkle stokEkle = new StokEkle();
            stokEkle.StartPosition = FormStartPosition.CenterScreen;
            stokEkle.ShowDialog();
        }

        private void btn_StokDus_Click(object sender, EventArgs e)
        {
            stokdusurme stokdusur = new stokdusurme();
            stokdusur.StartPosition = FormStartPosition.CenterScreen;
            stokdusur.ShowDialog();
        }

        private void btn_Guncelle_Click(object sender, EventArgs e)
        {
            GuncellemeForm guncelle = new GuncellemeForm(); ;
            guncelle.StartPosition = FormStartPosition.CenterScreen;
            guncelle.ShowDialog();
        }

        private void btn_SonSiparis_Click(object sender, EventArgs e)
        {
            SonSiparislerForm sonsiparis = new SonSiparislerForm();
            sonsiparis.StartPosition = FormStartPosition.CenterScreen;
            sonsiparis.ShowDialog();
        }

        private void btn_UrunEkle_Click(object sender, EventArgs e)
        {
            UrunEkle urunEkle = new UrunEkle();
            urunEkle.StartPosition = FormStartPosition.CenterScreen;
            urunEkle.ShowDialog();
        }

        private void btn_UrunSil_Click(object sender, EventArgs e)
        {
            frm_UrunSilme urunSil = new frm_UrunSilme();
            urunSil.StartPosition = FormStartPosition.CenterScreen;
            urunSil.ShowDialog();
        }
    }
}
