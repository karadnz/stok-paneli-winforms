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

namespace ndpProje2
{
    public partial class musteriPanel : Form
    {


        public musteriPanel()
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

            foreach(Musteri musteri in musteriler)
            {
                
                musteriSecCombo.Items.Add(musteri.musteriIsim);
            }


        }

        private void musteriPanel_FormClosing(object sender, FormClosingEventArgs e)
        {
            //cikinca kapamak icin
            giris girisEkran = new giris();
            girisEkran.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
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










            if (radioTshirtE.Checked)
            {
                
                bilgiAd.Text    = urunler[0].urunAdi;
                bilgiFiyat.Text = urunler[0].urunFiyat;
                bilgiStok.Text  = urunler[0].urunStokRaf;

            }

            else if (radioPantalonE.Checked)
            {
                bilgiAd.Text    = urunler[1].urunAdi;
                bilgiFiyat.Text = urunler[1].urunFiyat;
                bilgiStok.Text  = urunler[1].urunStokRaf;
            }


            else if (radioAyakkabiE.Checked)
            {
                bilgiAd.Text    = urunler[2].urunAdi;
                bilgiFiyat.Text = urunler[2].urunFiyat;
                bilgiStok.Text  = urunler[2].urunStokRaf;
            }

            else if (radioTshirtK.Checked)
            {
                bilgiAd.Text    = urunler[3].urunAdi;
                bilgiFiyat.Text = urunler[3].urunFiyat;
                bilgiStok.Text  = urunler[3].urunStokRaf;
            }

            else if (radioPantalonK.Checked)
            {
                bilgiAd.Text    = urunler[4].urunAdi;
                bilgiFiyat.Text = urunler[4].urunFiyat;
                bilgiStok.Text  = urunler[4].urunStokRaf;
            } 


            else if (radioAyakkabiK.Checked)
            {
                bilgiAd.Text    = urunler[5].urunAdi;
                bilgiFiyat.Text = urunler[5].urunFiyat;
                bilgiStok.Text  = urunler[5].urunStokRaf;
            }

            else if (radioTshirtC.Checked)
            {
                bilgiAd.Text    = urunler[6].urunAdi;
                bilgiFiyat.Text = urunler[6].urunFiyat;
                bilgiStok.Text  = urunler[6].urunStokRaf;
            }

            else if (radioPantalonC.Checked)
            {
                bilgiAd.Text    = urunler[7].urunAdi;
                bilgiFiyat.Text = urunler[7].urunFiyat;
                bilgiStok.Text  = urunler[7].urunStokRaf;
            }

            else if (radioAyakkabiC.Checked)
            {
                bilgiAd.Text    = urunler[8].urunAdi;
                bilgiFiyat.Text = urunler[8].urunFiyat;
                bilgiStok.Text  = urunler[8].urunStokRaf;
            }
        }

        private void btnSatin_Click(object sender, EventArgs e)
        {

            string filePath = Fonksiyonlar.filePath;


            //dosyadan urunleri cek liste yap

            List<string> lines = new List<string>();

            List<Urun> urunler = new List<Urun>();

            lines = File.ReadAllLines($@"{filePath}\urun.txt").ToList();

            foreach (string line in lines)
            {
                string[] items = line.Split(',');
                Urun urun = new Urun(items[0], items[1], items[2], items[3], items[4], items[5]);
                urunler.Add(urun);

            }



            //dosyadan musterileri cek liste yap


            List<Musteri> musteriler = new List<Musteri>();

            lines = File.ReadAllLines($@"{filePath}\musteri.txt").ToList();

            foreach (string line in lines)
            {
                string[] items = line.Split(',');
                Musteri musteri = new Musteri(items[0], items[1], items[2], items[3]);
                musteriler.Add(musteri);

            }


            //dosyadan musteri siparisleri cek

            List<MusteriSiparis> musteriSiparisleri = new List<MusteriSiparis>();

            lines = File.ReadAllLines($@"{filePath}\musteriSiparis.txt").ToList();

            foreach (string line in lines)
            {
                string[] items = line.Split(',');
                MusteriSiparis siparis = new MusteriSiparis(items[0], items[1], items[2], items[3], items[4], items[5], items[6], items[7]);
                musteriSiparisleri.Add(siparis);

            }





            if (radioTshirtE.Checked)
            {


                if(musteriSecCombo.SelectedIndex==-1)
                {
                    string message = "Musteri Seciniz!!";
                    string title = "Hata";
                    MessageBox.Show(message, title);

                }

                else if((adetBuy.Value>int.Parse(urunler[0].urunStokRaf)))
                {
                    string message = "Stok Yetersiz!";
                    string title = "Hata";
                    MessageBox.Show(message, title);
                }

                else if (adetBuy.Value <1)
                {
                    string message = "Gecerli miktarda siparis veriniz!";
                    string title = "Hata";
                    MessageBox.Show(message, title);
                }

                //eger musteri secili ise ve alinan adet 0dan buyuk ve stoktan az ise
                else
                {
                    //alinan urunleri stoktan dusmek icin
                    urunler[0].urunStokRaf = (int.Parse(urunler[0].urunStokRaf) - adetBuy.Value).ToString();

                    List<string> urunOutStr = new List<string>();

                    foreach (Urun u in urunler) {urunOutStr.Add(u.ToString());}

                    File.WriteAllLines($@"{filePath}\urun.txt", urunOutStr);


                    //siparisi siparis dosyasina eklemek icin
                    int index = musteriSecCombo.SelectedIndex;

                    List<string> sipOutStr = new List<string>();

                    musteriSiparisleri.Add(new MusteriSiparis(
                        musteriler[index].musteriId, musteriler[index].musteriIsim,
                        musteriler[index].musteriTelefon, musteriler[index].musteriAdres,
                        urunler[0].urunKod, urunler[0].urunAdi,adetBuy.Value.ToString(),urunler[0].urunFiyat)
                        );

                    foreach (MusteriSiparis s in musteriSiparisleri) { sipOutStr.Add(s.ToString()); }

                    File.WriteAllLines($@"{filePath}\musteriSiparis.txt", sipOutStr);

                    string message = "Siparis Eklendi!";
                    string title = "Basari";
                    MessageBox.Show(message, title);
                }
                

            }

            else if (radioPantalonE.Checked)
            {
                if (musteriSecCombo.SelectedIndex == -1)
                {
                    string message = "Musteri Seciniz!!";
                    string title = "Hata";
                    MessageBox.Show(message, title);

                }

                else if ((adetBuy.Value > int.Parse(urunler[1].urunStokRaf)))
                {
                    string message = "Stok Yetersiz!";
                    string title = "Hata";
                    MessageBox.Show(message, title);
                }

                else if (adetBuy.Value < 1)
                {
                    string message = "Gecerli miktarda siparis veriniz!";
                    string title = "Hata";
                    MessageBox.Show(message, title);
                }

                //eger musteri secili ise ve alinan adet 0dan buyuk ve stoktan az ise
                else
                {
                    //alinan urunleri stoktan dusmek icin
                    urunler[1].urunStokRaf = (int.Parse(urunler[1].urunStokRaf) - adetBuy.Value).ToString();

                    List<string> urunOutStr = new List<string>();

                    foreach (Urun u in urunler) { urunOutStr.Add(u.ToString()); }

                    File.WriteAllLines($@"{filePath}\urun.txt", urunOutStr);


                    //siparisi siparis dosyasina eklemek icin
                    int index = musteriSecCombo.SelectedIndex;

                    List<string> sipOutStr = new List<string>();

                    musteriSiparisleri.Add(new MusteriSiparis(
                        musteriler[index].musteriId, musteriler[index].musteriIsim,
                        musteriler[index].musteriTelefon, musteriler[index].musteriAdres,
                        urunler[1].urunKod, urunler[1].urunAdi, adetBuy.Value.ToString(), urunler[1].urunFiyat)
                        );

                    foreach (MusteriSiparis s in musteriSiparisleri) { sipOutStr.Add(s.ToString()); }

                    File.WriteAllLines($@"{filePath}\musteriSiparis.txt", sipOutStr);

                    string message = "Siparis Eklendi!";
                    string title = "Basari";
                    MessageBox.Show(message, title);
                }
            }


            else if (radioAyakkabiE.Checked)
            {
                if (musteriSecCombo.SelectedIndex == -1)
                {
                    string message = "Musteri Seciniz!!";
                    string title = "Hata";
                    MessageBox.Show(message, title);

                }

                else if ((adetBuy.Value > int.Parse(urunler[2].urunStokRaf)))
                {
                    string message = "Stok Yetersiz!";
                    string title = "Hata";
                    MessageBox.Show(message, title);
                }

                else if (adetBuy.Value < 1)
                {
                    string message = "Gecerli miktarda siparis veriniz!";
                    string title = "Hata";
                    MessageBox.Show(message, title);
                }

                //eger musteri secili ise ve alinan adet 0dan buyuk ve stoktan az ise
                else
                {
                    //alinan urunleri stoktan dusmek icin
                    urunler[2].urunStokRaf = (int.Parse(urunler[2].urunStokRaf) - adetBuy.Value).ToString();

                    List<string> urunOutStr = new List<string>();

                    foreach (Urun u in urunler) { urunOutStr.Add(u.ToString()); }

                    File.WriteAllLines($@"{filePath}\urun.txt", urunOutStr);


                    //siparisi siparis dosyasina eklemek icin
                    int index = musteriSecCombo.SelectedIndex;

                    List<string> sipOutStr = new List<string>();

                    musteriSiparisleri.Add(new MusteriSiparis(
                        musteriler[index].musteriId, musteriler[index].musteriIsim,
                        musteriler[index].musteriTelefon, musteriler[index].musteriAdres,
                        urunler[2].urunKod, urunler[2].urunAdi, adetBuy.Value.ToString(),urunler[2].urunFiyat)
                        );

                    foreach (MusteriSiparis s in musteriSiparisleri) { sipOutStr.Add(s.ToString()); }

                    File.WriteAllLines($@"{filePath}\musteriSiparis.txt", sipOutStr);

                    string message = "Siparis Eklendi!";
                    string title = "Basari";
                    MessageBox.Show(message, title);
                }
            }

            else if (radioTshirtK.Checked)
            {
                if (musteriSecCombo.SelectedIndex == -1)
                {
                    string message = "Musteri Seciniz!!";
                    string title = "Hata";
                    MessageBox.Show(message, title);

                }

                else if ((adetBuy.Value > int.Parse(urunler[3].urunStokRaf)))
                {
                    string message = "Stok Yetersiz!";
                    string title = "Hata";
                    MessageBox.Show(message, title);
                }

                else if (adetBuy.Value < 1)
                {
                    string message = "Gecerli miktarda siparis veriniz!";
                    string title = "Hata";
                    MessageBox.Show(message, title);
                }

                //eger musteri secili ise ve alinan adet 0dan buyuk ve stoktan az ise
                else
                {
                    //alinan urunleri stoktan dusmek icin
                    urunler[3].urunStokRaf = (int.Parse(urunler[3].urunStokRaf) - adetBuy.Value).ToString();

                    List<string> urunOutStr = new List<string>();

                    foreach (Urun u in urunler) { urunOutStr.Add(u.ToString()); }

                    File.WriteAllLines($@"{filePath}\urun.txt", urunOutStr);


                    //siparisi siparis dosyasina eklemek icin
                    int index = musteriSecCombo.SelectedIndex;

                    List<string> sipOutStr = new List<string>();

                    musteriSiparisleri.Add(new MusteriSiparis(
                        musteriler[index].musteriId, musteriler[index].musteriIsim,
                        musteriler[index].musteriTelefon, musteriler[index].musteriAdres,
                        urunler[3].urunKod, urunler[3].urunAdi, adetBuy.Value.ToString(),urunler[3].urunFiyat)
                        );

                    foreach (MusteriSiparis s in musteriSiparisleri) { sipOutStr.Add(s.ToString()); }

                    File.WriteAllLines($@"{filePath}\musteriSiparis.txt", sipOutStr);

                    string message = "Siparis Eklendi!";
                    string title = "Basari";
                    MessageBox.Show(message, title);
                }
            }

            else if (radioPantalonK.Checked)
            {
                if (musteriSecCombo.SelectedIndex == -1)
                {
                    string message = "Musteri Seciniz!!";
                    string title = "Hata";
                    MessageBox.Show(message, title);

                }

                else if ((adetBuy.Value > int.Parse(urunler[4].urunStokRaf)))
                {
                    string message = "Stok Yetersiz!";
                    string title = "Hata";
                    MessageBox.Show(message, title);
                }

                else if (adetBuy.Value < 1)
                {
                    string message = "Gecerli miktarda siparis veriniz!";
                    string title = "Hata";
                    MessageBox.Show(message, title);
                }

                //eger musteri secili ise ve alinan adet 0dan buyuk ve stoktan az ise
                else
                {
                    //alinan urunleri stoktan dusmek icin
                    urunler[4].urunStokRaf = (int.Parse(urunler[4].urunStokRaf) - adetBuy.Value).ToString();

                    List<string> urunOutStr = new List<string>();

                    foreach (Urun u in urunler) { urunOutStr.Add(u.ToString()); }

                    File.WriteAllLines($@"{filePath}\urun.txt", urunOutStr);


                    //siparisi siparis dosyasina eklemek icin
                    int index = musteriSecCombo.SelectedIndex;

                    List<string> sipOutStr = new List<string>();

                    musteriSiparisleri.Add(new MusteriSiparis(
                        musteriler[index].musteriId, musteriler[index].musteriIsim,
                        musteriler[index].musteriTelefon, musteriler[index].musteriAdres,
                        urunler[4].urunKod, urunler[4].urunAdi, adetBuy.Value.ToString(), urunler[4].urunFiyat)
                        );

                    foreach (MusteriSiparis s in musteriSiparisleri) { sipOutStr.Add(s.ToString()); }

                    File.WriteAllLines($@"{filePath}\musteriSiparis.txt", sipOutStr);

                    string message = "Siparis Eklendi!";
                    string title = "Basari";
                    MessageBox.Show(message, title);
                }
            }


            else if (radioAyakkabiK.Checked)
            {
                if (musteriSecCombo.SelectedIndex == -1)
                {
                    string message = "Musteri Seciniz!!";
                    string title = "Hata";
                    MessageBox.Show(message, title);

                }

                else if ((adetBuy.Value > int.Parse(urunler[5].urunStokRaf)))
                {
                    string message = "Stok Yetersiz!";
                    string title = "Hata";
                    MessageBox.Show(message, title);
                }

                else if (adetBuy.Value < 1)
                {
                    string message = "Gecerli miktarda siparis veriniz!";
                    string title = "Hata";
                    MessageBox.Show(message, title);
                }

                //eger musteri secili ise ve alinan adet 0dan buyuk ve stoktan az ise
                else
                {
                    //alinan urunleri stoktan dusmek icin
                    urunler[5].urunStokRaf = (int.Parse(urunler[5].urunStokRaf) - adetBuy.Value).ToString();

                    List<string> urunOutStr = new List<string>();

                    foreach (Urun u in urunler) { urunOutStr.Add(u.ToString()); }

                    File.WriteAllLines($@"{filePath}\urun.txt", urunOutStr);


                    //siparisi siparis dosyasina eklemek icin
                    int index = musteriSecCombo.SelectedIndex;

                    List<string> sipOutStr = new List<string>();

                    musteriSiparisleri.Add(new MusteriSiparis(
                        musteriler[index].musteriId, musteriler[index].musteriIsim,
                        musteriler[index].musteriTelefon, musteriler[index].musteriAdres,
                        urunler[5].urunKod, urunler[5].urunAdi, adetBuy.Value.ToString(),urunler[5].urunFiyat)
                        );

                    foreach (MusteriSiparis s in musteriSiparisleri) { sipOutStr.Add(s.ToString()); }

                    File.WriteAllLines($@"{filePath}\musteriSiparis.txt", sipOutStr);

                    string message = "Siparis Eklendi!";
                    string title = "Basari";
                    MessageBox.Show(message, title);
                }
            }

            else if (radioTshirtC.Checked)
            {
                if (musteriSecCombo.SelectedIndex == -1)
                {
                    string message = "Musteri Seciniz!!";
                    string title = "Hata";
                    MessageBox.Show(message, title);

                }

                else if ((adetBuy.Value > int.Parse(urunler[6].urunStokRaf)))
                {
                    string message = "Stok Yetersiz!";
                    string title = "Hata";
                    MessageBox.Show(message, title);
                }

                else if (adetBuy.Value < 1)
                {
                    string message = "Gecerli miktarda siparis veriniz!";
                    string title = "Hata";
                    MessageBox.Show(message, title);
                }

                //eger musteri secili ise ve alinan adet 0dan buyuk ve stoktan az ise
                else
                {
                    //alinan urunleri stoktan dusmek icin
                    urunler[6].urunStokRaf = (int.Parse(urunler[6].urunStokRaf) - adetBuy.Value).ToString();

                    List<string> urunOutStr = new List<string>();

                    foreach (Urun u in urunler) { urunOutStr.Add(u.ToString()); }

                    File.WriteAllLines($@"{filePath}\urun.txt", urunOutStr);


                    //siparisi siparis dosyasina eklemek icin
                    int index = musteriSecCombo.SelectedIndex;

                    List<string> sipOutStr = new List<string>();

                    musteriSiparisleri.Add(new MusteriSiparis(
                        musteriler[index].musteriId, musteriler[index].musteriIsim,
                        musteriler[index].musteriTelefon, musteriler[index].musteriAdres,
                        urunler[6].urunKod, urunler[6].urunAdi, adetBuy.Value.ToString(),urunler[6].urunFiyat)
                        );

                    foreach (MusteriSiparis s in musteriSiparisleri) { sipOutStr.Add(s.ToString()); }

                    File.WriteAllLines($@"{filePath}\musteriSiparis.txt", sipOutStr);

                    string message = "Siparis Eklendi!";
                    string title = "Basari";
                    MessageBox.Show(message, title);
                }
            }

            else if (radioPantalonC.Checked)
            {
                if (musteriSecCombo.SelectedIndex == -1)
                {
                    string message = "Musteri Seciniz!!";
                    string title = "Hata";
                    MessageBox.Show(message, title);

                }

                else if ((adetBuy.Value > int.Parse(urunler[7].urunStokRaf)))
                {
                    string message = "Stok Yetersiz!";
                    string title = "Hata";
                    MessageBox.Show(message, title);
                }

                else if (adetBuy.Value < 1)
                {
                    string message = "Gecerli miktarda siparis veriniz!";
                    string title = "Hata";
                    MessageBox.Show(message, title);
                }

                //eger musteri secili ise ve alinan adet 0dan buyuk ve stoktan az ise
                else
                {
                    //alinan urunleri stoktan dusmek icin
                    urunler[7].urunStokRaf = (int.Parse(urunler[7].urunStokRaf) - adetBuy.Value).ToString();

                    List<string> urunOutStr = new List<string>();

                    foreach (Urun u in urunler) { urunOutStr.Add(u.ToString()); }

                    File.WriteAllLines($@"{filePath}\urun.txt", urunOutStr);


                    //siparisi siparis dosyasina eklemek icin
                    int index = musteriSecCombo.SelectedIndex;

                    List<string> sipOutStr = new List<string>();

                    musteriSiparisleri.Add(new MusteriSiparis(
                        musteriler[index].musteriId, musteriler[index].musteriIsim,
                        musteriler[index].musteriTelefon, musteriler[index].musteriAdres,
                        urunler[7].urunKod, urunler[7].urunAdi, adetBuy.Value.ToString(), urunler[7].urunFiyat)
                        );

                    foreach (MusteriSiparis s in musteriSiparisleri) { sipOutStr.Add(s.ToString()); }

                    File.WriteAllLines($@"{filePath}\musteriSiparis.txt", sipOutStr);

                    string message = "Siparis Eklendi!";
                    string title = "Basari";
                    MessageBox.Show(message, title);
                }
            }

            else if (radioAyakkabiC.Checked)
            {
                if (musteriSecCombo.SelectedIndex == -1)
                {
                    string message = "Musteri Seciniz!!";
                    string title = "Hata";
                    MessageBox.Show(message, title);

                }

                else if ((adetBuy.Value > int.Parse(urunler[8].urunStokRaf)))
                {
                    string message = "Stok Yetersiz!";
                    string title = "Hata";
                    MessageBox.Show(message, title);
                }

                else if (adetBuy.Value < 1)
                {
                    string message = "Gecerli miktarda siparis veriniz!";
                    string title = "Hata";
                    MessageBox.Show(message, title);
                }

                //eger musteri secili ise ve alinan adet 0dan buyuk ve stoktan az ise
                else
                {
                    //alinan urunleri stoktan dusmek icin
                    urunler[8].urunStokRaf = (int.Parse(urunler[8].urunStokRaf) - adetBuy.Value).ToString();

                    List<string> urunOutStr = new List<string>();

                    foreach (Urun u in urunler) { urunOutStr.Add(u.ToString()); }

                    File.WriteAllLines($@"{filePath}\urun.txt", urunOutStr);


                    //siparisi siparis dosyasina eklemek icin
                    int index = musteriSecCombo.SelectedIndex;

                    List<string> sipOutStr = new List<string>();

                    musteriSiparisleri.Add(new MusteriSiparis(
                        musteriler[index].musteriId, musteriler[index].musteriIsim,
                        musteriler[index].musteriTelefon, musteriler[index].musteriAdres,
                        urunler[8].urunKod, urunler[8].urunAdi, adetBuy.Value.ToString(),urunler[8].urunFiyat)
                        );

                    foreach (MusteriSiparis s in musteriSiparisleri) { sipOutStr.Add(s.ToString()); }

                    File.WriteAllLines($@"{filePath}\musteriSiparis.txt", sipOutStr);

                    string message = "Siparis Eklendi!";
                    string title = "Basari";
                    MessageBox.Show(message, title);
                }
            }

        }
    }
}
