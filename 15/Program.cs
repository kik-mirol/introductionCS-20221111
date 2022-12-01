// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
//15.С клавиатуры вводится целое число. Вывести третью цифру числа или сообщить, что её нет (Вывести: NO).
Console.WriteLine("Введите число: ");
int a= Convert.ToInt32(Console.ReadLine());
if(a > 99 && a < 1000)
{
    System.Console.WriteLine(a % 10);
}
else if (a > 999 && a < 10000)
{
    System.Console.WriteLine(a % 1000 / 10 % 10);
}
else if(a > 9999 && a < 100000)
{
    System.Console.WriteLine((a % 1000) / 100);
}
else
{
    System.Console.WriteLine("NO");
}
    
