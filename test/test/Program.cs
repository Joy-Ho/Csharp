Console.WriteLine("Enter the radius: ");
bool tranfer = double.TryParse(Console.ReadLine(), out double r);

double area = CalculateArea(r, out double circumference);
Console.WriteLine($"area is {area}, and circumference is {circumference}");

double CalculateArea(double radius, out double circumference)
{
    circumference = radius * 2 * Math.PI;
    return radius * radius * Math.PI;
}