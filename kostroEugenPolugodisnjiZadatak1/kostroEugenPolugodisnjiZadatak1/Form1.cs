﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kostroEugenPolugodisnjiZadatak1
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

        private void btnIdi_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(textBox1.Text);
        }

        private void btnGmail_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.gmail.com");
        }

        private void btnWebmail_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://webmail.carnet.hr");
        }

        private void btnIspis_Click(object sender, EventArgs e)
        {
            webBrowser1.Print();
        }

        private void btnNaprijed_Click(object sender, EventArgs e)
        {
            webBrowser1.GoForward();
        }

        private void btnNatrag_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
        }
    }
}
