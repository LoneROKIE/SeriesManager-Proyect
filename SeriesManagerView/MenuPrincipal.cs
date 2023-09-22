using System;

namespace SeriesManagerView
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {

        }

        // boton 1
        private void btnAdd_Click(object sender, EventArgs e)
        {
            // abre nuev ventana
            NuevaPelicula nueva = new NuevaPelicula();
            nueva.Show();
            // se esconde esta vent
            // this.Hide();
        }

        private void btnPeliculas_Click(object sender, EventArgs e)
        {
            ListarPeliculas peliculas = new ListarPeliculas();
            peliculas.Show();

        }

        private void btnNuevaSerie_Click(object sender, EventArgs e)
        {
            NuevaSerie serie = new NuevaSerie();
            serie.Show();
        }

        private void btnSeries_Click(object sender, EventArgs e)
        {
            ListarSeries listarSeries = new ListarSeries();
            listarSeries.Show();
        }
    }
}