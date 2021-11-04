using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Degiskenler_ornekler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double uzun, kısa,cevre,alan;

            uzun = Convert.ToDouble(textBox1.Text);
            kısa = Convert.ToDouble(textBox2.Text);
            cevre = (2 * uzun) + (2 * kısa);
            alan = uzun * kısa;
            label5.Text = "Alan:" + alan.ToString() + " Çevre:" + cevre.ToString();

            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            double yaricap, cevre, alan;
            yaricap = Convert.ToDouble(txtcevre.Text);
            cevre = 2 * yaricap * 3.14;
            alan = yaricap * yaricap * 3.14;
            lblsonuccevre.Text = "Alan:" + alan.ToString() + " Çevre:" + cevre.ToString();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            double mat, edeb, fızık, ort;
            mat = Convert.ToDouble(txtmat.Text);
            edeb = Convert.ToDouble(txtedeb.Text);
            fızık = Convert.ToDouble(txtfızık.Text);
            ort = (mat + edeb + fızık) / 3;
            lblogrencıson.Text = "Ortalama: " + ort.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double sayi1, sayi2, sayi3, toplam, bölüm, fark, çarpım;
            sayi1 = Convert.ToDouble(txtsayi1.Text);
            sayi2 = Convert.ToDouble(txtsayi2.Text);
            sayi3 = Convert.ToDouble(txtsayi3.Text);
            toplam = sayi1 + sayi2 + sayi3;
            fark = sayi1 - sayi2 - sayi3;
            çarpım = sayi1 * sayi2 * sayi3;
            bölüm = sayi1 / sayi2 / sayi3;
            MessageBox.Show("toplam:" + toplam + "\n" + "fark:" + fark + "\n" + "çarpım:" + çarpım + "\n" + "bölüm:" + bölüm);


        }
    }
}
