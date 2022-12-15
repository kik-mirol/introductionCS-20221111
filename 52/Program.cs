// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
//52.Написать программу преобразования десятичного числа в двоичное
string DecimalToBin(int n)
{
    string s="";
    if (n==0) return "0";
    while(n!=0)
    {
        s=Convert.ToString(n%2)+s;
        n/=2;
    }
    return s;
}
System.Console.WriteLine();
System.Console.WriteLine(DecimalToBin(7));