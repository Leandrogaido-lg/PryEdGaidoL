using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PryEdGaidoL
{
    internal class clsArchivo
    {
        public string NomArchivo = "";

        public void Grabar()
        {
            StreamWriter AD = new StreamWriter(NomArchivo);
            AD.WriteLine("");
            AD.Close();
        }

        public void Grabar(String Dato)
        {
            StreamWriter AD = new StreamWriter(NomArchivo, true);
            AD.WriteLine(Dato);
            AD.Close();
        }

        public void Recorrer(ListBox lstDatos)
        {

            lstDatos.Items.Clear();
            string DatoLeido = "";
            StreamReader AD = new StreamReader(NomArchivo);
            DatoLeido = AD.ReadLine();
            while (DatoLeido != null)
            {
                lstDatos.Items.Add(DatoLeido);
                DatoLeido = AD.ReadLine();
            }
            AD.Close();


        }

        public void BorrarTodo()
        {

            StreamWriter AD = new StreamWriter (NomArchivo, false);
            AD.Close();

        }


        public void Grabar(string Dato1, string Dato2, String Dato3)

        {
            StreamWriter AD = new StreamWriter(NomArchivo, true);
            AD.Write(Dato1);
            AD.Write(";");
            AD.Write(Dato2);
            AD.Write(";");
            AD.WriteLine(Dato3);
            AD.Close();



        }
    }   
}
