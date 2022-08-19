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
        private bool mouseDown;
        private Point lastLocation;

        public Form1()
        {
            InitializeComponent();
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

        private void buttonNav_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void buttonNav_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void buttonNav_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }
    }
}
