using System;
using System.Collections.Generic;
using System.Linq;
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
    //static class program

    
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// 
     
        [STAThread]

        static void Main()
        {

            //string filePathD = @"C:\depo\deneme.txt";
            //bool fileExists = File.Exists(filePathD);
            //if(!fileExists)
            //{
            //    File.Create(@"C:\depo\deneme.txt");
            //}

            //directory kontrol

            string directoryPath = @"C:\depo\";
            if (!File.Exists(directoryPath)) { Directory.CreateDirectory(directoryPath); }


            //string filePathGiderler = @"C:\depo\giderler.txt";
            //string filePathMusteri = @"C:\depo\musteri.txt";
            //string filePathMusteriSiparis = @"C:\depo\musteriSiparis.txt";
            //string filePathTedarikci = @"C:\depo\tedarikci.txt";
            //string filePathTedarikciSiparis = @"C:\depo\tedarikciSiparis.txt";
            string filePathUrun = @"C:\depo\urun.txt";
            //txt kontrol

            string[] pathes = new string[] { @"C:\depo\giderler.txt" , @"C:\depo\musteri.txt", @"C:\depo\musteriSiparis.txt", @"C:\depo\tedarikci.txt"
            ,@"C:\depo\tedarikciSiparis.txt"};

            foreach(string path in pathes)
            {
                if(!(File.Exists(path)))
                {
                    File.Create(path).Close();

                }
            }


            //urun dosyasi olusturma
            if(!(File.Exists(filePathUrun)))
            {
                File.Create(filePathUrun).Close();

                List<Urun> urunler = new List<Urun>();

                urunler.Add(new Urun("e01", "T-shirt Erkek", "Erkek", "100", "100", "200"));
                urunler.Add(new Urun("e02", "Pantalon Erkek", "Erkek", "150", "75", "150"));
                urunler.Add(new Urun("e03", "Ayakkabi Erkek", "Erkek", "750", "50", "100"));

                urunler.Add(new Urun("k01", "T-shirt Kadin", "Kadin", "90", "100", "200"));
                urunler.Add(new Urun("k03", "Pantalon Kadin", "Kadin", "140", "75", "150"));
                urunler.Add(new Urun("k03", "Ayakkabi Kadin", "Kadin", "740", "50", "100"));

                urunler.Add(new Urun("c01", "T-shirt Cocuk", "Cocuk", "60", "100", "200"));
                urunler.Add(new Urun("c02", "Pantalon Cocuk", "Cocuk", "70", "75", "150"));
                urunler.Add(new Urun("c03", "Ayakkabi Cocuk", "Cocuk", "80", "50", "100"));

                List<string> urunOutStr = new List<string>();

                foreach (Urun u in urunler) { urunOutStr.Add(u.ToString()); }

                File.WriteAllLines($@"{directoryPath}\urun.txt", urunOutStr);



            }





            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            Application.Run(new giris());
        }
    }
}
