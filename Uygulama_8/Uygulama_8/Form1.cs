using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uygulama_8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonYuzde10_Click(object sender, EventArgs e)
        {
            double fiyat, indirimliFiyat, indirimTutari;
            fiyat = Convert.ToDouble(textBox1.Text);
            indirimTutari = fiyat * 0.1;
            indirimliFiyat = fiyat - indirimTutari;
            labelİndirimliFiyat.Text = indirimliFiyat.ToString()+" TL";
            //indirimliFiyat=fiyat-fiyat*0.1;
        }

        private void buttonYuzde25_Click(object sender, EventArgs e)
        {
            double fiyat, indirimliFiyat;
            fiyat = Convert.ToDouble(textBox1.Text);
            indirimliFiyat = fiyat - fiyat * 0.25;
            labelİndirimliFiyat.Text = indirimliFiyat.ToString() + " TL";
            
        }

        private void buttonYuzde50_Click(object sender, EventArgs e)
        {
            double fiyat, indirimliFiyat;
            fiyat = Convert.ToDouble(textBox1.Text);
            indirimliFiyat = fiyat - fiyat * 0.500000000000000;
            labelİndirimliFiyat.Text = indirimliFiyat.ToString() + " TL";
        }

        private void buttonYuzde75_Click(object sender, EventArgs e)
        {
            double fiyat, indirimliFiyat;
            fiyat = Convert.ToDouble(textBox1.Text);
            indirimliFiyat = fiyat - fiyat * 0.75;
            labelİndirimliFiyat.Text = indirimliFiyat.ToString() + " TL";
        }
    }
}
