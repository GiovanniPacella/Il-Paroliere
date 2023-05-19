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

        private void button26_Click(object sender, EventArgs e)
        {
            string parolaInserita = Ricerca.Text;
            if (parolaInserita != "")
            {
                bool isParolaCorretta = Model.isParolaTrovata(parolaInserita.ToUpper());
                if (isParolaCorretta)
                {
                    Ricerca.Clear();
                    Trovate.Items.Add(parolaInserita);
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
                        Controller.setPunteggio(int.Parse(Punti.Text));
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
            //Precario
        }


    }


}
