using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace modul3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        String input;
        int angka1, angka2, hasil;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            input += "1";
            label1.Text = input;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn2_Click(object sender, EventArgs e)
        {
            input += "2";
            label1.Text = input;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            input += "3";
            label1.Text = input;
        }

        private void btnplus_Click(object sender, EventArgs e)
        {
            angka1 = int.Parse(input);
            input = "";
        }

        private void btn4_Click_1(object sender, EventArgs e)
        {
            input += "4";
            label1.Text = input;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            input += "5";
            label1.Text = input;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            input += "6";
            label1.Text = input;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            input += "7";
            label1.Text = input;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            input += "8";
            label1.Text = input;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            input += "9";
            label1.Text = input;
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            input += "0";
            label1.Text = input;
        }

        private void btnequal_Click(object sender, EventArgs e)
        {
            angka2 = int.Parse(input);
            
            hasil = angka1 + angka2;
            label1.Text = " " + hasil;
        }
    }
}
