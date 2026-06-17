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
    public partial class frmBdOperaciones : Form
    {
        public frmBdOperaciones()
        {
            InitializeComponent();
        }
        clsBaseDatos bd = new clsBaseDatos();

        private void btnProySimple_Click(object sender, EventArgs e)
        {
            String varSQL = "SELECT TITULO " +
                          "FROM LIBRO " +
                          "ORDER BY 1 DESC";
            bd.Listar(dgvBaseDatos, varSQL);
        }

        private void btnProyMulti_Click(object sender, EventArgs e)
        {
            String varSQL = "SELECT TITULO, AÑO " +
                          "FROM LIBRO " +
                          "ORDER BY TITULO ASC";
            bd.Listar(dgvBaseDatos, varSQL);
        }

        private void btnJuntar_Click(object sender, EventArgs e)
        {
            String varSQL = "SELECT TITULO, NOMBRE  " +
                          "from LIBRO inner join PAIS " +
                          "on LIBRO.IDPAIS = PAIS.IDPAIS";
            bd.Listar(dgvBaseDatos, varSQL);
        }

        private void btnSelecSimple_Click(object sender, EventArgs e)
        {

        }

        private void btnSelecConv_Click(object sender, EventArgs e)
        {
            String varSQL = "SELECT * " +
                          "FROM (select * from libro where idIdioma > 1 ) as X " +
                          "WHERE IDPAIS = 2 ";
            bd.Listar(dgvBaseDatos, varSQL);
        }

        private void btnUnion_Click(object sender, EventArgs e)
        {
            String varSQL = "SELECT * " +
                          "FROM LIBRO " +
                          "WHERE IDIDIOMA = 1 " +
                          "UNION " +
                          "SELECT * " +
                          "FROM LIBRO " +
                          "WHERE IDIDIOMA = 2";
            bd.Listar(dgvBaseDatos, varSQL);
        }

        private void btnInterseccion_Click(object sender, EventArgs e)
        {
            String varSQL = "SELECT * from libro " +
                          "where idIdioma = 2 and " +
                          "idLibro in " +
                          "(Select idLibro from libro where IdPais = 3 ) " +
                          "order by 1 asc ";
            bd.Listar(dgvBaseDatos, varSQL);

        }

        private void btnDiferencia_Click(object sender, EventArgs e)
        {
            String varSQL = "SELECT * from libro " +
                          "where idIdioma = 2 and " +
                          "idLibro not in " +
                          "(Select idLibro from libro where IdPais = 3 ) " +
                          "order by 1 asc ";
            bd.Listar(dgvBaseDatos, varSQL);
        }
    }
}
