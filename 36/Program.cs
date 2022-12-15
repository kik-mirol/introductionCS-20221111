// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
//36.
int[] mas = {13, 26, 63, 58, 85, 6, 77, 58, 29 };
 int n = mas.Length;
 int find = Convert.ToInt32(Console.ReadLine());
 int index = 0;
 while(index < n)
 {
    if (mas[index] == find)
    {
        System.Console.WriteLine(index);
        break;
    }
    index++;
 }