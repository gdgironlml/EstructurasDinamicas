using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstructurasDinamicas
{
    public class ListaDoblementeEnlazada
    {
        private NodoDoble inicio = null;
        private NodoDoble fin = null;
        private int tamaño = 0;

        public bool EstaVacia() => inicio == null;

        public int GetTamaño() => tamaño;

        public void InsertarAlInicio(int valor)
        {
            NodoDoble nuevo = new NodoDoble(valor);
            if (EstaVacia())
            {
                inicio = fin = nuevo;
            }
            else
            {
                nuevo.siguiente = inicio;
                inicio.anterior = nuevo;
                inicio = nuevo;
            }
            tamaño++;
        }

        public void InsertarAlFinal(int valor)
        {
            NodoDoble nuevo = new NodoDoble(valor);
            if (EstaVacia())
            {
                inicio = fin = nuevo;
            }
            else
            {
                fin.siguiente = nuevo;
                nuevo.anterior = fin;
                fin = nuevo;
            }
            tamaño++;
        }

        public void RecorrerAdelante()
        {
            NodoDoble actual = inicio;
            while (actual != null)
            {
                Console.Write($"[{actual.dato}] <-> ");
                actual = actual.siguiente;
            }
            Console.WriteLine("null");
        }

        public void RecorrerAtras()
        {
            NodoDoble actual = fin;
            while (actual != null)
            {
                Console.Write($"[{actual.dato}] <-> ");
                actual = actual.anterior;
            }
            Console.WriteLine("null");
        }

        public bool BuscarPorValor(int valor)
        {
            NodoDoble actual = inicio;
            while (actual != null)
            {
                if (actual.dato == valor) return true;
                actual = actual.siguiente;
            }
            return false;
        }

        public string BuscarPorIndice(int indice)
        {
            if (indice < 0 || indice >= tamaño) return "Error: Índice fuera de rango";
            NodoDoble actual = inicio;
            for (int i = 0; i < indice; i++)
            {
                actual = actual.siguiente;
            }
            return actual.dato.ToString();
        }

        public bool BorrarElemento(int valor)
        {
            NodoDoble actual = inicio;
            while (actual != null)
            {
                if (actual.dato == valor)
                {
                    if (actual == inicio)
                    {
                        inicio = inicio.siguiente;
                        if (inicio != null) inicio.anterior = null;
                        else fin = null;
                    }
                    else if (actual == fin)
                    {
                        fin = fin.anterior;
                        fin.siguiente = null;
                    }
                    else
                    {
                        actual.anterior.siguiente = actual.siguiente;
                        actual.siguiente.anterior = actual.anterior;
                    }
                    tamaño--;
                    return true;
                }
                actual = actual.siguiente;
            }
            return false;
        }
    }
}
