// See https://aka.ms/new-console-template for more information

/*
 * try - a block attempts an operation
 * catch - catch any fatal error or exception
 * finally - weather the try or catch was successful
 * throw - end the program execution with the error.
  */

Console.WriteLine("Enter first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());

//input 0 for error
Console.WriteLine("Enter second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());

    try
{
    int quotient = num1 / num2;
    Console.WriteLine("Result is: " + quotient.ToString());
}
catch (DivideByZeroException ex)
{
    Console.WriteLine($"illegal operation:  {ex.Message}");
}
catch (Exception ex)
{
    throw ex;
}


