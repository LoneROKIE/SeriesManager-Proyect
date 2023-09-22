using System;


namespace SeriesManagerClases
{
    public class Serie : Pelicula
    {
        public int idSerie { get; set; }
        public int capitulo { get; set; }
        public int temporada { get; set; }
        public string nombreGenero { get; set; }

        public Serie(string titulo, int genero, bool terminada, int capitulo
            , int temporada) : base(titulo, genero, terminada)
        {
            this.idSerie = idSerie;
            this.capitulo = capitulo;
            this.temporada = temporada;
            
        }
        public Serie()
        {

        }
        // toString
        public override string ToString()
        {
            return string.Format(base.ToString()+ ", Capitulo: {0}, Temporada: {1}, " +
                "Tipo Serie: {2}",this.capitulo, this.temporada);
        }


    }
}
