namespace delegats_level_manager;

public class Character
{
    public int Level { get; set; } = 1;
    public int CurrentXp { get; set; } = 0;
    public int XpForNextLevel { get; set; } = 100;
    public int Gold { get; set; } = 0;
    public int Strength { get; set; } = 1;
    public event Action<Character, int> OnLevelUp;

    public void AddXP(int amount)
    {
        CurrentXp += amount;
        while (CurrentXp >= XpForNextLevel)
        {
            Level++;
            CurrentXp -= XpForNextLevel;
            XpForNextLevel = Level * 100;
            OnLevelUp?.Invoke(this, Level);
        }
    }
}