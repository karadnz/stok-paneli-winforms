using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
    public partial class giris : Form
    {

        


        public giris()
        {
            InitializeComponent();
            

            


        }



        private void button1_Click(object sender, EventArgs e)
        {
            musteriPanel musteripanel = new musteriPanel();
            musteripanel.Show();
            this.Hide();
        }

        

        private void button2_Click(object sender, EventArgs e)
        {
            yoneticiPanel yoneticipanel = new yoneticiPanel();
            yoneticipanel.Show();
            this.Hide();

        }








        private void giris_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
