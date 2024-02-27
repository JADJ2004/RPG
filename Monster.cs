
public class Monster
{
    public int ID { get; private set; }
    public string Name { get; private set; }
    public int Damage { get; private set; }
    public int Reward { get; private set; }
    public int Health { get; private set; }
    public double CritResistance { get; private set; }
    public Monster(int id, string name, int damage, int reward, int health, double critresistance)
    {
        ID = id;
        Name = name;
        Damage = damage;
        Reward = reward;
        Health = health;
        CritResistance = critresistance;
    }
    public void GetAttacked(int damage)
    {
        Health = Math.Max(0, Health - damage);
    }
}
