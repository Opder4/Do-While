int cantidadnumero = 1;
int numero = 0;
int suma = 0;
do
{
    Console.WriteLine($"Ingrese el {cantidadnumero}° número: ");
    Console.WriteLine();
    numero=int.Parse( Console.ReadLine() );
    Console.WriteLine();
    suma += numero;
    cantidadnumero++;
} while (cantidadnumero <= 5);
Console.WriteLine($"la suma es {suma}");