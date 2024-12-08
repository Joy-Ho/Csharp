int seasonNumber = 0;
Season spring = (Season)seasonNumber;

int secondSeasonNumber = 1;
Season summer = (Season)secondSeasonNumber;
Console.WriteLine(summer);

public enum Season
{
    Spring,
    Summer,
    Autumn,
    Winter
}


public class Ingredient
{
    public Ingredient(int priceIfExtraTopping)
    {
        Console.WriteLine("Constructor from Ingredient class");
        PriceIfExtraTopping = priceIfExtraTopping;
    }

    public int PriceIfExtraTopping {  get; }
    public override string ToString() => Name;
    public virtual string Name { get; } = "Some ingredient";
}

public class Cheddar : Ingredient
{
    public Cheddar(int priceIfExtraTopping, int agedForMonths):base(priceIfExtraTopping)
    {
        AgedForMonths = agedForMonths;
        Console.WriteLine("Constructor from the Cheddar class");
    }

    public override string Name =>
        $"{base.Name}, more specifically, a Cheddar cheese aged for {AgedForMonths} months";
    public int AgedForMonths { get; }
}

public class Mozzarella : Ingredient
{
    public Mozzarella(int priceIfExtraTopping) : base(priceIfExtraTopping)
    {
    }

    //public string Name => "Mozzarella";

    public override string Name => "Mozzarella";
    public bool IsLight { get; }
}

public class TomatoSauce : Ingredient
{
    public TomatoSauce(int priceIfExtraTopping) : base(priceIfExtraTopping)
    {
    }

    //public string Name => "Tomato Sauce";
    public override string Name => "Tomato sauce";
    public int TomatoesIn100Grams {  get; }
}
