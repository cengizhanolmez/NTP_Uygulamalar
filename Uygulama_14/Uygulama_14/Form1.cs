using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uygulama_14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            char harf = Convert.ToChar(comboBox1.Text);

            switch (harf)
            {
                case 'A': labelMesaj.Text = " A harfi alfabenin 1. harfidir."; break;
                case 'B': labelMesaj.Text = " B harfi alfabenin 2. harfidir."; break;
                case 'C': labelMesaj.Text = " C harfi alfabenin 3. harfidir."; break;
                case 'D': labelMesaj.Text = harf.ToString()+" harfi alfabenin 4. harfidir."; break;
                case 'E': labelMesaj.Text = harf.ToString() + " harfi alfabenin 5. harfidir."; break;
                case 'F': labelMesaj.Text = harf.ToString() + " harfi alfabenin 6. harfidir."; break;

                default: labelMesaj.Text = "Hatalı Giriş"; break;


                   
            }
        }
    }
}
