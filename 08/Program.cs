// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
//8.Вывести на экран числа от -N до N
System.Console.WriteLine("введите число N:");
int N=Convert.ToInt32(Console.ReadLine());
int b;
b=0-N;
int count=b;
while(count<N+1)
{
    System.Console.WriteLine(count);count++;
}