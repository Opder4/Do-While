int numero = -1;
int contador = 0;
Console.WriteLine("Ingrese los números que quiera e ingrese 0 para mostrar la cantidad de números");
Console.WriteLine();
do
{
    Console.WriteLine($"Ingrese un número");
    Console.WriteLine();
    numero = int.Parse(Console.ReadLine());
    Console.WriteLine();
    contador++;
} while (numero != 0);
Console.WriteLine($"la cantidad total de números ingresados son {contador}");

