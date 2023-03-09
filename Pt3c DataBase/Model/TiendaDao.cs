using MySql.Data.MySqlClient;
using MySqlX.XDevAPI;
using Org.BouncyCastle.Utilities;
using System.Data;
using System.Data.Common;

namespace Model
{
    public class TiendaDao
    {
        private DbConect dbConnect;
        private MySqlConnection con;

        public TiendaDao()
        {
            dbConnect = DbConect.getInstance();
        }

        public List<Cliente> getAll()
        {
            List<Cliente> resposta = new List<Cliente>();
            String query = "SELECT nomClient, adreça, població, telèfon, emailCOntacte FROM clients"; //la consulta que li fem a la BBDD
            try
            {
                con = dbConnect.getConnection();

                if (con != null)
                {
                    con.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, con))
                    {
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                while (reader.Read())
                                {
                                    resposta.Add(new Cliente(nomclient: reader[0].ToString(), adreça: reader[1].ToString(), poblacio: reader[2].ToString(), telefon: reader[3].ToString(), emailContacte: reader[4].ToString()));

                                }
                            }
                            else
                            {
                                Console.WriteLine("No rows found in clients table - TiendaDAO.");
                            }
                        }
                    }
                }
            }
            catch (MySqlException error1)
            {
                Console.WriteLine("Error MySql " + error1.Message);
            }
            catch (Exception error2)
            {
                Console.WriteLine("Error general " + error2.Message);
            }
            return resposta;
        }


        public DataSet comandasConNombre(string name)
        {
            String query = "SELECT c.nomClient, o.dataComanda, o.formaPagament, o.descompte, o.enviat FROM clients c JOIN comandes o ON c.idClient = o.idClient WHERE c.nomClient =@name";
            DataSet ds = new DataSet();
            try
            {
                con = dbConnect.getConnection();

                if (con != null)
                {
                    con.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, con))
                    {
                        cmd.Parameters.Add(new MySqlParameter("@name", name));

                        using (MySqlDataAdapter adapter = new MySqlDataAdapter())
                        {
                            adapter.SelectCommand = cmd;
                            adapter.Fill(ds);
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error en clientDao.getCommanda()" + e.Message);
            }
            return ds;
        }

        public List<Cliente> getNombre()
        {
            List<Cliente> resposta = new List<Cliente>();
            String query = "SELECT nomClient FROM clients"; //la consulta que li fem a la BBDD
            try
            {
                con = dbConnect.getConnection();

                if (con != null)
                {
                    con.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, con))
                    {
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                while (reader.Read())
                                {
                                    resposta.Add(new Cliente(nomclient: reader[0].ToString()));

                                }
                            }
                            else
                            {
                                Console.WriteLine("No rows found in clients table - TiendaDAO.");
                            }
                        }
                    }
                }
            }
            catch (MySqlException error1)
            {
                Console.WriteLine("Error MySql " + error1.Message);
            }
            catch (Exception error2)
            {
                Console.WriteLine("Error general " + error2.Message);
            }
            return resposta;
        }

        public List<Cliente> getTelefono()
        {
            List<Cliente> resposta = new List<Cliente>();
            String query = "SELECT nomclient,telèfon FROM clients "; //la consulta que li fem a la BBDD
            try
            {
                con = dbConnect.getConnection();

                if (con != null)
                {
                    con.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, con))
                    {
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                while (reader.Read())
                                {
                                    resposta.Add(new Cliente(nomclient: reader[0].ToString(), telefon: reader[1].ToString()));

                                }
                            }
                            else
                            {
                                Console.WriteLine("No rows found in clients table - TiendaDAO.");
                            }
                        }
                    }
                }
            }
            catch (MySqlException error1)
            {
                Console.WriteLine("Error MySql " + error1.Message);
            }
            catch (Exception error2)
            {
                Console.WriteLine("Error general  " + error2.Message);
            }
            return resposta;
        }

        /**
        private void MostrarDatosEnListView(ListView listView)
        {
            con = dbConnect.getConnection();
            // Ejecuta una consulta para recuperar los datos de la base de datos
            string consulta = "SELECT * FROM clients";
            MySqlCommand comando = new MySqlCommand(consulta, con);
            MySqlDataReader reader = comando.ExecuteReader();

            // Limpia el control ListView
            listView.Clear();

            // Agrega cada fila de los datos a la ListView
            while (reader.Read())
            {
                ListViewItem item = new ListViewItem(reader["columna1"].ToString());
                item.SubItems.Add(reader["columna2"].ToString());
                item.SubItems.Add(reader["columna3"].ToString());
                listView.Items.Add(item);
            }

            // Cierra el reader
            reader.Close();
        }
        **/
    }
}