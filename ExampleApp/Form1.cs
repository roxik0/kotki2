﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExampleApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Git jest bardzo fajnym programem","Komunikat",MessageBoxButtons.RetryCancel,MessageBoxIcon.Information);
            MessageBox.Show("Git jest git", "Komunikat", MessageBoxButtons.RetryCancel, MessageBoxIcon.Information);
            MessageBox.Show("Rozwiązywanie konfliktów jest proste.", "Komunikat", MessageBoxButtons.RetryCancel, MessageBoxIcon.Information);
			//ostatni raz?
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          //Ale fajnie
            MessageBox.Show("Git jest git", "Komunikat", MessageBoxButtons.RetryCancel, MessageBoxIcon.Information);
            //Fajny styl
            //nowa linia
            //Covid not rulez
        }
    }
}
