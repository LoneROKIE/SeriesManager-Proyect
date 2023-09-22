using System;

namespace SeriesManagerClases
{
    public class Pelicula
    {
        public int idPelicula { get; set; }
        public string titulo { get; set; }
        public int genero { get; set; }
        public bool terminada { get; set; }
        public string nombreGenero { get; set; }


        // constructor
        public Pelicula(string titulo, int genero, bool terminada)
        {
            this.titulo = titulo;
            this.genero = genero;
            this.terminada = terminada;
        }
 
        public Pelicula() { }

        // to String por si se ocupa
        public override string ToString()
        {
            return String.Format("Titulo: {0}, Genero: {1}, Terminada: {2}", this.idPelicula,
                this.genero, this.terminada);
        }


    }
}