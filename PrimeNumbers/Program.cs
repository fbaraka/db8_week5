using PrimeNumbers;

Console.WriteLine("Hello, Welcome to the Prime Finder");
Console.WriteLine("This application will find you any prime, in order, from first prime number on.");




do

{
Console.Write("Which prime number are you looking for? ");
int userNumber = Convert.ToInt32(Console.ReadLine());

    if (userNumber == 0)
    {
        Console.WriteLine("Zero is not prime.");
    }
    else if (userNumber == 1)
    {
        Console.WriteLine("The prime number of 1 is 1.");
    }
    else
    {
        Console.WriteLine($"The number {userNumber} prime is {PrimeNumberGenerator.GetPrime(userNumber)}");
    } 
} while (KeepGoing());


static bool KeepGoing()
{

    while (true)
    {
       
        Console.WriteLine("Would you like to keep going? (y/n)");
        // Ask the user for their input
        string response = Console.ReadLine();
        response = response.ToLower();

        if (response == "y" || response == "yes")
        {
            return true;
        }
        else if (response == "n" || response == "no")
        {
            return false;
        }
        else
        {
            Console.WriteLine("Please enter y or n");
        }
    }
}
