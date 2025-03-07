namespace partials.Person;

public partial class Person
{
    public string FirstName 
    { 
        get => _firstName;
        set
        {
            if (_firstName != value)
            {
                _firstName = value;
                OnNameChanged();
            }
        }
    }
    
    private string _firstName;

    public partial void OnNameChanged();
}