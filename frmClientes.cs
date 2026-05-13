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
    public partial class frmClientes : Form
    {
        public frmClientes()
        {
            InitializeComponent();
        }

        private void btnGrabarCl_Click(object sender, EventArgs e)
        {
            clsArchivo objClientes = new clsArchivo();
            objClientes.NomArchivo = "Clientes.csv";
            objClientes.Grabar(txtCodigo.Text, txtNombreCl.Text, txtDeuda.Text);
            objClientes.Recorrer(dgvClientes);
            MessageBox.Show("Cliente guardado");
            txtCodigo.Clear();
            txtNombreCl.Clear();
            txtDeuda.Clear();
        }
    }
}
