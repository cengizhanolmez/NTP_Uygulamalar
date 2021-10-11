using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uygulama_16
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonIF_Click(object sender, EventArgs e)
        {
            byte sinif = Convert.ToByte(comboBox1.Text);

            if (sinif>=1 && sinif<=4)
            {
                MessageBox.Show("ilkokuldasınız...","İf Mesajı");
            }

            if (sinif >= 5 && sinif <= 8)
            {
                MessageBox.Show("Ortaokuldasnız...", "İf Mesajı");
            }

            if (sinif >= 9 && sinif <= 12)
            {
                MessageBox.Show("Lisedesiniz...", "İf Mesajı");
            }

            if (!(sinif>=1 && sinif<=12))
            {
                MessageBox.Show("Hatalı Giriş...", "İf Mesajı");
            }

        }

        private void buttonSC_Click(object sender, EventArgs e)
        {
            byte sinif = Convert.ToByte(comboBox1.Text);

            switch (sinif)
            {
                case 1:
                case 2:
                case 3:
                case 4: MessageBox.Show("ilkokuldasınız...", "Switch-Case Mesajı");     break;
                case 5:
                case 6:
                case 7:
                case 8: MessageBox.Show("Ortaokuldasınız...", "Switch-Case Mesajı");    break;
                case 9:
                case 10:
                case 11:
                case 12: MessageBox.Show("Lisedesiniz...", "Switch-Case Mesajı");       break;

                default:
                    MessageBox.Show("Hatalı Giriş...", "Switch-Case Mesajı");           break;
            }
        }
    }
}
