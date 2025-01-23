// See https://aka.ms/new-console-template for more information

//Declare fixed size array
int[] grades = new int[5];
//5 space addresses 0,1,2,3,4
//Add values to fixed size arrays
grades[0] = 1;
grades[1] = 25;
grades[2] = 38;
grades[0] = 45;
grades[4] = 54;

grades = new int[] { 1, 25, 38, 45, 54 };

for (int i = 0; i< grades.Length; i++)
{
    Console.WriteLine("Enter Grade: ");
    grades[i] = Convert.ToInt32(Console.ReadLine());
}
//print values in fixed size array
Console.WriteLine("The grades you have entered are: ");
for (int i = 0; i < grades.Length; i++)
{
    Console.WriteLine(grades[i]);
}


//Declare vbariable sized array
string[] finalGrades = new string[] {"test", "Student", "etc"};
//Add values to variabke sized arrays
//print values in variable sized array.