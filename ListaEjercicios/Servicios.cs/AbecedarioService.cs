using System;
using System.Collections.Generic;

namespace ListaEjerciciosAmigo.Servicios
{
    public class AbecedarioService
    {
        public void MostrarAbecedarioFiltrado()
        {
            List<char> abecedario = new List<char>();
            for (char c = 'a'; c <= 'z'; c++)
                abecedario.Add(c);

            List<char> resultado = new List<char>();
            for (int i = 0; i < abecedario.Count; i++)
            {
                if ((i + 1) % 3 != 0)
                    resultado.Add(abecedario[i]);
            }

            Console.WriteLine(string.Join(", ", resultado));
        }
    }
}
