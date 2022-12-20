// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
//62.
Console.WriteLine("Задайте количество строк двумерного массива:");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Задайте количество столбцов двумерного массива:");
int n = Convert.ToInt32(Console.ReadLine());
double[,] a = new double[m, n];
Random random = new Random();

void PrintArray(double[,] arr)
{ 
    for (int i = 0; i < m; i++)
    { 
        for (int j = 0; j < n; j++)
        {
            Console.Write($"{arr[i, j]} ");
        }
        Console.WriteLine();
    }
}

void FillArray(double[,] arr)
{
    for (int i = 0; i < m; i++)
    { 
        for (int j = 0; j < n; j++)
        { 
            arr[i,j] = random.Next(-100, 100);
        }
    }
}




void ChangeArray(double[,] arr)
{ 
    for (int i = 0; i < m; i++)
    { 
        for (int j = 0; j < n; j++)
        {
            if(a[i,j] % 2==0) a[i,j]=-a[i,j];
            Console.Write($"{arr[i, j]} ");
        }
        Console.WriteLine();
    }
}

FillArray(a);

Console.WriteLine();

PrintArray(a);

ChangeArray(a);
