using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PryEdGaidoL
{
    public partial class frmGrafo : Form
    {
        public frmGrafo()
        {
            InitializeComponent();
        }
        clsGrafo objGrafo = new clsGrafo();

        private void btnCargar_Click(object sender, EventArgs e)
        {
            int origen = cmbOrigen.SelectedIndex;
            int destino = cmbDestino.SelectedIndex;
            decimal precio = Convert.ToDecimal(txtPrecio.Text);

            objGrafo.Agregar(origen, destino, precio);
            MessageBox.Show("Ruta cargada exitosamente.");
            objGrafo.MostrarTodo(dgvGrilla);
            txtPrecio.Clear();
        }

        private void frmGrafo_Load(object sender, EventArgs e)
        {
            objGrafo.MostrarCiudades(cmbOrigen);
            objGrafo.MostrarCiudades(cmbDestino);

            objGrafo.MostrarCiudades(cmbOrigen2);
            objGrafo.MostrarCiudades(cmbDestino2);


            objGrafo.MostrarCiudades(cmbDesde);
            objGrafo.MostrarCiudades(cmbHasta);
            objGrafo.MostrarTodo(dgvGrilla);
        }

        private void btnListarDestinos_Click(object sender, EventArgs e)
        {
            int origen = cmbDesde.SelectedIndex;

            objGrafo.MostrarDestinos(origen, dgvGrilla);
        }

        private void btnListarOrigenes_Click(object sender, EventArgs e)
        {
            int origenIdx = cmbDesde.SelectedIndex;
            int destinoIdx = cmbHasta.SelectedIndex;

            decimal precio = objGrafo.Consultar(origenIdx, destinoIdx);

            dgvGrilla.Rows.Clear();
            dgvGrilla.Columns.Clear();

            dgvGrilla.Columns.Add("ColOrigen", "Origen");
            dgvGrilla.Columns.Add("ColDestino", "Destino");
            dgvGrilla.Columns.Add("ColPrecio", "Precio");

            string ciudadOrigen = cmbDesde.Text;
            string ciudadDestino = cmbHasta.Text;

            // 6. Agregamos la fila con la información detallada
            dgvGrilla.Rows.Add(ciudadOrigen, ciudadDestino, precio);
        }

        private void btnVerTodo_Click(object sender, EventArgs e)
        {
            objGrafo.MostrarTodo(dgvGrilla);
        }

        private void btnBorrarTodo_Click(object sender, EventArgs e)
        {
            objGrafo.BorrarTodo();
            MessageBox.Show("Todos los datos del grafo han sido borrados.");
            objGrafo.MostrarTodo(dgvGrilla);
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            int origen = cmbOrigen2.SelectedIndex;
            int destino = cmbDestino2.SelectedIndex;

            objGrafo.Eliminar(origen, destino);

            MessageBox.Show("La ruta seleccionada fue eliminada exitosamente.");
            objGrafo.MostrarTodo(dgvGrilla);
        }
    }
}
