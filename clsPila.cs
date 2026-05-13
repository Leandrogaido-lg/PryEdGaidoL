using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace PryEdGaidoL
{
    internal class clsPila
    {
        public string NomArchivo = "";
        private clsNodo pri;
        
        public clsNodo Primero
        { 
            get { return pri; } 
            set { pri = value; }
        }

        public void Agregar(clsNodo Nuevo)
        {
            if (Primero == null)
            {
                Primero = Nuevo;
            }
            else
            {
                Nuevo.Siguiente = Primero;
                Primero = Nuevo;


            }
        }


        public void Eliminar()
        {
            if (Primero == null)
            {
                Primero = Primero.Siguiente;
                
            
            }
        
        }

        public void Recorrer(DataGridView Grilla)
        {
            clsNodo aux = Primero;
            Grilla.Rows.Clear();
            while (aux != null)
            {
                Grilla.Rows.Add(aux.Codigo, aux.Nombre, aux.Tràmite);
                aux = aux.Siguiente;
            }

        }

        public void Recorrer(ListBox lstDatos)
        {
            lstDatos.Items.Clear();
            string DatoLeido = "";
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

        public void Recorrer(String NombreArchivo)
        {
            clsNodo aux = Primero;
            StreamWriter AD = new StreamWriter(NombreArchivo, false, Encoding.UTF8);
            AD.WriteLine("Lista de espera\n");
            AD.WriteLine("Codigo,Nombre,Tramite");

            while (aux != null)
            {
                AD.Write(aux.Codigo);
                AD.Write(';');
                AD.Write(aux.Nombre);
                AD.Write(';');
                AD.WriteLine(aux.Tràmite);
                aux = aux.Siguiente;
            }
            AD.Close();

        }
    }
}
