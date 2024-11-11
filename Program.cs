// See https://aka.ms/new-console-template for more information
string testing = "Testing testing";
Console.WriteLine(testing);

bool isEnabled = false;

if (isEnabled)
{
    Console.WriteLine("Boolean is true");
}

int count = 0;
while (count < 10)
{
    Console.WriteLine("Count: " + count);
    count++;
}

Console.WriteLine("old breadfoot!");

Person skrotnisse = new Person("Skrotnisse", "Rotehue");

Console.WriteLine("The persons first name is: " + skrotnisse.firstName);
Console.WriteLine("The persons last name is: " + skrotnisse.lastName);

int numbersOfPlayers = 0;
while (numbersOfPlayers < 6)
{
    Person person = new Person("Player", "Annon" + numbersOfPlayers);
    Console.WriteLine("Player: " + person.lastName);
    numbersOfPlayers++;
}