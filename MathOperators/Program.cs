// See https://aka.ms/new-console-template for more information

//Basic Assignment
int num = 5;
num = 5;

//Arithmetic operators
int num1 = 11;
int num2 = 12;

Console.WriteLine($"Addition:  {num1 + num2}");
Console.WriteLine($"Subtraction:  {num1 - num2}");
Console.WriteLine($"Multiplication:  {num1 * num2}");
Console.WriteLine($"Division:  {num1 / num2}");
Console.WriteLine($"Modulus:  {num1 % num2}");

num1 = num1 + 4;
//new values
Console.WriteLine($"Addition:  {num1 + num2}");
Console.WriteLine($"Subtraction:  {num1 - num2}");
Console.WriteLine($"Multiplication:  {num1 * num2}");
Console.WriteLine($"Division:  {num1 / num2}");
Console.WriteLine($"Modulus:  {num1 % num2}");

//Compound assignment operators
//Actually changing value.
num1 += 4; //19
num1 -= 4; //15
num1 *= 4; //60
num1 /= 4; //15
num1 %= 4; //3
