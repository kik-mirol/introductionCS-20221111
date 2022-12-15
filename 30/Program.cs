// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
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
    int prod = 1;
    int count = 1;
    while(count <= a)
    {
        int result = prod * count;
        prod = result;
        count++;
    }
    return prod;
}
int NumberSum = GetNumbersSum(mas);
System.Console.WriteLine($"произведение чисел от 1 до {a} = {NumberSum}");
FillArray(mas);
