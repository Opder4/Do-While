int numero = -1;
int suma = 0;
int ordinales = 1;
Console.WriteLine("Ingrese los números que quiera sumar e ingrese 0 para mostrar la suma final");
Console.WriteLine();
do
{
    Console.WriteLine($"Ingrese el {ordinales}° número");
    Console.WriteLine();
    numero=int.Parse( Console.ReadLine() );
    Console.WriteLine();
    suma += numero;
    ordinales++;
} while (numero != 0);
Console.WriteLine($"la suma total es {suma}");
