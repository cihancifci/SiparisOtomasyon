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

    public partial class AnaSayfaForm : Form
    {
        

        
        public AnaSayfaForm()
        {           
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (rdo_musteri.Checked)
            {
                if ((kullanıcıadtext.Text == "cihan" && parolatext.Text == "123"))
                {
                    SiparisForm siparisForm = new SiparisForm();
                    siparisForm.StartPosition = FormStartPosition.CenterScreen;
                    siparisForm.ShowDialog();
                }
            }

            else if (rdo_admin.Checked)
            {
                if(kullanıcıadtext.Text == "admin" && parolatext.Text == "123")
                {
                    KullanıcıForm kullanıcıForm = new KullanıcıForm();
                    kullanıcıForm.StartPosition = FormStartPosition.CenterScreen;
                    kullanıcıForm.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("Hatalı Giriş!");
            }
            
            
        }

        private void AnaSayfaForm_Load(object sender, EventArgs e)
        {
            Urun urun = new Urun() { isim = "Kazak", kargoAgırlık = 0.6, Fiyat = 80, acıklama = "güzel kazak" ,stokSayisi = 50};
            Urun urun2 = new Urun() { isim = "Pantolon", kargoAgırlık = 0.8, Fiyat = 140, acıklama = "bu pantolon kalitelidir" , stokSayisi = 50 };
            Urun urun3 = new Urun() { isim = "Ayakkabı", kargoAgırlık = 0.7, Fiyat = 150, acıklama = "bu ayakkabı çok kalitelidir" , stokSayisi = 50 };
            Urun urun4 = new Urun() { isim = "T-Shirt", kargoAgırlık = 0.4, Fiyat = 40, acıklama = "bu t-shirt çok cikistir" , stokSayisi = 50 };
            Program.urunler.Add(urun);
            Program.urunler.Add(urun2);
            Program.urunler.Add(urun3);
            Program.urunler.Add(urun4);
        }
    }
}
