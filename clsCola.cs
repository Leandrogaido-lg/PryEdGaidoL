using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PryEdGaidoL
{
    internal class clsCola
    {
        private clsNodo pri;
        private clsNodo ult;


        public clsNodo Primero
        {
            get { return pri; }
            set { pri = value; }
        }

        public clsNodo Ultimo
        {
            get { return ult; }
            set { ult = value; }
        }

        public void Agregar(clsNodo Nuevo)
        {
            if (Primero != null)
            {
                Primero = Nuevo;
                Ultimo = Nuevo;

            }
            else
            {
                Ultimo.Siguiente = Nuevo;
                Ultimo = Nuevo;
            }
        }

        public void Eliminar ()
        {
            if(Primero == Ultimo)
            {
                Primero = null;
                Ultimo = null;

            }
            else
            {
                Primero = Primero.Siguiente;
            }


        }

        public void Recorrer (DataGridView Grilla)
        {
            clsNodo aux = Primero;
            Grilla.Rows.Clear ();

            while (aux != null)
            {
                Grilla.Rows.Add(aux.Codigo, aux.Nombre, aux.Tràmite);
                aux = aux.Siguiente;
            
            }
        
        }

        public void Recorrer (String NomArchivo)
        {
            clsNodo aux = Primero;
            StreamWriter AD = new StreamWriter(NomArchivo, false, Encoding.UTF8);
            AD.WriteLine("Lista de espera/n");
            AD.WriteLine("Código,Nombre,Trámite");
            while (aux != null)
            {
                AD.WriteLine(aux.Codigo);
                AD.Write(";");
                AD.Write(aux.Nombre);
                AD.Write(";");
                AD.WriteLine(aux.Tràmite);
                aux = aux.Siguiente;
            }
            AD.Close();
        }
        public void Recorrer(ListBox lstDatos)
        {
            lstDatos.Items.Clear();
            string DatoLeido = "";
            string NomArchivo = null;
            if (!File.Exists(NomArchivo)) return;
            StreamReader AD = new StreamReader(NomArchivo);
            DatoLeido = AD.ReadLine();
            while (DatoLeido != null)
            {
                lstDatos.Items.Add(DatoLeido);
                DatoLeido = AD.ReadLine();
            }
            AD.Close();
        }
    }
}
