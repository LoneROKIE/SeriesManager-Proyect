using SeriesManagerClases;
using System;
using System.Configuration;
using System.Data.SqlClient;

namespace SeriesManagerDAO
{
    public class PeliculaDAO
    {
        private readonly string connectionString;

        public PeliculaDAO()
        {
            // Obtenemos la cadena de conexion desde App.Config
            connectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;
        }

        public List<Pelicula> ObtenerTodasLasPeliculas()
        {
            // Creamos la lista
            List<Pelicula> peliculas = new List<Pelicula>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    // Abrimos la conexión
                    connection.Open();
                    string query = "SELECT P.*, G.GENERONOMBRE AS nombreGenero " +
                                   "FROM PELICULASTB P " +
                                   "INNER JOIN GENEROTB G ON P.GENEROID = G.GENEROID"; // Modifica esta consulta para unir las tablas de género

                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        Pelicula pelicula = new Pelicula
                        {
                            idPelicula = Convert.ToInt32(reader["PELICULASID"]),
                            titulo = reader["TITULO"].ToString(),
                            nombreGenero = reader["nombreGenero"].ToString(), // Nombre del género
                            genero = Convert.ToInt32(reader["GENEROID"]), // ID del género
                            terminada = Convert.ToBoolean(reader["TERMINADA"])
                        };

                        peliculas.Add(pelicula);
                    }
                    reader.Close();

                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error al obtener las Películas: " + ex.Message);
                }
            }

            return peliculas;
        }




        public bool InsertarPelicula(Pelicula pelicula)
        {
            using(SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "INSERT INTO PELICULASTB (TITULO,GENEROID,TERMINADA)" +
                        " VALUES (@titulo, @generoid, @terminada)";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@titulo", pelicula.titulo);
                    command.Parameters.AddWithValue("@generoid", pelicula.genero);
                    command.Parameters.AddWithValue("@terminada", pelicula.terminada);

                    int rowsAffected = command.ExecuteNonQuery(); // se ejecuta la query

                    // es como una condicional return true si rowsAffected es mayor que 0
                    return rowsAffected > 0;

                }catch(Exception ex)
                {
                    Console.WriteLine("ERROR AL INSERTAR LA PELICULA: " + ex.Message);
                    return false;
                }
            }
        }

        // metodo para obtener el id de la fila que seleccione
        public Pelicula ObtenerId(int Id)
        {
            // hacemos el query
            string query = "SELECT peliculasid, titulo " +
                "FROM PELICULASTB where peliculasid = @id ";

            using(SqlConnection connection = new SqlConnection(connectionString))
            {
                // instancia para ejecutar la query
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@id", Id);

                try
                {
                    // abrimos la conexion
                    connection.Open();
                    // lector de datos
                    SqlDataReader reader = command.ExecuteReader();

                    reader.Read();

                    Pelicula pelicula = new Pelicula();
                    pelicula.idPelicula = reader.GetInt32(0);
                    pelicula.titulo = reader.GetString(1);


                    reader.Close();
                    connection.Close();
                    return pelicula;

                }catch(Exception ex)
                {
                    throw new Exception("Hay un error en la BD: " + ex.Message);
                }
            }

        }

        // metodo para editar 
        public void EditarPelicula(int peliculasid,string titulo, int generoid,bool terminada)
        {
            //query
            string query = "UPDATE PELICULASTB SET TITULO=@titulo, GENEROID=@generoid, TERMINADA=@terminada " +
                 "WHERE PELICULASID=@peliculasid";


            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query,connection);
                command.Parameters.AddWithValue("@titulo", titulo);
                command.Parameters.AddWithValue("@generoid", generoid);
                command.Parameters.AddWithValue("@terminada", terminada);
                command.Parameters.AddWithValue("@peliculasid", peliculasid);

                try
                {
                    // abrimos la conexion
                    connection.Open();
                    // ejecutamos la query
                    command.ExecuteNonQuery();
                    // cerramos la conexion
                    connection.Close();
                }
                catch(Exception ex)
                {
                    throw new Exception("Hay un error en la bd: " + ex);
                }

            }

        }

        // metodo para eliminar
        public void Eliminar(int Id)
        {
            string query = "DELETE from peliculastb WHERE peliculasid = @id";

            using(SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query,connection);
                command.Parameters.AddWithValue("@id", Id);
                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }
                catch(Exception ex)
                {
                    throw new Exception("Hay un error en la BD: " + ex.Message);
                }
            }

        }
    }
}