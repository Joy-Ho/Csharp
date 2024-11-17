Console.WriteLine("Enter a word: ");
String word = Console.ReadLine();

if (word.Length < 5)
{
    Console.WriteLine(word + " is less than 5 characters.");
}
else if(word.Length < 11)
{
    Console.WriteLine(word + " is between 5 and 10 characters.");
}
else
{
    Console.WriteLine(word + " is larger than 10 characters.");
}
