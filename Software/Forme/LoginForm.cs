﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Forme.Baza_podataka;

namespace Forme
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void nazadButton_Click(object sender, EventArgs e)
        {
            Form1 pocetnaForm = new Form1();
            this.Hide();
            pocetnaForm.ShowDialog();
        }

        private void prijaviSeButton_Click(object sender, EventArgs e)
        {

        }
    }
}
