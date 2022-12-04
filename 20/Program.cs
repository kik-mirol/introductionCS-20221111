// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
//20.Определить номер четверти плоскости, в которой находится точка с координатами Х и У, причем X ≠ 0 и Y ≠ 0
System.Console.WriteLine("введите число X:");
double X=Convert.ToDouble(Console.ReadLine());
System.Console.WriteLine("введите число Y:");
double Y=Convert.ToDouble(Console.ReadLine());
if (X>0 && Y>0) System.Console.WriteLine("1 четверть");
if (X<0 && Y>0) System.Console.WriteLine("2 четверть");
if (X<0 && Y<0) System.Console.WriteLine("3 четверть");
if (X>0 && Y<0) System.Console.WriteLine("4 четверть");