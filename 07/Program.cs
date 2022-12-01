// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
//7.Выяснить является ли число чётным.
System.Console.WriteLine("введите число:");
int a=Convert.ToInt32(Console.ReadLine());
if ((a % 2) == 0)
{
    Console.WriteLine("чётное");
}
else
{
    Console.WriteLine("нечётное");
}