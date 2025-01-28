namespace delegats_level_manager;

public class Character
{
    public int Level { get; set; }
    public int CurrentXP { get; set; }
    public int XPForNextLevel { get; set; }
    public event Action<Character, int> OnLevelUp;

    public void AddXP(int amount)
    {
        CurrentXP += amount;
        if (CurrentXP >= XPForNextLevel)
        {
            Level++;
            CurrentXP = 0;
            XPForNextLevel = Level * 100;
            OnLevelUp?.Invoke(this, Level);
        }
    }
}