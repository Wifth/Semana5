// See https://aka.ms/new-console-template for more information

using System.Diagnostics.CodeAnalysis;

for (int x = 1; x <= 5; x = x + 1) 
{
    Console.WriteLine($"Hola {x}");
}

Console.WriteLine("\nFin\n");


for (int x = 4; x <= 16; x = x + 4)
{
    Console.Write($"{x} ");
}


string resp = "S";
double suma = 0, cant = 0;
while (resp == "s")
{
    Console.WriteLine("Desea participar? (S/N)");
    resp = Console.ReadLine().Trim().ToUpper();
    if (resp == "S")
    {
        Console.WriteLine("Ingrese su edad");
        int edad = Convert.ToInt32(Console.ReadLine());
        suma = suma + edad;
        cant = cant + 1;
    }
} 