Random random = new Random();
var RollDiceResult = random.Next(1, 7);


class Dice
{
    private const int diceSide = 6;
    private int _dice;

    public Dice(int dice)
    {
        _dice = dice;
    }

    public static int RollDice()
    {
        var random = new Random();
        return random.Next(1, diceSide);
    }
}


