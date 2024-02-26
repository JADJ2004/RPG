using System;

namespace Placeholder
{
    public class Program
    {
        private static GameSession _gameSession;
        private static bool gameRunning = true;

        public static void Main(string[] args)
        {
            _gameSession = new GameSession();

            Console.WriteLine("Welcome to the game! Type 'quit' to exit.");

            while (gameRunning)
            {
                if (Console.KeyAvailable)
                {
                    string userInput = Console.ReadLine();

                    if (string.Equals(userInput, "quit", StringComparison.OrdinalIgnoreCase))
                    {
                        gameRunning = false;
                        continue;
                    }

                    ProcessInput(userInput);
                }
            }
        }

        private static void ProcessInput(string input)
        {
            switch (input.ToUpper())
            {
                case "N":
                    _gameSession.MoveNorth();
                    break;
                case "S":
                    _gameSession.MoveSouth();
                    break;
                case "E":
                    _gameSession.MoveEast();
                    break;
                case "W":
                    _gameSession.MoveWest();
                    break;
                case "A":
                    _gameSession.Attack();
                    break;
                case "Q":
                    _gameSession.ShowQuests();
                    break;
                case "I":
                    _gameSession.ShowInventory();
                    break;
                case "QUIT":
                    gameRunning = false;
                    break;
                default:
                    Console.WriteLine("Invalid command. Please try again.");
                    break;
            }

            if (gameRunning)
            {
                DisplayCurrentLocation();
                DisplayAvailableCommands();
            }
        }

        private static void DisplayCurrentLocation()
        {
            Console.Clear();
            Console.WriteLine($"You are at {_gameSession.CurrentLocation.Name}.");
            Console.WriteLine(_gameSession.CurrentLocation.Description);

            if (_gameSession.CurrentLocation.QuestAvailableHere != null)
            {
                Console.WriteLine($"Quest available: {_gameSession.CurrentLocation.QuestAvailableHere.Name}");
            }

            if (_gameSession.CurrentLocation.MonsterLivingHere != null)
            {
                Console.WriteLine($"WARNING: {_gameSession.CurrentLocation.MonsterLivingHere.Name} spotted!");
            }
        }

        private static void DisplayAvailableCommands()
        {
            Console.WriteLine("Available commands:");
            Console.WriteLine("'N' - Go North");
            Console.WriteLine("'S' - Go South");
            Console.WriteLine("'E' - Go East");
            Console.WriteLine("'W' - Go West");
            Console.WriteLine("'A' - Attack");
            Console.WriteLine("'Q' - Quests");
            Console.WriteLine("'I' - Inventory");
            Console.WriteLine("'Quit' - Quit Game");
            Console.Write("Enter command: ");
        }
    }

    class GameSession
    {
        public Location CurrentLocation { get; private set; }

        public GameSession()
        {
            CurrentLocation = World.LocationByID(World.LOCATION_ID_HOME); // de startlocatie
        }

        public void MoveNorth()
        {
            if (CurrentLocation.LocationToNorth != null)
            {
                CurrentLocation = CurrentLocation.LocationToNorth;
            }
            else
            {
                Console.WriteLine("You cannot move north from here.");
                Console.ReadKey();
            }
        }

        public void MoveSouth()
        {
            if (CurrentLocation.LocationToSouth != null)
            {
                CurrentLocation = CurrentLocation.LocationToSouth;
            }
            else
            {
                Console.WriteLine("You cannot move south from here.");
                Console.ReadKey();
            }
        }

        public void MoveEast()
        {
            if (CurrentLocation.LocationToEast != null)
            {
                CurrentLocation = CurrentLocation.LocationToEast;
            }
            else
            {
                Console.WriteLine("You cannot move east from here.");
                Console.ReadKey();
            }
        }

        public void MoveWest()
        {
            if (CurrentLocation.LocationToWest != null)
            {
                CurrentLocation = CurrentLocation.LocationToWest;
            }
            else
            {
                Console.WriteLine("You cannot move west from here.");
                Console.ReadKey();
            }
        }

        public void Attack()
        {
            // Hier attack code
        }

        public void ShowQuests()
        {
            // Hier quest code
        }

        public void ShowInventory()
        {
            // Hier inventory code
        }
    }
}
