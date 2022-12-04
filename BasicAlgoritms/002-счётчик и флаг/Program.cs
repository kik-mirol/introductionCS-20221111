// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

int n=int.Parse(Console.ReadLine());
int k=0;
bool flag=false;
for(int i=0;i<n;i++)
{
    int a=int.Parse(Console.ReadLine());
    if (a<5) k++;
    if (a==10) flag=true;
}
System.Console.WriteLine(k);
if (flag==true)
{
    System.Console.WriteLine("YES");
}
else 
{
    System.Console.WriteLine("NO");
}