namespace delegates;

public class Alarm
{
    public event Action OnAlarm;
    
    public void Trigger()
    {
        Console.WriteLine("Alarm triggered!");
        OnAlarm?.Invoke();
    }

}