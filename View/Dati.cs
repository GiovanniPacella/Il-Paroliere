using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Il_Paroliere.View
{
    public partial class Dati : Form
    {
        public Dati()
        {
            InitializeComponent();
        }

        private void Bottonecontinua_Click(object sender, EventArgs e)
        {
            this.Hide();
            var gioca = new Gioco();
            gioca.Closed += (s, args) => this.Close();
            gioca.Show();
        }
    }
}
