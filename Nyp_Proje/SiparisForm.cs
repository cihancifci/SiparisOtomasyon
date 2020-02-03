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
    public partial class SiparisForm : Form
    {
        

        public SiparisForm()
        {
            InitializeComponent();          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int index = 10 ;
            bool sepetkontrol = false;
            bool stokKontrol = true;
            Urun urun = new Urun();
            for (int i = 0; i < Program.urunler.Count; i++)
            {
                if (uruncmb.Text == Program.urunler[i].isim)
                {
                    for (int j = 0; j < Program.sepetim.Count; j++)
                    {
                        if (uruncmb.Text == Program.sepetim[j].isim)
                        {
                            
                            if (Program.sepetim[j].adet + Convert.ToUInt16(textBox1.Text) <= Program.urunler[i].stokSayisi)
                            {
                                Program.sepetim[j].adet += Convert.ToUInt16(textBox1.Text);
                                Program.sepetim[j].Fiyat += Convert.ToUInt16(textBox1.Text) * Program.urunler[i].Fiyat;
                                Program.sepetim[j].kargoAgırlık += Convert.ToUInt16(textBox1.Text) * Program.urunler[i].kargoAgırlık;
                                sepetkontrol = true;
                                index = i;
                                break;
                            }
                            else
                            {
                                sepetkontrol = true;
                                stokKontrol = false;
                                break;
                            }
                        }
                    }

                    if (!sepetkontrol)
                    {
                        if (Convert.ToUInt16(textBox1.Text) <= Program.urunler[i].stokSayisi)
                        {
                            urun.isim = uruncmb.Text;
                            urun.adet = Convert.ToUInt16(textBox1.Text);
                            urun.Fiyat = Program.urunler[i].Fiyat * urun.adet;
                            urun.kargoAgırlık = Program.urunler[i].kargoAgırlık * urun.adet;
                            Program.sepetim.Add(urun);
                            index = i;
                            break;
                        }

                        else
                        {
                            stokKontrol = false;
                        }
                        
                    }
                    if (!stokKontrol)
                    {
                        MessageBox.Show("Yetersiz Stok");
                        index = i;
                        break;
                    }
                    
                }
            }

            if (index == 10)
            {
                MessageBox.Show("Hatalı Seçim");
            }
            textBox1.Text = 1.ToString();
  
        }

        private void uruncmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < Program.urunler.Count; i++)
            {
                if (uruncmb.Text == Program.urunler[i].isim)
                {
                    richTextBox1.Text = "Fiyat : " + Program.urunler[i].Fiyat + "\n\nAçıklama : " + Program.urunler[i].acıklama + "\n\nKargo Ağırlığı : " + Program.urunler[i].kargoAgırlık;
                    break;
                }
            }

        }

        private void SiparisForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            int a;
            a = Program.sepetim.Count; 
            for (int i = (a-1); i >=0; i--)
            {
                Program.sepetim.RemoveAt(i);
            }
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

        private void button4_Click(object sender, EventArgs e)
        {
            Sepet sepet = new Sepet();
            sepet.StartPosition = FormStartPosition.CenterScreen;
            sepet.ShowDialog();
        }

        private void SiparisForm_Load(object sender, EventArgs e)
        {
            uruncmb.Items.Clear();
            for (int i = 0; i < Program.urunler.Count; i++)
            {
                uruncmb.Items.Add(Program.urunler[i].isim);
            }
        }
    }
}
