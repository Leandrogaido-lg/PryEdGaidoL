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
    public partial class frmArbol : Form
    {
        public frmArbol()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            clsNodo x = new clsNodo();
            x.Codigo = Convert.ToInt32(txtCodigo.Text);
            x.Nombre = txtNombre.Text;
            x.Tràmite = txtTramite.Text;

            // 3. Pasar el nodo al método Agregar
            miArbol.Agregar(nuevoNodo);

            // 4. Actualizar la grilla
            miArbol.Recorrer(dgvListado);

            // Opcional: Limpiar las cajas de texto para la siguiente carga
            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtTramite.Text = "";
            txtCodigo.Focus();
        }
    }
}
