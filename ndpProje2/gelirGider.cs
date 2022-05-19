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
    public partial class gelirGider : Form
    {
        public gelirGider()
        {
            InitializeComponent();
        }

        private void yenile_Click(object sender, EventArgs e)
        {
            int topGelir = 0;
            string filePath = Fonksiyonlar.filePath;
            listView1.Items.Clear();
            listView2.Items.Clear();

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
                topGelir+= int.Parse(musteriSiparis.siparisAdet) * int.Parse(musteriSiparis.urunFiyat);
                string gelir = (int.Parse(musteriSiparis.siparisAdet) * int.Parse(musteriSiparis.urunFiyat)).ToString();
                string[] row = { musteriSiparis.musteriIsim, musteriSiparis.urunAdi, musteriSiparis.siparisAdet,gelir };
                var satir = new ListViewItem(row);
                listView1.Items.Add(satir);


            }

            lblTopGelir.Text = topGelir.ToString();

            int topGider = 0;


            List<Gider> giderler = new List<Gider>();
            lines = File.ReadAllLines($@"{filePath}\giderler.txt").ToList();
            foreach (string line in lines)
            {
                string[] items = line.Split(',');
                Gider gider = new Gider(items[0], items[1], items[2], items[3], items[4], items[5]);
                giderler.Add(gider);
            }

            foreach (Gider gider in giderler)
            {
                string satirGider = (int.Parse(gider.giderPersonel) + int.Parse(gider.giderGida) + int.Parse(gider.giderElektrik) + int.Parse(gider.giderIsitma) + int.Parse(gider.giderDiger)).ToString();
                topGider += int.Parse(gider.giderPersonel) + int.Parse(gider.giderGida) + int.Parse(gider.giderElektrik) + int.Parse(gider.giderIsitma) + int.Parse(gider.giderDiger);
                string[] row = { gider.giderTarih, gider.giderPersonel, gider.giderGida, gider.giderElektrik, gider.giderIsitma, gider.giderDiger,satirGider };
                var satir = new ListViewItem(row);
                listView2.Items.Add(satir);


            }

            lblTopGider.Text = topGider.ToString();
        }

        private void giderEkle_Click(object sender, EventArgs e)
        {
            label13.Text = tarihSecici.Value.ToString();
            label14.Text = tarihSecici.Text;


            string filePath = Fonksiyonlar.filePath;

            List<string> lines = new List<string>();

            List<Gider> giderler = new List<Gider>();
            lines = File.ReadAllLines($@"{filePath}\giderler.txt").ToList();
            foreach (string line in lines)
            {
                string[] items = line.Split(',');
                Gider gider = new Gider(items[0], items[1], items[2], items[3], items[4], items[5]);
                giderler.Add(gider);
            }


            //en az bir deger dolu olmali
            if (!(nmrPersonel.Value==0&& nmrGida.Value == 0 && nmrElektrik.Value == 0 && nmrIsitma.Value == 0 && nmrDiger.Value == 0 ))
            {
                string tarih = tarihSecici.Text;

                giderler.Add(new Gider(tarihSecici.Text, nmrPersonel.Value.ToString(), nmrGida.Value.ToString(), nmrElektrik.Value.ToString()
                    , nmrIsitma.Value.ToString(), nmrDiger.Value.ToString()));


                List<string> giderOutStr = new List<string>();

                foreach (Gider g in giderler) { giderOutStr.Add(g.ToString()); }

                File.WriteAllLines($@"{filePath}\giderler.txt", giderOutStr);


                string message = "Gider basariyla eklendi!";
                string title = "Basari";
                MessageBox.Show(message, title);

            }

            else 
            {
                string message = "En az bir alanı doldurunuz!";
                string title = "Hata";
                MessageBox.Show(message, title);
            }
        }
    }
}
