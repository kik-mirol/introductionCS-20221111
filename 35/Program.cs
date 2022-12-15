// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
//35.Написать программу замены элементов массива на противоположные
int[] array = new int[10];
Random rand = new Random();
for (int i = 0; i < array.Length; i++)
{
    array[i] = rand.Next(-100,100);
}
Console.WriteLine(string.Join ("  ", array));
for (int count = 0; count < array.Length; count++)
{
    array[count] = array[count] * (-1);
}
Console.WriteLine(string.Join ("  ", array));