using System;

namespace HanoiSolver
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Resolución del problema de las Torres de Hanoi.");
            Console.Write("Ingrese el número de discos: ");
            int numDiscos;

            // Verificamos que el usuario ingrese un número entero positivo
            while (!int.TryParse(Console.ReadLine(), out numDiscos) || numDiscos <= 0)
            {
                Console.Write("Por favor, ingrese un número válido y positivo de discos: ");
            }

            Console.WriteLine($"\nMovimientos para resolver las Torres de Hanoi con {numDiscos} discos:\n");
            ResolverHanoi(numDiscos, 'A', 'B', 'C');
        }

        /// <summary>
        /// Método recursivo para resolver el problema de las Torres de Hanoi.
        /// </summary>
        /// <param name="n">Cantidad de discos</param>
        /// <param name="origen">Torre origen</param>
        /// <param name="auxiliar">Torre auxiliar</param>
        /// <param name="destino">Torre destino</param>
        static void ResolverHanoi(int n, char origen, char auxiliar, char destino)
        {
            if (n == 1)
            {
                Console.WriteLine($"Mover disco 1 de la torre {origen} a la torre {destino}");
                return;
            }

            // Mover n-1 discos desde la torre origen a la torre auxiliar
            ResolverHanoi(n - 1, origen, destino, auxiliar);

            // Mover el disco restante a la torre destino
            Console.WriteLine($"Mover disco {n} de la torre {origen} a la torre {destino}");

            // Mover los n-1 discos desde la torre auxiliar a la torre destino
            ResolverHanoi(n - 1, auxiliar, origen, destino);
        }
    }
}
