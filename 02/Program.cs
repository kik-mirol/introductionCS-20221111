// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
//2.С клавиатуры вводятся два вещественных числа. Проверять является ли одно из них квадратом второго
System.Console.WriteLine("введите число a:");
double a=Convert.ToDouble(Console.ReadLine());
System.Console.WriteLine("введите число b:");
double b=Convert.ToDouble(Console.ReadLine());
if (a*a==b) System.Console.WriteLine($"{b} является квадратом {a}");
if (b*b==a) System.Console.WriteLine($"{a} является квадратом {b}");
/*
{
    //true
}
else
{
    //false
}
*/