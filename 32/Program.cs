// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
//32.Задать массив из 8 целых элементов и вывести их на экран
int[] array = new int[8];
Random rand = new Random();
for (int i = 0; i < array.Length; i++)
{
    array[i] = rand.Next(-100,100);
}
Console.WriteLine(string.Join ("  ", array));
