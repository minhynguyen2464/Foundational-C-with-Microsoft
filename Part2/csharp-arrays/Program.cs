using System;
internal class Program
{
    private static void Main(string[] args)
    {
        string[] orderID = { "B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179" };
        Console.WriteLine("The name starts with 'B'!");
        foreach (string order in orderID)
        {
            if (order.StartsWith("B"))
            {
                System.Console.WriteLine(order);
            }
        }
    }
}