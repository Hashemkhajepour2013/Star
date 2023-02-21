// See https://aka.ms/new-console-template for more information

using System.Threading.Channels;

Console.WriteLine("hello world ...");
string star = "*";
for (int i = 15; i > 0 ; i--)
{
    for (int k = 15; k > i+1; k--)
    {
        Console.Write(" ");
        k--;
    }
    for (int j = 1; j <= i; j++)
    {
        Console.Write("*");
    }

    i--;
    Console.WriteLine();
}

for (int i = 0; i < 15; i++)
{
    for (int k = 0; k < 15-(i+1); k++)
    {
        Console.Write(" ");
        k++;
    }
    for (int j = 0; j <= i; j++)
    {
        Console.Write("*");
    }

    i++;
    Console.WriteLine();
}
Console.ReadKey();