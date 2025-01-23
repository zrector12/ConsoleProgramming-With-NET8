// See https://aka.ms/new-console-template for more information
string firstName = "Zach";
string lastName = "Rec";
DateTime date = DateTime.Now;

//Print to screen
Console.WriteLine(firstName);
Console.WriteLine("String being printed");
//Concat
Console.WriteLine(firstName + " " + lastName);
Console.WriteLine("My full name is " + lastName + " "+ firstName);
Console.WriteLine($"My full name is {firstName},{lastName}");
Console.WriteLine("My full name is {0}, {1}", lastName, firstName);

//String Length
int length = firstName.Length;
Console.WriteLine($"Your name is {length} letters long");

//Replace string parts
string newName = firstName.Replace('T', 'K');
Console.WriteLine($"Your new name is {newName}");
//Append to other string
string fullName = firstName + lastName;
Console.WriteLine($"Your full name is: {fullName}");
//Split string
string[] splitName = fullName.Split('v');
for(int i = 0; i < splitName.Length; i++)
{
    Console.WriteLine(splitName[i]);
}

string nullString = null;
string empty = "";
string space = "";

//Compare Strings
if (string.IsNullOrEmpty(nullString))
{
    //write string is null
}
if (firstName == lastName)
{
    Console.WriteLine("names are equal");
}
if(firstName != lastName)
{
    Console.WriteLine("not equal");
}

int comparisonResult = string.Compare(firstName, lastName);
//Convert to string
string convertedString = string.Empty;
int number = 123456;

convertedString = number.ToString();
convertedString = 14624242.ToString();

fullName.ToUpper();
fullName.ToLower();

