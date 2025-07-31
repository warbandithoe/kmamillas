class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Conversor de distancias: Kilómetros <-> Millas");
        Console.WriteLine("1. Convertir de Kilómetros a Millas");
        Console.WriteLine("2. Convertir de Millas a Kilómetros");
        Console.Write("Seleccione una opción (1 o 2): ");

        string opcion = Console.ReadLine();

        switch (opcion)
        {
            case "1":
                Console.Write("Ingrese los kilómetros: ");
                double km = double.Parse(Console.ReadLine());
                Kilometros kilometros = new Kilometros(km);
                Console.WriteLine($"{km} km son {kilometros.A_Millas():0.000} millas.");
                break;

            case "2":
                Console.Write("Ingrese las millas: ");
                double mi = double.Parse(Console.ReadLine());
                Millas millas = new Millas(mi);
                Console.WriteLine($"{mi} millas son {millas.A_Kilometros():0.000} km.");
                break;

            default:
                Console.WriteLine("Opción inválida.");
                break;
        }

        Console.WriteLine("Presione cualquier tecla para salir.");
        Console.ReadKey();
    }
}