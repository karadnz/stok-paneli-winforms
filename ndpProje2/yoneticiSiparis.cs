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
    public partial class yoneticiSiparis : Form
    {
        public yoneticiSiparis()
        {
            InitializeComponent();

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

                tedarikciSecCombo.Items.Add(tedarikci.tedarikciIsim);
            }
        }

        private void btnBilgi_Click(object sender, EventArgs e)
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

                bilgiAd.Text = urunler[0].urunAdi;
                bilgiFiyat.Text = urunler[0].urunFiyat;
                bilgiStok.Text = urunler[0].urunStokRaf;
                bilgiStokDepo.Text = urunler[0].urunStokDepo;

            }

            else if (radioPantalonE.Checked)
            {
                bilgiAd.Text = urunler[1].urunAdi;
                bilgiFiyat.Text = urunler[1].urunFiyat;
                bilgiStok.Text = urunler[1].urunStokRaf;
                bilgiStokDepo.Text = urunler[1].urunStokDepo;
            }


            else if (radioAyakkabiE.Checked)
            {
                bilgiAd.Text = urunler[2].urunAdi;
                bilgiFiyat.Text = urunler[2].urunFiyat;
                bilgiStok.Text = urunler[2].urunStokRaf;
                bilgiStokDepo.Text = urunler[2].urunStokDepo;
            }

            else if (radioTshirtK.Checked)
            {
                bilgiAd.Text = urunler[3].urunAdi;
                bilgiFiyat.Text = urunler[3].urunFiyat;
                bilgiStok.Text = urunler[3].urunStokRaf;
                bilgiStokDepo.Text = urunler[3].urunStokDepo;
            }

            else if (radioPantalonK.Checked)
            {
                bilgiAd.Text = urunler[4].urunAdi;
                bilgiFiyat.Text = urunler[4].urunFiyat;
                bilgiStok.Text = urunler[4].urunStokRaf;
                bilgiStokDepo.Text = urunler[4].urunStokDepo;
            }


            else if (radioAyakkabiK.Checked)
            {
                bilgiAd.Text = urunler[5].urunAdi;
                bilgiFiyat.Text = urunler[5].urunFiyat;
                bilgiStok.Text = urunler[5].urunStokRaf;
                bilgiStokDepo.Text = urunler[5].urunStokDepo;
            }

            else if (radioTshirtC.Checked)
            {
                bilgiAd.Text = urunler[6].urunAdi;
                bilgiFiyat.Text = urunler[6].urunFiyat;
                bilgiStok.Text = urunler[6].urunStokRaf;
                bilgiStokDepo.Text = urunler[6].urunStokDepo;
            }

            else if (radioPantalonC.Checked)
            {
                bilgiAd.Text = urunler[7].urunAdi;
                bilgiFiyat.Text = urunler[7].urunFiyat;
                bilgiStok.Text = urunler[7].urunStokRaf;
                bilgiStokDepo.Text = urunler[7].urunStokDepo;
            }

            else if (radioAyakkabiC.Checked)
            {
                bilgiAd.Text = urunler[8].urunAdi;
                bilgiFiyat.Text = urunler[8].urunFiyat;
                bilgiStok.Text = urunler[8].urunStokRaf;
                bilgiStokDepo.Text = urunler[8].urunStokDepo;
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



            //dosyadan tedarikcileri cek liste yap


            List<Tedarikci> tedarikciler = new List<Tedarikci>();

            lines = File.ReadAllLines($@"{filePath}\tedarikci.txt").ToList();


            foreach (string line in lines)
            {
                string[] items = line.Split(',');
                Tedarikci tedarikci = new Tedarikci(items[0], items[1], items[2], items[3]);
                tedarikciler.Add(tedarikci);

            }


            //dosyadan tedarikci siparisleri cek

            List<TedarikciSiparis> tedarikciSiparisleri = new List<TedarikciSiparis>();

            lines = File.ReadAllLines($@"{filePath}\tedarikciSiparis.txt").ToList();

            foreach (string line in lines)
            {
                string[] items = line.Split(',');
                TedarikciSiparis siparis = new TedarikciSiparis(items[0], items[1], items[2], items[3], items[4], items[5], items[6],items[7]);
                tedarikciSiparisleri.Add(siparis);

            }


            if (radioTshirtE.Checked)
            {

                if (tedarikciSecCombo.SelectedIndex == -1)
                {
                    string message = "Tedarikci Seciniz!!";
                    string title = "Hata";
                    MessageBox.Show(message, title);

                }

               

                else if (adetBuy.Value < 1)
                {
                    string message = "Gecerli miktarda siparis veriniz!";
                    string title = "Hata";
                    MessageBox.Show(message, title);
                }

                //eger tedarikci secili ise ve alinan adet 0dan buyuk ve stoktan az ise
                else
                {
                    //alinan urunleri stokga eklemek icin
                    urunler[0].urunStokDepo = (int.Parse(urunler[0].urunStokDepo) + adetBuy.Value).ToString();

                    List<string> urunOutStr = new List<string>();

                    foreach (Urun u in urunler) { urunOutStr.Add(u.ToString()); }

                    File.WriteAllLines($@"{filePath}\urun.txt", urunOutStr);


                    //siparisi siparis dosyasina eklemek icin
                    int index = tedarikciSecCombo.SelectedIndex;

                    List<string> sipOutStr = new List<string>();

                    tedarikciSiparisleri.Add(new TedarikciSiparis(
                        tedarikciler[index].tedarikciId, tedarikciler[index].tedarikciIsim,
                        tedarikciler[index].tedarikciTelefon, tedarikciler[index].tedarikciAdres,
                        urunler[0].urunKod, urunler[0].urunAdi, adetBuy.Value.ToString(),urunler[0].urunFiyat)
                        );

                    foreach (TedarikciSiparis s in tedarikciSiparisleri) { sipOutStr.Add(s.ToString()); }

                    File.WriteAllLines($@"{filePath}\tedarikciSiparis.txt", sipOutStr);

                    string message = "Siparis Eklendi!";
                    string title = "Basari";
                    MessageBox.Show(message, title);
                }

            }

            else if (radioPantalonE.Checked)
            {
                if (tedarikciSecCombo.SelectedIndex == -1)
                {
                    string message = "Tedarikci Seciniz!!";
                    string title = "Hata";
                    MessageBox.Show(message, title);

                }



                else if (adetBuy.Value < 1)
                {
                    string message = "Gecerli miktarda siparis veriniz!";
                    string title = "Hata";
                    MessageBox.Show(message, title);
                }

                //eger tedarikci secili ise ve alinan adet 0dan buyuk ve stoktan az ise
                else
                {
                    //alinan urunleri stokga eklemek icin
                    urunler[1].urunStokDepo = (int.Parse(urunler[1].urunStokDepo) + adetBuy.Value).ToString();

                    List<string> urunOutStr = new List<string>();

                    foreach (Urun u in urunler) { urunOutStr.Add(u.ToString()); }

                    File.WriteAllLines($@"{filePath}\urun.txt", urunOutStr);


                    //siparisi siparis dosyasina eklemek icin
                    int index = tedarikciSecCombo.SelectedIndex;

                    List<string> sipOutStr = new List<string>();

                    tedarikciSiparisleri.Add(new TedarikciSiparis(
                        tedarikciler[index].tedarikciId, tedarikciler[index].tedarikciIsim,
                        tedarikciler[index].tedarikciTelefon, tedarikciler[index].tedarikciAdres,
                        urunler[1].urunKod, urunler[1].urunAdi, adetBuy.Value.ToString(), urunler[1].urunFiyat)
                        );

                    foreach (TedarikciSiparis s in tedarikciSiparisleri) { sipOutStr.Add(s.ToString()); }

                    File.WriteAllLines($@"{filePath}\tedarikciSiparis.txt", sipOutStr);

                    string message = "Siparis Eklendi!";
                    string title = "Basari";
                    MessageBox.Show(message, title);
                }
            }


            else if (radioAyakkabiE.Checked)
            {
                if (tedarikciSecCombo.SelectedIndex == -1)
                {
                    string message = "Tedarikci Seciniz!!";
                    string title = "Hata";
                    MessageBox.Show(message, title);

                }



                else if (adetBuy.Value < 1)
                {
                    string message = "Gecerli miktarda siparis veriniz!";
                    string title = "Hata";
                    MessageBox.Show(message, title);
                }

                //eger tedarikci secili ise ve alinan adet 0dan buyuk ve stoktan az ise
                else
                {
                    //alinan urunleri stokga eklemek icin
                    urunler[2].urunStokDepo = (int.Parse(urunler[2].urunStokDepo) + adetBuy.Value).ToString();

                    List<string> urunOutStr = new List<string>();

                    foreach (Urun u in urunler) { urunOutStr.Add(u.ToString()); }

                    File.WriteAllLines($@"{filePath}\urun.txt", urunOutStr);


                    //siparisi siparis dosyasina eklemek icin
                    int index = tedarikciSecCombo.SelectedIndex;

                    List<string> sipOutStr = new List<string>();

                    tedarikciSiparisleri.Add(new TedarikciSiparis(
                        tedarikciler[index].tedarikciId, tedarikciler[index].tedarikciIsim,
                        tedarikciler[index].tedarikciTelefon, tedarikciler[index].tedarikciAdres,
                        urunler[2].urunKod, urunler[2].urunAdi, adetBuy.Value.ToString(), urunler[2].urunFiyat)
                        );

                    foreach (TedarikciSiparis s in tedarikciSiparisleri) { sipOutStr.Add(s.ToString()); }

                    File.WriteAllLines($@"{filePath}\tedarikciSiparis.txt", sipOutStr);

                    string message = "Siparis Eklendi!";
                    string title = "Basari";
                    MessageBox.Show(message, title);
                }
            }

            else if (radioTshirtK.Checked)
            {
                if (tedarikciSecCombo.SelectedIndex == -1)
                {
                    string message = "Tedarikci Seciniz!!";
                    string title = "Hata";
                    MessageBox.Show(message, title);

                }



                else if (adetBuy.Value < 1)
                {
                    string message = "Gecerli miktarda siparis veriniz!";
                    string title = "Hata";
                    MessageBox.Show(message, title);
                }

                //eger tedarikci secili ise ve alinan adet 0dan buyuk ve stoktan az ise
                else
                {
                    //alinan urunleri stokga eklemek icin
                    urunler[3].urunStokDepo = (int.Parse(urunler[3].urunStokDepo) + adetBuy.Value).ToString();

                    List<string> urunOutStr = new List<string>();

                    foreach (Urun u in urunler) { urunOutStr.Add(u.ToString()); }

                    File.WriteAllLines($@"{filePath}\urun.txt", urunOutStr);


                    //siparisi siparis dosyasina eklemek icin
                    int index = tedarikciSecCombo.SelectedIndex;

                    List<string> sipOutStr = new List<string>();

                    tedarikciSiparisleri.Add(new TedarikciSiparis(
                        tedarikciler[index].tedarikciId, tedarikciler[index].tedarikciIsim,
                        tedarikciler[index].tedarikciTelefon, tedarikciler[index].tedarikciAdres,
                        urunler[3].urunKod, urunler[3].urunAdi, adetBuy.Value.ToString(), urunler[3].urunFiyat)
                        );

                    foreach (TedarikciSiparis s in tedarikciSiparisleri) { sipOutStr.Add(s.ToString()); }

                    File.WriteAllLines($@"{filePath}\tedarikciSiparis.txt", sipOutStr);

                    string message = "Siparis Eklendi!";
                    string title = "Basari";
                    MessageBox.Show(message, title);
                }
            }

            else if (radioPantalonK.Checked)
            {
                if (tedarikciSecCombo.SelectedIndex == -1)
                {
                    string message = "Tedarikci Seciniz!!";
                    string title = "Hata";
                    MessageBox.Show(message, title);

                }



                else if (adetBuy.Value < 1)
                {
                    string message = "Gecerli miktarda siparis veriniz!";
                    string title = "Hata";
                    MessageBox.Show(message, title);
                }

                //eger tedarikci secili ise ve alinan adet 0dan buyuk ve stoktan az ise
                else
                {
                    //alinan urunleri stokga eklemek icin
                    urunler[4].urunStokDepo = (int.Parse(urunler[4].urunStokDepo) + adetBuy.Value).ToString();

                    List<string> urunOutStr = new List<string>();

                    foreach (Urun u in urunler) { urunOutStr.Add(u.ToString()); }

                    File.WriteAllLines($@"{filePath}\urun.txt", urunOutStr);


                    //siparisi siparis dosyasina eklemek icin
                    int index = tedarikciSecCombo.SelectedIndex;

                    List<string> sipOutStr = new List<string>();

                    tedarikciSiparisleri.Add(new TedarikciSiparis(
                        tedarikciler[index].tedarikciId, tedarikciler[index].tedarikciIsim,
                        tedarikciler[index].tedarikciTelefon, tedarikciler[index].tedarikciAdres,
                        urunler[4].urunKod, urunler[4].urunAdi, adetBuy.Value.ToString(), urunler[4].urunFiyat)
                        );

                    foreach (TedarikciSiparis s in tedarikciSiparisleri) { sipOutStr.Add(s.ToString()); }

                    File.WriteAllLines($@"{filePath}\tedarikciSiparis.txt", sipOutStr);

                    string message = "Siparis Eklendi!";
                    string title = "Basari";
                    MessageBox.Show(message, title);
                }
            }


            else if (radioAyakkabiK.Checked)
            {
                if (tedarikciSecCombo.SelectedIndex == -1)
                {
                    string message = "Tedarikci Seciniz!!";
                    string title = "Hata";
                    MessageBox.Show(message, title);

                }



                else if (adetBuy.Value < 1)
                {
                    string message = "Gecerli miktarda siparis veriniz!";
                    string title = "Hata";
                    MessageBox.Show(message, title);
                }

                //eger tedarikci secili ise ve alinan adet 0dan buyuk ve stoktan az ise
                else
                {
                    //alinan urunleri stokga eklemek icin
                    urunler[5].urunStokDepo = (int.Parse(urunler[5].urunStokDepo) + adetBuy.Value).ToString();

                    List<string> urunOutStr = new List<string>();

                    foreach (Urun u in urunler) { urunOutStr.Add(u.ToString()); }

                    File.WriteAllLines($@"{filePath}\urun.txt", urunOutStr);


                    //siparisi siparis dosyasina eklemek icin
                    int index = tedarikciSecCombo.SelectedIndex;

                    List<string> sipOutStr = new List<string>();

                    tedarikciSiparisleri.Add(new TedarikciSiparis(
                        tedarikciler[index].tedarikciId, tedarikciler[index].tedarikciIsim,
                        tedarikciler[index].tedarikciTelefon, tedarikciler[index].tedarikciAdres,
                        urunler[5].urunKod, urunler[5].urunAdi, adetBuy.Value.ToString(), urunler[5].urunFiyat)
                        );

                    foreach (TedarikciSiparis s in tedarikciSiparisleri) { sipOutStr.Add(s.ToString()); }

                    File.WriteAllLines($@"{filePath}\tedarikciSiparis.txt", sipOutStr);

                    string message = "Siparis Eklendi!";
                    string title = "Basari";
                    MessageBox.Show(message, title);
                }
            }

            else if (radioTshirtC.Checked)
            {
                if (tedarikciSecCombo.SelectedIndex == -1)
                {
                    string message = "Tedarikci Seciniz!!";
                    string title = "Hata";
                    MessageBox.Show(message, title);

                }



                else if (adetBuy.Value < 1)
                {
                    string message = "Gecerli miktarda siparis veriniz!";
                    string title = "Hata";
                    MessageBox.Show(message, title);
                }

                //eger tedarikci secili ise ve alinan adet 0dan buyuk ve stoktan az ise
                else
                {
                    //alinan urunleri stokga eklemek icin
                    urunler[6].urunStokDepo = (int.Parse(urunler[6].urunStokDepo) + adetBuy.Value).ToString();

                    List<string> urunOutStr = new List<string>();

                    foreach (Urun u in urunler) { urunOutStr.Add(u.ToString()); }

                    File.WriteAllLines($@"{filePath}\urun.txt", urunOutStr);


                    //siparisi siparis dosyasina eklemek icin
                    int index = tedarikciSecCombo.SelectedIndex;

                    List<string> sipOutStr = new List<string>();

                    tedarikciSiparisleri.Add(new TedarikciSiparis(
                        tedarikciler[index].tedarikciId, tedarikciler[index].tedarikciIsim,
                        tedarikciler[index].tedarikciTelefon, tedarikciler[index].tedarikciAdres,
                        urunler[6].urunKod, urunler[6].urunAdi, adetBuy.Value.ToString(), urunler[6].urunFiyat)
                        );

                    foreach (TedarikciSiparis s in tedarikciSiparisleri) { sipOutStr.Add(s.ToString()); }

                    File.WriteAllLines($@"{filePath}\tedarikciSiparis.txt", sipOutStr);

                    string message = "Siparis Eklendi!";
                    string title = "Basari";
                    MessageBox.Show(message, title);
                }
            }

            else if (radioPantalonC.Checked)
            {
                if (tedarikciSecCombo.SelectedIndex == -1)
                {
                    string message = "Tedarikci Seciniz!!";
                    string title = "Hata";
                    MessageBox.Show(message, title);

                }



                else if (adetBuy.Value < 1)
                {
                    string message = "Gecerli miktarda siparis veriniz!";
                    string title = "Hata";
                    MessageBox.Show(message, title);
                }

                //eger tedarikci secili ise ve alinan adet 0dan buyuk ve stoktan az ise
                else
                {
                    //alinan urunleri stokga eklemek icin
                    urunler[7].urunStokDepo = (int.Parse(urunler[7].urunStokDepo) + adetBuy.Value).ToString();

                    List<string> urunOutStr = new List<string>();

                    foreach (Urun u in urunler) { urunOutStr.Add(u.ToString()); }

                    File.WriteAllLines($@"{filePath}\urun.txt", urunOutStr);


                    //siparisi siparis dosyasina eklemek icin
                    int index = tedarikciSecCombo.SelectedIndex;

                    List<string> sipOutStr = new List<string>();

                    tedarikciSiparisleri.Add(new TedarikciSiparis(
                        tedarikciler[index].tedarikciId, tedarikciler[index].tedarikciIsim,
                        tedarikciler[index].tedarikciTelefon, tedarikciler[index].tedarikciAdres,
                        urunler[7].urunKod, urunler[7].urunAdi, adetBuy.Value.ToString(), urunler[7].urunFiyat)
                        );

                    foreach (TedarikciSiparis s in tedarikciSiparisleri) { sipOutStr.Add(s.ToString()); }

                    File.WriteAllLines($@"{filePath}\tedarikciSiparis.txt", sipOutStr);

                    string message = "Siparis Eklendi!";
                    string title = "Basari";
                    MessageBox.Show(message, title);
                }
            }

            else if (radioAyakkabiC.Checked)
            {
                if (tedarikciSecCombo.SelectedIndex == -1)
                {
                    string message = "Tedarikci Seciniz!!";
                    string title = "Hata";
                    MessageBox.Show(message, title);

                }



                else if (adetBuy.Value < 1)
                {
                    string message = "Gecerli miktarda siparis veriniz!";
                    string title = "Hata";
                    MessageBox.Show(message, title);
                }

                //eger tedarikci secili ise ve alinan adet 0dan buyuk ve stoktan az ise
                else
                {
                    //alinan urunleri stokga eklemek icin
                    urunler[8].urunStokDepo = (int.Parse(urunler[8].urunStokDepo) + adetBuy.Value).ToString();

                    List<string> urunOutStr = new List<string>();

                    foreach (Urun u in urunler) { urunOutStr.Add(u.ToString()); }

                    File.WriteAllLines($@"{filePath}\urun.txt", urunOutStr);


                    //siparisi siparis dosyasina eklemek icin
                    int index = tedarikciSecCombo.SelectedIndex;

                    List<string> sipOutStr = new List<string>();

                    tedarikciSiparisleri.Add(new TedarikciSiparis(
                        tedarikciler[index].tedarikciId, tedarikciler[index].tedarikciIsim,
                        tedarikciler[index].tedarikciTelefon, tedarikciler[index].tedarikciAdres,
                        urunler[8].urunKod, urunler[8].urunAdi, adetBuy.Value.ToString(), urunler[8].urunFiyat)
                        );

                    foreach (TedarikciSiparis s in tedarikciSiparisleri) { sipOutStr.Add(s.ToString()); }

                    File.WriteAllLines($@"{filePath}\tedarikciSiparis.txt", sipOutStr);

                    string message = "Siparis Eklendi!";
                    string title = "Basari";
                    MessageBox.Show(message, title);
                }
            }


        }
    }
}
