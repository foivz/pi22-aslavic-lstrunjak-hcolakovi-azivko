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
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        private void odjaviSeButton_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            this.Hide();
            loginForm.ShowDialog();
        }

        private void dodajLinijuButton_Click(object sender, EventArgs e)
        {
            DodavanjeLinije dodavanjeLinije = new DodavanjeLinije();
            dodavanjeLinije.ShowDialog();
        }

        private void azurirajLinijuButton_Click(object sender, EventArgs e)
        {
            AzuriranjeLinijeForm azuriranjeLinijeForm = new AzuriranjeLinijeForm();
            azuriranjeLinijeForm.ShowDialog();
        }
    }
}
