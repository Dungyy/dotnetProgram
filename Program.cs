// See https://aka.ms/new-console-template for more information

// Terminal title
Console.Title = "Dungy bot";
// Terminal Text color
Console.ForegroundColor = ConsoleColor.Green;

double num1;
double num2;

Console.WriteLine("Hello, whats your name?");
string userName = Console.ReadLine();

Console.WriteLine("Hello " + userName + " It's nice to meet you!");
Console.WriteLine(userName + " Give me an number from 0-100");

num1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine(num1 + " ok cool, and another number?");

num2 = Convert.ToDouble(Console.ReadLine());

double result = num1 * num2;

Console.WriteLine("So does " + num1 + "x" + num2 + " = " + result + "?");

// wait to close terminal
Console.ReadKey();
