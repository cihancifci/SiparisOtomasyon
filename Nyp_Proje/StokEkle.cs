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
    public partial class StokEkle : Form
    {
       

        public StokEkle()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            

            if (uruncmb.Text != "" )
            {
                for (int i = 0; i < Program.urunler.Count; i++)
                {
                    if (uruncmb.Text == Program.urunler[i].isim)
                    {
                        Program.urunler[i].StokEkle(int.Parse(textBox1.Text));
                        break;
                    }
                }
                
                MessageBox.Show("Başarı ile stok eklediniz");
            }
            else MessageBox.Show("HATALI SEÇİM");
        }


        private void button2_Click(object sender, EventArgs e)
        {
            int a;
            a = Convert.ToInt16(textBox1.Text);

            a += 1;
            textBox1.Text = a.ToString();
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

        private void UrunEkleme_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < Program.urunler.Count; i++)
            {
                uruncmb.Items.Add(Program.urunler[i].isim);
            }
        }
    }
}
