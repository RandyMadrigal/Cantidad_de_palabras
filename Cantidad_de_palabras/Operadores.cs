using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cantidad_de_palabras
{
    class Operadores
    {
        private int total = 0;
        private string palabra;
        private string Cadena = "0123456789";

        public Operadores(){   }

        public int TOTAL
        {
            get { return total; }
            set { total = value; }
        }

        public String PALABRA
        {
            get { return palabra; }
            set { palabra = value; }
        }

        public string CADENA
        {
            get { return Cadena; }
            set { Cadena = value; }
        }


    }
}
