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

namespace siralama_algoritmasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) 
        {
            int girdi=Convert.ToInt16(textBox1.Text); 
            dizi_elemanlari.Items.Add(girdi);
            
        }

        private void button2_Click(object sender, EventArgs e)  
        {
            siralanmis_dizi.Items.Clear(); 
            int[] dizi = new int[dizi_elemanlari.Items.Count];
            for (int i = 0; i < dizi_elemanlari.Items.Count; i++)
            {
                dizi[i] = Convert.ToInt32(dizi_elemanlari.Items[i]);
            }

            int[] siralanmisDizi = Insertion(dizi);
            foreach (int p in siralanmisDizi)
            {
                siralanmis_dizi.Items.Add(p);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            siralanmis_dizi.Items.Clear();

            int[] dizi = new int[dizi_elemanlari.Items.Count];
            for (int i = 0; i < dizi_elemanlari.Items.Count; i++)
            {
                dizi[i] = Convert.ToInt32(dizi_elemanlari.Items[i]);
            }

            int[] siralanmisDizi=Insertion(dizi);
            

            for (int i = siralanmisDizi.Length-1; i >= 0; i--)
            {
                siralanmis_dizi.Items.Add(siralanmisDizi[i]);
            }
        }

        public int[] Insertion(int[] dizi)
        {
            for (int i = 0; i < dizi.Length - 1; i++)
            {
                for (int j = i + 1; j > 0; j--)
                {
                    if (dizi[j - 1] > dizi[j])
                    {
                        int temp = dizi[j - 1];
                        dizi[j - 1] = dizi[j];
                        dizi[j] = temp;
                    }
                }
            }
            return dizi;
        }
    }
}


// BUBBLE SORT
/*
 using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace siralama_algoritmasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) // dizi elemanlarını ekleme
        {
            try
            {
                int sayi=Convert.ToInt32(textBox1.Text); 
                dizi_elemanlari.Items.Add(sayi);
            }catch(Exception ex){
                Console.WriteLine(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)  // küçükten büyüğe sıralama
        {
            siralanmis_dizi.Items.Clear(); 
            int[] dizi = new int[dizi_elemanlari.Items.Count];
            for (int i = 0; i < dizi_elemanlari.Items.Count; i++)
            {
                dizi[i] = Convert.ToInt32(dizi_elemanlari.Items[i]);
            }
            
            int temp;
            for (int j = 0; j <= dizi.Length - 2; j++)
            {
                for (int i = 0; i <= dizi.Length - 2; i++)
                {
                    if (dizi[i] > dizi[i + 1])
                    {
                        temp = dizi[i + 1];
                        dizi[i + 1] = dizi[i];
                        dizi[i] = temp;
                    }
                }
            }
            foreach (int p in dizi)
            {
                siralanmis_dizi.Items.Add(p);
            }
        }

        private void button3_Click(object sender, EventArgs e)// büyükten küçüğe sıralama
        {
            siralanmis_dizi.Items.Clear();

            int[] dizi = new int[dizi_elemanlari.Items.Count];
            for (int i = 0; i < dizi_elemanlari.Items.Count; i++)
            {
                dizi[i] = Convert.ToInt32(dizi_elemanlari.Items[i]);
            }
            int temp;
            for (int j = 0; j <= dizi.Length - 2; j++)
            {
                for (int i = 0; i <= dizi.Length - 2; i++)
                {
                    if (dizi[i] > dizi[i + 1])
                    {
                        temp = dizi[i + 1];
                        dizi[i + 1] = dizi[i];
                        dizi[i] = temp;
                    }
                }
            }

            for (int i = dizi.Length-1; i > 0; i--)
            {
                siralanmis_dizi.Items.Add(dizi[i]);
            }
        }
    }
}

 */