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
    public partial class frmCola : Form
    {
        public frmCola()
        {
            InitializeComponent();
        }

        clsCola ColaEspera = new clsCola(); //global

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            clsNodo Persona = new clsNodo();
            Persona.Codigo = Convert.ToInt32(txtCodigo.Text);
            Persona.Nombre = txtNombre.Text;
            Persona.Tràmite = txtTramite.Text;  

            ColaEspera.Agregar(Persona);
            ColaEspera.Recorrer(dgvCola);
            ColaEspera.Recorrer("Cola.csv");
            ColaEspera.Recorrer(lstbCola);

                txtCodigo.Clear();
                txtNombre.Clear();
                txtTramite.Clear();
                
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (ColaEspera.Primero != null)
            {
                ColaEspera.Eliminar();
                ColaEspera.Recorrer(dgvCola);
                ColaEspera.Recorrer("Cola.csv");
                ColaEspera.Recorrer(lstbCola);
            }
             else
            {
                lblCodigo2.Text = "";
                lblNombre2.Text = "";
                lblTramite2.Text = "";
            }
        }
    }
}
