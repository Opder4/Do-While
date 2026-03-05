int numero = -1;
int numero2 = 0;
do
{
    Console.WriteLine();
    Console.WriteLine("Ingrese un número positivo: ");
    Console.WriteLine();
    numero=int.Parse(Console.ReadLine());
    Console.WriteLine();
    numero2 = numero;
    if (numero2 == 0)
    {
        Console.WriteLine("El número 0 no es positivo ni negativo");
    }
} while (numero <= 0);
    Console.WriteLine("Gracias por ingresar un número positivo");
