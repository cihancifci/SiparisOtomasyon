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
   
    public partial class GuncellemeForm : Form
    {

        public GuncellemeForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (uruncmb.Text != "" && fiyattext.Text != "" && ağırlıktext.Text != "" && acıklamatext.Text != "")
            {
                for (int i = 0; i < Program.urunler.Count; i++)
                {
                    if (uruncmb.Text == Program.urunler[i].isim)
                    {
                        Program.urunler[i].Fiyat = int.Parse(fiyattext.Text);
                        Program.urunler[i].kargoAgırlık = double.Parse(ağırlıktext.Text);
                        Program.urunler[i].acıklama = acıklamatext.Text;
                        Temizle();
                        MessageBox.Show("Ürün başarı ile güncellendi");
                        uruncmb.Text = "";
                    }
                }
            }
            else
            {
                MessageBox.Show("Boş değer girilemez");
            }


        }

        private void uruncmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < Program.urunler.Count; i++)
            {
                if (uruncmb.Text == Program.urunler[i].isim)
                {
                    richTextBox1.Text = "Fiyat : " + Program.urunler[i].Fiyat + "\n\nAçıklama : " + Program.urunler[i].acıklama + "\n\nKargo Ağırlığı : " + Program.urunler[i].kargoAgırlık;
                }
            }

        }

        private void GuncellemeForm_Load(object sender, EventArgs e)
        {
            comboboxDoldur();
        }
        public void comboboxDoldur()
        {
            for (int i = 0; i < Program.urunler.Count; i++)
            {
                uruncmb.Items.Add(Program.urunler[i].isim);
            }
        }
        public void Temizle()
        {
            uruncmb.Text = "";
            fiyattext.Text = "";
            ağırlıktext.Text = "";
            acıklamatext.Text = "";
            richTextBox1.Text = "";
        }
    }
}
