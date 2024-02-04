// See https://aka.ms/new-console-template for more information
using System.Runtime.InteropServices;

Console.WriteLine("Enter the year");
string yearString = Console.ReadLine();

if (!int.TryParse(yearString, out int year ) || year<0)
{
    Console.WriteLine("You entered not number or empty string or it was negative number");
    return;
}

if (year % 4 == 0 && year % 100 != 0 || year % 400 == 0)
{
    Console.WriteLine("YES");
}
else
{
    Console.WriteLine("NO");
}
