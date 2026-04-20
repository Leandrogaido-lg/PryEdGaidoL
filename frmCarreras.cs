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
    public partial class frmCarreras : Form
    {
        public frmCarreras()
        {
            InitializeComponent();
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            clsArchivo x = new clsArchivo();
            x.NomArchivo = "Carreras.csv";
            x.BorrarTodo();
            x.Grabar(txtCarrera.Text);
            x.Recorrer(lstbCarrera);

            MessageBox.Show("La carrera " + txtCarrera.Text + " se ha grabado correctamente");

            // Actualizar cualquier frmAlumnos abierto
            foreach (Form f in Application.OpenForms)
            {
                if (f is frmAlumnos frm)
                {
                    frm.CargarCarreras();
                }
            }

            txtCarrera.Clear();
        }

        private void frmCarreras_Load(object sender, EventArgs e)
        {
            clsArchivo x = new clsArchivo();
            x.NomArchivo = "Carreras.cvs";
            x.Recorrer(lstbCarrera);
        }
    }

}       

        
    

