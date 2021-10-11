using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uygulama_7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
             int sayi1, sayi2, toplam;// int tipinde sayi1, sayi2 ve toplam değişkenleri tanımlandı
             sayi1 = Convert.ToInt32(textBoxSayi1.Text);//textBoxSayi1 e girilen değeri int tipine çevirip sayi1 değişkenine atadık
             sayi2 = Convert.ToInt32(textBoxSayi2.Text);//textBoxSayi2 e girilen değeri int tipine çevirip sayi2 değişkenine atadık
             toplam = sayi1 + sayi2;//işlem

             textBoxToplam.Text = toplam.ToString();// toplam değişkeninin tipi int olduğu için textBoxToplam a gönderirken string olarak gönderdik
             
            
        }

        private void button_Kare_Click(object sender, EventArgs e)
        {
            int sayi = Convert.ToInt32(textBoxSayiKare.Text);
            int karesi = sayi * sayi;
            MessageBox.Show("Girdiğiniz Sayının Karesi="+karesi,"SONUÇ");
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int Sayi_1 = Convert.ToInt32(textBox_Sayi1.Text);
            int sayi_2 = Convert.ToInt32(textBox_Sayi2.Text);
            int islem = (Sayi_1 + sayi_2) * 2 + 5;
            textBoxSonuc.Text = islem.ToString();
        }
    }
}
