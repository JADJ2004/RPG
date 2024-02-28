public class CombatSystem
{
    private Player player;
    private Monster monster;

    public CombatSystem(Player player, Monster monster)
    {
        this.player = player;
        this.monster = monster;
    }
    public void StartCombat()
    {
        Console.WriteLine("Combat has started!");
        Console.WriteLine($"Enemy: {monster.Name}");
        Random random = new Random();
        while (player.Health > 0 && monster.Health > 0)
        {
            Console.WriteLine("Choose an action:");
            Console.WriteLine("1: Attack");
            Console.WriteLine("2: Heal");
            Console.WriteLine("3: Throw Potion");
            string action = Console.ReadLine();
            switch (action)
            {
                case "1": // Attack
                    PerformAttack(random);
                    break;
                case "2": // Heal
                    PerformHeal();
                    break;
                default:
                    Console.WriteLine("Invalid choice, please choose again.");
                    continue;
            }

            if (monster.Health <= 0 || player.Health <= 0) break; // Check if the combat should end

            // Monster's turn
            PerformMonsterAttack(random);
        }

        Console.WriteLine("Combat ended!");
    }
    private void PerformAttack(Random random)
    {
        // Player's turn to attack
        Console.WriteLine($"{player.Name} attacks {monster.Name}!");
        int FinalDamagePlayer = player.CurrentWeapon.Damage;
        if (random.NextDouble() < monster.CritResistance)
        {
            Console.WriteLine("It's a critical hit!");
            FinalDamagePlayer *= 2;
        }
        monster.GetAttacked(FinalDamagePlayer);
        Console.WriteLine($"{monster.Name} has {monster.Health} health left.");
        if (monster.Health <= 0)
        {
            Console.WriteLine($"{monster.Name} defeated!");
            player.AddGold(monster.Reward);
            Console.WriteLine($"Player received {monster.Reward} gold. Total gold: {player.TotalGold}");
        }
    }
    private void PerformHeal()
    {
        // Player's turn to heal
        int healAmount = 35; // This can be adjusted or made dynamic
        player.IncreaseHealth(healAmount);
        Console.WriteLine($"{player.Name} heals for {healAmount} points. Total health: {player.Health}.");
    }
    private void PerformMonsterAttack(Random random)
    {
        Console.WriteLine($"{monster.Name} attacks {player.Name}!");
        int FinalDamageMonster = monster.Damage;
        if (random.NextDouble() < 0.1) // Monster's chance to critical hit
        {
            FinalDamageMonster *= 2;
        }
        player.DecreaseHealth(FinalDamageMonster);
        Console.WriteLine($"{player.Name} has {player.Health} health left.");
        if (player.Health <= 0)
        {
            Console.WriteLine("Player defeated!");
        }
    }
}
