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
    public partial class frmColores : Form
    {
        public frmColores()
        {
            InitializeComponent();
        }

        private void btnGrabarC_Click(object sender, EventArgs e)
        {
            clsArchivo x = new clsArchivo();
            x.NomArchivo = "";
            x.Grabar (txtNombreC.Text);
            x.Recorrer(lstbColores);
            MessageBox.Show("Datos Grabados");

            txtNombreC.Text = "";
        }

        private void txtNombreC_TextChanged(object sender, EventArgs e)
        {
            if (txtNombreC.Text == "")
            {
                btnGrabarC.Enabled = false;
            }
            else
            {
                btnGrabarC.Enabled = true;
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            if (lstbColores.Items.Count == 0)
            {
                MessageBox.Show("No hay Colores Cargados para borrar");
                return;
            }
            clsArchivo colores = new clsArchivo();
            colores.NomArchivo = "Colores.csv";
            colores.BorrarTodo();
            colores.Recorrer(lstbColores);
            MessageBox.Show("Datos Borrados");
        }

        



    }
}
