// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
//84.
class Program
{ 
    static void Main(string[] args) 
    {
            string num = Console.ReadLine();
            int temp = 0;
            if (!Int32.TryParse(num, out temp))
                Console.WriteLine("Это не является верной записью целого числа");
            else 
            {
                int sum = 0;
                foreach (char digit in num)
                    sum += digit - 48;
                Console.WriteLine(sum);
            }
    }
}