using System;
using System.Collections.Generic;

namespace ListaEjerciciosAmigo.Servicios
{
    public class NotasAsignaturaService
    {
        public void MostrarNotasPorAsignatura()
        {
            List<string> asignaturas = new List<string> { "Matemáticas", "Física", "Química", "Historia", "Lengua" };
            Dictionary<string, double> notas = new Dictionary<string, double>();

            foreach (string asignatura in asignaturas)
            {
                Console.Write($"¿Qué nota obtuviste en {asignatura}? ");
                double nota = double.Parse(Console.ReadLine());
                notas[asignatura] = nota;
            }

            Console.WriteLine("\nResumen de tus notas:");
            foreach (var item in notas)
            {
                Console.WriteLine($"En {item.Key} has sacado {item.Value}");
            }
        }
    }
}
