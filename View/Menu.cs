namespace Il_Paroliere
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void bottoneUscita_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Sei sicuro di voler uscire?", "Messaggio", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void bottoneGioca_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Sei sicuro di voler uscire???", "Messaggio", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void Menu_Load(object sender, EventArgs e)
        {
        }
    }
}