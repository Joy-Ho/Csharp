Console.WriteLine("Hello");
Console.WriteLine("Input the first number: ");

var number1 = int.Parse(Console.ReadLine());

Console.WriteLine("Input the second number: ");
var number2 = int.Parse(Console.ReadLine());

Console.WriteLine("What do you want to do with those numbers?");
Console.WriteLine("[A]dd");
Console.WriteLine("[S]ubtract");
Console.WriteLine("[M]ultiply");

var option = Console.ReadLine();

switch (option)
{
    case "A":
    case "a":
        Console.WriteLine(number1 + " + " + number2 + " = " + (number1+number2));
        break;

    case "S":
    case "s":
        Console.WriteLine(number1 + " - " + number2 + " = " + (number1 - number2));
        break;

    case "M":
    case "m":
        Console.WriteLine(number1 + " * " + number2 + " = " + (number1 * number2));
        break;

    default:
        Console.WriteLine("Invalid option");
        break;

}
