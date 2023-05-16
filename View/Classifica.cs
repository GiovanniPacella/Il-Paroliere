using Il_Paroliere.Control;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Il_Paroliere.View
{
    public partial class Classifica : Form
    {
        public Classifica()
        {
            InitializeComponent();
            Connection con = new Connection();
            con.connOpen();
            string query = "SELECT * FROM partitagpo ORDER BY punteggio DESC LIMIT 8;";
            MySqlDataReader reader = con.querySelect(query);
            while (reader.Read())
            {
                Console.WriteLine("Nome giocatore: " + reader["nomeGiocatore"]);
                Console.WriteLine("Punteggio: " + reader["punteggio"]);
                Console.WriteLine("Parole trovate: " + reader["paroleTrovate"]);

            }
            con.connClose();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            var menu = new Menu();
            menu.Closed += (s, args) => this.Close();
            menu.Show();
        }
    }
}
