using EstructurasDinamicas;

class Program
{
    static void Main(string[] args)
    {
        ListaDoblementeEnlazada lista = new ListaDoblementeEnlazada();
        int opcion = -1;

        while (opcion != 0)
        {
            Console.WriteLine("Que deseas hacer?");
            Console.WriteLine("1. Insertar al inicio");
            Console.WriteLine("2. Insertar al Final");
            Console.WriteLine("3. Recorrer hacia adelante");
            Console.WriteLine("4. Recorrer hacia atras");
            Console.WriteLine("5. Mostrar tamaño de la lista");
            Console.WriteLine("6. Mostrar si la lista esta vacia");
            Console.WriteLine("7. Buscar elemento por valor");
            Console.WriteLine("8. Buscar elemento por indice");
            Console.WriteLine("9. Borrar un Elemento");
            Console.WriteLine("0. Salir");

            if (int.TryParse(Console.ReadLine(), out opcion))
            {
                EjecutarOpcion(opcion, lista);
            }
        }
    }

    static void EjecutarOpcion(int opcion, ListaDoblementeEnlazada lista)
    {
        int valor;
        switch (opcion)
        {
            case 1:
                Console.Write("Ingrese valor: ");
                if (int.TryParse(Console.ReadLine(), out valor)) lista.InsertarAlInicio(valor);
                break;
            case 2:
                Console.Write("Ingrese valor: ");
                if (int.TryParse(Console.ReadLine(), out valor)) lista.InsertarAlFinal(valor);
                break;
            case 3:
                lista.RecorrerAdelante();
                break;
            case 4:
                lista.RecorrerAtras();
                break;
            case 5:
                Console.WriteLine($"Tamaño de la lista: {lista.GetTamaño()}");
                break;
            case 6:
                Console.WriteLine(lista.EstaVacia() ? "Lista Vacia" : "Lista con datos");
                break;
            case 7:
                Console.Write("Valor a buscar: ");
                if (int.TryParse(Console.ReadLine(), out valor))
                    Console.WriteLine(lista.BuscarPorValor(valor) ? "Encontrado" : "No existe");
                break;
            case 8:
                Console.Write("Indice a consultar: ");
                if (int.TryParse(Console.ReadLine(), out valor))
                    Console.WriteLine($"Valor: {lista.BuscarPorIndice(valor)}");
                break;
            case 9:
                Console.Write("Valor a eliminar: ");
                if (int.TryParse(Console.ReadLine(), out valor))
                    Console.WriteLine(lista.BorrarElemento(valor) ? "Valor eliminado" : "Valor no encontrado");
                break;
        }
    }
}