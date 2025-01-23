// See https://aka.ms/new-console-template for more information

//Create a DateTime from date and time
using System.Globalization;

//empty DateTime
DateTime date = new DateTime();

//Create a DateTime from a date and time
DateTime dateOfBirth = new DateTime(1980, 12, 31);
Console.WriteLine("My Dob is : " + dateOfBirth);
Console.WriteLine("My Dob is : " + dateOfBirth.Date);

Console.WriteLine("Day of the week {0}", dateOfBirth.DayOfWeek);
Console.WriteLine("Day of the Year: {0}", dateOfBirth.DayOfYear);
Console.WriteLine("Time of day:{0}", dateOfBirth.TimeOfDay);
Console.WriteLine("Tick:{0}", dateOfBirth.Ticks);
Console.WriteLine("Kind:{0}", dateOfBirth.Kind);


//Create a DateTime from current timestamp
DateTime now = DateTime.Now;
Console.WriteLine("the time is currently : " + now);

//Create a DateTime from a string
DateTime dateFromString = DateTime.Parse("1/31/2021", CultureInfo.InvariantCulture);
Console.WriteLine("The date from string is " + dateFromString);

//Add additional time
Console.WriteLine("One hour from now is: " + now.AddHours(1));
Console.WriteLine("One hour from now is: " + now.AddDays(1));


// ticks from date time
Console.WriteLine("Time as a numeral: " + now.Ticks);
//Date only
DateOnly dateOnlyOfBirth = DateOnly.FromDateTime(dateOfBirth);
Console.WriteLine("Date Only: " + dateOnlyOfBirth);

//time only
TimeOnly timeOnlyOfBirth = TimeOnly.FromDateTime(dateOfBirth);

/*
dateOfBirth.DayOfYear
*/