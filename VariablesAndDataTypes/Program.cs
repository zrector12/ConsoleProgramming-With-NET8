// See https://aka.ms/new-console-template for more information

//Variable Declarations and types
string fullName = string.Empty;
int age = 0;
//float salary = 0.0f;
//decimal salary = 0.0M;
double salary = 0.0;
char gender = char.MinValue;
bool working = false;

//prompt user for input
Console.Write("Please enter your name: ");
fullName = Console.ReadLine();

Console.Write("Please enter your age: ");
age = Convert.ToInt32(Console.ReadLine());

Console.Write("Please enter your salary: ");
salary = Convert.ToDouble(Console.ReadLine());

Console.Write("Pleas enter your gender (M or F): ");
gender = Convert.ToChar(Console.ReadLine());

Console.Write("Are you working?: ");
working = Convert.ToBoolean(Console.ReadLine());

//Print info
Console.WriteLine("Your name is: " + fullName);//concatenation
Console.WriteLine("Your age is: {0} " , age);
Console.WriteLine($"Your Salary is: {salary}");//interpolation
Console.WriteLine($"Your Gender is {gender}");
Console.WriteLine($"You are employed: {working}");


