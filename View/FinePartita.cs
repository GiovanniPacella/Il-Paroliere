using Il_Paroliere.Control;
using Il_Paroliere.Model;
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
            
            MainController controller = new MainController();
            MainModel model = new MainModel(); 
            Connection con = new Connection();
            int punteggio = controller.getPunteggio();
            int numParoleTrovate = controller.getNumParole();
            string nomeGiocatore = controller.getNicknameGiocatore();

            string query = "INSERT INTO partitagpo (ID, punteggio, paroleTrovate, nomeGiocatore) VALUES (NULL, '"+punteggio+"', '"+numParoleTrovate+"', '"+nomeGiocatore+"');";
            if(con.connOpen())
            {
                con.queryGenerica(query);
                con.connClose();
            }
            else
            {
                MessageBox.Show("Connessione al database non riuscita!", "Errore connessione", MessageBoxButtons.OK);

            }
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
