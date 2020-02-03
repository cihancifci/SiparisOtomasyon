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
    public partial class stokdusurme : Form
    {
        public stokdusurme()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ( uruncmb.Text != "")
            {
                bool kontrol = false;
                for (int i = 0; i < Program.urunler.Count; i++)
                {
                    if (uruncmb.Text == Program.urunler[i].isim )
                    {
                        if (Program.urunler[i].stokSayisi >= int.Parse(textBox1.Text))
                        {
                            Program.urunler[i].StokDus(int.Parse(textBox1.Text));
                            kontrol = true;
                        }
                        else
                            MessageBox.Show("Yetersiz stok");
                        break;
                    }
                }
                if (kontrol)
                {
                    MessageBox.Show("Başarı ile stok düşürdünüz");
                }
            }
            else { MessageBox.Show("HATALI SEÇİM !!!");}
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int a;
            a = Convert.ToInt16(textBox1.Text);
            if (a > 1)
            {
                a -= 1;
                textBox1.Text = a.ToString();

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int a;
            a = Convert.ToInt16(textBox1.Text);

            a += 1;
            textBox1.Text = a.ToString();
        }

        private void stokdusurme_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < Program.urunler.Count; i++)
            {
                uruncmb.Items.Add(Program.urunler[i].isim);
            }
        }
    }
}
