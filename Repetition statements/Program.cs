// See https://aka.ms/new-console-template for more information

//For loop (counter controlled)
for (int i = 0; i < 10; i++)
{
    Console.WriteLine("I am in a loop");
    Console.WriteLine($"Counter value : {i}");
}

Console.WriteLine();
Console.WriteLine("FOR LOOP FINISHED");

//While loop (Condition controlled)
int n = 0;
while (n < 5)
{
    Console.WriteLine("Input a number : ");
    n = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($"You entered {n}");
}

Console.WriteLine();
Console.WriteLine("WHILE LOOP FINISHED");

//Do ... while loop (Condition Controlled - Post Check)
n = 0;
do
{
    Console.WriteLine("input a number : ");
    n = Convert.ToInt32(Console.ReadLine());

}while (n < 5);

//For each
