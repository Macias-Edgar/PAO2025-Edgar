using System;
using System.Collections.Generic;

namespace ListaEjerciciosAmigo.Servicios
{
    public class NumerosInversosService
    {
        public void MostrarInverso()
        {
            List<int> numeros = new List<int>();
            for (int i = 1; i <= 10; i++)
                numeros.Add(i);

            numeros.Reverse();

            Console.WriteLine(string.Join(", ", numeros));
        }
    }
}
