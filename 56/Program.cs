// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
//56.
using System;
 public class Example
{
    public static void Main()
    {
        int[] arr = { 5, 4, 7, 2, 9 };
 
        int[] copy = new int[arr.Length];
        arr.CopyTo(copy, 0);
 
        Console.WriteLine(String.Join(", ", copy));     
    }  
}