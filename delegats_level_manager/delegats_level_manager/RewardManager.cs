namespace delegats_level_manager;

public class RewardManager
{
    public void OnCharacterLevelUp(Character character, int newLevel)
    {
        character.Gold += 100;
        Console.WriteLine("You got 100 gold");
    }
}