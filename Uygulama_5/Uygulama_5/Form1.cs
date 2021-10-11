using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uygulama_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_Goster_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = true;
        }

        private void button_Gizle_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
        }

        private void button_SepeteEkle_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox1.Text);
        }

        private void button_Temizle_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Buton 1 e tıkladınız","Buton1");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Buton 2 ye tıkladınız", "Buton2");
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            MessageBox.Show("Buton 1 in üzerindesiniz", "Buton1");
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            MessageBox.Show("Mause artık Buton 2 de değil ", "Buton2");
        }

        private void button_Kirmizi_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Red;
        }

        private void button_Mavi_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Blue;
        }

        private void button_Yesil_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Green;
        }

        private void button_Gri_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Gray;
        }
    }
}
