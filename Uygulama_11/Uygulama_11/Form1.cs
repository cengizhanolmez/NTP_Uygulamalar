using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uygulama_11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double sayi1, sayi2, sonuc;
            sayi1 = Convert.ToDouble(textBoxSayi1.Text);
            sayi2 = Convert.ToDouble(textBoxSayi2.Text);

            if (radioButtonToplama.Checked==true)
            {
                sonuc = sayi1 + sayi2;
                labelSonuc.Text = sonuc.ToString();
            }

            if (radioButtonCarpma.Checked==true)
            {
                sonuc = sayi1 * sayi2;
                labelSonuc.Text = sonuc.ToString();
            }

        }
    }
}
