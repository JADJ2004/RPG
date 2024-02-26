﻿class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Echoes of Freedom");
        Player mai = new Player("Mai");
        int currentChapter = 1;
        bool gameOver = false;

        while (!gameOver)
        {
            Console.WriteLine("Mai has lived her entire life within the walls of this sanctum. A place ruled by strict rules and indoctrination, " +
            "under the leadership of her parents. She has been taught that the outside world is dangerous and that their group " +
            "offers protection and truth.\nFollowing the brutal assassination of her parents by the opposition (the group the parents said was dangerous), " +
            "Mai experiences a crisis. Conflicted and seeking answers, she makes the decision to escape and find the opposition, " +
            "so she can seek revenge.\n");
            Console.WriteLine("Oh no it's a guard, i have to fight him");
            while (Quest1 != "won");
            {
                FightScene();
                if (Quest1 == "won")
                {
                    getGold();
                    BuyWeapon();
                    if (BuyWeapon == "yes")
                        {
                            RemoveGold();
                            AddWeapon("fire blade");
                        }
                    Location.UnlockLocation("Unknown Territories");
                    ShowLocationsStatus()
                    break;
                }
            }
            Console.WriteLine("Chapter 2: Pursued by the Past\n" +
            "As Mai ventures into the unknown, she is not alone. Members of her own community, loyal to the cause and her parents' legacy, pursue her relentlessly. " +
            "Viewing her as a traitor for leaving, they are determined to bring her back by force. Mai must confront these enemies, " +
            "using both her wit and combat skills learned within those walls. These battles test her resolve and force her to question the " +
            "true nature of her enemies and allies alike.");
            Console.WriteLine("use latest weapon y/n?");
            inputUser = Console.ReadLine().ToLower();
            if (inputUser == "y")
            {
                criticalChane = 0.5;
            }
            while (Quest2 != "won");
            {
                FightScene();
                if (Quest2 == "won")
                {
                    getGold();
                    BuyWeapon();
                    if (BuyWeapon == "yes")
                        {
                            RemoveGold();
                            AddWeapon("weapon 2");
                        }
                    Location.UnlockLocation("Opposition Camp");
                    ShowLocationsStatus()
                    break;
                }
            }
            Console.WriteLine("Chapter 3: The Other Side\n" +
            "Venturing beyond the confines of the sanctum, Mai encounters the opposition, the very people blamed for her parents' " +
            "death. Expecting hostility, she is taken aback by their warmth and the stark contrast between their ideals " +
            "and what she has been led to believe.");
            Console.WriteLine("Fight guard or snitch opposition fight/s");
            answerInput = Console.ReadLine().ToLower();
            if (answerInput == "fight" )
            {
                Console.WriteLine("use latest weapon y/n?");
                inputUser = Console.ReadLine().ToLower();
                if (inputUser == "y")
                {
                    criticalChane = 0.5;
                }
                while (Quest3 != "won");
                {
                    FightScene();
                    if (Quest3 == "won")
                    {
                        getGold();
                        BuyWeapon();
                        if (BuyWeapon == "yes")
                            {
                                RemoveGold();
                                AddWeapon("weapon 3");
                            }
                        Location.UnlockLocation("Forest");
                        ShowLocationsStatus()
                        addKarma();
                        break;
                    }
                }
            }
            else
            {
                Console.WriteLine("snitches opposition to the guards");
                Location.UnlockLocation("Forest");
                ShowLocationsStatus()
            }
            Console.WriteLine("Chapter 4: Revelations\n" +
            "As Mai integrates with the opposition, she uncovers the truth: the world outside is not the dystopia painted by her " +
            "parents. Instead, it is a place striving for freedom and individual thought, fighting against the oppressive control " +
            "of the Sanctum.");
            Console.WriteLine("Oh look this person needs some money\nHelp person y/n");
            userInput = Console.ReadLine().ToLower();
            if (userInput == "y")
                {
                    Console.WriteLine("Oh thank you very much Mai!");
                    addKarma();
                }
            while (Quest4 != "won");
            {
                Console.WriteLine("use latest weapon y/n?");
                inputUser = Console.ReadLine().ToLower();
                if (inputUser == "y")
                {
                    criticalChane = 0.5;
                }
                FightScene();
                if (Quest4 == "won")
                {
                    getGold();
                    BuyWeapon();
                    if (BuyWeapon == "yes")
                        {
                            RemoveGold();
                            AddWeapon("weapon 4");
                        }
                    Location.UnlockLocation("Crossroads");
                    ShowLocationsStatus()
                    break;
                }
            }

            Console.WriteLine("Chapter 5: The Choice\n" +
            "Faced with the reality of her upbringing and the ideals of the opposition, Mai stands at a crossroads. " +
            "Her decision to join this new group and fight for true freedom could lead to the salvation of many. Choosing the " +
            "path of good and aligning with the opposition promises a brighter future. " +
            "Alternatively, she could choose to return to the sanctum and betray the opposition (effectively betraying herself).");
            while (Quest5 != "won");
            {
                Console.WriteLine("use latest weapon y/n?");
                inputUser = Console.ReadLine().ToLower();
                if (inputUser == "y")
                {
                    criticalChane = 0.5;
                }
                FightScene();
                if (Quest5 == "won")
                {
                    Location.UnlockLocation("Crossroads");
                    break;
                }
            }
            if (Karma.KarmaPoints != 0)
            {
                Console.WriteLine("You made good choices! you are now officially the leader of the opposition");
                // monologue for chapter 6
                // Chapter 6: A Twist in Time (alleen als mai good karma heeft)
                    // Embracing her role within the opposition, Mai discovers a shocking truth through a series of clues: in a 
                    // bizarre twist of fate, she learns that she herself will become the leader of this group in the future, orchestrating 
                    // the downfall of her own parents. This revelation highlights the cyclical nature of conflict and the complex moral 
                    // landscape Mai must navigate. Her parents, despite their facade of benevolence, had committed atrocities that justified 
                    // their overthrow. (dit is gewoon een dialogue alsof we nu in de toekomst zijn, een soort outro)
                Location.UnlockLocation("Back to the Sanctum");
            }
            else
            {
                Console.WriteLine("You have chosen the way of the sanctum, now you will kill the leader of the opposition");
                // monologue for killing the leader of the opposition
                Console.WriteLine("Why does she have the same eyes as me..?");
            }

            
                    gameOver = true;
                    break;    
        }
        Console.WriteLine("Thank you for playing Echoes of Freedom.");
        gameOver = true;
    }
}

