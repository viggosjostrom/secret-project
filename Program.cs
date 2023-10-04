// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.WriteLine("Hej hej igen");


Console.Write("Skriv din ålder: ");
int num = int.Parse(Console.ReadLine());

Console.Write("Skriv ditt namn: ");
string? name = Console.ReadLine();



for (int i = 0; i < name.Length; i++)
{
    Console.WriteLine($"Hej {name}! Du är välkommen! Och du är {num} gammal!");
}