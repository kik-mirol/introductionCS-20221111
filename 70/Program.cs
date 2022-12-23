// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
//70
namespace ConsoleApplication17
{
    class Program
    {
        static string lne(int n)
        {
            if (n == 1)
                return "1";
            else
                return lne(n - 1) + n;
        }
        static void Main(string[] args)
        {
           
            Console.WriteLine(lne(7));
 
        }
    }
}