// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
//9.Вывести на экран четные числа от 1 до N
System.Console.WriteLine("введите число N:");
int N=Convert.ToInt32(Console.ReadLine());
int i=2;
while(i<N+1)
{
    System.Console.WriteLine($"{i} ");i=i+2;
}