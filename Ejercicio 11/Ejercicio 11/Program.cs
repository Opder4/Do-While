int cantidadnumero = 1;
double numero = 0;
double suma = 0;
do
{
    Console.WriteLine($"Ingrese el {cantidadnumero}° número: ");
    Console.WriteLine();
    numero=double.Parse( Console.ReadLine() );
    Console.WriteLine();
    suma += numero;
    cantidadnumero++;
} while (cantidadnumero <= 5);
Console.WriteLine($"la suma es {suma}");