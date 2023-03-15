using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fibonacci
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            listBox1.HorizontalScrollbar = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            string fibonacciString="";
            int sayi = Convert.ToInt16(textBox1.Text);
            for (long i = 1; i <= sayi; i++)
            {
                fibonacciString= fibonacciString+" " +Fib(i);
                if(i== sayi)
                    listBox1.Items.Add("Fibonacci:"+fibonacciString);
            }
            
            long faktoriyel=Faktor(sayi);
            listBox1.Items.Add("Faktoriyel: " + faktoriyel);
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            textBox1.Clear();
        }
        
        static long Fib(long n)
        {
            if (n < 2) return n;
            return Fib(n - 1)+Fib(n);
        }

        static long Faktor(long n)
        {
            if (n == 0)
            {
                return 1;
            }
            return n * Faktor(n - 1);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
