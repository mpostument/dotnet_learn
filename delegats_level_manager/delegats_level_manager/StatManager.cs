namespace delegats_level_manager;

public class StatManager
{
    public void OnCharacterLevelUp(Character character, int newLevel)
    {
        character.Strength += 5;
        Console.WriteLine("Strength +5");
    }
}