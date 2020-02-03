using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nyp_Proje
{
    static class Program
    {
        /// <summary>
        /// Uygulamanın ana girdi noktası.
        /// </summary>
        public static List<Urun> sepetim = new List<Urun>();
        public static List<SiparisDetay>  sonsiparisler = new List<SiparisDetay>();
        public static List<Urun> urunler = new List<Urun>();
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
               
            Application.Run(new AnaSayfaForm());
        }
    }
}
