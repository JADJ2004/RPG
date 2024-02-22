public class Weapon
{
    public string Name {get; set;}
    public Weapon(string name)
    {
        Name = name;
    }
    public List<Weapon> Weapons = new List<Weapon>();

    public void addWeapon(Weapon item)
    {
        Weapons.Add(item);
    }

    public void removeWeapon(Weapon item)
    {
        Weapons.Remove(item);
    }
    public void printWeapons()
    {
        foreach (var weapon in Weapons)
        {
            Console.WriteLine(weapon.Name);
        }
    }
}
