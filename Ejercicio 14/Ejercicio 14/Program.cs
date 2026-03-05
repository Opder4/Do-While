double numero = -1;
double numeromayor = double.MinValue;
Console.WriteLine("Ingrese los números que quiera e ingrese 0 para mostrar la suma final");
Console.WriteLine();
do
{
    Console.WriteLine($"Ingrese un número");
    Console.WriteLine();
    numero = double.Parse(Console.ReadLine());
    Console.WriteLine();
    if (numeromayor<numero)
    {
        numeromayor = numero;
    }
} while (numero != 0);
Console.WriteLine($"El número mayor fue {numeromayor}");

