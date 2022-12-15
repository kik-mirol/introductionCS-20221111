// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
//24.Вывести на экран таблицу квадратов чисел от 1 до N

/*
int Tablesq(int NumberDigits,)
{
     int n=(int)Math.Pow(a,2);
     int a=1;
     while (a<NumberDigits+1)
     {
           a++;
     }
    return n;
}




int NumberDigits=Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine(Tablesq(NumberDigits));
*/
/*


object tablesq(double N,double sq)
{
     for (int i=1;i<N+1;i++)
     {
          sq=i*i;
     }
     return tablesq;
}
double N=Convert.ToDouble(Console.ReadLine());
System.Console.Write($"{N}"," ");
System.Console.WriteLine(tablesq);
*/
int n = Convert.ToInt32(Console.ReadLine());
int[] mas = new int[n];
void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 1;
    while (index < length)
    {
        collection[index] = index * index;
        index++;
    }
}
void PrintArray(int[] col)
{
    int count = col.Length;
    int pos = 1;
    while(pos < count)
    {
        System.Console.WriteLine(col[pos]);
        pos++;
    }
}



FillArray(mas);
PrintArray(mas);