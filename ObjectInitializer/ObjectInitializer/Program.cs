var Person = new Person("Mary", 1965)
{
    Name = "John", //optional
    YearOfBirth = 1981 //optional
};

Console.WriteLine(Person.Name);

class Person
{
    public string Name { get; set; }
    public int YearOfBirth { get; set; }

    public Person(string name, int yearOfBirth)
    {
        Name = name;
        YearOfBirth = yearOfBirth;
    }

}
