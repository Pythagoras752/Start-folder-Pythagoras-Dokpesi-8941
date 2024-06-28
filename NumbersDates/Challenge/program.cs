
                               // Pythagoras Dokpesi BU/23C/IT/8941


using System;

while (true)
{
    Console.Write("Enter a date (dd/mm/yyyy) or type 'exit' to quit: ");
    string input = Console.ReadLine();

    if (input.ToLower() == "exit")
    {
        Console.WriteLine("Goodbye!");
        break;
    }

    if (DateTime.TryParse(input, out DateTime userDate))
    {
        
        DateTime currentDate = DateTime.Today;

        if (userDate < currentDate)
        {
            TimeSpan daysPassed = currentDate - userDate;
            Console.WriteLine($"Days passed since {userDate.ToShortDateString()}: is {daysPassed.Days} days");
        }
        else if (userDate > currentDate)
        {
            TimeSpan daysRemaining = userDate - currentDate;
            Console.WriteLine($"Days remaining until {userDate.ToShortDateString()}: will be {daysRemaining.Days} days");
        }
        else
        {
            Console.WriteLine("Today is the same as the entered date!");
        }
    }
    else
    {
        Console.WriteLine("Invalid date format. Please enter a valid date (MM/dd/yyyy).");
    }
}