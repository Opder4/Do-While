Console.WriteLine("Ingrese un número para mostar su tabla de multiplicar: ");
Console.WriteLine();
int numero=int.Parse(Console.ReadLine());
Console.WriteLine();
int rangotabla = 1;
do
{
    Console.WriteLine($"{numero} X {rangotabla} = {numero*rangotabla}");
    rangotabla++;
} while (rangotabla <= 10);