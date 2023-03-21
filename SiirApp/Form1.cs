using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SiirApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            var yazar = yazarText.Text;
            var siirAdi = siirAdiText.Text;
            var satirSayisi = satirSayisiText.Text.Length == 0 ? 0 : Convert.ToInt16(satirSayisiText.Text);
            var besteleyen = besteleyenText.Text;
            var bestelenmeTarihi = tarihText.Text.Length == 0 ? 0 : Convert.ToInt16(tarihText.Text);

            if (bestelenmeTarihi == 0)
            {
                var siir = new Siir();
                siir.yazar = yazar.Length == 0 ? "ANONIM" : yazar;
                siir.siirAdi = siirAdi;
                siir.satirSayisi = satirSayisi;
                listBox1.Items.Add(siir.yazar);
                listBox1.Items.Add(siir.siirAdi);
                listBox1.Items.Add(siir.satirSayisi);
                listBox1.Items.Add(siir.Aciklama());

            }
            else
            {
                var bestelenmisSiir = new BestelenenSiirler();
                bestelenmisSiir.yazar = yazar.Length == 0 ? "ANONIM" : yazar;
                bestelenmisSiir.siirAdi = siirAdi;
                bestelenmisSiir.satirSayisi = satirSayisi;
                bestelenmisSiir.siiriBestelyenKisi = besteleyen;
                bestelenmisSiir.siirinBestelendigiTarih = bestelenmeTarihi;
                listBox1.Items.Add(bestelenmisSiir.yazar);
                listBox1.Items.Add(bestelenmisSiir.siirAdi);
                listBox1.Items.Add(bestelenmisSiir.satirSayisi);
                listBox1.Items.Add(bestelenmisSiir.siiriBestelyenKisi);
                listBox1.Items.Add(bestelenmisSiir.siirinBestelendigiTarih);
                listBox1.Items.Add(bestelenmisSiir.Aciklama());
            }
        }
    }
}
