using SeriesManagerClases;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeriesManagerDAO
{
    public class GeneroDAO
    {
        private readonly string connectionString;

        public GeneroDAO()
        {
            // Obtenemos la cadena de conexion desde App.Config
            connectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;
        }

        // metodo para obtener todos los Generos de Peliculas o Series
        public List<Genero> ObtenerGeneros()
        {
            // creamos la lista
            List<Genero> generos = new List<Genero>();

            using(SqlConnection conexion = new SqlConnection(connectionString))
            {
                try
                {
                    // abrimos la conexion
                    conexion.Open();
                    // creamos la query
                    String query = "SELECT * FROM GENEROTB";

                    SqlCommand command = new SqlCommand(query, conexion);
                    SqlDataReader reader = command.ExecuteReader();

                    while(reader.Read())
                    {
                        Genero genero = new Genero
                        {
                            idgenero = Convert.ToInt32(reader["GENEROID"]),
                            generoNombre = reader["GENERONOMBRE"].ToString()
                        };
                        generos.Add(genero);
                    }
                    // cerramos el reader
                    reader.Close();

                }
                catch(SqlException ex)
                {
                    Console.WriteLine("Hubo una excepcion: "+ex.Message);

                }

            }
            return generos;
        }

        // metodo para obtener el id de un genero dado
        // este metodo va a recibir un string que es el GENERONOMBRE
        // obtener todos los idGenero donde GENERONOMBRE == STRING
        public int GetGeneroId(string generonombre)
        {
            // query
            string query = "SELECT generoid from GENEROTB where generonombre= @generonombre";

            using (SqlConnection conexion = new SqlConnection(connectionString))
            {
                try
                {
                    //abrimos la conexion
                    conexion.Open();
                    // slqcommand recibe la query y la cadena de conexion o conexion
                    SqlCommand command = new SqlCommand(query, conexion);
                    command.Parameters.AddWithValue("generonombre", generonombre);

                    // data reader 
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        int idgenero = reader.GetInt32(0);
                        reader.Close();
                        conexion.Close();
                        return idgenero;
                    }
                    else
                    {
                        reader.Close();
                        conexion.Close();
                        // Manejar el caso en que no se encontró un registro con el nombre de género dado.
                        // Puedes lanzar una excepción o manejarlo de otra manera según tu lógica de negocio.
                        throw new Exception("No se encontró un género con el nombre proporcionado.");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("ERROR: " + ex);
                    // Manejar la excepción según tus necesidades
                    throw ex;
                }
            }
        }



    }
}
