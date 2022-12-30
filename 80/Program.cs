// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
//80.
int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
for (int i = a; i <= b; i++)
    Console.WriteLine(i.ToString() + "-й символ таблицы ASCII: " + (char)i);
Console.ReadKey();