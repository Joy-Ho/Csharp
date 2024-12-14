using test3.Extensions;

var list = new List<int> { 1, 5, 10, 8, 12, 4, 5, 6 };
var result = list.TakeEverySecond();
foreach(var item in result)
{
    Console.WriteLine(item);
}


public enum Season
{
    Spring,
    Summer,
    Autumn,
    Winter

}