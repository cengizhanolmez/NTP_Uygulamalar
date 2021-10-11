using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //swich case
            int gun = Convert.ToInt32(textBox1.Text);
            string gunDeger = "";

            switch (gun)
            {
                case 1: 
                case 2: 
                case 3: 
                case 4: 
                case 5: gunDeger = "Hafta içi"; break;
                case 6: 
                case 7: gunDeger = "Haftasonu"; break;
                default: gunDeger = "Bulunamadı"; break;
            }

            label2.Text = "Gun (swich): " + gunDeger;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //if else 
            int gun = Convert.ToInt32(textBox1.Text);
            string gunDeger = "";
            if(gun == 1)
            {
                gunDeger = "Pazartesi";
            }else if (gun == 2)
            {
                gunDeger = "Salı";
            }
            else if (gun == 3)
            {
                gunDeger = "Çarşamba";
            }
            else if (gun == 4)
            {
                gunDeger = "Perşembe";
            }
            else if (gun == 5)
            {
                gunDeger = "Cuma";
            }
            else if (gun == 6)
            {
                gunDeger = "Cumartesi";
            }
            else if (gun == 7)
            {
                gunDeger = "Pazar";
            }
            else
            {
                gunDeger = "Bulunamadı";
            }
            label2.Text = "Bugun:"+gunDeger;
        }
    }
}
