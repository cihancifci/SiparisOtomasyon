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
    public partial class SonSiparislerForm : Form
    {
        public SonSiparislerForm()
        {
            InitializeComponent();
        }

        private void SonSiparislerForm_Load(object sender, EventArgs e)
        {
            
            try
            {
                for (int i = 0; i < Program.sonsiparisler.Count; i++)
                {
                    string[] satınalımlar = new string[9];

                    satınalımlar[0] = (i+1).ToString() ;
                    satınalımlar[5] = Program.sonsiparisler[i].satinAlanAd;
                    satınalımlar[6] = Program.sonsiparisler[i].odemetürü;
                    satınalımlar[7] = Program.sonsiparisler[i].tarih;
                    satınalımlar[8] = Program.sonsiparisler[i].vergi.ToString();

                    for (int j = 0; j < Program.sonsiparisler[i].urunDetaylar.Count; j++)
                    {
                        satınalımlar[1] = Program.sonsiparisler[i].urunDetaylar[j].isim;
                        satınalımlar[2] = Program.sonsiparisler[i].urunDetaylar[j].adet.ToString();
                        satınalımlar[3] = Program.sonsiparisler[i].urunDetaylar[j].kargoAgırlık.ToString();
                        satınalımlar[4] = Program.sonsiparisler[i].urunDetaylar[j].Fiyat.ToString();
                    }
                   
                        try
                        {
                            if (int.Parse(satınalımlar[0]) >= 0)
                            {
                                var item = new ListViewItem(satınalımlar);
                                listView1.Items.Add(item);
                            }
                        }
                        catch { }
                }
            }

            catch
            {
                MessageBox.Show("hata");
            }
            
        }
    }
}
