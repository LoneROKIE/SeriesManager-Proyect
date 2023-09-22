using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SeriesManagerClases;

namespace SeriesManagerDAO
{
    public class SerieDAO
    {
        private readonly string connectionString;

        public SerieDAO()
        {
            // Obtenemos la cadena de conexion desde App.Config
            connectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;
            
        }
        // metodo para obtener todas las  series
        public List<Serie> obtenerTodasSeries()
        {
            // creamos una lista
            List<Serie> seriesLista = new List<Serie>();

            using(SqlConnection connection= new SqlConnection(connectionString))
            {
                try
                {
                    // abrimos la conexion
                    connection.Open();
                    // query
                    string query = "SELECT S.*, G.GENERONOMBRE AS nombreGenero " +
                        " FROM SERIESTB S " +
                        " INNER JOIN GENEROTB G ON S.GENEROID = G.GENEROID";

                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataReader reader = command.ExecuteReader();

                    //mientras el lector lee xd
                    while (reader.Read())
                    {
                        Serie serie = new Serie
                        {
                            idSerie = Convert.ToInt32(reader["SERIESID"]),
                            capitulo = Convert.ToInt32(reader["Capitulo"]),
                            temporada = Convert.ToInt32(reader["TEMPORADA"]),
                            titulo = reader["TITULO"].ToString(),
                            nombreGenero = reader["nombreGenero"].ToString(),
                            genero = Convert.ToInt32(reader["GENEROID"]),
                            terminada = Convert.ToBoolean(reader["TERMINADA"])
                        };
                        // aniadimos la serie a la lista de series
                        seriesLista.Add(serie);

                    }
                    reader.Close();

                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error al obtener las Películas: " + ex.Message);
                }
            }
            return seriesLista;
        }

        // metodo para insertar una nueva serie en la BD
        public bool InsertarSerie(Serie serie)
        {
            using(SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "INSERT INTO SERIESTB(TITULO,GENEROID,TERMINADA,CAPITULO,TEMPORADA) " +
                        " VALUES(@titulo,@generoid,@terminada,@capitulo, @temporada)";
                    SqlCommand command = new SqlCommand(query,connection);
                    command.Parameters.AddWithValue("@titulo", serie.titulo);
                    command.Parameters.AddWithValue("@generoid", serie.genero);
                    command.Parameters.AddWithValue("@terminada", serie.terminada);
                    command.Parameters.AddWithValue("@capitulo", serie.capitulo);
                    command.Parameters.AddWithValue("@temporada", serie.temporada);
                    
                    int rowsAffected = command.ExecuteNonQuery(); // se ejecuta la query
                    // es como una condicional return true si rowsAffected es mayor que 0
                    return rowsAffected > 0;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("excepcion: " + ex);
                    return false;
                }
            }
        }

        // obtener el id de la fila 
        public Serie ObtenerId(int Id)
        {
            // query
            string query = "SELECT seriesid, titulo, capitulo, temporada FROM" +
                " SERIESTB where seriesid= @id";

            using(SqlConnection connection = new SqlConnection(connectionString))
            {
                
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@id", Id);

                try
                {
                    // abrimos la conexion
                    connection.Open();
                    //  lector de datos
                    SqlDataReader reader = command.ExecuteReader();

                    reader.Read();

                    Serie serie = new Serie();
                    serie.idSerie = reader.GetInt32(0);
                    serie.titulo = reader.GetString(1);
                    serie.capitulo = reader.GetInt32(2);
                    serie.temporada = reader.GetInt32(3);

                    reader.Close();
                    connection.Close();
                    return serie;

                }
                catch (Exception ex)
                {
                    throw new Exception("Hay un error en la BD: " + ex.Message);
                }

            }
        }

        // quede en crear el metodo editar serie
        public void EditarSerie(int seriesid,string titulo, int generoid,bool terminada, int capitulo, int temporada)
        {
            // query
            string query = "UPDATE SERIESTB SET TITULO=@titulo, GENEROID=@generoid, TERMINADA=@terminada, " +
                "CAPITULO=@capitulo, TEMPORADA=@temporada " +
                "WHERE SERIESID=@seriesid";

            using( SqlConnection connection = new SqlConnection(connectionString))
            {

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@titulo",titulo);
                command.Parameters.AddWithValue("@generoid", generoid);
                command.Parameters.AddWithValue("@terminada", terminada);
                command.Parameters.AddWithValue("@capitulo", capitulo);
                command.Parameters.AddWithValue("@temporada", temporada);
                command.Parameters.AddWithValue("@seriesid", seriesid);

                try
                {
                    //abrimos la conexion
                    connection.Open();
                    // ejecutamosla query
                    command.ExecuteNonQuery();
                    //cerramos l a conexion
                    connection.Close();
                }
                catch(Exception ex)
                {
                    throw new Exception("Hay un error en la BD: " + ex);
                }

            }
        }

        // metodo para eliminar
        public void Eliminar(int Id)
        {
            string query = "DELETE from seriestb WHERE seriesid = @id";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@id", Id);
                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }
                catch (Exception ex)
                {
                    throw new Exception("Hay un error en la BD: " + ex.Message);
                }
            }

        }

    }
}
