using System.Threading.Channels;

string contra = "";
do
{
    Console.WriteLine("Ingrese la contraseña: ");
    Console.WriteLine();
    contra=Console.ReadLine();
    Console.WriteLine();
} while (contra != "1234");
Console.WriteLine("Contraseña correcta");
Console.WriteLine();
Console.WriteLine("Puede ingresar");