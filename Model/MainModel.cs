using Il_Paroliere.Control;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Globalization;
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

        public bool isInDatabase(String x)
        {
            Connection con = new Connection();
            con.connOpen();
            string query = "SELECT * FROM parole WHERE parola='" + x + "' ;";
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

        public bool isCorretta(String x)
        {
            if (isPrimoCaratterePresente(x[0]))
            {
                return true;
            }
            return false;
        }

        public bool isPrimoCaratterePresente(char x)
        {
            for (int i = 0; i < nRigheColonne; i++)
            {
                for (int j = 0; j < nRigheColonne; j++)
                {
                    if (this.Board[i, j] == x)
                    {
                        string[] posizioniTrovate = new string[25];
                        posizioniTrovate[0]=(i+j).ToString();
                        return cercaAdiacenti(i, j, Char.ToString(x), 1, posizioniTrovate);
                    }
                }
            }
            return false;
        }

        public bool isGiàPresente(string[]posizioni, int j, string posizioneDaVerificare)
        {
            for(int i = 0; i <j; i++)
            {
                if (posizioni[i] == posizioneDaVerificare)
                {
                    return true;
                }
            }
            return false;
        }



        public bool cercaAdiacenti(int x, int y, String parolaCostruita, int indiceParola, string[] posizioniTrovate)
        {
            if (parolaTrovata == parolaCostruita)
            {
                return true;
            }
            char carattereDaCercare = parolaTrovata[indiceParola];

            //Lettera destra centrale
            if (!isGiàPresente(posizioniTrovate, indiceParola, (x+1,y).ToString()) && x<4 && this.Board[x+1, y] == carattereDaCercare)
            {
                posizioniTrovate[indiceParola] = (x + 1, y).ToString();
                parolaCostruita += Char.ToString(carattereDaCercare);
                return cercaAdiacenti(x+1, y, parolaCostruita, indiceParola+1, posizioniTrovate);
            }

            //Lettera sinistra centrale
            if(!isGiàPresente(posizioniTrovate, indiceParola, (x - 1, y).ToString()) && x >0 && this.Board[x-1, y] == carattereDaCercare)
            {
                posizioniTrovate[indiceParola] = (x - 1, y).ToString();
                parolaCostruita += Char.ToString(carattereDaCercare);
                return cercaAdiacenti(x-1, y, parolaCostruita, indiceParola + 1, posizioniTrovate);
            }

            //Lettera superiore sinistra
            if(!isGiàPresente(posizioniTrovate, indiceParola, (x - 1, y-1).ToString()) && x >0 && y>0 && this.Board[x-1, y-1] == carattereDaCercare)
            {
                posizioniTrovate[indiceParola] = (x - 1, y-1).ToString();
                parolaCostruita += Char.ToString(carattereDaCercare);
                return cercaAdiacenti(x-1, y-1, parolaCostruita, indiceParola + 1, posizioniTrovate);
            }

            //Lettera superiore destra
            if (!isGiàPresente(posizioniTrovate, indiceParola, (x + 1, y - 1).ToString()) && x < 4 && y > 0 && this.Board[x + 1, y - 1] == carattereDaCercare)
            {   
                posizioniTrovate[indiceParola] = (x + 1, y - 1).ToString();
                parolaCostruita += Char.ToString(carattereDaCercare);
                return cercaAdiacenti(x+1, y - 1, parolaCostruita, indiceParola + 1, posizioniTrovate);
            }

            //Lettera superiore centrale
            if (!isGiàPresente(posizioniTrovate, indiceParola, (x, y - 1).ToString()) && y > 0 && this.Board[x, y - 1] == carattereDaCercare)
            {
                posizioniTrovate[indiceParola] = (x, y - 1).ToString();
                parolaCostruita += Char.ToString(carattereDaCercare);
                return cercaAdiacenti(x, y - 1, parolaCostruita, indiceParola + 1, posizioniTrovate);
            }

            //Lettera inferiore centrale
            if(!isGiàPresente(posizioniTrovate, indiceParola, (x, y + 1).ToString()) && y <4 && this.Board[x,y+1]== carattereDaCercare)
            {
                posizioniTrovate[indiceParola] = (x, y + 1).ToString();
                parolaCostruita += Char.ToString(carattereDaCercare);
                return cercaAdiacenti(x, y + 1, parolaCostruita, indiceParola + 1, posizioniTrovate);
            }

            //Lettera inferiore sinistra
            if (!isGiàPresente(posizioniTrovate, indiceParola, (x-1, y + 1).ToString()) && x >0 && y < 4 && this.Board[x-1, y + 1] == carattereDaCercare)
            {   
                posizioniTrovate[indiceParola] = (x - 1, y + 1).ToString();
                parolaCostruita += Char.ToString(carattereDaCercare);
                return cercaAdiacenti(x-1, y + 1, parolaCostruita, indiceParola + 1, posizioniTrovate);
            }

            //Lettera inferiore destra
            if (!isGiàPresente(posizioniTrovate, indiceParola, (x+1, y + 1).ToString()) && x < 4 && y < 4 && this.Board[x + 1, y + 1] == carattereDaCercare)
            {
                posizioniTrovate[indiceParola] = (x + 1, y + 1).ToString();
                parolaCostruita += Char.ToString(carattereDaCercare);
                return cercaAdiacenti(x + 1, y + 1, parolaCostruita, indiceParola + 1, posizioniTrovate);
            }
            return false;
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
