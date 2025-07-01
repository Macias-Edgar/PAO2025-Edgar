using System;

class Nodo
{
    public int Dato;
    public Nodo Siguiente;

    public Nodo(int dato)
    {
        Dato = dato;
        Siguiente = null;
    }
}

class ListaEnlazada
{
    public Nodo Cabeza;

    public ListaEnlazada()
    {
        Cabeza = null;
    }

    // Método para agregar un nodo al final
    public void Agregar(int dato)
    {
        Nodo nuevo = new Nodo(dato);
        if (Cabeza == null)
        {
            Cabeza = nuevo;
        }
        else
        {
            Nodo actual = Cabeza;
            while (actual.Siguiente != null)
            {
                actual = actual.Siguiente;
            }
            actual.Siguiente = nuevo;
        }
    }

    // Mostrar todos los elementos de la lista
    public void Mostrar()
    {
        Nodo actual = Cabeza;
        while (actual != null)
        {
            Console.Write(actual.Dato + " -> ");
            actual = actual.Siguiente;
        }
        Console.WriteLine("null");
    }

    // Buscar cuántas veces aparece un valor
    public void BuscarDato(int valor)
    {
        int contador = 0;
        Nodo actual = Cabeza;

        while (actual != null)
        {
            if (actual.Dato == valor)
                contador++;

            actual = actual.Siguiente;
        }

        if (contador == 0)
            Console.WriteLine($"El valor {valor} no se encuentra en la lista.");
        else
            Console.WriteLine($"El valor {valor} aparece {contador} vez/veces en la lista.");
    }

    // Eliminar nodos que estén fuera del rango permitido
    public void EliminarFueraDeRango(int min, int max)
    {
        // Eliminar nodos del inicio
        while (Cabeza != null && (Cabeza.Dato < min || Cabeza.Dato > max))
        {
            Cabeza = Cabeza.Siguiente;
        }

        Nodo actual = Cabeza;

        while (actual != null && actual.Siguiente != null)
        {
            if (actual.Siguiente.Dato < min || actual.Siguiente.Dato > max)
            {
                actual.Siguiente = actual.Siguiente.Siguiente;
            }
            else
            {
                actual = actual.Siguiente;
            }
        }
    }
}

class Program
{
    static void Main()
    {
        ListaEnlazada lista = new ListaEnlazada();
        Random rnd = new Random();

        // Generar 50 números aleatorios entre 1 y 999
        for (int i = 0; i < 50; i++)
        {
            int numero = rnd.Next(1, 1000);
            lista.Agregar(numero);
        }

        Console.WriteLine("Lista generada:");
        lista.Mostrar();

        // Solicitar al usuario un rango válido
        Console.WriteLine("Ingrese el valor mínimo del rango:");
        int min = int.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese el valor máximo del rango:");
        int max = int.Parse(Console.ReadLine());

        // Eliminar valores fuera del rango
        lista.EliminarFueraDeRango(min, max);

        Console.WriteLine("Lista después de eliminar valores fuera del rango:");
        lista.Mostrar();

        // Buscar cuántas veces aparece un número
        Console.WriteLine("¿Qué número desea buscar en la lista?");
        int buscar = int.Parse(Console.ReadLine());

        lista.BuscarDato(buscar);
    }
}
