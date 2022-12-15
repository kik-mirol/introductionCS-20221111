// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
//50.
void Main()
{
    Console.WriteLine("Введите 1 сторону");
    int a = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите 2 сторону");
    int b = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите 3 сторону");
    int c = Convert.ToInt32(Console.ReadLine());
    if ((a<=0 || b<=0 || c<=0) || (a+b<=c || a+c<=b || c+b<=a))
    {
        Console.WriteLine("Такой треугольник не сущ.");
        Console.ReadKey();
        return;
    }
Console.Write("Треугольник существует");
int max=Math.Max(Math.Max(a, b), c);
if (max == a)
{
    a = b;
    b = c;
}
else
if (max == b)
{
    b = c;
}
Console.WriteLine($": прямоугольный ",Math.Pow(max,2)==Math.Pow(a,2)+Math.Pow(b,2));
Console.ReadKey();
}
Main();
