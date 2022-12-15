// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
//54.
static void Main(string[] args)
{
    int input = Convert.ToInt32(Console.ReadLine());
    int first = 0, second = 1, third = 0;
    System.Console.WriteLine(first);
    System.Console.WriteLine(second);
    for (int i = 0; i < input-2; i++)
    {
        third = first + second;
        System.Console.WriteLine(third);
        first = second;
        second = third;
    }
}
System.Console.WriteLine("Введите количество чисел : ");
Main(args);
