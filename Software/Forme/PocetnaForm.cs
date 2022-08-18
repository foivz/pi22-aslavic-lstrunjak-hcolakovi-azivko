using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forme
{
    public partial class Form1 : Form
    {
        LoginForm loginForm = new LoginForm();
        public Form1()
        {
            InitializeComponent();
        }

        private void adminButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            loginForm.ShowDialog();
        }

        private void registriraniKorisnikButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            loginForm.ShowDialog();
        }

        private void izlazButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void neregistriraniKorisnikButton_Click(object sender, EventArgs e)
        {
            NeregistriraniKorisnikForm neregistriraniKorisnikForm = new NeregistriraniKorisnikForm();
            this.Hide();
            neregistriraniKorisnikForm.ShowDialog();
        }
    }
}
