public class Player 
{   public int TotalGold = 0;
    public int Health = 100;
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
        if (Health != 100)
        {
            Health += health;
        }
    }
    public void DecreaseHealth(int health)
    {
        if (Health != 0)
        {
            Health -= health;
        }
    }

}
// hier moet nog een player name field komen
// hier moet ook de chapter komen
