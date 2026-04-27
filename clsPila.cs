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


        public void BorrarTodo()
        {
            EnsureFilePath();
            // Truncate or create the file empty
            File.WriteAllText(NomArchivo, string.Empty);
        }

        public void Grabar(string Dato1, string Dato2, string Dato3)
        {
            EnsureFilePath();
            using (var sw = new StreamWriter(NomArchivo, true))
            {
                sw.Write(Dato1);
                sw.Write(";");
                sw.Write(Dato2);
                sw.Write(";");
                sw.WriteLine(Dato3);
            }
        }

        public void Recorrer(DataGridView Grilla)
        {
            if (string.IsNullOrWhiteSpace(NomArchivo) || !File.Exists(NomArchivo))
            {
                Grilla.Rows.Clear();
                return;
            }

            Grilla.Rows.Clear();
            using (var sr = new StreamReader(NomArchivo))
            {
                string DatoLeido;
                while ((DatoLeido = sr.ReadLine()) != null)
                {
                    var cols = DatoLeido.Split(';');
                    Grilla.Rows.Add(cols);
                }
            }
        }

       
    }
}
