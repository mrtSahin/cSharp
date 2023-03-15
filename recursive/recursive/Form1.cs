using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace recursive
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void hesaplaButton_Click(object sender, EventArgs e)
        {
            string responseText = "";
            int number = Convert.ToInt32(textBox1.Text);
            for (int i = 1; i <= number; i++)
            {
                responseText = responseText.Length > 0 ? responseText + " "+ fibonacciSeries(i) : Convert.ToString(fibonacciSeries(i));
            }
            string finalResponse = textBox1.Text + " sayısının faktöriyel değeri: "+ factorial(number) + "'dir ve fibonacci dizisinin ilk "+ textBox1.Text + " değeri: " + responseText + "'dir";
            listBox1.Items.Add(finalResponse);
        }


        private int fibonacciSeries(int n)
        {
            if (n == 0 || n == 1) return n;
            return fibonacciSeries(n - 1) + fibonacciSeries(n - 2);
        }

        private int factorial(int n)
        {
            if (n == 0) return 1;
            return n * factorial(n - 1);
        }

        private void silButton_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            listBox1.Items.Clear();
        }
    }
}
