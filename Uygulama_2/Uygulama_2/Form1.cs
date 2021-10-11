using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uygulama_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Label_Ad.Text = textBox_Ad.Text;
            Label_Soyad.Text = textBox_Soyad.Text;
            Label_Dogum.Text = textBox_Dogum.Text;
            Label_Alan.Text = textBox_Alan.Text;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Hoşgeldiniz... Formunuz yükleniyor...","Giriş Mesajı",MessageBoxButtons.YesNoCancel);
        }
    }
}
