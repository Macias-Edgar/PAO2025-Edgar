using ListaEjerciciosAmigo.Servicios;
using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        
        // EJERCICIO 3: Notas por asignatura
        
        Console.WriteLine("Ejercicio 3: Notas por asignatura");
        var notasService = new NotasAsignaturaService();
        notasService.MostrarNotasPorAsignatura();

        
        // EJERCICIO 5: Números inversos
        
        Console.WriteLine("\nEjercicio 5: Números del 1 al 10 en orden inverso");
        var numerosService = new NumerosInversosService();
        numerosService.MostrarInverso();

        
        // EJERCICIO 6: Reprobadas
        
        Console.WriteLine("\nEjercicio 6: Asignaturas reprobadas");
        var reprobadasService = new ReprobadasService();
        reprobadasService.MostrarAsignaturasReprobadas();

        
        // EJERCICIO 7: Abecedario filtrado
        
        Console.WriteLine("\nEjercicio 7: Abecedario sin múltiplos de 3");
        var abecedarioService = new AbecedarioService();
        abecedarioService.MostrarAbecedarioFiltrado();

        
        // EJERCICIO 13: Media y desviación estándar
        
        Console.WriteLine("\nEjercicio 13: Estadísticas");
        var estadisticaService = new EstadisticaService();
        estadisticaService.CalcularEstadisticas();
    }
}
