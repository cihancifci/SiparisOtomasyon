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
    public partial class Sepet : Form
    {

        public Sepet()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {


            try
            {
                if (listView1.Items[0].SubItems[0].Text == "1")
                {
                    OdemeEkrani odemeekran = new OdemeEkrani();

                    odemeekran.StartPosition = FormStartPosition.CenterScreen;
                    odemeekran.ShowDialog();
                    this.Close();
                }
            }
            catch (Exception)
            {

                MessageBox.Show("sepete ürün ekleyin");
            }
               
             
            
        }
        private void Sepet_Load(object sender, EventArgs e)
        {
       
                
            listView1.FullRowSelect = true;

            string[] sepet = new string[6] ;


            for (int i = 0; i < Program.sepetim.Count; i++)
            {   
                sepet[0] = (i+1).ToString() ;
                sepet[1] = Program.sepetim[i].isim;
                sepet[2] = Program.sepetim[i].adet.ToString();
                sepet[3] = Program.sepetim[i].kargoAgırlık.ToString();
                sepet[4] = Program.sepetim[i].Fiyat.ToString();

                var item = new ListViewItem(sepet);
                listView1.Items.Add(item);
            }

        }


        private void button4_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedIndices.Count > 0)
            {
                
              
                int deger;
                deger = int.Parse(listView1.SelectedItems[0].SubItems[0].Text)-1;
                listView1.SelectedItems[0].Remove();
                Program.sepetim.RemoveAt(deger);
                for (int i = 0; i < Program.sepetim.Count; i++)
                {
                    listView1.Items[i].SubItems[0].Text = (i+1).ToString() ;
                    
                }

            }
        }

   
    }
}
