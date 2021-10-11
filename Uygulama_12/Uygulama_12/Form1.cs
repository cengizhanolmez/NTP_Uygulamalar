using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uygulama_12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int not = Convert.ToInt32(textBox1.Text);
            if (not >= 50)
            {
                if (not >= 85)
                {
                    MessageBox.Show("Takdir ile Sınıf Geçtiniz...");
                }
                else if (not >= 70)
                {
                    MessageBox.Show("Teşekkür ile Sınıf Geçtiniz...");
                }
                else
                {
                    MessageBox.Show("Belge almadan Sınıf Geçtiniz...");
                }
            }
            else
            {
                MessageBox.Show("KALDINIZ...");
            }
            
           
        }
    }
}
