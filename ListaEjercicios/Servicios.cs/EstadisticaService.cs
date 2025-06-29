using System;
using System.Collections.Generic;
using System.Linq;

namespace ListaEjerciciosAmigo.Servicios
{
    public class EstadisticaService
    {
        public void CalcularEstadisticas()
        {
            Console.Write("Ingrese una serie de números separados por comas: ");
            string entrada = Console.ReadLine();
            string[] partes = entrada.Split(',');

            List<double> numeros = partes.Select(p => double.Parse(p.Trim())).ToList();

            double media = numeros.Average();

            double sumaCuadrados = numeros.Sum(n => Math.Pow(n - media, 2));
            double desviacion = Math.Sqrt(sumaCuadrados / numeros.Count);

            Console.WriteLine($"Media: {media:F2}");
            Console.WriteLine($"Desviación típica: {desviacion:F2}");
        }
    }
}
