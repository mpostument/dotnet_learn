using delegats_level_manager;

Character character = new Character();
UIManager uiManager = new UIManager();
RewardManager rewardManager = new RewardManager();
StatManager statManager = new StatManager();

character.OnLevelUp += uiManager.OnCharacterLevelUp;
character.OnLevelUp += rewardManager.OnCharacterLevelUp;
character.OnLevelUp += statManager.OnCharacterLevelUp;


while (true)
{
    Console.WriteLine("Enter XP amount:");
    Console.WriteLine($"XP to next level {character.XpForNextLevel - character.CurrentXp}");;
    if (int.TryParse(Console.ReadLine(), out int xp))
    {
        character.AddXP(xp);
    }
    else
    {
        Console.WriteLine("Invalid input");
    }
}