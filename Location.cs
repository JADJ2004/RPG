public class Location {
    public static void fast_travel{
        // Voeg in deze list alle locaties toe
        List<string> locations = new List<string> {};

        while (true){
            Console.WriteLine("Where would you like to go?");
            Console.WriteLine("Locations:");
            foreach (string area in locations){
                Console.WriteLine(area);
            }

            string destination_choice = Console.ReadLine();
            if (locations.ToLower().Contains(destination_choice.ToLower())){
                //area_level(destination_choice);
                break;
            else if (destination_choice == "exit"){
                break;
            }
            else{
                Console.WriteLine("The location you picked is either off-limits or doesn't exist. Pick a new location.");
                continue;
            }
            }
        }
    }

    public static void area_level(area_choice){
        if (area_choice == ""){
            // Voeg hier de functie van dat locatie toe.
        }
    }

    /* Maak voor elke locatie een bijbehorende functie.
    // De string "destination_choice" wordt dan meegegeven als een parameter.
    // Aan de hand van die parameter wordt in area_level(...) een locatie gekozen.
    */
}
