int opcion = -1;
do
{
    Console.WriteLine("Menú");
    Console.WriteLine();
    Console.WriteLine("1. Mostar Saludo");
    Console.WriteLine("2. Mostar un número aleatorio");
    Console.WriteLine("0. Salir");
    Console.WriteLine("");
    Console.WriteLine("Seleccione una opción");
    Console.WriteLine("");
    opcion=int.Parse(Console.ReadLine());
    Console.WriteLine("");
    switch (opcion)
    {
        case 1:
            Console.WriteLine("Hola");
            Console.ReadLine();
            Console.Clear();
            break;
        case 2:
            Console.WriteLine(Random.Shared.Next(1,1000000));
            Console.ReadLine();
            Console.Clear();
            break;
        case 0:
            Console.WriteLine("Finalizando programa...");
            break;
        default:
            Console.WriteLine("Opción inválida");
            Console.ReadLine();
            Console.Clear();
            break;
    }
} while (opcion != 0);
Console.WriteLine("Programa finalizado");