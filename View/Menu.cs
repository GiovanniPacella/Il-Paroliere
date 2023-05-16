using Il_Paroliere.View;
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
            this.Hide();
            var gioco = new Gioco();
            gioco.Closed += (s, args) => this.Close();
            gioco.Show();
        }

        private void bottoneClassifica_Click(object sender, EventArgs e)
        {
            this.Hide();
            var classifica = new Classifica();
            classifica.Closed += (s, args) => this.Close();
            classifica.Show();
        }

        private void bottoneUscita_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Sei sicuro di voler uscire?", "Messaggio", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                Application.Exit();
            }
        }
    }
}