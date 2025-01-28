namespace delegats_level_manager;

public class UIManager
{
    public void OnCharacterLevelUp(Character character, int newLevel)
    {
        Console.WriteLine($"Level Up! Current Level: {newLevel}");
    }
}