using PigLatin;

Console.WriteLine("Pig Latin Translator!");
Console.WriteLine();
Console.Write("Enter a word: ");
string userInput = Console.ReadLine().ToLower();

if (userInput == "")
{
    Console.WriteLine("Sorry, please enter a real word.");
}
else
{
    Console.WriteLine(Translator.PigLatinize(userInput));
}

