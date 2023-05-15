using System;
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
        static string Uid = "localhost";
        static string password = "";
        public static MySqlConnection dataSource()
        {
            connMaster = new MySqlConnection($"server={server} database={database} Uid={Uid} password={password}");
            return connMaster;
        }
        public void connOpen()
        {
            dataSource();
            connMaster.Open();
        }
        public void connClose()
        {
            dataSource();
            connMaster.Close();
        }

        /*public Result queryGenerica()
        {
            return new Result();
        }*/

        /* 
            STRINGHE PER LE QUERY:

            string query = "SELECT * FROM partitagpo ORDER BY punteggio DESC;";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataReader reader = cmd.ExecuteReader();
            
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
