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
    public partial class stokIslemleri : Form
    {
        public stokIslemleri()
        {
            InitializeComponent();
        }

        private void guncelle_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            


            string filePath = Fonksiyonlar.filePath;

            List<string> lines = new List<string>();

            List<Urun> urunler = new List<Urun>();
            lines = File.ReadAllLines($@"{filePath}\urun.txt").ToList();
            foreach (string line in lines)
            {
                string[] items = line.Split(',');
                Urun urun = new Urun(items[0], items[1], items[2], items[3],items[4],items[5]);
                urunler.Add(urun);
            }

            foreach (Urun urun in urunler)
            {
                string[] row = { urun.urunKod, urun.urunAdi, urun.urunCinsiyet, urun.urunFiyat,urun.urunStokRaf,urun.urunStokDepo };
                var satir = new ListViewItem(row);
                listView1.Items.Add(satir);


            }
            
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

            string filePath = Fonksiyonlar.filePath;

            List<string> lines = new List<string>();

            List<Urun> urunler = new List<Urun>();
            lines = File.ReadAllLines($@"{filePath}\urun.txt").ToList();
            foreach (string line in lines)
            {
                string[] items = line.Split(',');
                Urun urun = new Urun(items[0], items[1], items[2], items[3], items[4], items[5]);
                urunler.Add(urun);
            }


            if (listView1.SelectedIndices.Count > 0)
            {
                
                int index = listView1.SelectedIndices[0];
                lblAd.Text = urunler[index].urunAdi;
                lblRaf.Text = urunler[index].urunStokRaf;
                lblDepo.Text = urunler[index].urunStokDepo;
            }

            //label2.Text = listView1.SelectedItems[0].Index.ToString();
        }

        private void btnIslemYap_Click(object sender, EventArgs e)
        {

            string filePath = Fonksiyonlar.filePath;

            List<string> lines = new List<string>();

            List<Urun> urunler = new List<Urun>();
            lines = File.ReadAllLines($@"{filePath}\urun.txt").ToList();
            foreach (string line in lines)
            {
                string[] items = line.Split(',');
                Urun urun = new Urun(items[0], items[1], items[2], items[3], items[4], items[5]);
                urunler.Add(urun);
            }

            //int index;
            if (listView1.SelectedIndices.Count > 0) {int index = listView1.SelectedIndices[0];}
           






            if (islemMiktar.Value<=0)
            {
                string message = "Gecerli bir miktar giriniz!";
                string title = "Hata";
                MessageBox.Show(message, title);

            }

            else if (!(listView1.SelectedIndices.Count > 0))
            {
                string message = "Listeden bir urun seciniz!";
                string title = "Hata";
                MessageBox.Show(message, title);
            }

            else if(radioDepoToRaf.Checked)
            {
                int index = listView1.SelectedIndices[0];
                

                if (islemMiktar.Value>int.Parse(urunler[index].urunStokDepo))
                {
                    string message = "Yeterli stok yok!";
                    string title = "Hata";
                    MessageBox.Show(message, title);

                }

                else 
                {
                    int temp = int.Parse(urunler[index].urunStokDepo);

                    urunler[index].urunStokDepo = (int.Parse(urunler[index].urunStokDepo) - islemMiktar.Value).ToString();

                    urunler[index].urunStokRaf = (int.Parse(urunler[index].urunStokRaf) + islemMiktar.Value).ToString();


                    List<string> urunOutStr = new List<string>();

                    foreach (Urun u in urunler) { urunOutStr.Add(u.ToString()); }

                    File.WriteAllLines($@"{filePath}\urun.txt", urunOutStr);

                    lblAd.Text = urunler[index].urunAdi;
                    lblRaf.Text = urunler[index].urunStokRaf;
                    lblDepo.Text = urunler[index].urunStokDepo;

                    string message = "Depodan rafa eklendi!";
                    string title = "Basari";
                    MessageBox.Show(message, title);

                }



            }



            else if (radioRafToDepo.Checked)
            {
                int index = listView1.SelectedIndices[0];


                if (islemMiktar.Value > int.Parse(urunler[index].urunStokRaf))
                {
                    string message = "Yeterli stok yok!";
                    string title = "Hata";
                    MessageBox.Show(message, title);

                }

                else
                {
                    int temp = int.Parse(urunler[index].urunStokDepo);

                    urunler[index].urunStokDepo = (int.Parse(urunler[index].urunStokDepo) + islemMiktar.Value).ToString();

                    urunler[index].urunStokRaf = (int.Parse(urunler[index].urunStokRaf) - islemMiktar.Value).ToString();


                    List<string> urunOutStr = new List<string>();

                    foreach (Urun u in urunler) { urunOutStr.Add(u.ToString()); }

                    File.WriteAllLines($@"{filePath}\urun.txt", urunOutStr);

                    lblAd.Text = urunler[index].urunAdi;
                    lblRaf.Text = urunler[index].urunStokRaf;
                    lblDepo.Text = urunler[index].urunStokDepo;

                    string message = "Raftan Depoya eklendi!";
                    string title = "Basari";
                    MessageBox.Show(message, title);

                }



            }



        }
    }
}
