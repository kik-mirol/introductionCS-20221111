// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
//13.Удалить вторую цифру целого числа введенного с клавиатуры.(сколько цифр в числе должно быть? и удалить нужно 2 с конца или просто 2 цифру в числе?)
int a=Convert.ToInt32(Console.ReadLine());
int b=a / 100 * 10+a % 10;
System.Console.WriteLine(b);
