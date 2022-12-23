// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
//75.
Console.Write("Введите число M: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());

AkkermanFunction(m, n);

void AkkermanFunction (int m, int n)
{
    Console.Write (Akkerman (m, n)); 
}

int Akkerman(int m, int n)
{
    if (m == 0)
    {
        n++;
    }
    else if (n == 0 && m > 0)
    {
        return  (m - 1, 1);
    }
    else
    {
        return (Akkerman(m - 1, Akkerman(m, n - 1)));
    }
}