using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PryEdGaidoL
{
    internal class clsNodo
    {
        private Int32 cod;
        private String nom;
        private String tra;
        private clsNodo sig;
        private clsNodo ant;
        public Int32 cod
        {
            get { return cod; }
            set { cod = value; }
        }

        public String nom
        {
            get { return nom; }
            set { nom = value; }
        }

        public String tra
        {
            get { return tra; }
            set { tra = value; }
        }

        public clsNodo sig
        {
            get { return sig; }
            set { sig = value; }
        }   

        public clsNodo ant
        {
            get { return ant; }
            set { ant = value; }
        }

    }
}
