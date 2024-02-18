using System;

namespace Placeholder
{
    public class Program
    {
        private static bool gameRunning = true;

        public static void Main(string[] args)
        {   
            while (gameRunning)
            {
                if (Console.KeyAvailable)
                {
                    string userInput = Console.ReadLine();

                    if (string.Equals(userInput, "quit", StringComparison.OrdinalIgnoreCase))
                    {
                        gameRunning = false;
                        continue
                    }
                }
                // zet hier de rest van de code neer
            }
        }
    }
}
