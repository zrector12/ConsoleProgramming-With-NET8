// See https://aka.ms/new-console-template for more information

Console.WriteLine("Enter apples");
int numberOfApples = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter oranges");
int numberOfOranges = Convert.ToInt32(Console.ReadLine());
//if statements (==, <, >, >=, <=, !=) 
if (numberOfApples > numberOfOranges)
{
    Console.WriteLine("You have more apples");
}
else if(numberOfOranges < numberOfApples)
{
    Console.WriteLine("You have more oranges"); 
}
else if (numberOfApples == numberOfOranges)
{

}
else
{
    Console.WriteLine("No direct action");
}

Console.WriteLine("Enter final grade");
int grade = Convert.ToInt32(Console.ReadLine());
//switch statement
switch (grade)
{
    case int n when (n >= 0 && n<=60):
        Console.WriteLine("You failed");
        break;
    case int n when (n>=60 && n<=100):
        Console.WriteLine("You passed");
        break;
    case 101:
        Console.WriteLine("Single case example");
        break;
    default:
        Console.WriteLine("Invalid Grade");
        break;
}

//Ternary
var message = numberOfApples > numberOfOranges ? "You have more apples" : "you have more oranges";
Console.WriteLine(message);