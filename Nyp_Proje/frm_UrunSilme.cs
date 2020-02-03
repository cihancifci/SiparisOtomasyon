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
    public partial class frm_UrunSilme : Form
    {
        public frm_UrunSilme()
        {
            InitializeComponent();
        }

        private void frm_UrunSilme_Load(object sender, EventArgs e)
        {
            comboboxDoldur();
        }

        private void uruncmb_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            for (int i = 0; i < Program.urunler.Count; i++)
            {
                if (uruncmb.Text == Program.urunler[i].isim)
                {
                    rctxt_Bilgiler.Text = "Fiyat : " + Program.urunler[i].Fiyat + "\n\nAçıklama : " + Program.urunler[i].acıklama + "\n\nKargo Ağırlığı : " + Program.urunler[i].kargoAgırlık;
                }
            }
        }

        private void btn_Sil_Click_1(object sender, EventArgs e)
        {
            DialogResult dialog = new DialogResult();
            dialog = MessageBox.Show("Ürüni silmek istediğinize emin misiniz?","Uyarı",MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                for (int i = 0; i < Program.urunler.Count; i++)
                {
                    if (uruncmb.Text == Program.urunler[i].isim)
                    {
                        Program.urunler.RemoveAt(i);
                        MessageBox.Show("Ürün başarı ile silindi");
                        uruncmb.Items.Clear();
                        comboboxDoldur();
                        break;
                    }
                }
            }



        }

        public void comboboxDoldur()
        {
            for (int i = 0; i < Program.urunler.Count; i++)
            {
                uruncmb.Items.Add(Program.urunler[i].isim);
            }
        }
    }
}
