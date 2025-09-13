// Importamos los espacios de nombres necesarios para usar colecciones y entrada/salida.
using System;
using System.Collections.Generic;

namespace CatalogoRevistas
{
    class Program
    {
        // Método principal: punto de entrada del programa.
        static void Main(string[] args)
        {
            // Creamos una lista que almacenará los títulos de las revistas.
            List<string> revistas = new List<string>()
            {
                "National Geographic",
                "Time",
                "Scientific American",
                "Forbes",
                "Reader's Digest",
                "Nature",
                "Muy Interesante",
                "PC Magazine",
                "Vogue",
                "Sports Illustrated"
            };

            int opcion; // Variable para controlar el menú de opciones.

            // Bucle para que el menú se repita hasta que el usuario decida salir.
            do
            {
                Console.WriteLine("\n=== MENÚ DEL CATÁLOGO DE REVISTAS ===");
                Console.WriteLine("1. Buscar revista");
                Console.WriteLine("2. Mostrar catálogo completo");
                Console.WriteLine("3. Salir");
                Console.Write("Seleccione una opción: ");
                
                // Convertimos la entrada a entero para la opción.
                opcion = Convert.ToInt32(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Console.Write("Ingrese el título de la revista a buscar: ");
                        string titulo = Console.ReadLine();

                        // Llamamos a la función de búsqueda iterativa.
                        bool existe = BuscarRevista(revistas, titulo);

                        if (existe)
                            Console.WriteLine("Resultado: Encontrado");
                        else
                            Console.WriteLine("Resultado: No encontrado");
                        break;

                    case 2:
                        Console.WriteLine("\n--- Catálogo de Revistas ---");
                        foreach (var r in revistas)
                        {
                            Console.WriteLine("- " + r);
                        }
                        break;

                    case 3:
                        Console.WriteLine("Saliendo del sistema...");
                        break;

                    default:
                        Console.WriteLine("Opción no válida, intente nuevamente.");
                        break;
                }

            } while (opcion != 3);
        }

        // Método iterativo para buscar un título en la lista.
        static bool BuscarRevista(List<string> lista, string titulo)
        {
            // Recorremos cada elemento de la lista.
            foreach (string revista in lista)
            {
                // Comparamos ignorando mayúsculas/minúsculas.
                if (revista.Equals(titulo, StringComparison.OrdinalIgnoreCase))
                {
                    return true; // Si se encuentra, devolvemos verdadero.
                }
            }
            return false; // Si termina el bucle y no encontró coincidencia, devolvemos falso.
        }
    }
}
