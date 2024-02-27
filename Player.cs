public class Player 
{
    public int TotalGold = 0;
    public int Health = 100;
    public string Name { get; set; } // Player name field
    public int CurrentChapter { get; set; } // Player current chapter
    public Weapon CurrentWeapon { get; set; } // Determines the current weapon of the Player

    public Player(string name)
    {
        Name = name;
        CurrentChapter = 1; // Starting from chapter 1
    }

    public void EquipWeapon(Weapon weapon)
    {
        CurrentWeapon = weapon;
    }
    public void AddGold(int gold)
    {
        TotalGold += gold;
    }

    public void RemoveGold(int gold)
    {
        TotalGold -= gold;
    }

    public void IncreaseHealth(int health)
    {
        Health = Math.Min(100, Health + health);
    }

    public void DecreaseHealth(int health)
    {
        Health = Math.Max(0, Health - health);
    }
}
