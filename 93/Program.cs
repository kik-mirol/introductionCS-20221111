// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
//93.
Console.Write("Введите количество строк 1 массива: ");
            int linesA = int.Parse(Console.ReadLine());
            Console.Write("Введите количество столбцов 1 массива: ");
    int columnsA = int.Parse(Console.ReadLine());
    Console.Write("Введите количество строк 2 массива: ");
          int linesB = int.Parse(Console.ReadLine());
    Console.Write("Введите количество столбцов 2 массива: ");
    int columnsB = int.Parse(Console.ReadLine());
if (columnsA != linesB)
{
  Console.WriteLine("умножить нельзя");
  return;
}
    int[,] A = GetArray(linesA, columnsA, 0, 10);
    int[,] B = GetArray(linesB, columnsB, 0, 10);
    PrintArray(A);
    Console.WriteLine();
    PrintArray(B);
    Console.WriteLine();
    PrintArray(GetMultiplicationMatrix(A,B));

    int[,] GetArray(int m, int n, int min, int max)
    {
      int[,] result = new int[m, n];
      for (int i = 0; i < m; i++)
      {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(min, max + 1);
        }
      }
      return result;
    }

    void PrintArray(int[,] newArray)
    {
        for (int i = 0; i < newArray.GetLength(0); i++)
        {
            for (int j = 0; j < newArray.GetLength(1); j++)
            {
                Console.Write($"{newArray[i, j]} ");
            }
            Console.WriteLine();
        }
    }

    int [,] GetMultiplicationMatrix(int[,] arrayA, int[,] arrayB)
    {
        int[,] arrayC = new int[arrayA.GetLength(0), arrayB.GetLength(1)];
        for (int i = 0; i < arrayA.GetLength(0); i++)
        {
            for (int j = 0; j < arrayB.GetLength(1); j++)
            {
                for (int k = 0; k < arrayA.GetLength(1); k++)
                {
                    arrayC[i, j] += arrayA[i, k] * arrayB[k, j];
                }
            }
        }
        return arrayC;
    }