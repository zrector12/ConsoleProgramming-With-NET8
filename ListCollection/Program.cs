// See https://aka.ms/new-console-template for more information

//Declare list
List<String> names = new List<string>();
string name = "";
//add values to list
names[0] = "TestName";
names.Add("z");
names.Remove("z");

Console.WriteLine("Enter names: ");
//while (name != "-1")
//while (name.Equals("-1") == false)

while (names.Equals("-1"))
{
    Console.WriteLine("Enter name: ");
    name = Console.ReadLine();
    if (!string.IsNullOrEmpty(name) && !name.Equals("-1"))
    {
        names.Add(name);
        Console.WriteLine(($"{name} + was added successfully"));
    }
}

//print values in a list
Console.WriteLine("Printing names via for loop");
for (int i = 0; i < names.Count; i++)
{
    Console.WriteLine(names[i]);
}


Console.WriteLine("Printing names via forEach loop");
foreach(string item in names)
{
    Console.WriteLine(item);
}


