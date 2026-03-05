Console.WriteLine("Ingrese los número que quiera");
Console.WriteLine();
Console.WriteLine("Presione 0 para mostar:");
Console.WriteLine();
Console.WriteLine("- La suma total de los números");
Console.WriteLine("- Cuántos números se ingresaron");
Console.WriteLine("- El promedio de los número ingresados");
Console.WriteLine();
int numero = -1;
int suma = 0;
int contador = 0;
do
{
    Console.WriteLine("Ingrese un número: ");
    Console.WriteLine();
    numero=int.Parse(Console.ReadLine());
    Console.WriteLine();
    suma += numero;
    contador++;
} while (numero != 0);
Console.WriteLine($"La suma total de los números es {suma}");
Console.WriteLine();
Console.WriteLine($"La cantidad total de números ingresados son {contador-1}");
Console.WriteLine("");
Console.WriteLine($"El promedio de los números ingresador es {suma/(contador-1)}");