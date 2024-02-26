using System;
using System.Collections.Generic;

namespace AdventureGame
{
    public static class World
    {
        public static readonly List<Weapon> Weapons = new List<Weapon>();
        public static readonly List<Monster> Monsters = new List<Monster>();
        public static readonly List<Quest> Quests = new List<Quest>();
        public static readonly List<Location> Locations = new List<Location>();
        public static readonly Random RandomGenerator = new Random();

        public const int WEAPON_ID_RUSTY_SWORD = 1;
        public const int WEAPON_ID_CLUB = 2;

        public const int MONSTER_ID_RAT = 1;
        public const int MONSTER_ID_SNAKE = 2;
        public const int MONSTER_ID_GIANT_SPIDER = 3;

        public const int QUEST_ID_CLEAR_ALCHEMIST_GARDEN = 1;
        public const int QUEST_ID_CLEAR_FARMERS_FIELD = 2;
        public const int QUEST_ID_COLLECT_SPIDER_SILK = 3;

        public const int LOCATION_ID_HOME = 1;
        public const int LOCATION_ID_TOWN_SQUARE = 2;
        public const int LOCATION_ID_GUARD_POST = 3;
        public const int LOCATION_ID_ALCHEMIST_HUT = 4;
        public const int LOCATION_ID_ALCHEMISTS_GARDEN = 5;
        public const int LOCATION_ID_FARMHOUSE = 6;
        public const int LOCATION_ID_FARM_FIELD = 7;
        public const int LOCATION_ID_BRIDGE = 8;
        public const int LOCATION_ID_SPIDER_FIELD = 9;

        static World()
        {
            PopulateWeapons();
            PopulateMonsters();
            PopulateQuests();
            PopulateLocations();
        }

        private static void PopulateWeapons()
        {
            Weapons.Add(new Weapon(WEAPON_ID_RUSTY_SWORD, "Rusty Sword", 0, 3, 10));
            Weapons.Add(new Weapon(WEAPON_ID_CLUB, "Club", 0, 5, 15));
        }

        private static void PopulateMonsters()
        {
            Monsters.Add(new Monster(MONSTER_ID_RAT, "Rat", 5, 1, 3, 10, 1, 1));
            Monsters.Add(new Monster(MONSTER_ID_SNAKE, "Snake", 10, 2, 5, 20, 1, 2));
            Monsters.Add(new Monster(MONSTER_ID_GIANT_SPIDER, "Giant Spider", 20, 5, 10, 40, 2, 3));
        }

        private static void PopulateQuests()
        {
            Quest clearAlchemistGarden = new Quest(QUEST_ID_CLEAR_ALCHEMIST_GARDEN, "Clear the Alchemist's Garden", "Kill rats in the alchemist's garden to clear it.", new List<QuestCompletionItem> { new QuestCompletionItem(MonsterByID(MONSTER_ID_RAT), 5) }, 20, 10);
            Quest clearFarmersField = new Quest(QUEST_ID_CLEAR_FARMERS_FIELD, "Clear the Farmer's Field", "Kill snakes in the farmer's field to clear it.", new List<QuestCompletionItem> { new QuestCompletionItem(MonsterByID(MONSTER_ID_SNAKE), 3) }, 30, 20);
            Quest collectSpiderSilk = new Quest(QUEST_ID_COLLECT_SPIDER_SILK, "Collect Spider Silk", "Collect spider silk from giant spiders.", new List<QuestCompletionItem> { new QuestCompletionItem(MonsterByID(MONSTER_ID_GIANT_SPIDER), 4) }, 50, 25);

            Quests.Add(clearAlchemistGarden);
            Quests.Add(clearFarmersField);
            Quests.Add(collectSpiderSilk);
        }

        private static void PopulateLocations()
        {
            Location home = new Location(LOCATION_ID_HOME, "Home", "Your cozy little house.", null, null, null);
            Location townSquare = new Location(LOCATION_ID_TOWN_SQUARE, "Town Square", "The bustling center of the town.", null, null, null);
            Location guardPost = new Location(LOCATION_ID_GUARD_POST, "Guard Post", "A small guard post at the edge of the town.", null, null, null);
            Location alchemistHut = new Location(LOCATION_ID_ALCHEMIST_HUT, "Alchemist Hut", "A mysterious hut belonging to the local alchemist.", QuestByID(QUEST_ID_CLEAR_ALCHEMIST_GARDEN), null, null);
            Location alchemistsGarden = new Location(LOCATION_ID_ALCHEMISTS_GARDEN, "Alchemist's Garden", "A garden full of exotic plants... and rats.", null, MonsterByID(MONSTER_ID_RAT), null);
            Location farmhouse = new Location(LOCATION_ID_FARMHOUSE, "Farmhouse", "A small farmhouse on the outskirts of the town.", QuestByID(QUEST_ID_CLEAR_FARMERS_FIELD), null, null);
            Location farmField = new Location(LOCATION_ID_FARM_FIELD, "Farm Field", "A large field used for farming. Watch out for snakes!", null, MonsterByID(MONSTER_ID_SNAKE), null);
            Location bridge = new Location(LOCATION_ID_BRIDGE, "Bridge", "A sturdy stone bridge crossing a wide river.", null, null, null);
            Location spiderField = new Location(LOCATION_ID_SPIDER_FIELD, "Spider Field", "A forested area covered in webs. Spiders lurk everywhere.", QuestByID(QUEST_ID_COLLECT_SPIDER_SILK), MonsterByID(MONSTER_ID_GIANT_SPIDER), null);

            Locations.Add(home);
            Locations.Add(townSquare);
            Locations.Add(guardPost);
            Locations.Add(alchemistHut);
            Locations.Add(alchemistsGarden);
            Locations.Add(farmhouse);
            Locations.Add(farmField);
            Locations.Add(bridge);
            Locations.Add(spiderField);

            // Define paths between locations if needed for your game's logic
        }

        public static Location LocationByID(int id) => Locations.Find(l => l.ID == id);
        public static Weapon WeaponByID(int id) => Weapons.Find(w => w.ID == id);
        public static Monster MonsterByID(int id) => Monsters.Find(m => m.ID == id);
        public static Quest QuestByID(int id) => Quests.Find(q => q.ID == id);
    }
}
