using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstructurasDinamicas
{
    public class NodoDoble
    {
        public int dato;
        public NodoDoble siguiente;
        public NodoDoble anterior;

        public NodoDoble(int valor)
        {
            this.dato = valor;
            this.siguiente = null;
            this.anterior = null;
        }
    }
}
