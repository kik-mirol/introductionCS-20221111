// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
//5.С клавиатуры вводятся три числа. Найти максимальное из трех чисел
System.Console.WriteLine("введите число a:");
double a=Convert.ToDouble(Console.ReadLine());
System.Console.WriteLine("введите число b:");
double b=Convert.ToDouble(Console.ReadLine());
System.Console.WriteLine("введите число c:");
double c=Convert.ToDouble(Console.ReadLine());
double m;

if (a>b)
{
    m=a;
}
else
{
    m=b;
}
if (c>m) 
{
    m=c;
}
System.Console.WriteLine($"максимальное число {m}");

