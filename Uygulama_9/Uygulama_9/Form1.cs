using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uygulama_9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            byte sayi_1, sayi_2;
            sayi_1 = Convert.ToByte(textBox1.Text);
            sayi_2 = Convert.ToByte(textBox2.Text);

            if (sayi_1<sayi_2)
            {
                MessageBox.Show("1. sayı 2. sayıdan KÜÇÜKTÜR");
            }
            if (sayi_1 > sayi_2)
            {
                MessageBox.Show("1. sayı 2. sayıdan BÜYÜKTÜR");
            }
            if (sayi_1 == sayi_2)
            {
                MessageBox.Show("Sayılar birbirine EŞİTTİR");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            sbyte x =Convert.ToSByte(textBoxTC.Text);

            if (x%2==0) //x in değerinin 2 ye bölümünden kalan 0 a eşitse...
            {
                MessageBox.Show("Sayı ÇİFTTİR");
            }

            if (x%2 != 0) // x in değerinin 2 ye bölümünden kalan 0 a eşit değilse...
            {
                MessageBox.Show("Sayı TEKTİR");
            }
            
        }

        private void buttonKulKontrol_Click(object sender, EventArgs e)
        {
            string kullaniciAdi;
            kullaniciAdi = textBoxKullaniciAdi.Text;

            if (kullaniciAdi=="hrpmtal")
            {
                MessageBox.Show("Kullanıcı Adı Doğru");
            }
            else
            {
                MessageBox.Show("Kullancı Adı Yanlış");
            }
        }
    }
}
