class Traductor
{
    // Diccionario Español -> Inglés (lista diferente a la primera versión)
    static Dictionary<string, string> diccionario = new Dictionary<string, string>()
    {
        {"libro", "book"},
        {"mesa", "table"},
        {"silla", "chair"},
        {"perro", "dog"},
        {"gato", "cat"},
        {"escuela", "school"},
        {"amigo", "friend"},
        {"familia", "family"},
        {"coche", "car"},
        {"ciudad", "city"}
    };

    static void Main()
    {
        int opcion;
        do
        {
            Console.WriteLine("======= TRADUCTOR ESPAÑOL - INGLÉS =======");
            Console.WriteLine("1. Traducir una frase");
            Console.WriteLine("2. Agregar palabra nueva");
            Console.WriteLine("0. Salir");
            Console.Write("Elija una opción: ");

            opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    TraducirFrase();
                    break;
                case 2:
                    AgregarPalabra();
                    break;
                case 0:
                    Console.WriteLine("Gracias por usar el traductor. ¡Hasta luego!");
                    break;
                default:
                    Console.WriteLine("Opción inválida. Intente nuevamente.");
                    break;
            }

            Console.WriteLine();
        } while (opcion != 0);
    }

    static void TraducirFrase()
    {
        Console.Write("Ingrese una frase en español: ");
        string frase = Console.ReadLine();

        string[] palabras = frase.Split(' ');
        string traduccion = "";

        foreach (string palabra in palabras)
        {
            string minuscula = palabra.ToLower();

            if (diccionario.ContainsKey(minuscula))
            {
                traduccion += diccionario[minuscula] + " ";
            }
            else
            {
                traduccion += palabra + " ";
            }
        }

        Console.WriteLine("Traducción: " + traduccion);
    }

    static void AgregarPalabra()
    {
        Console.Write("Nueva palabra en español: ");
        string espanol = Console.ReadLine().ToLower();

        Console.Write("Su traducción en inglés: ");
        string ingles = Console.ReadLine().ToLower();

        if (!diccionario.ContainsKey(espanol))
        {
            diccionario.Add(espanol, ingles);
            Console.WriteLine($"La palabra '{espanol}' fue agregada como '{ingles}'.");
        }
        else
        {
            Console.WriteLine("Esa palabra ya existe en el diccionario.");
        }
    }
}
