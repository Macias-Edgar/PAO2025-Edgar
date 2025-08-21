using System;
using System.Collections.Generic;
using System.Linq;

namespace VacunacionCovid
{
    class Programa
    {
        static void Main(string[] args)
        {
            // 1. Generar la lista de 500 ciudadanos
            List<string> ciudadanos = new List<string>();
            for (int i = 1; i <= 500; i++)
            {
                ciudadanos.Add($"Persona {i}");
            }

            // 2. Crear 75 ciudadanos vacunados con Pfizer
            HashSet<string> grupoPfizer = new HashSet<string>();
            Random aleatorio = new Random();
            while (grupoPfizer.Count < 75)
            {
                int indice = aleatorio.Next(0, ciudadanos.Count);
                grupoPfizer.Add(ciudadanos[indice]);
            }

            // 3. Crear 75 ciudadanos vacunados con AstraZeneca
            HashSet<string> grupoAstra = new HashSet<string>();
            while (grupoAstra.Count < 75)
            {
                int indice = aleatorio.Next(0, ciudadanos.Count);
                grupoAstra.Add(ciudadanos[indice]);
            }

            // 4. Operaciones con teoría de conjuntos
            // a) Personas no vacunadas
            var noVacunas = ciudadanos.Except(grupoPfizer.Union(grupoAstra));

            // b) Personas vacunadas con ambas dosis
            var ambasVacunas = grupoPfizer.Intersect(grupoAstra);

            // c) Personas que solo recibieron Pfizer
            var soloPfizer = grupoPfizer.Except(grupoAstra);

            // d) Personas que solo recibieron AstraZeneca
            var soloAstra = grupoAstra.Except(grupoPfizer);

            // 5. Reporte en consola
            Console.WriteLine("=== REPORTE CAMPAÑA DE VACUNACIÓN COVID-19 ===\n");

            Console.WriteLine($"Total no vacunados: {noVacunas.Count()}");
            foreach (var persona in noVacunas) Console.WriteLine(persona);

            Console.WriteLine($"\nTotal con ambas dosis: {ambasVacunas.Count()}");
            foreach (var persona in ambasVacunas) Console.WriteLine(persona);

            Console.WriteLine($"\nTotal vacunados solo con Pfizer: {soloPfizer.Count()}");
            foreach (var persona in soloPfizer) Console.WriteLine(persona);

            Console.WriteLine($"\nTotal vacunados solo con AstraZeneca: {soloAstra.Count()}");
            foreach (var persona in soloAstra) Console.WriteLine(persona);

            Console.WriteLine("\n--- Fin del proceso ---");
            Console.ReadKey();
        }
    }
}
