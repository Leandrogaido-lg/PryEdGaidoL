using System;
using System.IO;
using System.Windows.Forms;

namespace PryEdGaidoL
{
    internal class clsArchivo
    {


        public string NomArchivo = "";
        
        

        public void Grabar(string Dato)
        {
            StreamWriter AD = new StreamWriter(NomArchivo, true);
             AD.WriteLine(Dato);
             AD.Close();
                
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


        public void BorrarTodo()
        {
            StreamWriter AD = new StreamWriter(NomArchivo, false);
                AD.Close();
        }

        public void Grabar(string Dato1, string Dato2, string Dato3)
        {

            StreamWriter AD = new StreamWriter(NomArchivo, true);
            
                AD.Write(Dato1);
                AD.Write(";");
                AD.Write(Dato2);
                AD.Write(";");
                AD.WriteLine(Dato3);
                AD.Close();
            
            
        }

        public void Recorrer(DataGridView Grilla)
        {
           

            Grilla.Rows.Clear();
                string DatoLeido;
                if (!File.Exists(NomArchivo)) return;
                StreamReader AD = new StreamReader(NomArchivo);
                DatoLeido = AD.ReadLine();

            while (DatoLeido  != null)
                {
                    Grilla.Rows.Add(DatoLeido.Split(';'));
                    DatoLeido = AD.ReadLine();
            }
            AD.Close();
        }

        public void Recorrer(ComboBox cmb)
        {
            cmb.Items.Clear();
            if  (!File.Exists(NomArchivo)) return;
            using ( StreamReader AD = new StreamReader(NomArchivo))
            {
                string DatoLeido;
                while ((DatoLeido = AD.ReadLine()) != null)
                {
                    cmb.Items.Add(DatoLeido);
                }
            }
        }

       
    }
}
