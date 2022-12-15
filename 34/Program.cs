// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
int[] array = new int[12];
Random rand = new Random();
for (int i = 0; i < array.Length; i++)
{
    array[i] = rand.Next(-9,9);
}
int plus = 0; 
int minus = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i] > 0) plus +=array[i];
    if (array[i] < 0) minus +=array[i];
}
Console.WriteLine(string.Join ("  ", array));
Console.WriteLine($"{minus},{plus}",minus,plus);



