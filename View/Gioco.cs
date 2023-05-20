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
    public partial class Gioco : Form
    {
        MainModel Model = new MainModel();
        MainController Controller = new MainController();
        private bool fineTimer = false;
        public Gioco()
        {
            InitializeComponent();
            SoundPlayer sound = new SoundPlayer(Properties.Resources.gioco);
            sound.PlayLooping();

            switch (Controller.getDifficolta())
            {
                case 1:
                    Timer.Text = "2:30";
                    break;
                case 2:
                    Timer.Text = "2:00";
                    break;
                case 3:
                    Timer.Text = "1:30";
                    break;
            }

            char[,] board = Model.getBoard();
            button1.Text = Char.ToString(board[0, 0]);
            button2.Text = Char.ToString(board[0, 1]);
            button3.Text = Char.ToString(board[0, 2]);
            button4.Text = Char.ToString(board[0, 3]);
            button5.Text = Char.ToString(board[0, 4]);
            button6.Text = Char.ToString(board[1, 0]);
            button7.Text = Char.ToString(board[1, 1]);
            button8.Text = Char.ToString(board[1, 2]);
            button9.Text = Char.ToString(board[1, 3]);
            button10.Text = Char.ToString(board[1, 4]);
            button11.Text = Char.ToString(board[2, 0]);
            button12.Text = Char.ToString(board[2, 1]);
            button13.Text = Char.ToString(board[2, 2]);
            button14.Text = Char.ToString(board[2, 3]);
            button15.Text = Char.ToString(board[2, 4]);
            button16.Text = Char.ToString(board[3, 0]);
            button17.Text = Char.ToString(board[3, 1]);
            button18.Text = Char.ToString(board[3, 2]);
            button19.Text = Char.ToString(board[3, 3]);
            button20.Text = Char.ToString(board[3, 4]);
            button21.Text = Char.ToString(board[4, 0]);
            button22.Text = Char.ToString(board[4, 1]);
            button23.Text = Char.ToString(board[4, 2]);
            button24.Text = Char.ToString(board[4, 3]);
            button25.Text = Char.ToString(board[4, 4]);
            timer1.Start();
        }

        public Gioco(object v, object sender, EventArgs eventArgs, EventArgs e)
        {
        }



        //Click al singolo bottone
        private void button1_Click(object sender, EventArgs e)
        {
            string carattere = button1.Text;
            Ricerca.Text = Ricerca.Text + carattere;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string carattere = button2.Text;
            Ricerca.Text = Ricerca.Text + carattere;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string carattere = button3.Text;
            Ricerca.Text = Ricerca.Text + carattere;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string carattere = button4.Text;
            Ricerca.Text = Ricerca.Text + carattere;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string carattere = button5.Text;
            Ricerca.Text = Ricerca.Text + carattere;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string carattere = button6.Text;
            Ricerca.Text = Ricerca.Text + carattere;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string carattere = button7.Text;
            Ricerca.Text = Ricerca.Text + carattere;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            string carattere = button8.Text;
            Ricerca.Text = Ricerca.Text + carattere;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            string carattere = button9.Text;
            Ricerca.Text = Ricerca.Text + carattere;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            string carattere = button10.Text;
            Ricerca.Text = Ricerca.Text + carattere;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            string carattere = button11.Text;
            Ricerca.Text = Ricerca.Text + carattere;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            string carattere = button12.Text;
            Ricerca.Text = Ricerca.Text + carattere;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            string carattere = button13.Text;
            Ricerca.Text = Ricerca.Text + carattere;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            string carattere = button14.Text;
            Ricerca.Text = Ricerca.Text + carattere;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            string carattere = button15.Text;
            Ricerca.Text = Ricerca.Text + carattere;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            string carattere = button16.Text;
            Ricerca.Text = Ricerca.Text + carattere;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            string carattere = button17.Text;
            Ricerca.Text = Ricerca.Text + carattere;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            string carattere = button18.Text;
            Ricerca.Text = Ricerca.Text + carattere;
        }

        private void button19_Click(object sender, EventArgs e)
        {
            string carattere = button19.Text;
            Ricerca.Text = Ricerca.Text + carattere;
        }

        private void button20_Click(object sender, EventArgs e)
        {
            string carattere = button20.Text;
            Ricerca.Text = Ricerca.Text + carattere;
        }

        private void button21_Click(object sender, EventArgs e)
        {
            string carattere = button21.Text;
            Ricerca.Text = Ricerca.Text + carattere;
        }

        private void button22_Click(object sender, EventArgs e)
        {
            string carattere = button22.Text;
            Ricerca.Text = Ricerca.Text + carattere;
        }

        private void button23_Click(object sender, EventArgs e)
        {
            string carattere = button23.Text;
            Ricerca.Text = Ricerca.Text + carattere;
        }

        private void button24_Click(object sender, EventArgs e)
        {
            string carattere = button24.Text;
            Ricerca.Text = Ricerca.Text + carattere;
        }

        private void button25_Click(object sender, EventArgs e)
        {
            string carattere = button25.Text;
            Ricerca.Text = Ricerca.Text + carattere;
        }

        private void button26_Click(object sender, EventArgs e)
        {
            string parolaInserita = Ricerca.Text;
            if (parolaInserita != "")
            {
                bool isParolaCorretta = Model.isParolaTrovata(parolaInserita.ToUpper());
                if (isParolaCorretta)
                {
                    Ricerca.Clear();
                    Trovate.Items.Add(parolaInserita.ToUpper());
                    Punti.Text = (int.Parse(Punti.Text) + Model.getPunteggio(parolaInserita, Controller.getDifficolta())).ToString();
                }
                else
                {
                    MessageBox.Show("Parola non trovata!", "Errore", MessageBoxButtons.OK);
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (!fineTimer)
            {
                int minuti = int.Parse(Timer.Text.Substring(0, 1));
                int secondi = int.Parse(Timer.Text.Substring(2, 2));
                if (secondi == 0)
                {
                    if (minuti > 0)
                    {
                        --minuti;
                        secondi = 60;
                    }
                    else
                    {
                        fineTimer = true;
                        SoundPlayer sound = new SoundPlayer(Properties.Resources.gioco);
                        sound.Stop();
                        Controller.setPunteggio(int.Parse(Punti.Text));
                        Controller.setNumParole(Model.getNumeroParole());
                        Model.pulisciParoleTrovate();
                        this.Hide();
                        var finePartita = new FinePartita();
                        finePartita.Closed += (s, args) => this.Close();
                        finePartita.Show();
                    }
                }
                --secondi;
                if (secondi < 10)
                {
                    Timer.Text = minuti.ToString() + ":0" + secondi.ToString();
                }
                else
                {
                    Timer.Text = minuti.ToString() + ":" + secondi.ToString();
                }
            }
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            Ricerca.Clear();
        }
    }


}
