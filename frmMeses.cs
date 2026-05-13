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
    public partial class frmMeses : Form
    {
        public frmMeses()
        {
            InitializeComponent();
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            clsArchivo x = new clsArchivo();
            x.NomArchivo = "";
            x.Grabar(txtNombreM.Text);
            x.Recorrer(lstbMeses);
            MessageBox.Show("Datos Grabados");

            txtNombreM.Text = "";
        }

        private void txtNombreM_TextChanged(object sender, EventArgs e)
        {

            if (txtNombreM.Text == "")
            {
                btnGrabar.Enabled = false;
            }
            else
            {
                btnGrabar.Enabled = true;
            }
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            if (lstbMeses.Items.Count == 0)
            {
                MessageBox.Show("No hay Meses Cargados para borrar");
                return;
            }
            clsArchivo meses = new clsArchivo();
            meses.NomArchivo = "Meses.csv";
            meses.BorrarTodo();
            meses.Recorrer(lstbMeses);
            MessageBox.Show("Datos Borrados");
        }
    }
}
