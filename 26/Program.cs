// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
//26.Найти сумму чисел от 1 до А

System.Console.Write("Введите число a: ");
int a = Convert.ToInt32(Console.ReadLine());
int[] mas = new int[a];
void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 1;
    while (index < length)
    {
        collection[index] = index;
        index++;
    }
}
int GetNumbersSum(int[] collection)
{
    int sum = 0;
    int count = 1;
    while(count <= a)
    {
        int result = sum + count;
        sum = result;
        count++;
    }
    return sum;
}
int NumberSum = GetNumbersSum(mas);
System.Console.WriteLine($"Сумма чисел от 1 до {a} = {NumberSum}");
FillArray(mas);

