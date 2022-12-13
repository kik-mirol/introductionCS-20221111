// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
//32.Задать массив из 8 целых элементов и вывести их на экран
Console.WriteLine("Введите размер массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[n];
Console.WriteLine($"массив: ",numbers);