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

namespace SeriesManagerView
{
    public partial class NuevaSerie : Form
    {
        private int? Id;
        public NuevaSerie(int? Id=null)
        {
            InitializeComponent();
            this.Id = Id;
            if(Id != null )
            {
                CargarDatos();
            }
        }

        private void CargarDatos()
        {
            SerieDAO seriedao = new SerieDAO();
            Serie serie = new Serie();
            serie = seriedao.ObtenerId(Id.Value);
            textBoxTitulo.Text = serie.titulo;
            numericUpDownCapitulo.Value = serie.capitulo;
            numericUpDownTemporada.Value = serie.temporada;

        }

        private void CargarComboBoxGenero()
        {
            GeneroDAO generoDao = new GeneroDAO();
            List<Genero> listaGENERO = generoDao.ObtenerGeneros();

            comboBox1.DataSource = listaGENERO;
            comboBox1.DisplayMember = "generoNombre"; // Establece la propiedad a mostrar
        }

        private void NuevaSerie_Load(object sender, EventArgs e)
        {
            CargarComboBoxGenero();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if(Id != null)
            {
                Editar();
            }
            else
            {
                AddNuevaSerie();
            }
        }

        // metodo para aniadir una nueva pelicula
        private void AddNuevaSerie()
        {
            try
            {
                // obtenemos los valores
                bool terminado = false;
                string titulo = textBoxTitulo.Text;
                int capitulo = Convert.ToInt32(numericUpDownCapitulo.Value);
                int temporada = Convert.ToInt32(numericUpDownTemporada.Value);

                GeneroDAO generodao = new GeneroDAO();
                int generoid = generodao.GetGeneroId(comboBox1.Text.ToString());

                if (checkBox1.Checked)
                {
                    terminado = true;
                }
                Serie serie = new Serie(titulo, generoid, terminado, capitulo, temporada);

                SerieDAO seriedao = new SerieDAO();
                seriedao.InsertarSerie(serie);
                MessageBox.Show("Se agrego la Serie!!");
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hubo un error: " + ex);
            }
        }
        
        private void Editar()
        {
            try
            {
                SerieDAO seriedao = new SerieDAO();
                GeneroDAO generodao = new GeneroDAO();
                int generoid = generodao.GetGeneroId(comboBox1.Text.ToString());
                int capitulo = Convert.ToInt32(numericUpDownCapitulo.Value);
                int temporada = Convert.ToInt32(numericUpDownTemporada.Value);
                bool terminada = false;
                if (checkBox1.Checked)
                {
                    terminada = true;
                }
                //int seriesid,string titulo, int generoid,bool terminada, int capitulo, int temporada
                seriedao.EditarSerie(Id.Value, textBoxTitulo.Text,generoid,terminada,capitulo,temporada);
                MessageBox.Show("Se Edito la Serie !!!");
                this.Hide();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error excepcion: " + ex.Message);
            }
        }

    }
}
