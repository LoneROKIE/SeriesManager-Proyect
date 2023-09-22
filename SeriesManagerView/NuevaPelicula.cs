using SeriesManagerClases;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SeriesManagerView
{
    public partial class NuevaPelicula : Form
    {
        private int? Id;
        public NuevaPelicula(int? Id = null)
        {
            InitializeComponent();
            this.Id = Id;
            if(Id != null)
            {
                CargarDatos();
            }
        }

        private void CargarDatos()
        {
            PeliculaDAO peliculadao = new PeliculaDAO();
            Pelicula pelicula = new Pelicula();
            pelicula = peliculadao.ObtenerId(Id.Value);
            textBoxTitulo.Text = pelicula.titulo;
        }


        private void NuevaPelicula_Load(object sender, EventArgs e)
        {
            CargarComboBoxGenero();
        }

        private void CargarComboBoxGenero()
        {
            GeneroDAO generoDao = new GeneroDAO();
            List<Genero> listaGENERO = generoDao.ObtenerGeneros();

            comboBox1.DataSource = listaGENERO;
            comboBox1.DisplayMember = "generoNombre"; // Establece la propiedad a mostrar
        }


        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if(Id != null)
            {
                Editar();
            }
            else
            {
                AddNueva();
            }
        }
        // metodo para aniadir una nueva pelicula
        private void AddNueva()
        {
            try
            {
                // obtenemos los valores
                bool terminado = false;
                string titulo = textBoxTitulo.Text;

                GeneroDAO generodao = new GeneroDAO();
                int generoid = generodao.GetGeneroId(comboBox1.Text.ToString());

                if (checkBox1.Checked)
                {
                    terminado = true;
                }

                Pelicula pelicula = new Pelicula(titulo, generoid, terminado);

                // ahora vamos a crear la pelicula
                PeliculaDAO peliculaDao = new PeliculaDAO();
                peliculaDao.InsertarPelicula(pelicula);

                MessageBox.Show("Se agrego la pelicula");
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hubo un error: " + ex);
            }
        }

        // metodo para editar una pelicula
        private void Editar()
        {
            try
            {
                GeneroDAO generodao = new GeneroDAO();
                int generoid = generodao.GetGeneroId(comboBox1.Text.ToString());
                PeliculaDAO peliculadao = new PeliculaDAO();
                bool terminado = false;
                if (checkBox1.Checked)
                {
                    terminado = true;
                }
                peliculadao.EditarPelicula(Id.Value,textBoxTitulo.Text, generoid,terminado);
                MessageBox.Show("Se Edito la pelicula !!!");
                this.Hide();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error excepcion: " + ex.Message);
            }
        }

    }
}
