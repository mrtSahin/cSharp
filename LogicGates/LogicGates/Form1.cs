using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LogicGates
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void andButton_Click(object sender, EventArgs e)
        {
            if(comboBox1.Text!="" && comboBox2.Text != "")
                label4.Text = (Int16.Parse(comboBox1.Text) & Int16.Parse(comboBox2.Text)).ToString();
            if (comboBox3.Text != "" && comboBox4.Text != "")
                label5.Text = (Int16.Parse(comboBox3.Text) & Int16.Parse(comboBox4.Text)).ToString();
            if (comboBox5.Text != "" && comboBox6.Text != "")
                label6.Text = (Int16.Parse(comboBox5.Text) & Int16.Parse(comboBox6.Text)).ToString();
            if (comboBox7.Text != "" && comboBox8.Text != "")
                label7.Text = (Int16.Parse(comboBox7.Text) & Int16.Parse(comboBox8.Text)).ToString();
        }

        private void orButton_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text != "" && comboBox2.Text != "")
                label4.Text = (Int16.Parse(comboBox1.Text) | Int16.Parse(comboBox2.Text)).ToString();
            if (comboBox3.Text != "" && comboBox4.Text != "")
                label5.Text = (Int16.Parse(comboBox3.Text) | Int16.Parse(comboBox4.Text)).ToString();
            if (comboBox5.Text != "" && comboBox6.Text != "")
                label6.Text = (Int16.Parse(comboBox5.Text) | Int16.Parse(comboBox6.Text)).ToString();
            if (comboBox7.Text != "" && comboBox8.Text != "")
                label7.Text = (Int16.Parse(comboBox7.Text) | Int16.Parse(comboBox8.Text)).ToString();
        }

        private void temizleButton_Click(object sender, EventArgs e)
        {
            label4.Text = "-";
            label5.Text = "-";
            label6.Text = "-";
            label7.Text = "-";

            comboBox1.Text = "";
            comboBox2.Text = "";
            comboBox3.Text = "";
            comboBox4.Text = "";
            comboBox5.Text = "";
            comboBox6.Text = "";
            comboBox7.Text = "";
            comboBox8.Text = "";
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
