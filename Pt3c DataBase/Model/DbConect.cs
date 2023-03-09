using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class DbConect
    {
        private static string connectionString = "Server=localhost;Database=clients;Uid=root;Pwd=;";//calficar com a Uid i Pwd un usuari donat d'alta a la base de dades amb permissos restringits
        private static DbConect instance;
        private static MySqlConnection con;

        private DbConect()
        {

        }
        public static DbConect getInstance()
        {
            if (instance == null)
            {
                instance = new DbConect();
            }
            return instance;
        }


        public MySqlConnection getConnection()
        {
            con = null;
            try
            {
                using (con = new MySqlConnection(connectionString)) ;


            }
            catch (MySqlException e)
            {

                Console.WriteLine("Error en la getConnection" + e.Message);
            }

            return con;

        }
    }
}
