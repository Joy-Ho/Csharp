int Add(int num1, int num2)
{
    return (num1 + num2);
}

Console.WriteLine("Add 2 numbers: ");
int num1 = Int32.Parse(Console.ReadLine());
int num2 = Int32.Parse(Console.ReadLine());

Console.WriteLine("Sum is " + Add(num1, num2));