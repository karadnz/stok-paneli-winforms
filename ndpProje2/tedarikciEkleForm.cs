using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

/****************************************************************************
**SAKARYA ÜNİVERSİTESİ
**BILGISAYAR VE BILISIM BILIMLERI FAKULTESI
**BILGISAYAR MUHENDISLIGI BOLUMU
**NESNEYE DAYALI PROGRAMLAMA DERSI
**2021-2022 BAHAR DONEMI
**	
**ODEV NUMARASI..........: Proje Odevi
**OGRENCI ADI............: MUSTAFA KARADENIZ
**OGRENCI NUMARASI.......: G211210066
**DERSIN ALINDIGI GRUP...: I.O. A Grubu
****************************************************************************/

namespace ndpProje2
{
    public partial class tedarikciEkleForm : Form
    {
        public tedarikciEkleForm()
        {
            InitializeComponent();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            //Tedarikcileri dosyadan cekmek icin
            string filePath = Fonksiyonlar.filePath;


            List<string> lines = new List<string>();

            List<Tedarikci> tedarikciler = new List<Tedarikci>();
            lines = File.ReadAllLines($@"{filePath}\tedarikci.txt").ToList();
            foreach (string line in lines)
            {
                string[] items = line.Split(',');
                Tedarikci tedarikci= new Tedarikci(items[0], items[1], items[2], items[3]);
                tedarikciler.Add(tedarikci);

            }

            string id = $"t0{tedarikciler.Count().ToString()}";
            string isim = txtAd.Text;
            string telefon = txtTel.Text;
            string sehir = txtSehir.Text;

            tedarikciler.Add(new Tedarikci(id, isim, telefon, sehir));

            List<string> tedarikciOutStr = new List<string>();

            foreach (Tedarikci t in tedarikciler) { tedarikciOutStr.Add(t.ToString()); }

            File.WriteAllLines($@"{filePath}\Tedarikci.txt", tedarikciOutStr);

            string message = "Tedarikci Eklendi!";
            string title = "Basari";
            MessageBox.Show(message, title);

            txtAd.Text = "";
            txtSehir.Text = "";
            txtTel.Text = "";
        }
    }
}
