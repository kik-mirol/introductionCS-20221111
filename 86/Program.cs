// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
//86.
class Program
{
    static void Main(string[] args)
    {
        string str = Console.ReadLine();
        Console.WriteLine("Введите символ:");
        string s = Console.ReadLine();
        int count = str.ToCharArray().Where(c => c == s[0]).Count();
        Console.WriteLine(count);
        Console.ReadKey();
 
 
    }
}