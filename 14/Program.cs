// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
//14.С клавиатуры вводятся два числа a и b. Выяснить, кратно ли число a числу b, если нет, вывести остаток от деления a на b.
System.Console.WriteLine("введите число a:");
int a=Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("введите число b:");
int b=Convert.ToInt32(Console.ReadLine());
if (a>=b)
{
if((a % b) == 0)
{
    System.Console.WriteLine($"число {a} кратно числу {b}");
}
else
{
    int c= a % b;
    System.Console.WriteLine($"число {a} не кратно числу {b} и остаток = {c}");
}
}
else
{
    System.Console.WriteLine($"число {a} не кратно числу {b},остатка нет");
}