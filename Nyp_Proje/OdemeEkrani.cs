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
    public partial class OdemeEkrani : Form
    {
        
        public OdemeEkrani()
        {
            InitializeComponent();
        }

        private void OdemeEkrani_Load(object sender, EventArgs e)
        {
            int toplamfiyat = 0; 
            for (int i = 0; i < Program.sepetim.Count; i++)
            {
                 toplamfiyat += Program.sepetim[i].Fiyat;
            }
            labelücret.Text = toplamfiyat.ToString() + " (%8 vergi dahildir)";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            kredicombo1.Visible = false;
            kredicombo2.Visible = false;
            kredilabel1.Visible = false;
            kredilabel2.Visible = false;
            kredilabel3.Visible = false;
            kredimask1.Visible = false;
            kredimask2.Visible = false;
            ceklabel1.Visible = true;
            cektext1.Visible = true;
            odemeturlabel1.Visible = true;
            odemeturlabel2.Visible = true;
            odemeturlabel2.Text = "ÇEK";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ceklabel1.Visible = false;
            cektext1.Visible = false;
            kredicombo1.Visible = true;
            kredicombo2.Visible = true;
            kredilabel1.Visible = true;
            kredilabel2.Visible = true;
            kredilabel3.Visible = true;
            kredimask1.Visible = true;
            kredimask2.Visible = true;
            odemeturlabel1.Visible = true;
            odemeturlabel2.Visible = true;
            odemeturlabel2.Text = "KREDİ KARTI";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            kredicombo1.Visible = false;
            kredicombo2.Visible = false;
            kredilabel1.Visible = false;
            kredilabel2.Visible = false;
            kredilabel3.Visible = false;
            kredimask1.Visible = false;
            kredimask2.Visible = false;
            ceklabel1.Visible = false;
            cektext1.Visible = false;
            odemeturlabel1.Visible = true;
            odemeturlabel2.Visible = true;
            odemeturlabel2.Text = "NAKİT";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Cek cek = new Cek()
            {
                bankaId = "13579"
            };
            Kredi kredi = new Kredi()
            {
                krediKartNo = "1234-1234-1234-1234",
                guvenlikKodu = "123"
                
            };
            if (odemeturlabel1.Visible == true)
            {
                if (textBox1.Text != "" && richTextBox1.Text !="" && ((odemeturlabel2.Text=="NAKİT") || (odemeturlabel2.Text == "ÇEK" && (cektext1.Text == cek.bankaId)) || (odemeturlabel2.Text == "KREDİ KARTI" && kredicombo1.Text == "06" && kredicombo2.Text == "2021" && kredimask1.Text == kredi.krediKartNo && kredimask2.Text ==kredi.guvenlikKodu) ))
                {
                    for (int i = 0; i < Program.sepetim.Count; i++)
                    {
                        SiparisDetay siparis = new SiparisDetay();
                        siparis.urunDetaylar.Add(Program.sepetim[i]);
                        siparis.tarih = dateTimePicker1.Text;
                        siparis.vergi = 8;
                        siparis.satinAlanAd = textBox1.Text;
                        if (kredicombo1.Visible == true)
                        {
                            siparis.odemetürü = "kredi kartı";
                        }
                        else if (ceklabel1.Visible == true)
                        {
                            siparis.odemetürü = "çek";
                        }
                        else if (ceklabel1.Visible == false && kredicombo1.Visible == false)
                        {
                            siparis.odemetürü = "nakit";
                        }
                        Program.sonsiparisler.Add(siparis);
                        
                    }
                    
                    for (int i = 0; i < Program.sepetim.Count; i++)
                    {
                        for (int j = 0; j < Program.urunler.Count; j++)
                        {
                            if (Program.urunler[j].isim == Program.sepetim[i].isim)
                            {
                                Program.urunler[j].StokDus(Program.sepetim[i].adet);
                            }
                        }
                       
                    }
                    
                    MessageBox.Show("BAŞARI İLE SATIN ALDINIZ ");
                    Program.sepetim.Clear();
                    this.Close() ;
                }
                else
                {
                    MessageBox.Show("EKSİK VEYA HATALI BİLGİ GİRDİNİZ");
                }
                
            }

            else { MessageBox.Show("LÜTFEN ÖDEME TÜRÜ SEÇİN"); }
        }
    }
}
