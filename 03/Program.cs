// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
//3.С клавиатуры вводятся два числа a и b. Найти максимальное из них.
System.Console.WriteLine("введите число a:");
double a=Convert.ToDouble(Console.ReadLine());
System.Console.WriteLine("введите число b:");
double b=Convert.ToDouble(Console.ReadLine());
if (a>b)
{
    System.Console.WriteLine($"{a} является максимальным ");
}
if (b>a) 
{
    System.Console.WriteLine($"{b} является максимальным ");
}
else
{
    System.Console.WriteLine("числа одинаковы");
}