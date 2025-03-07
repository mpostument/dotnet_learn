namespace partials.Person;

public partial class Person
{
    public string LastName { get; set; }

    public void PrintFullName()
    {
        Console.WriteLine($"{FirstName} {LastName}");
    }

    public partial void OnNameChanged()
    {
        Console.WriteLine("Name was changed");
    }
}