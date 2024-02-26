public class Weapon
{
    public int ID { get; private set; }
    public string Name { get; private set; }
    public int Damage { get; private set; }

    public Weapon(int id, string name, int damage)
    {
        ID = id;
        Name = name;
        Damage = damage;
    }

    public List<Weapon> Weapons = new List<Weapon>();

    public void AddWeapon(Weapon item)
    {
        Weapons.Add(item);
    }

    public void RemoveWeapon(Weapon item)
    {
        Weapons.Remove(item);
    }

    public void PrintWeapons()
    {
        foreach (var weapon in Weapons)
        {
            Console.WriteLine($"{weapon.Name}, Damage: {weapon.Damage}");
        }
    }
}
