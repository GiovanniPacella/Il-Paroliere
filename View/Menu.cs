using Il_Paroliere.View;

namespace Il_Paroliere
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void bottoneGioca_Click(object sender, EventArgs e)
        {

        }

        private void Menu_Load(object sender, EventArgs e)
        {
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