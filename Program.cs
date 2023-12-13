using System;
class Program
{
    static void Main(string[] args)
    {
    string[] array1 = {"Hola, Amigo", "Espanola", "RIO", "R&B", "OG Michael"};
    string[] result = new string[array1.Length];
    int count = 0;

    foreach (string s in array1)
    {
        if(s.Length <= 3)
        {

            result[count] = s;
            count++;
        }
    }
    Array.Resize(ref result, count);

    foreach (string s in result)
    {
        Console.WriteLine(s);
    }
    }
}