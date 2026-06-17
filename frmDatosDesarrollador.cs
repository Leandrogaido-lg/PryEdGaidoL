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
    public partial class frmDatosDesarrollador : Form
    {
        public frmDatosDesarrollador()
        {
            InitializeComponent();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void datosDelDesarrolladorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmInformacionDelCreador v = new frmInformacionDelCreador();
            v.ShowDialog();
        }

        private void coloresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmColores c = new frmColores();
            c.ShowDialog();
        }

        private void mesesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMeses m = new frmMeses();    
            m.ShowDialog();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmClientes cl = new frmClientes();
            cl.ShowDialog();
        }

        private void alumnosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAlumnos a = new frmAlumnos();
            a.ShowDialog();
        }

        private void carrerasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCarreras ca = new frmCarreras();
            ca.ShowDialog();
        }

        private void colaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCola co = new frmCola();
            co.ShowDialog();
        }

        private void pilaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPila p = new frmPila(); p.ShowDialog();
        }

        private void listaSimpleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListaSimple ls = new frmListaSimple(); ls.ShowDialog();
        }

        private void listaDobleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListaDoble ld = new frmListaDoble(); ld.ShowDialog();
        }

        private void arbolToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmArbol ar = new frmArbol();
            ar.ShowDialog();
        }

        private void grafoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGrafo g = new frmGrafo();
            g.ShowDialog();
        }

        private void frmDatosDesarrollador_Load(object sender, EventArgs e)
        {

        }

        private void consultaDeUnaTablaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmBdConsultaTablas ct = new frmBdConsultaTablas();
            ct.ShowDialog();
        }

        private void consultaDeBaseDeDatosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBdConsultaSql csql = new frmBdConsultaSql();
            csql.ShowDialog();
        }

        private void operacionesEnBaseDeDatosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBdOperaciones bdo = new frmBdOperaciones();
            bdo.ShowDialog();
        }

        private void consultasVariasConOperacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBdRepaso bdr = new frmBdRepaso();    
            bdr.ShowDialog();
        }
    }
}
