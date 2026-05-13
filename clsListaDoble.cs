using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PryEdGaidoL
{
    internal class clsListaDoble
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

        public void Agregar(clsNodo nvo)
        {
            if (pri == null)
            {
                pri = nvo;
                ult = nvo;
            }
            else
            {
                if (nvo.Codigo < Primero.Codigo)
                {
                    nvo.Siguiente = Primero;
                    Primero.Anterior = nvo;
                    Primero = nvo;
                }
                else
                { 
                    if (nvo.Codigo > Ultimo.Codigo)
                    {
                        Ultimo.Siguiente = nvo;
                        nvo.Anterior = Ultimo;
                        Ultimo = nvo;
                    }
                    else
                    {
                        clsNodo aux = Primero;
                        clsNodo ant = Primero;
                        while (aux != null && nvo.Codigo > aux.Codigo)
                        {
                            ant = aux;
                            aux = aux.Siguiente;
                        }
                        ant.Siguiente = nvo;
                        nvo.Anterior = ant;
                        nvo.Siguiente = aux;
                        aux.Anterior = nvo;

                    }
              
                
                }

            }
        }

        public void Recorrer(DataGridView Grilla) //ascendente
        {
            clsNodo aux = Primero;
            Grilla.Rows.Clear();

            while (aux != null)
            {
                Grilla.Rows.Add(aux.Codigo, aux.Nombre, aux.Tràmite);
                aux = aux.Siguiente;

            }
        }

        public void RecorrerDES(DataGridView Grilla) //descendente
        {
            clsNodo aux = Ultimo;
            Grilla.Rows.Clear();

            while (aux != null)
            {
                Grilla.Rows.Add(aux.Codigo, aux.Nombre, aux.Tràmite);
                aux = aux.Anterior;

            }
        }

        public void Recorrer(ComboBox cmb)
        {
            clsNodo aux = Primero;
            cmb.Items.Clear();

            while (aux != null)
            {
                cmb.Items.Add(aux.Codigo); // o lo que quieras mostrar
                aux = aux.Siguiente;
            }
        }
        public void Recorrer(ListBox lst)
        {
            clsNodo aux = Primero;
            lst.Items.Clear();

            while (aux != null)
            {
                lst.Items.Add(aux.Codigo);
                aux = aux.Siguiente;
            }
        }

        public void Eliminar(Int32 Codigo)
        {
            if (Primero.Codigo == Codigo && Ultimo == Primero)
            {
                Primero = null;
                Ultimo = null;
            }
            else
            {
                if (Primero.Codigo == Codigo)
                {
                    Primero = Primero.Siguiente;
                    Primero.Anterior = null;

                }
                else
                {
                    if (Ultimo.Codigo == Codigo)
                    {
                        Ultimo = Ultimo.Anterior;
                        Ultimo.Siguiente = null;
                    }
                    else
                    {
                        clsNodo aux = Primero;
                        clsNodo ant = Primero;
                        while (aux.Codigo < Codigo)
                        {
                            ant = aux;
                            aux = aux.Siguiente;
                        }
                        aux = aux.Siguiente;
                        ant.Siguiente = aux;
                        aux.Anterior = ant;

                    }

                }


            }
        }

    }
}
