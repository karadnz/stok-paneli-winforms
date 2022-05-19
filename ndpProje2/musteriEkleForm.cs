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
    public partial class musteriEkleForm : Form
    {
        public musteriEkleForm()
        {
            InitializeComponent();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            //Musterileri dosyadan cekmek icin
            string filePath = Fonksiyonlar.filePath;


            List<string> lines = new List<string>();

            List<Musteri> musteriler = new List<Musteri>();
            lines = File.ReadAllLines($@"{filePath}\musteri.txt").ToList();
            foreach (string line in lines)
            {
                string[] items = line.Split(',');
                Musteri musteri = new Musteri(items[0], items[1], items[2], items[3]);
                musteriler.Add(musteri);

            }

            string id =$"m0{musteriler.Count().ToString()}";
            string isim = txtAd.Text;
            string telefon = txtTel.Text;
            string sehir = txtSehir.Text;

            musteriler.Add(new Musteri(id,isim,telefon,sehir));

            List<string> musteriOutStr = new List<string>();

            foreach (Musteri m in musteriler) { musteriOutStr.Add(m.ToString()); }

            File.WriteAllLines($@"{filePath}\musteri.txt", musteriOutStr);

            string message = "Musteri Eklendi!";
            string title = "Basari";
            MessageBox.Show(message, title);

            txtAd.Text = "";
            txtSehir.Text = "";
            txtTel.Text = "";



        }
    }
}
