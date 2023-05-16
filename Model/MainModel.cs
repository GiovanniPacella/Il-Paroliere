using Il_Paroliere.Control;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Il_Paroliere.Model
{
    internal class MainModel
    {
        private static int nRigheColonne = 5;
        private char [] lettere = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };
        private char[,] Board = new char[nRigheColonne,nRigheColonne];
        private String parolaTrovata;

        private int[][] posizioniCaratteri = new int[25][];
        private int contatoreParola = 0;

        public MainModel() { }

        public void creaBoard()
        {
            Random rnd = new Random();
            for (int i = 0; i < nRigheColonne; i++){
                for (int j = 0; j < nRigheColonne; j++){
                    Board[i,j] = lettere[rnd.Next(0,lettere.Length)];
                }
            }
        }

        public void stampaBoard(){
            for (int i = 0; i < nRigheColonne; i++){
                for (int j = 0; j < nRigheColonne; j++){
                    Console.WriteLine(this.Board[i,j]+ " ");
                }
                Console.WriteLine("\n");
            }
        }


        public bool isPrimoCaratterePresente(char x)
        {
            for (int i = 0; i < nRigheColonne; i++)
            {
                for (int j = 0; j < nRigheColonne; j++)
                {
                    if (this.Board[i,j]== x)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public bool isInDatabase(String x)
        {
            Connection con = new Connection();
            con.connOpen();
            string query = "SELECT * FROM parole WHERE parola='"+x+"' ;";
            if (con.queryGenerica(query))
            {
                this.parolaTrovata = x;
                return true;
            }
            else
            {
                this.parolaTrovata = "";
                return false;
            }
        }

        public bool isParolaTrovata(String x)
        {
            if (isInDatabase(x) && isCorretta(x))
            {
                return true;
            }
            else
            {
                return false;
            }
        }


   
        public bool isCorretta(String x)
        {
            return true;
        }

        public void setParolaTrovata(String parolaTrovata)
        {
            this.parolaTrovata = parolaTrovata;
        }

        public char[,] getBoard()
        {
            return this.Board;
        }

        




    }
}
