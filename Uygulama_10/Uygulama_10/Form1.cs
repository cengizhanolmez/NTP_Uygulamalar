﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uygulama_10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBoxLamba.Checked==true)
            {
                listBox1.Items.Add("Lamba Açık");
            }
            else
            {
                listBox1.Items.Add("Lamba Kapalı");
            }

            if (checkBoxKombi.Checked==true)
            {
                listBox1.Items.Add("Kombi Açık");
            }
            else
            {
                listBox1.Items.Add("Kombi Kapalı");
            }
        }

        private void buttonTemizle_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }
    }
}
