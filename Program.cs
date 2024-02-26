using System.Collections.Generic;
using System.Linq;

namespace AdventureGame
{
    class Program
    {
        static void Main(string[] args)
        {
            World world = new World();
            Player player = new Player();
            bool gameRunning = true;

            while (gameRunning)
            {
                Location currentLocation = world.GetCurrentLocation();
                Console.WriteLine($"You are at: {currentLocation.Description}");
                Console.WriteLine("A");
                Console.WriteLine("B");
                Console.WriteLine("I. View inventory");

                string input = Console.ReadLine();
                switch (input)
                {
                    case "A":
                    // logica hier
                        break;
                    case "I":
                        player.ViewInventory();
                        break;
                    case "B":
                    // logica hier
                        break;
                    default:
                        Console.WriteLine("Invalid option, please try again.");
                        break;
                }

                if (currentLocation.Quest != null && currentLocation.Quest.IsComplete(player))
                {
                    Console.WriteLine($"Quest completed: {currentLocation.Quest.Name}");
                    world.MoveToNextLocation();
                }
            }
        }
        public void Attack()
        {
            // Hier attack code
        }

        public void ShowInventory()
        {
            // Hier inventory code
        }
    }
}
