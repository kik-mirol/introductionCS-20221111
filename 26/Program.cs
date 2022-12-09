// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
//26.Найти сумму чисел от 1 до А
System.Console.Write("Введите число A: ");
int A = Convert.ToInt32(Console.ReadLine());

int GetNumbersSum(int A)
{
    int sum = 0;
    int count = 0;
    for (count = 0; count < A+2; count++)
    {
        int result = sum + count;
        sum = result;
        count++;
    }
    return sum;
}

int NumbersSum = GetNumbersSum(A);
System.Console.WriteLine($"Сумма чисел от 1 до {A} = {NumbersSum}");