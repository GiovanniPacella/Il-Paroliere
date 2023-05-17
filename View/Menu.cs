using Il_Paroliere.Control;
using Il_Paroliere.View;
using System.Drawing;
using System.Media;

namespace Il_Paroliere
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
            SoundPlayer sound = new SoundPlayer(Properties.Resources.title);
            sound.Play();

        }

        private void Menu_Load(object sender, EventArgs e)
        {
        }

        private void bottoneGioca_Click(object sender, EventArgs e)
        {
            Connection con = new Connection();
            if (con.connOpen())
            {
                this.Hide();
                var dati = new Dati();
                dati.Closed += (s, args) => this.Close();
                dati.Show();
            }
            else
            {
                MessageBox.Show("Connessione al database non disponibile!", "Errore connessione", MessageBoxButtons.OK);
            }
        }

        private void bottoneClassifica_Click(object sender, EventArgs e)
        {
            Connection con = new Connection();
            if (con.connOpen())
            {
                this.Hide();
                var classifica = new Classifica();
                classifica.Closed += (s, args) => this.Close();
                classifica.Show();
            }
            else
            {
                MessageBox.Show("Connessione al database non disponibile!", "Errore connessione", MessageBoxButtons.OK);
            }
            
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