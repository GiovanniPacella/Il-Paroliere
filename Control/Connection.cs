using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Common;

namespace Il_Paroliere.Control
{
    internal class Connection
    {
        public static MySqlConnection connMaster = new MySqlConnection();
        static string server = "172.22.201.51";
        static string database = "Pacella_DB";
        static string Uid = "utentedb";
        static string password = "Cobi_2022_$";
        public static MySqlConnection dataSource()
        {
            connMaster = new MySqlConnection("Server="+server+"; Database="+database+"; Uid="+Uid+"; Password="+password+";");
            return connMaster;
        }
        public void connOpen()
        {
            try
            {
                dataSource();
                connMaster.Open();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
        public void connClose()
        {
            try
            {
                dataSource();
                connMaster.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        public MySqlDataReader querySelect(string query)
        {
            MySqlCommand cmd = new MySqlCommand(query, connMaster);
            MySqlDataReader reader = cmd.ExecuteReader();
            return reader;
        }

        public void queryGenerica(string query)
        {
            MySqlCommand cmd = new MySqlCommand(query, connMaster);
            return;
        }

        /* 
            STRINGHE PER LE QUERY:

            string query = "SELECT * FROM partitagpo ORDER BY punteggio DESC;";
            
            
            while(reader.Read())
            {
                Console.WriteLine(reader["ID"]);
                Console.WriteLine(reader["punteggio"]);
                Console.WriteLine(reader["paroleTrovate"]);

            }
            
            try
            {
                string sql = "INSERT INTO partitagpo (punteggio, paroleTrovate) VALUES ('x', 'x')";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

        */
    }
}
