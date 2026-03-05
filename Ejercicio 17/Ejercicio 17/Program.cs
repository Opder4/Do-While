int numeros = -1;
int contador = 0;
Console.WriteLine("Ingrese los números que quiera y presione 0 para ver cuantos son pares");
Console.WriteLine();
do
{
    Console.WriteLine("Ingrese un número: ");
    Console.WriteLine();
    numeros=int.Parse(Console.ReadLine());
    Console.WriteLine();
    if (numeros%2==0)
    {
        contador++;
    }

} while (numeros != 0);
Console.WriteLine($"La cantidad de números pares ingresados son {contador-1}");