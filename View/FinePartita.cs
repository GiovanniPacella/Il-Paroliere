using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Il_Paroliere.View
{
    public partial class FinePartita : Form
    {
        public FinePartita()
        {
            InitializeComponent();
            SoundPlayer sound = new SoundPlayer(Properties.Resources.gioco);
            sound.Stop();
            MainController controller = new MainController();
            int punteggio = controller.getPunteggio();
            Punti.Text = punteggio.ToString();
            

        }

        private void bottoneMenu_Click(object sender, EventArgs e)
        {
            SoundPlayer sound = new SoundPlayer(Properties.Resources.gioco);
            sound.Stop();
            this.Hide();
            var menu = new Menu();
            menu.Closed += (s, args) => this.Close();
            menu.Show();
        }

        private void bottoneUscita_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Sei sicuro di voler uscire?", "Uscita", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                Application.Exit();
            }
        }
    }
}
