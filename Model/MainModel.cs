using Il_Paroliere.Control;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Media;
using System.Runtime.CompilerServices;
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
        List<string> paroleTrovate = new List<string>();
        List<string> posizioniIniziali = new List<string>();
        private bool[] ritornoFunzioniRicerca = new bool[100];

        public MainModel() {
            creaBoard();
        }

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
            string query = "SELECT * FROM paroledizionariogpo WHERE Parole='" + x + "' ;";
            if (con.queryGenerica(query))
            {
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
            this.parolaTrovata = x.ToUpper();
            if (isPrimoCaratterePresente(x[0]) && !isParolaGiàTrovata(x))
            {
                paroleTrovate.Add(parolaTrovata);
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool controllaRicerca()
        {
            for(int i =0;i<ritornoFunzioniRicerca.Length;i++)
            {
                if (ritornoFunzioniRicerca[i])
                {
                    return true;
                }
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
                        posizioniIniziali.Add(i.ToString() + j.ToString());
                    }
                }
            }
            for(int k = 0; k < posizioniIniziali.Count; k++)
            {
                string[] posizioniTrovate = new string[25];
                //Versione 1
                //int i = int.Parse(posizioniIniziali[k].Substring(0,1));
                //int j = int.Parse(posizioniIniziali[k].Substring(1, 1));
                //posizioniTrovate[0] = (i.ToString() + j.ToString());
                //ritornoFunzioniRicerca[k] = cercaAdiacenti(i, j, Char.ToString(x), 1, posizioniTrovate);
                //Versione 2
                int i = int.Parse(posizioniIniziali[k].Substring(0, 1));
                int j = int.Parse(posizioniIniziali[k].Substring(1, 1));
                ritornoFunzioniRicerca[k] = cercaAdiacentiV2(i, j, "", 0, posizioniTrovate);

            }
            if (controllaRicerca())
            {
                return true;
            }
            return false;
        }

        public bool isCarattereGiàPresente(string[]posizioni, int j, string posizioneDaVerificare)
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

        public bool isParolaGiàTrovata(string x)
        {
            for(int i = 0; i < paroleTrovate.Count; i++)
            {
                if (paroleTrovate[i] == x)
                {
                    return true;
                }
            }
            return false;
        }



        public bool cercaAdiacenti(int y, int x, String parolaCostruita, int indiceParola, string[] posizioniTrovate)
        {
            if (parolaTrovata == parolaCostruita)
            {
                return true;
            }
            char carattereDaCercare = parolaTrovata[indiceParola];

            //Lettera destra centrale
            if (!isCarattereGiàPresente(posizioniTrovate, indiceParola, y.ToString()+ (x + 1).ToString()) && x<4 && this.Board[y,x+1] == carattereDaCercare)
            {
                posizioniTrovate[indiceParola] = y.ToString() + (x + 1).ToString();
                parolaCostruita += Char.ToString(carattereDaCercare);
                return cercaAdiacenti(y, x+1, parolaCostruita, indiceParola+1, posizioniTrovate);
            }

            //Lettera sinistra centrale
            if(!isCarattereGiàPresente(posizioniTrovate, indiceParola, y.ToString()+ (x - 1).ToString()) && x >0 && this.Board[y, x-1] == carattereDaCercare)
            {
                posizioniTrovate[indiceParola] = y.ToString() + (x - 1).ToString();
                parolaCostruita += Char.ToString(carattereDaCercare);
                return cercaAdiacenti(y, x-1, parolaCostruita, indiceParola + 1, posizioniTrovate);
            }

            //Lettera superiore sinistra
            if(!isCarattereGiàPresente(posizioniTrovate, indiceParola, (y-1).ToString()+ (x - 1).ToString()) && x >0 && y>0 && this.Board[y-1, x-1] == carattereDaCercare)
            {
                posizioniTrovate[indiceParola] = (y - 1).ToString() + (x - 1).ToString();
                parolaCostruita += Char.ToString(carattereDaCercare);
                return cercaAdiacenti(y-1,x-1, parolaCostruita, indiceParola + 1, posizioniTrovate);
            }

            //Lettera superiore destra
            if (!isCarattereGiàPresente(posizioniTrovate, indiceParola, (y - 1).ToString()+ (x + 1).ToString()) && x < 4 && y > 0 && this.Board[y - 1,x+1] == carattereDaCercare)
            {   
                posizioniTrovate[indiceParola] = (y - 1).ToString() + (x + 1).ToString();
                parolaCostruita += Char.ToString(carattereDaCercare);
                return cercaAdiacenti(y - 1, x+1, parolaCostruita, indiceParola + 1, posizioniTrovate);
            }

            //Lettera superiore centrale
            if (!isCarattereGiàPresente(posizioniTrovate, indiceParola, (y - 1).ToString()+ x.ToString()) && y > 0 && this.Board[y - 1, x] == carattereDaCercare)
            {
                posizioniTrovate[indiceParola] = (y - 1).ToString() + x.ToString();
                parolaCostruita += Char.ToString(carattereDaCercare);
                return cercaAdiacenti(y-1, x, parolaCostruita, indiceParola + 1, posizioniTrovate);
            }

            //Lettera inferiore centrale
            if(!isCarattereGiàPresente(posizioniTrovate, indiceParola, (y + 1).ToString()+ x.ToString()) && y <4 && this.Board[y+1, x]== carattereDaCercare)
            {
                posizioniTrovate[indiceParola] = (y + 1).ToString() + x.ToString();
                parolaCostruita += Char.ToString(carattereDaCercare);
                return cercaAdiacenti(y + 1, x, parolaCostruita, indiceParola + 1, posizioniTrovate);
            }

            //Lettera inferiore sinistra
            if (!isCarattereGiàPresente(posizioniTrovate, indiceParola, (y + 1).ToString()+ (x - 1).ToString()) && x >0 && y < 4 && this.Board[y + 1, x-1] == carattereDaCercare)
            {   
                posizioniTrovate[indiceParola] = (y + 1).ToString() + (x - 1).ToString();
                parolaCostruita += Char.ToString(carattereDaCercare);
                return cercaAdiacenti(y+1, x- 1, parolaCostruita, indiceParola + 1, posizioniTrovate);
            }

            //Lettera inferiore destra
            if (!isCarattereGiàPresente(posizioniTrovate, indiceParola, (y + 1).ToString()+ (x + 1).ToString()) && x < 4 && y < 4 && this.Board[y + 1,x+1] == carattereDaCercare)
            {
                posizioniTrovate[indiceParola] = (y + 1).ToString() + (x + 1).ToString();
                parolaCostruita += Char.ToString(carattereDaCercare);
                return cercaAdiacenti(y + 1, x + 1, parolaCostruita, indiceParola + 1, posizioniTrovate);
            }
            paroleTrovate.Clear();
            return false;
        }


        
        public bool cercaAdiacentiV2(int y, int x, String parolaCostruita, int indiceParola, string[] posizioniTrovate){
            if(x>-1 && y>-1 && x<5 && y<5){
                if(Board[y, x]==parolaTrovata[indiceParola] && !isCarattereGiàPresente(posizioniTrovate, indiceParola, y.ToString()+x.ToString()) ){
                    posizioniTrovate[indiceParola] = y.ToString() + x.ToString();
                    parolaCostruita += Char.ToString(parolaTrovata[indiceParola]);
                    if(parolaCostruita==parolaTrovata){
                        return true;
                    }
                    return cercaAdiacentiV2(y+1, x, parolaCostruita, indiceParola+1, posizioniTrovate) || cercaAdiacentiV2(y-1, x, parolaCostruita, indiceParola+1, posizioniTrovate) || 
                    cercaAdiacentiV2(y-1, x-1, parolaCostruita, indiceParola+1, posizioniTrovate) || cercaAdiacentiV2(y-1, x+1, parolaCostruita, indiceParola+1, posizioniTrovate) || 
                    cercaAdiacentiV2(y, x+1, parolaCostruita, indiceParola+1, posizioniTrovate) || cercaAdiacentiV2(y, x-1, parolaCostruita, indiceParola+1, posizioniTrovate) || 
                    cercaAdiacentiV2(y+1, x-1, parolaCostruita, indiceParola+1, posizioniTrovate) || cercaAdiacentiV2(y+1, x+1, parolaCostruita, indiceParola+1, posizioniTrovate); 
                }
            }
            return false;        
        }
         

        public void setParolaTrovata(String parolaTrovata)
        {
            this.parolaTrovata = parolaTrovata;
        }

        public  void setBoard(char[,] x)
        {
            Board = x;
        }

        public char[,] getBoard()
        {
            return this.Board;
        }

    }
}
