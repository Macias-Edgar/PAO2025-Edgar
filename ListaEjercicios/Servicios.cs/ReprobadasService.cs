using System;
using System.Collections.Generic;

namespace ListaEjerciciosAmigo.Servicios
{
    public class ReprobadasService
    {
        public void MostrarAsignaturasReprobadas()
        {
            List<string> asignaturas = new List<string> { "Matemáticas", "Física", "Química", "Historia", "Lengua" };
            List<string> reprobadas = new List<string>();

            foreach (string asignatura in asignaturas)
            {
                Console.Write($"Nota en {asignatura}: ");
                double nota = double.Parse(Console.ReadLine());

                if (nota < 7)
                {
                    reprobadas.Add(asignatura);
                }
            }

            Console.WriteLine("\nDebes repetir:");
            foreach (string a in reprobadas)
            {
                Console.WriteLine(a);
            }
        }
    }
}
