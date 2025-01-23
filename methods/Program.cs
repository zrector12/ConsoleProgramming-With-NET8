// See https://aka.ms/new-console-template for more information


//Prototype - Defines the functions (type, name a d parameters)
//Definition - Has the code. It contains the code block
//Function Call - Makes the function
//DRY - Don't repeat yourself
//YAGNI - You aren't going to need it

//void functions (complete a task and move along)
void PrintName()
{
    Console.WriteLine("Trevoir Williams");
}

void Addition(int num1,int num2)
{
    Console.WriteLine($"The sum of {num1} and {num2} is: {num1 + num2}");
}

//value returning functions (complete a task, returns a value.)
int largestNumber (int num1, int num2, int num3)
{
    int largest = num1;
    if (largest < num2)
    {
        largest = num2;
    }
    if (largest < num3){
        largest = num3;
    }
    return largest;
}

PrintName();
Console.WriteLine("END of void");

Console.WriteLine("Enter number 1: ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter number 2: ");
int number2 = Convert.ToInt32(Console.ReadLine());

Addition(number1,number2);
Console.WriteLine("END of void");


Console.WriteLine("Enter number 3: ");
int number3 = Convert.ToInt32(Console.ReadLine());

int result = largestNumber(number1, number2, number3);
Console.WriteLine($"largest number is: {result}");

Console.WriteLine($"Largest number is : {largestNumber(number1, number2, number3)}");






