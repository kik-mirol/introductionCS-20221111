﻿// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
//25.Вывести на экран кубы чисел от 1 до N

int n = Convert.ToInt32(Console.ReadLine());
int[] mas = new int[n];
void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 1;
    while (index < length)
    {
        collection[index] = index * index * index;
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