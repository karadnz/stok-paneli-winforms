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
    public partial class yoneticiPanel : Form
    {
        public yoneticiPanel()
        {
            InitializeComponent();

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


            List<Tedarikci> tedarikciler = new List<Tedarikci>();
            lines = File.ReadAllLines($@"{filePath}\tedarikci.txt").ToList();
            foreach (string line in lines)
            {
                string[] items = line.Split(',');
                Tedarikci tedarikci = new Tedarikci(items[0], items[1], items[2], items[3]);
                tedarikciler.Add(tedarikci);
            }



        }

        private void yoneticiPanel_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            giris girisEkran = new giris();
            girisEkran.Show();
        }

        private void musteriEkle_Click(object sender, EventArgs e)
        {
            musteriEkleForm ekleForm = new musteriEkleForm();
            ekleForm.Show();
        }

        private void tedarikciEkle_Click(object sender, EventArgs e)
        {
            tedarikciEkleForm ekleForm = new tedarikciEkleForm();
            ekleForm.Show();
        }

        private void musteriGoster_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            label1.Text = "Musteriler:";
            label1.Show();


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

            foreach (Musteri musteri in musteriler)
            {
                string[] row = { musteri.musteriId, musteri.musteriIsim, musteri.musteriTelefon,musteri.musteriAdres };
                var satir = new ListViewItem(row);
                listView1.Items.Add(satir);


            }


            

        }

        private void tedarikciGoster_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            label1.Text = "Tedarikciler:";
            label1.Show();


            string filePath = Fonksiyonlar.filePath;

            List<string> lines = new List<string>();

            List<Tedarikci> tedarikciler = new List<Tedarikci>();
            lines = File.ReadAllLines($@"{filePath}\tedarikci.txt").ToList();
            foreach (string line in lines)
            {
                string[] items = line.Split(',');
                Tedarikci tedarikci = new Tedarikci(items[0], items[1], items[2], items[3]);
                tedarikciler.Add(tedarikci);
            }

            foreach (Tedarikci tedarikci in tedarikciler)
            {
                string[] row = { tedarikci.tedarikciId, tedarikci.tedarikciIsim, tedarikci.tedarikciTelefon, tedarikci.tedarikciAdres };
                var satir = new ListViewItem(row);
                listView1.Items.Add(satir);


            }

        }

        private void siparisVer_Click(object sender, EventArgs e)
        {
            yoneticiSiparis ysiparis = new yoneticiSiparis();
            ysiparis.Show();
        }

        private void satis_Click(object sender, EventArgs e)
        {
            listView2.Items.Clear();
            label2.Text = "Musterilere yapilan satislar:";
            label2.Show();


            string filePath = Fonksiyonlar.filePath;

            List<string> lines = new List<string>();

            List<MusteriSiparis> musteriSiparisler = new List<MusteriSiparis>();
            lines = File.ReadAllLines($@"{filePath}\musteriSiparis.txt").ToList();
            foreach (string line in lines)
            {
                string[] items = line.Split(',');
                MusteriSiparis musteriSiparis = new MusteriSiparis(items[0], items[1], items[2], items[3], items[4], items[5], items[6], items[7]);
                musteriSiparisler.Add(musteriSiparis);
            }

            foreach (MusteriSiparis musteriSiparis in musteriSiparisler)
            {
                string[] row = { musteriSiparis.musteriId, musteriSiparis.musteriIsim, musteriSiparis.urunAdi, musteriSiparis.siparisAdet };
                var satir = new ListViewItem(row);
                listView2.Items.Add(satir);


            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listView2.Items.Clear();
            label2.Text = "Tedarikcilerden verilen siparisler:";
            label2.Show();


            string filePath = Fonksiyonlar.filePath;

            List<string> lines = new List<string>();

            List<TedarikciSiparis> tedarikciSiparisler = new List<TedarikciSiparis>();
            lines = File.ReadAllLines($@"{filePath}\tedarikciSiparis.txt").ToList();
            foreach (string line in lines)
            {
                string[] items = line.Split(',');
                TedarikciSiparis tedarikciSiparis = new TedarikciSiparis(items[0], items[1], items[2], items[3], items[4], items[5], items[6],items[7]);
                tedarikciSiparisler.Add(tedarikciSiparis);
            }

            foreach (TedarikciSiparis tedarikciSiparis in tedarikciSiparisler)
            {
                string[] row = { tedarikciSiparis.tedarikciId, tedarikciSiparis.tedarikciIsim, tedarikciSiparis.urunAdi, tedarikciSiparis.siparisAdet };
                var satir = new ListViewItem(row);
                listView2.Items.Add(satir);


            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            stokIslemleri stokEkran = new stokIslemleri();
            stokEkran.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            gelirGider gelirEkran = new gelirGider();
            gelirEkran.Show();
        }
    }
}
