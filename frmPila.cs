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

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (objPila.Primero != null)
            {
                lblSombraC.Text = Convert.ToString(objPila.Primero.Codigo);
                lblSombraN.Text = objPila.Primero.Nombre;
                lblSombraT.Text = objPila.Primero.Tràmite;

                objPila.Eliminar();
                objPila.Recorrer(dgvPila);
                objPila.Recorrer("Pila.csv");
                objPila.Recorrer(lstbPila);
            }
            else
            {
                lblSombraC.Text = "";
                lblSombraN.Text = "";
                lblSombraT.Text = "";
                MessageBox.Show("No hay personas para eliminar en la pila");
            }
        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {
            if (txtCodigo.Text == "")
            {
                txtNombre.Enabled = false;
            }
            else
            {
                txtNombre.Enabled = true;
            }
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            if (txtNombre.Text == "")
            {
                txtTramite.Enabled = false;
            }
            else
            {
                txtTramite.Enabled = true;
            }
        }

        private void txtTramite_TextChanged(object sender, EventArgs e)
        {
            if (txtTramite.Text == "")
            {
                btnAgregar.Enabled = false;
            }
            else
            {
                btnAgregar.Enabled = true;
            }
        }

        
    }
}
