using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uygulama_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string mesaj = "mesaj verildi 2";
            textBox1.Text = mesaj;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //kırmızı renk yap.
            textBox3.ForeColor = Color.Red;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //siyah renk yap
            textBox3.ForeColor = Color.Black;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Göster
            textBox3.Visible = true;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            //gizle
            textBox3.Visible = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //aç 
            textBox3.Enabled = true;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            //kapat
            textBox3.Enabled = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox3.Font = new Font("Brodway",16);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox3.Font = new Font("aria",10);
        }
    }
}
