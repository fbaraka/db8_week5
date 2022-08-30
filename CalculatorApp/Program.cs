using CalculatorApp;

Console.WriteLine("Welcome to the Calculator!");
Console.WriteLine("1. Factorial");
Console.WriteLine("2. Factors");
Console.Write("Which would you ike to do?");
string userChoice = (Console.ReadLine());

Console.Write("Great! What number? ");
int userNumber = int.Parse(Console.ReadLine());

Calculator calc = new Calculator(userNumber);

if (userChoice == "1")
{
    int factorial = calc.FindFactorial();
    Console.WriteLine($"The factorial of {userNumber} is {factorial}");
}
else if (userChoice == "2")
{
    Console.WriteLine("Under construction! Coming soon!");
    Console.WriteLine($"The factors of {userNumber} are ... Don't know yet!");
}


