using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public static class World
    {
        public static readonly List<Item> Items = new List<Item>();
        public static readonly List<Monster> Monsters = new List<Monster>();
        public static readonly List<Quest> Quests = new List<Quest>();
        public static readonly List<Location> Locations = new List<Location>();

        //ASSIGNING IDS

        //Creates items as integers, to be used by XML and population

        //Items
        public const int ITEM_ID_RUSTY_SWORD = 1;
        public const int ITEM_ID_RAT_TAIL = 2;
        public const int ITEM_ID_PIECE_OF_FUR = 3;
        public const int ITEM_ID_SNAKE_FANG = 4;
        public const int ITEM_ID_SNAKESKIN = 5;
        public const int ITEM_ID_CLUB = 6;
        public const int ITEM_ID_HEALING_POTION = 7;
        public const int ITEM_ID_SPIDER_FANG = 8;
        public const int ITEM_ID_SPIDER_SILK = 9;
        public const int ITEM_ID_BRIDGE_PASS = 10;
        public const int ITEM_ID_BAT_WING = 11;
        public const int ITEM_ID_FLAMING_STINGER = 12;
        public const int ITEM_ID_CRYSTAL_PEN = 13;
        public const int ITEM_ID_FLAMING_SPELLTOME = 14;
        public const int ITEM_ID_LIGHTNING_SPELLTOME = 15;
        public const int ITEM_ID_KEYSHARD = 16;
        public const int ITEM_ID_KEYSHARD_MANTLE = 17;
        public const int ITEM_ID_GLASS_SWORD = 18;
        public const int ITEM_ID_ICY_SPELLTOME = 19;
        public const int ITEM_ID_WYRM_TOOTH = 20;
        public const int ITEM_ID_MOUNTAIN_DIAMOND = 21;
        public const int ITEM_ID_BURNING_POISON = 22;
        public const int ITEM_ID_SPICY_STINGER_STEW = 23;
        public const int ITEM_ID_TRAVEL_COOKIES = 24;
        public const int ITEM_ID_WILD_MUSHROOM_SNACK = 25;
        public const int ITEM_ID_GLACIOUS_POISON = 26;
        public const int ITEM_ID_BRUTISH_CLUB = 27;
        public const int ITEM_ID_MAJOR_HEALING_POTION = 28;
        public const int ITEM_ID_PRECIOUS_STONE = 29;
        public const int ITEM_ID_CAVE_ROOT = 30;
        public const int ITEM_ID_SEASHELL = 31;
        public const int ITEM_ID_SEAGULL_FEATHERS = 32;
        public const int ITEM_ID_CRAB_MEAT = 33;
        public const int ITEM_ID_EEL_TONGUE = 34;
        public const int ITEM_ID_CORAL_PIECE = 35;
        public const int ITEM_ID_SEA_URCHIN = 36;
        public const int ITEM_ID_STARFISH = 37;
        public const int ITEM_ID_SEA_SNAIL = 38;
        public const int ITEM_ID_RAVEN_BEAK = 39;
        public const int ITEM_ID_RIPE_GRAPE = 40;
        public const int ITEM_ID_LOCUST_LEGS = 41;
        public const int ITEM_ID_ROCKSNAKE_FANG = 42;
        public const int ITEM_ID_BOAR_TUSK = 43;
        public const int ITEM_ID_BUNCH_OF_FLOWERS = 44;
        public const int ITEM_ID_DELICIOUS_COBBLER_PIE = 45;
        public const int ITEM_ID_ROCKY_SPELLTOME = 46;
        public const int ITEM_ID_JEWELED_SWORD = 47;
        public const int ITEM_ID_RAT_JERKY = 48;
        public const int ITEM_ID_HOT_COCOA = 49;
        public const int ITEM_ID_BERRY_PASTRY = 50;
        public const int ITEM_ID_SMALL_LANTERN = 51;

        public const int UNSELLABLE_ITEM_PRICE = -1;

        //Monsters
        public const int MONSTER_ID_RAT = 1;
        public const int MONSTER_ID_SNAKE = 2;
        public const int MONSTER_ID_VICIOUS_RAVEN = 3;
        public const int MONSTER_ID_CRICKET_HOARD = 4;
        public const int MONSTER_ID_GIANT_SPIDER = 5;
        public const int MONSTER_ID_FIERY_SCORPION = 6;
        public const int MONSTER_ID_BAT = 7;
        public const int MONSTER_ID_BRUTAL_CRABBY = 8;
        public const int MONSTER_ID_POISONOUS_SEA_URCHIN = 9;
        public const int MONSTER_ID_ANGRY_SEAGULL = 10;
        public const int MONSTER_ID_EEL = 11;
        public const int MONSTER_ID_WYRM = 12;
        public const int MONSTER_ID_WINGED_BOAR = 13;
        public const int MONSTER_ID_ROCK_PYTHON = 14;
        public const int MONSTER_ID_GREATER_SPIDER = 15;

        //Quests
        public const int QUEST_ID_CLEAR_ALCHEMIST_GARDEN = 1;
        public const int QUEST_ID_CLEAR_FARMERS_FIELD = 2;
        public const int QUEST_ID_RETRIEVE_SCRIBES_PEN = 3;
        public const int QUEST_ID_REPAIR_KEY = 4;
        public const int QUEST_ID_SPIDER_SILKS = 5;
        public const int QUEST_ID_FLAMING_STINGERS = 6;
        public const int QUEST_ID_GLACIOUS_POISON = 7;
        public const int QUEST_ID_PYTHONS_BOARS = 8;
        public const int QUEST_ID_MOUNTAIN_DIAMOND = 9;
        public const int QUEST_ID_FLOWERS = 10;

        //Locations
        public const int LOCATION_ID_HOME = 1;
        public const int LOCATION_ID_TOWN_SQUARE = 2;
        public const int LOCATION_ID_GUARD_POST = 3;
        public const int LOCATION_ID_ALCHEMIST_HUT = 4;
        public const int LOCATION_ID_ALCHEMIST_GARDEN = 5;
        public const int LOCATION_ID_RAT_DEN = 6;
        public const int LOCATION_ID_FARMHOUSE = 7;
        public const int LOCATION_ID_FARM_FIELD_1 = 8;
        public const int LOCATION_ID_FARM_FIELD_2 = 9;
        public const int LOCATION_ID_FARM_FIELD_3 = 10;
        public const int LOCATION_ID_BRIDGE = 11;
        public const int LOCATION_ID_SPIDER_FIELD = 12;
        public const int LOCATION_ID_SPIDER_NEST = 13;
        public const int LOCATION_ID_FOREST_CLEARING = 14;
        public const int LOCATION_ID_WETLANDS = 15;
        public const int LOCATION_ID_QUARRY = 16;
        public const int LOCATION_ID_DEEP_WOODS = 17;
        public const int LOCATION_ID_SCRIBES_TOWER = 18;
        public const int LOCATION_ID_SCRIBES_ROOM = 19;
        public const int LOCATION_ID_BAT_CAVE = 20;
        public const int LOCATION_ID_DEEP_CAVE = 21;
        public const int LOCATION_ID_DARK_ZONE = 22;
        public const int LOCATION_ID_ROCKY_PATH = 23;
        public const int LOCATION_ID_MOUNTAIN_GATE = 24;
        public const int LOCATION_ID_ROCKY_SUMMIT = 25;
        public const int LOCATION_ID_STREET_MARKET_1 = 26;
        public const int LOCATION_ID_STREET_MARKET_2 = 27;
        public const int LOCATION_ID_CLOTHIER = 28;
        public const int LOCATION_ID_CHEF = 29;
        public const int LOCATION_ID_MAGE = 30;
        public const int LOCATION_ID_WARRIOR = 31;
        public const int LOCATION_ID_JEWELER = 32;
        public const int LOCATION_ID_ARMORER = 33;
        public const int LOCATION_ID_OCEANSIDE_DUNES = 34;
        public const int LOCATION_ID_BEACH = 35;
        public const int LOCATION_ID_JETTY = 36;
        public const int LOCATION_ID_TIDE_POOLS = 37;
        public const int LOCATION_ID_SHALLOW_REEF = 38;

        //Populates IDs
        static World()
        {
            PopulateItems();
            PopulateMonsters();
            PopulateQuests();
            PopulateLocations();
        }

        //
        //POPULATING
        //

        //Assigns ITEM_ID_ to name, namePlural, and price. Unsellable items are labeled with -1
        private static void PopulateItems()
        {
            Items.Add(new Item(ITEM_ID_RAT_TAIL, "Rat Tail", "Rat Tails", 2));
            Items.Add(new Item(ITEM_ID_PIECE_OF_FUR, "Piece of fur", "Pieces of Fur", 2));
            Items.Add(new Item(ITEM_ID_SNAKE_FANG, "Snake Fang", "Snake Fangs", 3));
            Items.Add(new Item(ITEM_ID_SNAKESKIN, "Snakeskin", "Snakeskins", 3));
            Items.Add(new Item(ITEM_ID_SPIDER_FANG, "Spider Fang", "Spider Fangs", 5));
            Items.Add(new Item(ITEM_ID_SPIDER_SILK, "Spider Silk", "Spider Silks", 5));
            Items.Add(new Item(ITEM_ID_BRIDGE_PASS, "Bridge Pass", "Bridge Passes", -1));
            Items.Add(new Item(ITEM_ID_BAT_WING, "Bat Wing", "Bat Wings", 5));
            Items.Add(new Item(ITEM_ID_CRYSTAL_PEN, "Crystal Pen", "Crystal Pens", -1));
            Items.Add(new Item(ITEM_ID_FLAMING_STINGER, "Flaming Stinger", "Flaming Stingers", 5));
            Items.Add(new Item(ITEM_ID_KEYSHARD, "Keyshard", "Keyshards", -1));
            Items.Add(new Item(ITEM_ID_KEYSHARD_MANTLE, "Mountain Key Mantle", "Mountain Key Mantles", -1));
            Items.Add(new Item(ITEM_ID_WYRM_TOOTH, "Wyrm's Tooth", "Wyrm's Teeth", 15));
            Items.Add(new Item(ITEM_ID_GLACIOUS_POISON, "Glacious Poison", "Glacious Poison", -1));
            Items.Add(new Item(ITEM_ID_MOUNTAIN_DIAMOND, "Mountain Diamond", "Mountain Diamonds", -1));
            Items.Add(new Item(ITEM_ID_PRECIOUS_STONE, "Precious Stone", "Precious Stones", 15));
            Items.Add(new Item(ITEM_ID_SEASHELL, "Seashell", "Seashells", 7));
            Items.Add(new Item(ITEM_ID_SEAGULL_FEATHERS, "Seagull Feather", "Seagull Feathers", 6));
            Items.Add(new Item(ITEM_ID_CRAB_MEAT, "Crab Meat" ,"Crab Meats", 5));
            Items.Add(new Item(ITEM_ID_EEL_TONGUE, "Eel Tongue", "Eel Tongues", 8));
            Items.Add(new Item(ITEM_ID_CORAL_PIECE, "Piece of Coral", "Pieces of Coral", 5));
            Items.Add(new Item(ITEM_ID_SEA_URCHIN, "Sea Urchin", "Sea Urchins", 5));
            Items.Add(new Item(ITEM_ID_STARFISH, "Starfish", "Starfishes", 5));
            Items.Add(new Item(ITEM_ID_SEA_SNAIL, "Sea Snail", "Sea Snails", 5));
            Items.Add(new Item(ITEM_ID_RAVEN_BEAK, "Raven Beak", "Raven Beaks", 4));
            Items.Add(new Item(ITEM_ID_LOCUST_LEGS, "Locust Leg", "Locust Legs", 2));
            Items.Add(new Item(ITEM_ID_ROCKSNAKE_FANG, "Stone Python Fang", "Stone Python Fangs", 13));
            Items.Add(new Item(ITEM_ID_BOAR_TUSK, "Boar Tusk", "Boar Tusks", 20));
            Items.Add(new Item(ITEM_ID_BUNCH_OF_FLOWERS, "Bundle of Flowers", "Bundles of Flowers", 35));
            Items.Add(new Item(ITEM_ID_SMALL_LANTERN, "Small Lantern", "Small Lanterns", -1));
            Items.Add(new Weapon(ITEM_ID_RUSTY_SWORD, "Rusty Sword", "Rusty Swords", 0, 5, 1));
            Items.Add(new Weapon(ITEM_ID_CLUB, "Club", "Clubs", 5, 13, 5));
            Items.Add(new Weapon(ITEM_ID_GLASS_SWORD, "Glass Sword", "Glass Swords", 15, 20, 12));
            Items.Add(new Weapon(ITEM_ID_BRUTISH_CLUB, "Brutish Club", "Brutish Clubs", 5, 30, 15));
            Items.Add(new Weapon(ITEM_ID_JEWELED_SWORD, "Jeweled Hero Sword", "Jeweled Hero Swords", 20, 20, 40));
            Items.Add(new HealingPotion(ITEM_ID_HEALING_POTION, "Minor Healing Potion", "Minor Healing Potions", 15, 10, 0, true, false, false, false));
            Items.Add(new HealingPotion(ITEM_ID_SPICY_STINGER_STEW, "Spicy Stinger Stew", "Spicy Stinger Stews", 10, 10, 5, false, false, true, false));
            Items.Add(new HealingPotion(ITEM_ID_TRAVEL_COOKIES, "Travel Cookie", "Travel Cookies", 7, 7, 2, false, false, true, false));
            Items.Add(new HealingPotion(ITEM_ID_WILD_MUSHROOM_SNACK, "Mixed Mushroom Snack", "Mixed Mushroom Snacks", 13, 8, 0, false, false, true, false));
            Items.Add(new HealingPotion(ITEM_ID_RIPE_GRAPE, "Ripe Grape", "Ripe Grapes", 5, 5, 0, false, false, true, false));
            Items.Add(new HealingPotion(ITEM_ID_MAJOR_HEALING_POTION, "Major Healing Potion", "Major Healing Potions", 20, 15, 0, true, false, false, false));
            Items.Add(new HealingPotion(ITEM_ID_CAVE_ROOT, "Cave Root", "Cave Roots", 5, 3, 0, false, false, true, false));
            Items.Add(new HealingPotion(ITEM_ID_BURNING_POISON, "Burning Poison", "Burning Poisons", 20, 0, 13, false, true, false, false));
            Items.Add(new HealingPotion(ITEM_ID_DELICIOUS_COBBLER_PIE, "Delicious Cobbler Pie", "Delicious Cobbler Pies", 20, 20, 0, false, false, true, false));
            Items.Add(new HealingPotion(ITEM_ID_RAT_JERKY, "Rat Jerky", "Rat Jerkies", 7, 10, 0, false, false, true, false));
            Items.Add(new HealingPotion(ITEM_ID_HOT_COCOA, "Hot Cocoa", "Hot Cocoas", 10, 7, 0, false, false, false, true));
            Items.Add(new HealingPotion(ITEM_ID_BERRY_PASTRY, "Berry Pastry", "Berry Pastries", 20, 20, 0, false, false, true, false));
            Items.Add(new Spell(ITEM_ID_FLAMING_SPELLTOME, "Book of Flames", "Books of Flames", 30, 7, 17));
            Items.Add(new Spell(ITEM_ID_LIGHTNING_SPELLTOME, "Book of Lightning", "Books of Lightning", 35, 10, 20));
            Items.Add(new Spell(ITEM_ID_ICY_SPELLTOME, "Book of Ice", "Books of Ice", 30, 15, 35));
            Items.Add(new Spell(ITEM_ID_ROCKY_SPELLTOME, "Book of Earth", "Books of Earth", 20, 5, 40));
            
        }

        //Populates monsters, assigns names and stats, then lootTables with items to drop and a drop chance
        private static void PopulateMonsters()
        {
            //id, name, maxDamage, exp, gold, curHP, maxHP

            Monster rat = new Monster(MONSTER_ID_RAT, "Rat", 5, 4, 10, 3, 3);
            rat.LootTable.Add(new LootItem(ItemByID(ITEM_ID_RAT_TAIL), 75, false));
            rat.LootTable.Add(new LootItem(ItemByID(ITEM_ID_PIECE_OF_FUR), 75, false));

            Monster snake = new Monster(MONSTER_ID_SNAKE, "Snake", 5, 3, 10, 3, 3);
            snake.LootTable.Add(new LootItem(ItemByID(ITEM_ID_SNAKE_FANG), 75, false));
            snake.LootTable.Add(new LootItem(ItemByID(ITEM_ID_SNAKESKIN), 75, false));
            snake.LootTable.Add(new LootItem(ItemByID(ITEM_ID_CLUB), 20, true));

            Monster giantSpider = new Monster(MONSTER_ID_GIANT_SPIDER, "Giant Enemy Spider", 20, 10, 25, 10, 10);
            giantSpider.LootTable.Add(new LootItem(ItemByID(ITEM_ID_SPIDER_FANG), 75, true));
            giantSpider.LootTable.Add(new LootItem(ItemByID(ITEM_ID_SPIDER_SILK), 25, false));

            Monster greaterSpider = new Monster(MONSTER_ID_GREATER_SPIDER, "Greater Enemy Spider", 40, 20, 35, 30, 30);
            greaterSpider.LootTable.Add(new LootItem(ItemByID(ITEM_ID_HEALING_POTION), 30, false));
            greaterSpider.LootTable.Add(new LootItem(ItemByID(ITEM_ID_SPIDER_SILK), 80, false));
            greaterSpider.LootTable.Add(new LootItem(ItemByID(ITEM_ID_GLACIOUS_POISON), 45, true));

            Monster fieryScorpion = new Monster(MONSTER_ID_FIERY_SCORPION, "Firey Scorpion", 25, 10, 30, 40, 40);
            fieryScorpion.LootTable.Add(new LootItem(ItemByID(ITEM_ID_HEALING_POTION), 50, false));
            fieryScorpion.LootTable.Add(new LootItem(ItemByID(ITEM_ID_FLAMING_STINGER), 75, false));

            Monster bat = new Monster(MONSTER_ID_BAT, "Feral Bat", 10, 7, 5, 8, 15);
            bat.LootTable.Add(new LootItem(ItemByID(ITEM_ID_BAT_WING), 75, false));
            bat.LootTable.Add(new LootItem(ItemByID(ITEM_ID_CRYSTAL_PEN), 1, true));

            Monster wyrm = new Monster(MONSTER_ID_WYRM, "Mountain Wyrm Boss", 60, 40, 40, 100, 100);
            wyrm.LootTable.Add(new LootItem(ItemByID(ITEM_ID_WYRM_TOOTH), 100, true));
            wyrm.LootTable.Add(new LootItem(ItemByID(ITEM_ID_MOUNTAIN_DIAMOND), 100, true));

            Monster brutalCrabby = new Monster(MONSTER_ID_BRUTAL_CRABBY, "Brutal Crabby", 15, 10, 15, 10, 10);
            brutalCrabby.LootTable.Add(new LootItem(ItemByID(ITEM_ID_CRAB_MEAT), 50, false));
            brutalCrabby.LootTable.Add(new LootItem(ItemByID(ITEM_ID_SEASHELL), 25, false));

            Monster seaUrchin = new Monster(MONSTER_ID_POISONOUS_SEA_URCHIN, "Poisonous Sea Urchin", 10, 8, 5, 5, 5);
            seaUrchin.LootTable.Add(new LootItem(ItemByID(ITEM_ID_SEA_URCHIN), 100, false));
            seaUrchin.LootTable.Add(new LootItem(ItemByID(ITEM_ID_STARFISH), 50, false));
            seaUrchin.LootTable.Add(new LootItem(ItemByID(ITEM_ID_SEA_SNAIL), 50, false));

            Monster angrySeagull = new Monster(MONSTER_ID_ANGRY_SEAGULL, "Hungry Seagull", 15, 10, 6, 14, 14);
            angrySeagull.LootTable.Add(new LootItem(ItemByID(ITEM_ID_SEAGULL_FEATHERS), 75, false));

            Monster eel = new Monster(MONSTER_ID_EEL, "Fat Eel", 25, 15, 10, 30, 30);
            eel.LootTable.Add(new LootItem(ItemByID(ITEM_ID_EEL_TONGUE), 75, false));
            eel.LootTable.Add(new LootItem(ItemByID(ITEM_ID_CORAL_PIECE), 50, false));

            Monster wingedBoar = new Monster(MONSTER_ID_WINGED_BOAR, "Winged Boar", 30, 25, 15, 30, 30);
            wingedBoar.LootTable.Add(new LootItem(ItemByID(ITEM_ID_BOAR_TUSK), 75, true));
            wingedBoar.LootTable.Add(new LootItem(ItemByID(ITEM_ID_BRUTISH_CLUB), 25, true));
            wingedBoar.LootTable.Add(new LootItem(ItemByID(ITEM_ID_MAJOR_HEALING_POTION), 20, false));

            Monster rockPython = new Monster(MONSTER_ID_ROCK_PYTHON, "Rock Python", 30, 25, 15, 30, 30);
            rockPython.LootTable.Add(new LootItem(ItemByID(ITEM_ID_ROCKSNAKE_FANG), 75, false));
            rockPython.LootTable.Add(new LootItem(ItemByID(ITEM_ID_ROCKY_SPELLTOME), 25, true));
            rockPython.LootTable.Add(new LootItem(ItemByID(ITEM_ID_MAJOR_HEALING_POTION), 20, false));

            Monster viciousRaven = new Monster(MONSTER_ID_VICIOUS_RAVEN, "Vicious Raven", 15, 10, 8, 10, 10);
            viciousRaven.LootTable.Add(new LootItem(ItemByID(ITEM_ID_RAVEN_BEAK), 75, false));
            viciousRaven.LootTable.Add(new LootItem(ItemByID(ITEM_ID_RIPE_GRAPE), 50, false));
            viciousRaven.LootTable.Add(new LootItem(ItemByID(ITEM_ID_HEALING_POTION), 25, false));

            Monster locustCloud = new Monster(MONSTER_ID_CRICKET_HOARD, "Locust Cloud", 10, 5, 5, 7, 7);
            locustCloud.LootTable.Add(new LootItem(ItemByID(ITEM_ID_LOCUST_LEGS), 75, false));

            //"Adds" the monsters to the world
            Monsters.Add(rat);
            Monsters.Add(snake);
            Monsters.Add(giantSpider);
            Monsters.Add(greaterSpider);
            Monsters.Add(fieryScorpion);
            Monsters.Add(bat);
            Monsters.Add(wyrm);
            Monsters.Add(brutalCrabby);
            Monsters.Add(seaUrchin);
            Monsters.Add(angrySeagull);
            Monsters.Add(eel);
            Monsters.Add(wingedBoar);
            Monsters.Add(rockPython);
            Monsters.Add(viciousRaven);
            Monsters.Add(locustCloud);
        }

        //Populates quests. Assigns names, titles, descriptions, xp, gold, requirements, and rewards. The QuestRewardItems class is funky and doesn't cooporate with
        //rich text, so you are met "rewards" rather than specific items in the messages text box. 
        private static void PopulateQuests()
        {
            Quest clearAlchemistGarden =
                new Quest(QUEST_ID_CLEAR_ALCHEMIST_GARDEN, "Clear the Alchemist's Garden", "Kill the rats in the Alchemist's garden and bring back 3 rat tails.", 20, 10);
            clearAlchemistGarden.QuestCompletionItems.Add(new QuestCompletionItem(ItemByID(ITEM_ID_RAT_TAIL), 3));
            clearAlchemistGarden.QuestRewardItems.Add(new QuestRewardItem(ItemByID(ITEM_ID_HEALING_POTION), 3));

            Quest clearFarmersField =
                new Quest(QUEST_ID_CLEAR_FARMERS_FIELD, "Clear the Farmer's Field", "Slay the critters in the Farmer's Fields and bring back some proof.", 20, 20);
            clearFarmersField.QuestCompletionItems.Add(new QuestCompletionItem(ItemByID(ITEM_ID_SNAKE_FANG), 3));
            clearFarmersField.QuestCompletionItems.Add(new QuestCompletionItem(ItemByID(ITEM_ID_LOCUST_LEGS), 10));
            clearFarmersField.QuestCompletionItems.Add(new QuestCompletionItem(ItemByID(ITEM_ID_RAVEN_BEAK), 5));
            clearFarmersField.QuestRewardItems.Add(new QuestRewardItem(ItemByID(ITEM_ID_BRIDGE_PASS), 1));
            clearFarmersField.QuestRewardItems.Add(new QuestRewardItem(ItemByID(ITEM_ID_RIPE_GRAPE), 10));

            Quest retrieveScribesPen =
                new Quest(QUEST_ID_RETRIEVE_SCRIBES_PEN, "Find and return the Scribe's Crystal Pen", "Find the bat that snatched the scribe's prized Crystal Pen and retrieve it.", 30, 30);
            retrieveScribesPen.QuestCompletionItems.Add(new QuestCompletionItem(ItemByID(ITEM_ID_CRYSTAL_PEN), 1));
            retrieveScribesPen.QuestRewardItems.Add(new QuestRewardItem(ItemByID(ITEM_ID_FLAMING_SPELLTOME), 1));

            Quest repairKey = 
                new Quest(QUEST_ID_REPAIR_KEY, "Repair the Mountain Key", "Find enough keyshards to repair the Mountain Key.", 15, 15);
            repairKey.QuestCompletionItems.Add(new QuestCompletionItem(ItemByID(ITEM_ID_KEYSHARD), 5));
            repairKey.QuestRewardItems.Add(new QuestRewardItem(ItemByID(ITEM_ID_KEYSHARD_MANTLE), 1));

            Quest clothierQ =
                new Quest(QUEST_ID_SPIDER_SILKS, "Retrieve the Silks", "Battle enough spiders to meet the Clothier's silk quota.", 15, 15);
            clothierQ.QuestCompletionItems.Add(new QuestCompletionItem(ItemByID(ITEM_ID_SPIDER_SILK), 15));
            clothierQ.QuestRewardItems.Add(new QuestRewardItem(ItemByID(ITEM_ID_DELICIOUS_COBBLER_PIE), 2));
            clothierQ.QuestRewardItems.Add(new QuestRewardItem(ItemByID(ITEM_ID_KEYSHARD), 1));


            Quest chefQ = 
                new Quest(QUEST_ID_FLAMING_STINGERS, "Harvest Flaming Stingers", "Retrieve enough Flaming Stingers for the chef to cook his dish.", 15, 15);
            chefQ.QuestCompletionItems.Add(new QuestCompletionItem(ItemByID(ITEM_ID_FLAMING_STINGER), 10));
            chefQ.QuestRewardItems.Add(new QuestRewardItem(ItemByID(ITEM_ID_SPICY_STINGER_STEW), 5));
            chefQ.QuestRewardItems.Add(new QuestRewardItem(ItemByID(ITEM_ID_KEYSHARD), 1));

            Quest mageQ =
                new Quest(QUEST_ID_GLACIOUS_POISON, "Find the Glacious Poison", "Find and return a bottle of the rare Glacious Poison.", 15, 15);
            mageQ.QuestCompletionItems.Add(new QuestCompletionItem(ItemByID(ITEM_ID_GLACIOUS_POISON), 1));
            mageQ.QuestRewardItems.Add(new QuestRewardItem(ItemByID(ITEM_ID_ICY_SPELLTOME), 1));
            mageQ.QuestRewardItems.Add(new QuestRewardItem(ItemByID(ITEM_ID_KEYSHARD), 1));

            Quest warriorQ =
                new Quest(QUEST_ID_PYTHONS_BOARS, "Kill the Monsters", "Go to the Wetlands and the Dark Zone and battle Winged Boars and Rock Pythons", 20, 20);
            warriorQ.QuestCompletionItems.Add(new QuestCompletionItem(ItemByID(ITEM_ID_BOAR_TUSK), 5));
            warriorQ.QuestCompletionItems.Add(new QuestCompletionItem(ItemByID(ITEM_ID_ROCKSNAKE_FANG), 5));
            warriorQ.QuestRewardItems.Add(new QuestRewardItem(ItemByID(ITEM_ID_GLASS_SWORD), 1));
            warriorQ.QuestRewardItems.Add(new QuestRewardItem(ItemByID(ITEM_ID_WILD_MUSHROOM_SNACK), 6));
            warriorQ.QuestRewardItems.Add(new QuestRewardItem(ItemByID(ITEM_ID_KEYSHARD), 1));

            Quest jewelerQ =
                new Quest(QUEST_ID_MOUNTAIN_DIAMOND, "Retrieve the Rare Mountain Diamond", "Slay the fearsome Wyrm and retrieve the Mountain Diamond", 30, 30);
            jewelerQ.QuestCompletionItems.Add(new QuestCompletionItem(ItemByID(ITEM_ID_MOUNTAIN_DIAMOND), 1));
            jewelerQ.QuestRewardItems.Add(new QuestRewardItem(ItemByID(ITEM_ID_JEWELED_SWORD), 1));

            Quest armorerQ =
                new Quest(QUEST_ID_FLOWERS, "Purchase a Bundle of Flowers", "Purchase a Bundle of Flowers and return to the Armorer", 10, 10);
            armorerQ.QuestCompletionItems.Add(new QuestCompletionItem(ItemByID(ITEM_ID_BUNCH_OF_FLOWERS), 1));
            armorerQ.QuestRewardItems.Add(new QuestRewardItem(ItemByID(ITEM_ID_MAJOR_HEALING_POTION), 4));
            armorerQ.QuestRewardItems.Add(new QuestRewardItem(ItemByID(ITEM_ID_KEYSHARD), 1));

            //"Adds" the quests to the world
            Quests.Add(clearAlchemistGarden);
            Quests.Add(clearFarmersField);
            Quests.Add(retrieveScribesPen);
            Quests.Add(repairKey);
            Quests.Add(clothierQ);
            Quests.Add(chefQ);
            Quests.Add(mageQ);
            Quests.Add(warriorQ);
            Quests.Add(jewelerQ);
            Quests.Add(armorerQ);
        }

        //Populates locations by giving names, descriptions, null/true/false values for bools. Can be populated with a quest via QuestAvailableHere, a monster
        //via MonsterLivingHere, or a vendor via VendorWorkingHere. ItemRequiredToEnter bars the player from entering without a specific item.
        private static void PopulateLocations()
        {
            Location home = new Location(LOCATION_ID_HOME, "Home", "Your house. You really need to clean up the place." + Environment.NewLine + "To the north, you see the cobbled path leading to Town Square.", null, null, null, null, false);

            Location townSquare = new Location(LOCATION_ID_TOWN_SQUARE, "Town Square", "In the center of the plaza, you see a nice fountain with various coins in the bottom." + Environment.NewLine + "There are few fellow villagers about today.", null, null, null, null, false);

            Location alchemistHut = new Location(LOCATION_ID_ALCHEMIST_HUT, "Alchemist's Hut", "There is a variety of strange, colorful plants on the shelves." + Environment.NewLine + "The alchemist, a friend, raves on about the terrible rats in his garden while mixing all sorts of strange potions." + Environment.NewLine + "Perhaps you could help?", null, null, null, null, false);
            alchemistHut.QuestAvailableHere = QuestByID(QUEST_ID_CLEAR_ALCHEMIST_GARDEN);

            Location alchemistGarden = new Location(LOCATION_ID_ALCHEMIST_GARDEN, "Alchemist's Garden", "Many plants and flowers are growing here." + Environment.NewLine + "Sure enough, a few rats gnaw on the roots of the previously flourishing herbs." + Environment.NewLine + "Before you get a chance to take in the beauty of the garden, a rat attacks you!", null, null, null, null, false);
            alchemistGarden.MonsterLivingHere = MonsterByID(MONSTER_ID_RAT);

            Location farmhouse = new Location(LOCATION_ID_FARMHOUSE, "The Farmhouse", "A small farmhouse on the edge of a field." + Environment.NewLine + "You don't know the farmer very well, but he's been struggling lately with an assortment of pests attacking his crops." + Environment.NewLine + "Perhaps he's willing to offer a reward if you help take care of his problem?", null, null, null, null, false);
            farmhouse.QuestAvailableHere = QuestByID(QUEST_ID_CLEAR_FARMERS_FIELD);

            Location field1 = new Location(LOCATION_ID_FARM_FIELD_1, "Northern Farm Field", "Fruit trees and grapevines cover this field, and the ripened berries dots the ground. Large, black ravens peck on them." + Environment.NewLine + "As you approach, they screech at you before diving in with sharp claws!", null, null, null, null, false);
            field1.MonsterLivingHere = MonsterByID(MONSTER_ID_VICIOUS_RAVEN);

            Location field2 = new Location(LOCATION_ID_FARM_FIELD_2, "The Farmer's Field", "You see rows of growing vegetables here, including corn." + Environment.NewLine + "You notice a nest of vile snakes lounging in the plants!", null, null, null, null, false);
            field2.MonsterLivingHere = MonsterByID(MONSTER_ID_SNAKE);
            
            Location field3 = new Location(LOCATION_ID_FARM_FIELD_3, "Southern Farm Field", "Vines of squash, watermelon, and pumpkins-to-be cover this field." + Environment.NewLine + "Clouds of insects swarm around the unripe melons and squashes, destroying patches of vines. They'll destroy the entire field if nothing stops them!", null, null, null, null, false);
            field3.MonsterLivingHere = MonsterByID(MONSTER_ID_CRICKET_HOARD);

            Location guardPost = new Location(LOCATION_ID_GUARD_POST, "Guard Post", "A tough-looking, stern guard protects the bridge." + Environment.NewLine + "It doesn't seem like he'll let you by without some sort of pass...", null, null, null, null, false);

            Location bridge = new Location(LOCATION_ID_BRIDGE, "Bridge", "A wide bridge made of stone, which crosses the town's river.", null, null, null, null, false);
            bridge.ItemRequiredToEnter = ItemByID(ITEM_ID_BRIDGE_PASS);

            Location spiderField = new Location(LOCATION_ID_SPIDER_FIELD, "Forest", "You see thick webs covering the trees..." + Environment.NewLine + "And hear the scratching and scraping of giant spiders crawling throughout the forest!", null, null, null, null, false);
            spiderField.MonsterLivingHere = MonsterByID(MONSTER_ID_GIANT_SPIDER);

            Location deepWoods = new Location(LOCATION_ID_DEEP_WOODS, "The Deep Woods", "The shade of the trees here darken your surroundings." + Environment.NewLine + "It's eerily quiet...", null, null, null, null, false);

            Location scribesTower = new Location(LOCATION_ID_DEEP_WOODS, "Scribe's Tower", "The forest opens up to another miniscule clearing, in the center of which stands a mysterious tower." + Environment.NewLine + "As you examine the area, you suddenly find yourself surrounded by giant, fiery scorpions, who seem to have made their home here!", null, null, null, null, false);
            scribesTower.MonsterLivingHere = MonsterByID(MONSTER_ID_FIERY_SCORPION);

            Location scribesRoom = new Location(LOCATION_ID_SCRIBES_ROOM, "Scribe's Room", "Having defeated the guarding scorpions, you enter the front room of the tower to see an older scribe hunched over his work." + Environment.NewLine + "He seems upset about something, and has a request for you, if you're willing to venture out.", null, null, null, null, false);
            scribesRoom.QuestAvailableHere = QuestByID(QUEST_ID_RETRIEVE_SCRIBES_PEN);

            Location batCave = new Location(LOCATION_ID_BAT_CAVE, "Bat Cave", "As you make your way south, you notice a wide, rocky opening. Entering the cave, you hear screeching and fluttering echoing off of the walls!", null, null, null, null, false);
            batCave.MonsterLivingHere = MonsterByID(MONSTER_ID_BAT);

            Location forestClearing = new Location(LOCATION_ID_FOREST_CLEARING, "Forest Clearing", "Here, the forest briefly clears into a small, circular meadow." + Environment.NewLine + "It's peaceful and rather barren, aside from a resting traveler merchant, who sees you and offers his wares.", null, null, null, null, true);

            Vendor travellingMerchant = new Vendor("Travelling Merchant");
            travellingMerchant.AddItemToInventory(ItemByID(ITEM_ID_TRAVEL_COOKIES));
            travellingMerchant.AddItemToInventory(ItemByID(ITEM_ID_LIGHTNING_SPELLTOME));
            travellingMerchant.AddItemToInventory(ItemByID(ITEM_ID_BUNCH_OF_FLOWERS));

            forestClearing.VendorWorkingHere = travellingMerchant;

            Location rockyPath = new Location(LOCATION_ID_ROCKY_PATH, "Rocky Path", "The woods end at the start of a craggly, worn path that steadily leads up the mountain." + Environment.NewLine + "It's a serene climb.", null, null, null, null, false);

            Location mountainGate = new Location(LOCATION_ID_MOUNTAIN_GATE, "Mountain Gate", "The path ends abruptly at a large, powerful-looking gate that blocks your progress." + Environment.NewLine + "It looks like you'll need some sort of key to get by...", null, null, null, null, false);
            mountainGate.QuestAvailableHere = QuestByID(QUEST_ID_REPAIR_KEY);

            Location rockySummit = new Location(LOCATION_ID_ROCKY_SUMMIT, "Mountain Summit", "When the gate opens, you're able to reach the very top of the mountain." + Environment.NewLine + "On the far side of the area, a giant wyrm lays in rest, stirring as you enter." + Environment.NewLine + "It quickly awakens and bristles its scales, baring its viscious teeth and preparing to strike." + Environment.NewLine + "Get ready for a fight!", null, null, null, null, false);
            rockySummit.MonsterLivingHere = MonsterByID(MONSTER_ID_WYRM);
            rockySummit.ItemRequiredToEnter = ItemByID(ITEM_ID_KEYSHARD_MANTLE);

            Location marketStreet1 = new Location(LOCATION_ID_STREET_MARKET_1, "The Street Market", "Various stores and shops line the streets, with many different merchants offering their goods." + Environment.NewLine + "For a price.", null, null, null, null, false);

            Location marketStreet2 = new Location(LOCATION_ID_STREET_MARKET_2, "The Street Market (cont.)", "Various stores and shops line the streets, with many different merchants offering their goods." + Environment.NewLine + "For a price.", null, null, null, null, false);
            
            Location clothier = new Location(LOCATION_ID_CLOTHIER, "The Clothier", "A clothier has set up shop here. He's surprised to see an adventurer like you enter." + Environment.NewLine + "He takes you aside and makes a request, in exchange for a reward.", null, null, null, null, false);
            //
            //CLOTHES/BAGS WILL BE ADDED IN THE FUTURE
            //
            /* Vendor clothierV = new Vendor("The Clothier");
            
            clothierV.AddItemToInventory(ItemByID(ITEM_ID_LEATHER_SATCHEL));
            clothierV.AddItemToInventory(ItemByID(ITEM_ID_TRAVEL_BOOTS));
            clothierV.AddItemToInventory(ItemByID(ITEM_ID_COOL_LOOKING_CAPE));
            
             clothier.VendorWorkingHere = clothierV; */

            clothier.QuestAvailableHere = QuestByID(QUEST_ID_SPIDER_SILKS);

            Location chef = new Location(LOCATION_ID_CHEF, "The Chef", "To the left, a chef boasts about his various exotic oils and salts. The dish he was most excited to create, however, is missing a vital ingredient." + Environment.NewLine + "He offers a reward to the crowd for anyone that can retrieve a few special ingredients.", null, null, null, null, true);
            Vendor chefV = new Vendor("The Chef");

            chefV.AddItemToInventory(ItemByID(ITEM_ID_RAT_JERKY));
            chefV.AddItemToInventory(ItemByID(ITEM_ID_HOT_COCOA));
            chefV.AddItemToInventory(ItemByID(ITEM_ID_BERRY_PASTRY));

            chef.VendorWorkingHere = chefV;

            chef.QuestAvailableHere = QuestByID(QUEST_ID_FLAMING_STINGERS);

            Location mage = new Location(LOCATION_ID_MAGE, "The Mage", "The next store is owned by a mysterious mage. She's preforming an assortment of party tricks and juggles balls of fire for an onlooking crowd." + Environment.NewLine + "An 'Item Wanted' poster displays next to her performance stand, depicting a request for a bottle of rare Glacious Poison.", null, null, null, null, true);
            Vendor mageV = new Vendor("The Mage");

            mageV.AddItemToInventory(ItemByID(ITEM_ID_HEALING_POTION));
            mageV.AddItemToInventory(ItemByID(ITEM_ID_BURNING_POISON));

            mage.VendorWorkingHere = mageV;

            mage.QuestAvailableHere = QuestByID(QUEST_ID_GLACIOUS_POISON);

            //ARMORER, WARRIOR, JEWELER, CLOTHIER SHOPS TO BE ADDED W/ NEW SYSTEMS

            Location warrior = new Location(LOCATION_ID_WARRIOR, "The Warrior", "A warrior is set up here, displaying an assortment of their hand-crafted battlegoods." + Environment.NewLine + "They notice you examining the shining blades, and offer a challlenge.", null, null, null, null, false);
            warrior.QuestAvailableHere = QuestByID(QUEST_ID_PYTHONS_BOARS);

            Location jeweler = new Location(LOCATION_ID_JEWELER, "The Jeweler", "An elderly woman has a neat, organized display of assorted accessories." + Environment.NewLine + "Next to the polished jewelry sits a display box of various gems, but the center display is empty...", null, null, null, null, false);
            jeweler.QuestAvailableHere = QuestByID(QUEST_ID_MOUNTAIN_DIAMOND);

            Location armorer = new Location(LOCATION_ID_ARMORER, "The Armorer", "The final vendor is an armorer, who you catch oogling the distant clothier." + Environment.NewLine + "He asks you for a personal favor.", null, null, null, null, false);
            armorer.QuestAvailableHere = QuestByID(QUEST_ID_FLOWERS);
            
            //
            
            Location oceansideDunes = new Location(LOCATION_ID_OCEANSIDE_DUNES, "Oceanside Dunes", "The chattering and lights of the market fade as you walk towards the sandy dunes." + Environment.NewLine + "You face the beach and the wide, infinite ocean.", null, null, null, null, false);
            
            Location beach = new Location(LOCATION_ID_BEACH, "The Beach", "Travelling down the dunes, you make it to the wide stretch of beach." + Environment.NewLine + "You hear creatures chittering about in the sand!", null, null, null, null, false);
            beach.MonsterLivingHere = MonsterByID(MONSTER_ID_BRUTAL_CRABBY);
            
            Location jetty = new Location(LOCATION_ID_JETTY, "The Jetty", "The beach abruptly ends at a rocky jetty holding calm water. Small, shimmering fish swim about." + Environment.NewLine + "Seagulls, which were once searching for food in the water, spot you and seem annoyed by your presence, and fly in to fight you away!", null, null, null, null, false);
            jetty.MonsterLivingHere = MonsterByID(MONSTER_ID_ANGRY_SEAGULL);

            Location tidePools = new Location(LOCATION_ID_TIDE_POOLS, "Tide Pools", "With the sea being far out, the craggly tide pools are filled to the brim with strange creatures." + Environment.NewLine + "You stick your hand into the water to search for shellfish...", null, null, null, null, false);
            tidePools.MonsterLivingHere = MonsterByID(MONSTER_ID_POISONOUS_SEA_URCHIN);

            Location shallowReef = new Location(LOCATION_ID_SHALLOW_REEF, "Shallow Reef", "You wade into the warm seawater to explore the small coral reef, searching for shells." + Environment.NewLine + "As you do, you feel something bite down on your thumb!", null, null, null, null, false);
            shallowReef.MonsterLivingHere = MonsterByID(MONSTER_ID_EEL);

            Location deepCave = new Location(LOCATION_ID_DEEP_CAVE, "Deeper in the Cave", "The screeching of nested bats fades as you jouney deeper into the cave." + Environment.NewLine + "The air grows humid here, and your footsteps echo on. You use your small lantern to light the way, which casts funky shadows on the walls.", null, null, null, null, false);
            
            Location darkZone = new Location(LOCATION_ID_DARK_ZONE, "The Dark Zone", "The air is cold here, and your lantern becomes the only source of light. How deep does this go?" + Environment.NewLine + "As you ponder, you hear something slither against the stone...", null, null, null, null, false);
            darkZone.MonsterLivingHere = MonsterByID(MONSTER_ID_ROCK_PYTHON);

            Location wetlands = new Location(LOCATION_ID_WETLANDS, "The Wetlands", "This is the first section of the wetlands, and currently the only area you can get to without some work." + Environment.NewLine + "The grassy mud beneath your boots is squishy and tough to navigate.", null, null, null, null, false);
            wetlands.MonsterLivingHere = MonsterByID(MONSTER_ID_WINGED_BOAR);

            Location spiderNest = new Location(LOCATION_ID_SPIDER_NEST, "Spider Nest", "As you enter the next area, you find it filled with even more webs." + Environment.NewLine + "Giant spiders are crawling all over the place!", null, null, null, null, false);
            spiderNest.MonsterLivingHere = MonsterByID(MONSTER_ID_GREATER_SPIDER);

            //Actually adds locations to the map. Locations to the north of the player's current location are labeled LocationToNorth, etc.
            home.LocationToNorth = townSquare;
            home.LocationToSouth = marketStreet1;

            townSquare.LocationToNorth = alchemistHut;
            townSquare.LocationToSouth = home;
            townSquare.LocationToEast = guardPost;
            townSquare.LocationToWest = farmhouse;

            farmhouse.LocationToEast = townSquare;
            farmhouse.LocationToWest = field2;

            field1.LocationToSouth = field2;

            field2.LocationToEast = farmhouse;
            field2.LocationToNorth = field1;
            field2.LocationToSouth = field3;

            field3.LocationToNorth = field2;

            alchemistHut.LocationToSouth = townSquare;
            alchemistHut.LocationToNorth = alchemistGarden;

            alchemistGarden.LocationToSouth = alchemistHut;

            guardPost.LocationToEast = bridge;
            guardPost.LocationToWest = townSquare;

            bridge.LocationToWest = guardPost;
            bridge.LocationToEast = spiderField;

            spiderField.LocationToWest = bridge;
            spiderField.LocationToEast = forestClearing;
            spiderField.LocationToNorth = spiderNest;

            spiderNest.LocationToSouth = spiderField;

            forestClearing.LocationToWest = spiderField;
            forestClearing.LocationToEast = deepWoods;
            forestClearing.LocationToNorth = wetlands;

            wetlands.LocationToSouth = forestClearing;

            deepWoods.LocationToWest = forestClearing;
            deepWoods.LocationToNorth = scribesTower;
            deepWoods.LocationToEast = rockyPath;
            deepWoods.LocationToSouth = batCave;

            scribesTower.LocationToSouth = deepWoods;
            scribesTower.LocationToNorth = scribesRoom;

            scribesRoom.LocationToSouth = scribesTower;

            rockyPath.LocationToWest = deepWoods;
            rockyPath.LocationToEast = mountainGate;

            mountainGate.LocationToWest = rockyPath;
            mountainGate.LocationToEast = rockySummit;

            rockySummit.LocationToWest = mountainGate;

            batCave.LocationToNorth = deepWoods;
            batCave.LocationToEast = deepCave;

            deepCave.LocationToEast = darkZone;
            deepCave.LocationToWest = batCave;

            darkZone.LocationToWest = deepCave;

            marketStreet1.LocationToNorth = home;
            marketStreet1.LocationToEast = chef;
            marketStreet1.LocationToWest = clothier;
            marketStreet1.LocationToSouth = marketStreet2;

            chef.LocationToWest = marketStreet1;

            clothier.LocationToEast = marketStreet1;

            marketStreet2.LocationToNorth = marketStreet1;
            marketStreet2.LocationToWest = warrior;
            marketStreet2.LocationToEast = mage;
            marketStreet2.LocationToSouth = oceansideDunes;

            warrior.LocationToEast = marketStreet2;

            mage.LocationToWest = marketStreet2;

            oceansideDunes.LocationToNorth = marketStreet2;
            oceansideDunes.LocationToSouth = beach;
            oceansideDunes.LocationToEast = armorer;
            oceansideDunes.LocationToWest = jeweler;

            jeweler.LocationToEast = oceansideDunes;

            armorer.LocationToWest = oceansideDunes;

            beach.LocationToNorth = oceansideDunes;
            beach.LocationToEast = tidePools;
            beach.LocationToSouth = shallowReef;
            beach.LocationToWest = jetty;

            tidePools.LocationToWest = beach;

            jetty.LocationToEast = beach;

            shallowReef.LocationToNorth = beach;

            //And finally, adds locations to the world.
            Locations.Add(home);
            Locations.Add(townSquare);
            Locations.Add(guardPost);
            Locations.Add(alchemistHut);
            Locations.Add(alchemistGarden);
            Locations.Add(farmhouse);
            Locations.Add(field1);
            Locations.Add(field2);
            Locations.Add(field3);
            Locations.Add(bridge);
            Locations.Add(spiderField);
            Locations.Add(spiderNest);
            Locations.Add(deepWoods);
            Locations.Add(scribesTower);
            Locations.Add(scribesRoom);
            Locations.Add(batCave);
            Locations.Add(deepCave);
            Locations.Add(darkZone);
            Locations.Add(rockyPath);
            Locations.Add(mountainGate);
            Locations.Add(rockySummit);
            Locations.Add(forestClearing);
            Locations.Add(wetlands);
            Locations.Add(marketStreet1);
            Locations.Add(marketStreet2);
            Locations.Add(clothier);
            Locations.Add(chef);
            Locations.Add(warrior);
            Locations.Add(mage);
            Locations.Add(jeweler);
            Locations.Add(armorer);
            Locations.Add(oceansideDunes);
            Locations.Add(beach);
            Locations.Add(jetty);
            Locations.Add(tidePools);
            Locations.Add(shallowReef);
        }

        //
        //MISC
        //

        //ID system
        public static Item ItemByID(int id)
        {
            foreach(Item item in Items)
            {
                if(item.ID == id)
                {
                    return item;
                }
            } return null;
        }

        public static Monster MonsterByID(int id)
        {
            foreach(Monster monster in Monsters)
            {
                if(monster.ID == id)
                {
                    return monster;
                }
            } return null;
        }

        public static Quest QuestByID(int id)
        {
            foreach(Quest quest in Quests)
            {
                if(quest.ID == id)
                {
                    return quest;
                }
            } return null;
        }

        public static Location LocationByID(int id)
        {
            foreach(Location location in Locations)
            {
                if(location.ID == id)
                {
                    return location;
                }
            } return null;
        }
    }
}
