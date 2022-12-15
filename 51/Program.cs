// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
//51.
int n = Convert.ToInt32(Console.ReadLine());
int count = 0;
int i;
for (i = 1;i < n+1;i++)
{
    int N = Convert.ToInt32(Console.ReadLine());
    if (N > 0) count++;
}
System.Console.WriteLine($"Количество положительных чисел = {count}");