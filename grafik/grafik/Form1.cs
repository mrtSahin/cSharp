using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace grafik
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)  //  HESAPLA BUTONU
        {

            chart1.Series["s1"].Points.Clear();

            var degerler = degerlerDon();
            string[] degerlerText = { "Egitim", "Gida", "Akaryakit", "Saglik", "Diger"};

            for (int i = 0; i < 5; i++)
            {
                  chart1.Series["s1"].Points.AddXY(oranBul(degerler[i], degerler[5]) + "\n" + degerlerText[i], (degerler[i] * 100 / degerler[5]).ToString());
            }

        }

        private void button2_Click(object sender, EventArgs e) // YÜZDE HESAPLA BUTONU
        {
            var degerler = degerlerDon();
            var istenenAlanIndex = comboBox1.SelectedIndex;
            var istenenAlanText = comboBox1.Text;
            var oran = oranBul(degerler[istenenAlanIndex], degerler[5]);
            label7.Text= istenenAlanText+" harcamaları "+oran+" oranındadır";

        }

        private int[] degerlerDon()
        {
            int egitim = Convert.ToInt32(textBoxEgitim.Text);
            int gida = Convert.ToInt32(textBoxGida.Text);
            int akaryakit = Convert.ToInt32(textBoxAkaryakit.Text);
            int saglik = Convert.ToInt32(textBoxSaglik.Text);
            int diger = Convert.ToInt32(textBoxDiger.Text);

            int toplam = egitim + gida + akaryakit + saglik + diger;

            int[] degerler = { egitim ,gida, akaryakit, saglik , diger, toplam };
            return degerler;

        }

        private string oranBul(int deger,int toplam)
        {
            return "%"+Math.Round((double)deger * 100 / toplam, 1);
        }
    }
}
