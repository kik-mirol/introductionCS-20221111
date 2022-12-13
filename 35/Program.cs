// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
//35.Написать программу замены элементов массива на противоположные
class Program
    {
        static void Main(string[] args)
        {
            int[] mass = new int[10];
            Random r = new Random();
            for (int i = 0; i<mass.Length;i++)
            {
                mass[i] = r.Next(1, 10);
                Console.Write(mass[i] *(-1) + " ");
            }
            Console.WriteLine();
        }
        Console.ReadKey());
    }