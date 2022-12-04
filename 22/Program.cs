// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
//22.Программа проверяет пятизначное  на палиндромом.
System.Console.WriteLine("введите 1-ую цифру числa:");
int a=Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("введите 2-ую цифру числа:");
int b=Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("введите 3-ую цифру числа:");
int c=Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("введите 4-ую цифру числа:");
int d=Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("введите 5-ую цифру числа:");
int e=Convert.ToInt32(Console.ReadLine());

if (a==e && b==d) System.Console.WriteLine("YES");else System.Console.WriteLine("NO");