using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uygulama_17
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double tutar = Convert.ToDouble(textBox1.Text);

            if (radioButton1.Checked==true)
            {
                MessageBox.Show("Ödenecek Tutar="+tutar.ToString()+" TL","Toplam Tutar");
            }
            if ((radioButton2.Checked==true) || (radioButton3.Checked==true))
            {
                tutar = tutar + (tutar * 5 / 100);
                MessageBox.Show("Ödenecek Tutar=" + tutar.ToString() + " TL", "Toplam Tutar");
            }

            if ((radioButton4.Checked==true)||(radioButton5.Checked==true))
            {
                tutar = tutar + (tutar * 10 / 100);
                MessageBox.Show("Ödenecek Tutar=" + tutar.ToString() + " TL", "Toplam Tutar");
            }
        }
    }
}
