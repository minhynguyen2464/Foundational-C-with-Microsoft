/*
    Random coin = new Random();
    Console.WriteLine((coin.Next(0, 2) == 0) ? "heads" : "tails");
*/

string permission = "Admin|Manager";
int level = 60;

if (permission.Contains("Admin"))
{
    if (level <= 55)
    {
        System.Console.WriteLine("Welcome, Admin user.");
    }
    System.Console.WriteLine("Welcome, Super Admin user.");
}
else
{
    if (level >= 20)
    {
        System.Console.WriteLine("Contact an Admin for access.");
    }
    System.Console.WriteLine("You do not have sufficient privileges.");
}