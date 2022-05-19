using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


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
    public class Musteri
    {
        
        public string musteriId { get; set; }
        public string musteriIsim { get; set; }
        public string musteriTelefon { get; set; }
        public string musteriAdres { get; set; }


        public Musteri(string musteriId, string musteriIsim, string musteriTelefon, string musteriAdres)
        {
            this.musteriId = musteriId;
            this.musteriIsim = musteriIsim;
            this.musteriTelefon = musteriTelefon;
            this.musteriAdres = musteriAdres;
        }

        public override string ToString()
        {
            return $"{musteriId},{musteriIsim},{musteriTelefon},{musteriAdres}";
        }



    }




    public class Tedarikci
    {
        
        public string tedarikciId { get; set; }
        public string tedarikciIsim { get; set; }
        public string tedarikciTelefon { get; set; }
        public string tedarikciAdres { get; set; }

        //ctrl + .

        public Tedarikci(string tedarikciId, string tedarikciIsim, string tedarikciTelefon, string tedarikciAdres)
        {
            this.tedarikciId = tedarikciId;
            this.tedarikciIsim = tedarikciIsim;
            this.tedarikciTelefon = tedarikciTelefon;
            this.tedarikciAdres = tedarikciAdres;
        }

        public override string ToString()
        {
            return $"{tedarikciId},{tedarikciIsim},{tedarikciTelefon},{tedarikciAdres}";
        }





    }


    public class Urun
    {


        public string urunKod { get; set; }
        public string urunAdi { get; set; }
        public string urunCinsiyet { get; set; }


        public string urunFiyat { get; set; }
        public string urunStokRaf { get; set; }

        public string urunStokDepo { get; set; }


        public Urun(string urunKod, string urunAdi, string urunCinsiyet, string urunFiyat, string urunStokRaf, string urunStokDepo)
        {
            this.urunKod = urunKod;
            this.urunAdi = urunAdi;
            this.urunCinsiyet = urunCinsiyet;
            this.urunFiyat = urunFiyat;
            this.urunStokRaf = urunStokRaf;
            this.urunStokDepo = urunStokDepo;
        }


        public override string ToString()
        {
            return $"{urunKod},{urunAdi},{urunCinsiyet},{urunFiyat},{urunStokRaf},{urunStokDepo}";
        }


    }


    public class MusteriSiparis
    {
        

        public string musteriId { get; set; }
        public string musteriIsim { get; set; }
        public string musteriTelefon { get; set; }
        public string musteriAdres { get; set; }

        public string urunKod { get; set; }

        public string urunAdi { get; set; }

        public string siparisAdet { get; set; }

        public string urunFiyat { get; set; }



        public MusteriSiparis(string musteriId, string musteriIsim, string musteriTelefon, string musteriAdres, string urunKod, string urunAdi, string siparisAdet, string urunFiyat)
        {
            this.musteriId = musteriId;
            this.musteriIsim = musteriIsim;
            this.musteriTelefon = musteriTelefon;
            this.musteriAdres = musteriAdres;
            this.urunKod = urunKod;
            this.urunAdi = urunAdi;
            this.siparisAdet = siparisAdet;
            this.urunFiyat = urunFiyat;
        }


        public override string ToString()
        {
            return $"{musteriId},{musteriIsim},{musteriTelefon},{musteriAdres},{urunKod},{urunAdi},{siparisAdet},{urunFiyat}";
        }




    }




    public class TedarikciSiparis
    {


        public string tedarikciId { get; set; }
        public string tedarikciIsim { get; set; }
        public string tedarikciTelefon { get; set; }
        public string tedarikciAdres { get; set; }

        public string urunKod { get; set; }

        public string urunAdi { get; set; }

        public string siparisAdet { get; set; }

        public string urunFiyat { get; set; }



        public TedarikciSiparis(string tedarikciId, string tedarikciIsim, string tedarikciTelefon, string tedarikciAdres, string urunKod, string urunAdi, string siparisAdet, string urunFiyat)
        {
            this.tedarikciId = tedarikciId;
            this.tedarikciIsim = tedarikciIsim;
            this.tedarikciTelefon = tedarikciTelefon;
            this.tedarikciAdres = tedarikciAdres;
            this.urunKod = urunKod;
            this.urunAdi = urunAdi;
            this.siparisAdet = siparisAdet;
            this.urunFiyat = urunFiyat;

        }


        public override string ToString()
        {
            return $"{tedarikciId},{tedarikciIsim},{tedarikciTelefon},{tedarikciAdres},{urunKod},{urunAdi},{siparisAdet},{urunFiyat}";
        }




    }


    public class Gider
    {
        

        public string giderTarih { get; set; }
        public string giderPersonel { get; set; }
        public string giderGida { get; set; }
        public string giderElektrik { get; set; }
        public string giderIsitma { get; set; }
        public string giderDiger { get; set; }


        public Gider(string giderTarih, string giderPersonel, string giderGida, string giderElektrik, string giderIsitma, string giderDiger)
        {
            this.giderTarih = giderTarih;
            this.giderPersonel = giderPersonel;
            this.giderGida = giderGida;
            this.giderElektrik = giderElektrik;
            this.giderIsitma = giderIsitma;
            this.giderDiger = giderDiger;
        }


        public override string ToString()
        {
            return $"{giderTarih},{giderPersonel},{giderGida},{giderElektrik},{giderIsitma},{giderDiger}";
        }



    }






    public static class Fonksiyonlar
    {

        public static string filePath = @"C:\depo";
        public static string deneme()
        {
            return "sa";
        }

        
    }



    
}
