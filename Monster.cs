public class Monster
{
    public int ID { get; private set; }
    public string Name { get; private set; }
    public int Damage { get; private set; }
    public int Reward { get; private set; }
    public int Health { get; private set; }

    public Monster(int id, string name, int damage, int reward, int health)
    {
        ID = id;
        Name = name;
        Damage = damage;
        Reward = reward;
        Health = health;
    }
}
