namespace delegates;

public class FixErrors
{
    public delegate void NotificationHandler(string message);
    // Caes 1
    public void Case1()
    {
        NotificationHandler handler = Notify;
        handler("Test message");
    }
    
    void Notify(string message)
    {
        Console.WriteLine(message);
    }

    // Case 2
    public delegate void NotificationHandler2(string message);

    public void Case2()
    {
        NotificationHandler2 handler = (string msg) => Console.WriteLine(msg);
        handler("123");
    }

    // Case 3
    public delegate void NotificationHandler3(string message);

    public void Case3()
    {
        NotificationHandler3 handler = null;
        handler?.Invoke("Test");
    }

    // Case 4
    public delegate void NotificationHandler5(string message);
    public void Case4()
    {
        NotificationHandler5 handler = (string message) => Console.WriteLine(message);

    }

    // Case 5
    public delegate int MathOperation(int a, int b);
    public void Case5()
    {
        MathOperation operation = (a, b) => a * b;
        Console.WriteLine(operation(5, 5));
    }
    
    public delegate void NotificationHandler6(string message);
    // Case 6. Not sure what wrong here
    public void Case6()
    {
        NotificationHandler6 handler = message => Console.WriteLine(message);
        handler -= message => Console.WriteLine(message);
    }
    
    // Case 7 
    public delegate void NotificationHandler7(string message);
    public void Case7()
    {
        NotificationHandler7 handler = message => Console.WriteLine(message);
        handler?.Invoke("Case 7");
    }
    
    // Case 8
    public delegate void NotificationHandler8(string message);
    public void Case8()
    {
        NotificationHandler handler = message => Console.WriteLine(message);
        handler.Invoke("Case 8");

    }
    
    // Case 9
    public delegate void NotificationHandler9(string message);
    public void Case9()
    {
        NotificationHandler9 handler = Console.WriteLine;
        handler("Test");
    }
    
    // Case 10. Not sure what is wrong here
    public delegate void NotificationHandler10(string message);

    public void Case10()
    {
        NotificationHandler10 handler = message => Console.WriteLine(message);
        handler -= Console.WriteLine;
    }
}