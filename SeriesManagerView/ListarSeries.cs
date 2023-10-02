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
    public partial class ListarSeries : Form
    {
        public ListarSeries()
        {
            InitializeComponent();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            int? Id = GetIdSeries();
            if (Id != null)
            {
                NuevaSerie EditarSerie = new NuevaSerie(Id);
                EditarSerie.ShowDialog();
                Refrescar();
            }
        }
        private void Refrescar()
        {
            SerieDAO seriedao = new SerieDAO();
            dataGridView1.DataSource = seriedao.obtenerTodasSeries();
        }
        private int? GetIdSeries()
        {
            try
            {
                return int.Parse(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells["idSerie"].Value.ToString());

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
                return null;
            }
        }

        private void ListarSeries_Load(object sender, EventArgs e)
        {
            Refrescar();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // boton para eliminar
            int? Id = GetIdSeries();
            try
            {
                if (Id != null)
                {
                    SerieDAO seriedao = new SerieDAO();
                    seriedao.Eliminar(Id.Value);
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
