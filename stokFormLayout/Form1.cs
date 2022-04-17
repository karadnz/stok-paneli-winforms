using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Runtime.InteropServices; //rounded kose icin

namespace stokFormLayout
{
    public partial class Form1 : Form
    {
        //rounded kose

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn
        (
        int nLeftRect,
        int nTopRect,
        int nRightRect,
        int nBottomRect,
        int nWidthEllipse,
        int nHeightEllipse
        );

        //rounded kose

        public Form1()
        {
            InitializeComponent();

            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25)); //rounded kose

            //tiklanan butonu belirtmek icin
            pnlNav.Height = btnAnasayfa.Height;
            pnlNav.Top = btnAnasayfa.Top;
            pnlNav.Left = btnAnasayfa.Left;
            btnAnasayfa.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void btnAnasayfa_Click(object sender, EventArgs e)
        {
            //tiklanan butonu belirtmek icin
            pnlNav.Height = btnAnasayfa.Height;
            pnlNav.Top = btnAnasayfa.Top;
            pnlNav.Left = btnAnasayfa.Left;
            btnAnasayfa.BackColor = Color.FromArgb(46, 51, 73); 




        }

        private void btnStok_Click(object sender, EventArgs e)
        {
            //tiklanan butonu belirtmek icin
            pnlNav.Height = btnStok.Height;
            pnlNav.Top = btnStok.Top;
            pnlNav.Left = btnStok.Left;
            btnStok.BackColor = Color.FromArgb(46, 51, 73);

        }

        private void btnTSiparis_Click(object sender, EventArgs e)
        {
            //tiklanan butonu belirtmek icin
            pnlNav.Height = btnTSiparis.Height;
            pnlNav.Top = btnTSiparis.Top;
            pnlNav.Left = btnTSiparis.Left;
            btnTSiparis.BackColor = Color.FromArgb(46, 51, 73);

        }

        private void btnMSiparis_Click(object sender, EventArgs e)
        {
            //tiklanan butonu belirtmek icin
            pnlNav.Height = btnMSiparis.Height;
            pnlNav.Top = btnMSiparis.Top;
            pnlNav.Left = btnMSiparis.Left;
            btnMSiparis.BackColor = Color.FromArgb(46, 51, 73);

        }

        private void btnTedarikci_Click(object sender, EventArgs e)
        {
            //tiklanan butonu belirtmek icin
            pnlNav.Height = btnTedarikci.Height;
            pnlNav.Top = btnTedarikci.Top;
            pnlNav.Left = btnTedarikci.Left;
            btnTedarikci.BackColor = Color.FromArgb(46, 51, 73);

        }

        private void btnMusteri_Click(object sender, EventArgs e)
        {
            //tiklanan butonu belirtmek icin
            pnlNav.Height = btnMusteri.Height;
            pnlNav.Top = btnMusteri.Top;
            pnlNav.Left = btnMusteri.Left;
            btnMusteri.BackColor = Color.FromArgb(46, 51, 73);

        }

        private void btnGider_Click(object sender, EventArgs e)
        {
            //tiklanan butonu belirtmek icin
            pnlNav.Height = btnGider.Height;
            pnlNav.Top = btnGider.Top;
            pnlNav.Left = btnGider.Left;
            btnGider.BackColor = Color.FromArgb(46, 51, 73);

        }

        private void btnAyar_Click(object sender, EventArgs e)
        {
            //tiklanan butonu belirtmek icin
            pnlNav.Height = btnAyar.Height;
            pnlNav.Top = btnAyar.Top;
            pnlNav.Left = btnAyar.Left;
            btnAyar.BackColor = Color.FromArgb(46, 51, 73);

        }

        private void btnGider_Leave(object sender, EventArgs e)
        {
            btnGider.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnAyar_Leave(object sender, EventArgs e)
        {
            btnAyar.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnTSiparis_Leave(object sender, EventArgs e)
        {
            btnTSiparis.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnMSiparis_Leave(object sender, EventArgs e)
        {
            btnMSiparis.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnTedarikci_Leave(object sender, EventArgs e)
        {
            btnTedarikci.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnMusteri_Leave(object sender, EventArgs e)
        {
            btnMusteri.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnStok_Leave(object sender, EventArgs e)
        {
            btnStok.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnAnasayfa_Leave(object sender, EventArgs e)
        {
            btnAnasayfa.BackColor = Color.FromArgb(24, 30, 54);
        }
    }
}
