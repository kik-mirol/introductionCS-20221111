// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
//29.Подсчитать сумму цифр в числе. Сделать подпрограмму.
int a = int.Parse(Console.ReadLine());
            int s = 0;
            while (a > 0)
            {
 
                s = s + a % 10;
                a = a /10 ;
 
            }
 Console.WriteLine(s);