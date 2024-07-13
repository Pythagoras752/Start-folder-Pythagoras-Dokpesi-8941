               // Pythagoras Dokpesi BU/23C/IT/8941

// Application Programming .NET Programming with C# by Abdullahi Tijjani
// Example file for formatting date information

// Define a date
using System.Globalization;

DateTime AprFools = new DateTime(2025, 4, 1, 13, 23, 30); 

// TODO: 'd' Short date: mm/dd/yyyy (or dd/mm depending on locale)
Console.WriteLine($"{AprFools:d}");

// TODO: 'D' Full date: mm/dd/yyyy (or dd/mm depending on locale)
Console.WriteLine($"{AprFools:D}");

// TODO: 'f' Full date, short time
Console.WriteLine($"{AprFools:f}");

// TODO: 'F' Full date, long time
Console.WriteLine($"{AprFools:F}");

// TODO: 'g' General date and short time
Console.WriteLine($"{AprFools:g}");

// TODO: 'G' General date and full time
Console.WriteLine($"{AprFools:G}");

// TODO: Format using a specific CultureInfo2
Console.WriteLine(AprFools.ToString("d", CultureInfo.CreateSpecificCulture("de-DE")));

// TODO: Defining custom date and time formats
Console.WriteLine($"{AprFools:dddd, MMMM, d yyyy}");
Console.WriteLine($"{AprFools:ddd, h:mm:ss tt}");
Console.WriteLine($"{AprFools:MMM, d yyyy}");
