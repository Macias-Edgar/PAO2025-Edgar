using System;

namespace RegistroEstudiante
{
    // Clase Estudiante para representar los datos de un estudiante
    public class Estudiante
    {
        // Atributos privados
        private string id;
        private string nombres;
        private string apellidos;
        private string direccion;
        private string[] telefonos = new string[3]; // Arreglo de 3 teléfonos

        // Constructor para inicializar el objeto
        public Estudiante(string id, string nombres, string apellidos, string direccion, string[] telefonos)
        {
            this.id = id;
            this.nombres = nombres;
            this.apellidos = apellidos;
            this.direccion = direccion;
            this.telefonos = telefonos;
        }

        // Método para mostrar los datos del estudiante
        public void MostrarInformacion()
        {
            Console.WriteLine("ID: " + id);
            Console.WriteLine("Nombres: " + nombres);
            Console.WriteLine("Apellidos: " + apellidos);
            Console.WriteLine("Dirección: " + direccion);
            Console.WriteLine("Teléfonos:");
            for (int i = 0; i < telefonos.Length; i++)
            {
                Console.WriteLine($"Teléfono {i + 1}: {telefonos[i]}");
            }
        }
    }

    // Clase principal para ejecutar el programa
    class Program
    {
        static void Main(string[] args)
        {
            // Definimos un arreglo de teléfonos
            string[] telefonos = new string[3];

            // Solicitamos los datos al usuario
            Console.Write("Ingrese el ID del estudiante: ");
            string id = Console.ReadLine();

            Console.Write("Ingrese los nombres del estudiante: ");
            string nombres = Console.ReadLine();

            Console.Write("Ingrese los apellidos del estudiante: ");
            string apellidos = Console.ReadLine();

            Console.Write("Ingrese la dirección del estudiante: ");
            string direccion = Console.ReadLine();

            // Solicitar los 3 teléfonos
            for (int i = 0; i < telefonos.Length; i++)
            {
                Console.Write($"Ingrese el teléfono {i + 1}: ");
                telefonos[i] = Console.ReadLine();
            }

            // Crear el objeto Estudiante
            Estudiante estudiante = new Estudiante(id, nombres, apellidos, direccion, telefonos);

            // Mostrar los datos ingresados
            Console.WriteLine("\n--- Datos del Estudiante ---");
            estudiante.MostrarInformacion();
        }
    }
}
