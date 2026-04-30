using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace PryEdGaidoL
{
    public partial class frmPila : Form
    {
        public frmPila()
        {
            InitializeComponent();
        }

        clsPila objPila = new clsPila();

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            clsNodo x = new clsNodo();
            x.Codigo = Convert.ToInt32(txtCodigo.Text);
            x.Nombre = txtNombre.Text;
            x.Tràmite = txtTramite.Text;

            objPila.Agregar(x);
            objPila.Recorrer(dgvPila);
            objPila.Recorrer(lstbPila);
             
            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtTramite.Text = "";

        }
    }
}
