using System.Linq;

public class Location
{
    public string Name { get; set; }
    public string Description { get; set; }
    public bool IsUnlocked { get; set; }

    public Location(string name, string description, bool isUnlocked = false)
    {
        Name = name;
        Description = description;
        IsUnlocked = isUnlocked;
    }

    public static List<Location> AllLocations = new List<Location>();

    static Location()
    {
        LocationManager(); // Call the method to initialize locations
    }

    static void LocationManager()
    {
        AllLocations.Add(new Location("Sanctum", "Mai's home, surrounded by high walls.", true));
        AllLocations.Add(new Location("Unknown Territories", "Areas outside the Sanctum. Dangerous and unexplored.", false));
        AllLocations.Add(new Location("Opposition Camp", "The base of the opposition.", false));
        AllLocations.Add(new Location("Forest", "Areas outside the Sanctum. Beautiful wilderness.", false));
        AllLocations.Add(new Location("Crossroads", "Middle of the road... Two directions to go to.", false));
        AllLocations.Add(new Location("Back to the Sanctum", "Cold.. but with a mission.", false));
    }

    public static void UnlockLocation(string locationName)
    {
        Location location = AllLocations.FirstOrDefault(l => l.Name == locationName);
        if (location != null)
        {
            location.IsUnlocked = true;
        }
    }

    public static void ShowLocationsStatus()
    {
        foreach (var location in AllLocations)
        {
            Console.WriteLine($"{location.Name}: {(location.IsUnlocked ? "Unlocked" : "Locked")}");
        }
    }
}
