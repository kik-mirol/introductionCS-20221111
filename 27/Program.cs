// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
//27.Возведите число А в натуральную степень B используя цикл
 
int core = Convert.ToInt32(Console.ReadLine());
int degree = Convert.ToInt32(Console.ReadLine());
int count = 1;
int result = core;
while (count < degree)
{
    result = result * core;
    count++;
}

System.Console.WriteLine($"{core} ^ {degree} = {result}");



