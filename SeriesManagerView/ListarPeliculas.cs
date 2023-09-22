using SeriesManagerDAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SeriesManagerView
{
    public partial class ListarPeliculas : Form
    {
        public ListarPeliculas()
        {
            InitializeComponent();
        }

        private void ListarPeliculas_Load(object sender, EventArgs e)
        {
            try
            {
                // cargamos las peliculas en el datagrid view
                PeliculaDAO peliculas = new PeliculaDAO();
                dataGridViewListaPeliculas.DataSource = peliculas.ObtenerTodasLasPeliculas();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridViewListaPeliculas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // listamos las peliculas en el da grid view.

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            int? Id = GetIdPeliculas();
            if (Id != null)
            {
                NuevaPelicula EditarPelicula = new NuevaPelicula(Id);
                EditarPelicula.ShowDialog();
                Refrescar();
            }
        }

        private void Refrescar()
        {
            PeliculaDAO peliculadao = new PeliculaDAO();
            dataGridViewListaPeliculas.DataSource = peliculadao.ObtenerTodasLasPeliculas();
        }

        private int? GetIdPeliculas()
        {
            try
            {
                return int.Parse(dataGridViewListaPeliculas.Rows[dataGridViewListaPeliculas.CurrentRow.Index].Cells["idPelicula"].Value.ToString());

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
                return null;
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            // boton para eliminar
            int? Id = GetIdPeliculas();
            try
            {
                if(Id != null)
                {
                    PeliculaDAO peliculadao = new PeliculaDAO();
                    peliculadao.Eliminar(Id.Value);
                    Refrescar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en la bd" + ex);
            }
        }
    }
}