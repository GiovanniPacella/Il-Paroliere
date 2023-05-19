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
using System.Media;

namespace Il_Paroliere.View
{
    public partial class Classifica : Form
    {
        public Classifica()
        {
            InitializeComponent();
            SoundPlayer sound = new SoundPlayer(Properties.Resources.classifica);
            sound.PlayLooping();


            Connection con = new Connection();
            con.connOpen();
            string query = "SELECT * FROM partitagpo ORDER BY punteggio DESC, paroleTrovate DESC LIMIT 8;";
            MySqlDataReader reader = con.querySelect(query);
            int i = 0;
            while (reader.Read())
            {
                Console.WriteLine("Nome giocatore: " + reader["nomeGiocatore"]);
                Console.WriteLine("Punteggio: " + reader["punteggio"]);
                Console.WriteLine("Parole trovate: " + reader["paroleTrovate"]);
                switch (i)
                {
                    case 0:
                        label10.Text = reader["nomeGiocatore"] + " - Punti: " + reader["punteggio"] + " - Parole: " + reader["paroleTrovate"];
                        break;
                    case 1:
                        label11.Text = reader["nomeGiocatore"] + " - Punti: " + reader["punteggio"] + " - Parole: " + reader["paroleTrovate"];
                        break;
                    case 2:
                        label12.Text = reader["nomeGiocatore"] + " - Punti: " + reader["punteggio"] + " - Parole: " + reader["paroleTrovate"];
                        break;
                    case 3:
                        label13.Text = reader["nomeGiocatore"] + " - Punti: " + reader["punteggio"] + " - Parole: " + reader["paroleTrovate"];
                        break;
                    case 4:
                        label14.Text = reader["nomeGiocatore"] + " - Punti: " + reader["punteggio"] + " - Parole: " + reader["paroleTrovate"];
                        break;
                    case 5:
                        label15.Text = reader["nomeGiocatore"] + " - Punti: " + reader["punteggio"] + " - Parole: " + reader["paroleTrovate"];
                        break;
                    case 6:
                        label16.Text = reader["nomeGiocatore"] + " - Punti: " + reader["punteggio"] + " - Parole: " + reader["paroleTrovate"];
                        break;
                    case 7:
                        label17.Text = reader["nomeGiocatore"] + " - Punti: " + reader["punteggio"] + " - Parole: " + reader["paroleTrovate"];
                        break;
                }
                i++;
            }
            con.connClose();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var menu = new Menu();
            menu.Closed += (s, args) => this.Close();
            menu.Show();
        }
    }
}
