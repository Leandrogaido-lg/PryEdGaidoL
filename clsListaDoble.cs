using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                    }
                       
                            
                
                
                }
                
               






            }
        }




    }
}
