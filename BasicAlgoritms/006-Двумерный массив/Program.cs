// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
//Ввод-вывод двумерного массива, поиск в двумерном массиве, сортировка двумерного массива

int[,] a=new int[3,4];
//int[,] a1= {{1,2,3,4},{1,2,3,4},{1,2,3,4}};
//int[,] a1= new int[3,4] {{1,2,3,4},{1,2,3,4},{1,2,3,4}};
Random random=new Random();
for (int i=0;i<3;i++)
     for(int j=0;j<4;j++)
       a[i,j]=random.Next(0,10);

for(int i=0;i<3;i++)
{
     for(int j=0;j<4;j++)
        System.Console.WriteLine($"{a[i,j],4}");
    System.Console.WriteLine();
}
