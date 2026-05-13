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
    public partial class frmListaDoble : Form
    {
        public frmListaDoble()
        {
            InitializeComponent();
        }
        clsListaDoble objLista = new clsListaDoble();
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (objLista.Primero != null)
            {
                if (cmbCodigo.SelectedIndex != -1)
                {
                    int x = Convert.ToInt32(cmbCodigo.SelectedItem);
                    objLista.Eliminar(x);

                    objLista.Recorrer(dgvListaDoble);
                    objLista.Recorrer(lstbLista);
                    objLista.Recorrer(cmbCodigo);
                }
                else
                {
                    MessageBox.Show("Debe seleccionar un código para eliminar");
                }
            }
            else
            {
                MessageBox.Show("No hay datos para eliminar");
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            clsNodo objNodo = new clsNodo();
            objNodo.Codigo = Convert.ToInt32(txtCodigo.Text);
            objNodo.Nombre = txtNombre.Text;
            objNodo.Tràmite = txtTramite.Text;

            objLista.Agregar(objNodo);
            objLista.Recorrer(dgvListaDoble);
            objLista.Recorrer(lstbLista);
            objLista.Recorrer(cmbCodigo);

            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtTramite.Text = "";
        }

        private void radAscendente_CheckedChanged(object sender, EventArgs e)
        {
            objLista.Recorrer(dgvListaDoble);
            objLista.Recorrer(lstbLista);
            objLista.Recorrer(cmbCodigo);
        }

        private void radDescendente_CheckedChanged(object sender, EventArgs e)
        {
            objLista.RecorrerDES(dgvListaDoble);
            objLista.Recorrer(lstbLista);
            objLista.Recorrer(cmbCodigo);
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
