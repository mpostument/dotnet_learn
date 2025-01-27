namespace delegates;

public class UsersManager
{
    public List<User> Users = new List<User>();
    private int _count = 100;

    public void GenerateUsers()
    {
        for (int i = 0; i < _count; i++)
        {
            Users.Add(new User($"User{i}", 0+i));
        }
    }
    
    public void FilterUsers(Predicate<User> filterHandler)
    {
        foreach (var user in Users)
        {
            if (filterHandler(user))
            {
                Console.WriteLine($"User found: {user.Name}");
            }
        }
    }
}