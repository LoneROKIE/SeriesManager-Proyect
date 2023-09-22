using System;
using System.Configuration;
using System.Data.SqlClient;
namespace CadenaConexionDB
{
    // aqui creamos la cadena de conexion con la DB
    public class ConexionDB
    {
        // funcion para abrir la conexion
        public void OpenSqlConnection()
        {
            string connectionString = GetConnectionString();

            using(SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = connectionString;
                // abrimos la conexion
                conn.Open();

                Console.WriteLine("State: {0}", conn.State);
                Console.WriteLine("ConnectionString: {0}", conn.ConnectionString);
            }
        }

        public string GetConnectionString()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;

            return connectionString;
        }

    }
}