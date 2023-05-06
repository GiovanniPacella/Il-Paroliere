using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Il_Paroliere.Control
{
    internal class Connection
    {
        public static MySqlConnection connMaster = new MySqlConnection();
        static string server = "172.22.201.51";
        static string database = "Pacella_DB";
        static string Uid = "localhost";
        static string password = ";";
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
    }
}
