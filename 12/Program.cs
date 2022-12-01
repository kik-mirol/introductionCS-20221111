// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
//12.С клавиатуры вводится целое число из  диапазона  [10, 99]. Показать наибольшую цифру числа
System.Console.WriteLine("введите число от 10 до 99 включительно:");
int a=Convert.ToInt32(Console.ReadLine());
int c;
int b;
b=a % 10;
c=a / 10;
if (b>c)
{
    System.Console.WriteLine(b);
}
else
{
    System.Console.WriteLine(c);
}