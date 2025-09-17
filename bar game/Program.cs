using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("It's almost time to open the restaurant. Are you ready to work at the bar? (yes/no)");
        string answer = Console.ReadLine();

        if (answer.ToLower() == "yes")
        {
            Console.WriteLine("");
            Console.WriteLine("It's pay day, work your hardest");
            Console.WriteLine("");
            Console.WriteLine("Three customers walk in and sit at the bar.");
            Console.WriteLine("");
            Console.WriteLine("Jerry: I'll have a cactus milkshake with battery acid.");
            Console.WriteLine("Millie: I want a pint of your finest garbage juice.");
            Console.WriteLine("Mrs. Gabriel: I'll have a glass of water with lots of ice.");
            Console.WriteLine("(Jerry and Millie are complete strangers to you)");
            Console.WriteLine("(But Mrs. Gabriel was your teacher in high school who you never liked)");
            Console.WriteLine("(She always gave you the lowest grades in the class despite all your efforts)");
            Console.WriteLine("");

            Console.WriteLine("Who do you serve first?");
            Console.WriteLine("");
            Console.WriteLine("1. Jerry");
            Console.WriteLine("2. Millie");
            Console.WriteLine("3. Mrs. Gabriel");

            // Player can pick who to serve first
            int customerServed = int.Parse(Console.ReadLine());

            // Jerry
            if (customerServed == 1)
            {
                Console.WriteLine("");
                Console.WriteLine("Collect the ingredients for Jerry's cactus milkshake with battery acid.");
                Console.WriteLine("");
                Console.WriteLine("[Chocolate Syrup] [Potted Cactus] [Egg Shells] [Pencil Shavings]");
                Console.WriteLine("[Battery Acid] [Toothpaste] [Soda Water] [Vinegar] [Ice Cream]");
                Console.WriteLine("[Green Paint] [Armpit Hair] [Shaving Cream] [Milk]");
                Console.WriteLine("");
                Console.WriteLine("Select the correct ingredients (separate with commas):");

                string jerryIngredients = Console.ReadLine();
                bool jerryDrinkCorrect = jerryIngredients.ToLower() == "potted cactus, battery acid, ice cream, milk";

                if (jerryDrinkCorrect)
                {
                    Console.WriteLine("");
                    Console.WriteLine("You served Jerry his milkshake.");
                    Console.WriteLine("Jerry: Ah, just like how mama used to make it.");
                    Console.WriteLine("");
                    Console.WriteLine("Who will you serve now?");
                    Console.WriteLine("");
                    Console.WriteLine("2. Millie");
                    Console.WriteLine("3. Mrs. Gabriel");

                    customerServed = int.Parse(Console.ReadLine());

                    if (customerServed == 2)
                    {
                        // Millie after Jerry
                        Console.WriteLine("");
                        Console.WriteLine("Collect the ingredients for Millie's garbage juice.");
                        Console.WriteLine("");
                        Console.WriteLine("[Banana Peel] [Orange Puree] [Pineapple Juice] [Candy]");
                        Console.WriteLine("[Hand Sanitizer] [Used Socks] [Cup of Pee] [Cheese]");
                        Console.WriteLine("[Snotty Tissue] [Garbage Water] [Strawberries] [Vomit]");
                        Console.WriteLine("");
                        Console.WriteLine("Select the correct ingredients (separate with commas):");

                        string millieIngredients = Console.ReadLine();
                        bool millieDrinkCorrect = millieIngredients.ToLower() == "banana peel, used socks, cup of pee, snotty tissue, garbage water, vomit";

                        if (millieDrinkCorrect)
                        {
                            Console.WriteLine("");
                            Console.WriteLine("You served Millie her garbage juice.");
                            Console.WriteLine("Millie: This is the best garbage juice I've ever had!");
                            Console.WriteLine("");
                            Console.WriteLine("Only Mrs. Gabriel is left to serve.");
                            Console.WriteLine("");
                            Console.WriteLine("Collect the ingredients for Mrs. Gabriel's glass of water with lots of ice.");
                            Console.WriteLine("");
                            Console.WriteLine("      [Ice Cubes]                  [Tap Water]     ");
                            Console.WriteLine("");
                            Console.WriteLine("                      [Poison]                     ");
                            Console.WriteLine("");
                            Console.WriteLine("Select the correct ingredients (separate with commas):");

                            string gabrielIngredients = Console.ReadLine();
                            bool gabrielDrinkPoisoned = gabrielIngredients.ToLower() == "ice cubes, tap water, poison";

                            if (gabrielDrinkPoisoned)
                            {
                                Console.WriteLine("");
                                Console.WriteLine("You served Mrs. Gabriel her glass of water with lots of ice.");
                                Console.WriteLine("Mrs. Gabriel: This water tastes funny...");
                                Console.WriteLine("Mrs. Gabriel suddenly collapses to the floor.");
                                Console.WriteLine("");
                                Console.WriteLine("You poisoned your high school teacher who you never liked.");
                                Console.WriteLine("The crowd builds up around her.");
                                Console.WriteLine("It didn't take long for the police to show up");
                                Console.WriteLine("You were arrested for poisoning Mrs. Gabriel.");
                                Console.WriteLine("But in your world, you don't care because you never liked her.");
                                Console.WriteLine("");
                                Console.WriteLine("You win!");
                            }
                            else
                            {
                                Console.WriteLine("");
                                Console.WriteLine("You served Mrs. Gabriel her glass of water with lots of ice.");
                                Console.WriteLine("Mrs. Gabriel: This water is too cold!");
                                Console.WriteLine("");
                                Console.WriteLine("Ungrateful b!#*h");
                                Console.WriteLine("You are unsatisfied.");
                                Console.WriteLine("");
                                Console.WriteLine("You . . .");
                                Console.WriteLine("Win?");
                            }
                        }
                        else
                        {
                            Console.WriteLine("");
                            Console.WriteLine("Millie: Something's missing... I'm Leaving!");
                        }
                    }
                    else
                    {
                        // Mrs. Gabriel after Jerry
                        Console.WriteLine("");
                        Console.WriteLine("Collect the ingredients for Mrs. Gabriel's glass of water with lots of ice.");
                        Console.WriteLine("");
                        Console.WriteLine("      [Ice Cubes]                  [Tap Water]     ");
                        Console.WriteLine("");
                        Console.WriteLine("                      [Poison]                     ");
                        Console.WriteLine("");
                        Console.WriteLine("Select the correct ingredients (separate with commas):");

                        string gabrielIngredients = Console.ReadLine();
                        bool gabrielDrinkPoisoned = gabrielIngredients.ToLower() == "ice cubes, tap water, poison";

                        if (gabrielDrinkPoisoned)
                        {
                            Console.WriteLine("");
                            Console.WriteLine("You poisoned Mrs. Gabriel...");
                            Console.WriteLine("Mrs. Gabriel: This water tastes funny...");
                            Console.WriteLine("Mrs. Gabriel suddenly collapses to the floor.");
                            Console.WriteLine("");
                            Console.WriteLine("You poisoned your high school teacher who you never liked.");
                            Console.WriteLine("The crowd builds up around her.");
                            Console.WriteLine("It didn't take long for the police to show up");
                            Console.WriteLine("You were arrested for poisoning Mrs. Gabriel.");
                            Console.WriteLine("But in your world, you don't care because you never liked her.");
                            Console.WriteLine("");
                            Console.WriteLine("You win!");
                        }
                        else
                        {
                            Console.WriteLine("");
                            Console.WriteLine("You served Mrs. Gabriel some regular water.");
                            Console.WriteLine("");
                            Console.WriteLine("Mrs. Gabriel: This water is too cold!");
                            Console.WriteLine("Ungrateful b!#*h");
                            Console.WriteLine("You are unsatisfied.");
                            Console.WriteLine("");
                            Console.WriteLine("It's just Millie now");
                            Console.WriteLine("");
                            Console.WriteLine("Collect the ingredients for her garbage juice.");
                            Console.WriteLine("");
                            Console.WriteLine("[Banana Peel] [Orange Puree] [Pineapple Juice] [Candy]");
                            Console.WriteLine("[Hand Sanitizer] [Used Socks] [Cup of Pee] [Cheese]");
                            Console.WriteLine("[Snotty Tissue] [Garbage Water] [Strawberries] [Vomit]");
                            Console.WriteLine("");
                            Console.WriteLine("Select the correct ingredients (separate with commas):");

                            string millieIngredients1 = Console.ReadLine();
                            bool millieDrinkCorrect1 = millieIngredients1.ToLower() == "banana peel, used socks, cup of pee, snotty tissue, garbage water, vomit";

                            if (millieDrinkCorrect1)
                            {
                                Console.WriteLine("");
                                Console.WriteLine("You served Millie her garbage juice.");
                                Console.WriteLine("Millie: This is the best garbage juice I've ever had!");
                                Console.WriteLine("");
                                Console.WriteLine("You win I guess?");
                            }
                            else
                            {
                                Console.WriteLine("");
                                Console.WriteLine("Millie: Something's missing... I'm Leaving!");
                            }
                        }
                    }
                }
            }
            // Millie
            else if (customerServed == 2)
            {
                Console.WriteLine("");
                Console.WriteLine("Collect the ingredients for her garbage juice.");
                Console.WriteLine("");
                Console.WriteLine("[Banana Peel] [Orange Puree] [Pineapple Juice] [Candy]");
                Console.WriteLine("[Hand Sanitizer] [Used Socks] [Cup of Pee] [Cheese]");
                Console.WriteLine("[Snotty Tissue] [Garbage Water] [Strawberries] [Vomit]");
                Console.WriteLine("");
                Console.WriteLine("Select the correct ingredients (separate with commas):");

                string millieIngredients2 = Console.ReadLine();
                bool millieDrinkCorrect2 = millieIngredients2.ToLower() == "banana peel, used socks, cup of pee, snotty tissue, garbage water, vomit";

                if (millieDrinkCorrect2)
                {
                    Console.WriteLine("");
                    Console.WriteLine("You served Millie her garbage juice.");
                    Console.WriteLine("Millie: This is the best garbage juice I've ever had!");
                    Console.WriteLine("");
                    Console.WriteLine("Who will you serve now?");
                    Console.WriteLine("");
                    Console.WriteLine("1. Jerry");
                    Console.WriteLine("3. Mrs. Gabriel");

                    customerServed = int.Parse(Console.ReadLine());

                    if (customerServed == 1)
                    {
                        // Jerry after Millie
                        Console.WriteLine("");
                        Console.WriteLine("Collect the ingredients for Jerry's cactus milkshake with battery acid.");
                        Console.WriteLine("");
                        Console.WriteLine("[Chocolate Syrup] [Potted Cactus] [Egg Shells] [Pencil Shavings]");
                        Console.WriteLine("[Battery Acid] [Toothpaste] [Soda Water] [Vinegar] [Ice Cream]");
                        Console.WriteLine("[Green Paint] [Armpit Hair] [Shaving Cream] [Milk]");
                        Console.WriteLine("");
                        Console.WriteLine("Select the correct ingredients (separate with commas):");

                        string jerryIngredients2 = Console.ReadLine();
                        bool jerryDrinkCorrect2 = jerryIngredients2.ToLower() == "potted cactus, battery acid, ice cream, milk";

                        if (jerryDrinkCorrect2)
                        {
                            Console.WriteLine("");
                            Console.WriteLine("You served Jerry his milkshake.");
                            Console.WriteLine("Jerry: Ah, just like how mama used to make it.");
                            Console.WriteLine("");
                            Console.WriteLine("Only Mrs. Gabriel is left to serve.");
                            Console.WriteLine("");
                            Console.WriteLine("Collect the ingredients for Mrs. Gabriel's glass of water with lots of ice.");
                            Console.WriteLine("");
                            Console.WriteLine("      [Ice Cubes]                  [Tap Water]     ");
                            Console.WriteLine("");
                            Console.WriteLine("                      [Poison]                     ");
                            Console.WriteLine("");
                            Console.WriteLine("Select the correct ingredients (separate with commas):");

                            string gabrielIngredients2 = Console.ReadLine();
                            bool gabrielDrinkPoisoned2 = gabrielIngredients2.ToLower() == "ice cubes, tap water, poison";

                            if (gabrielDrinkPoisoned2)
                            {
                                Console.WriteLine("");
                                Console.WriteLine("You served Mrs. Gabriel her glass of water with lots of ice.");
                                Console.WriteLine("Mrs. Gabriel: This water tastes funny...");
                                Console.WriteLine("Mrs. Gabriel suddenly collapses to the floor.");
                                Console.WriteLine("");
                                Console.WriteLine("You poisoned your high school teacher who you never liked.");
                                Console.WriteLine("The crowd builds up around her.");
                                Console.WriteLine("It didn't take long for the police to show up");
                                Console.WriteLine("You were arrested for poisoning Mrs. Gabriel.");
                                Console.WriteLine("But in your world, you don't care because you never liked her.");
                                Console.WriteLine("");
                                Console.WriteLine("You win!");
                                Console.WriteLine("Kinda");
                            }
                            else
                            {
                                Console.WriteLine("");
                                Console.WriteLine("You served Mrs. Gabriel her glass of water with lots of ice.");
                                Console.WriteLine("Mrs. Gabriel: This water is too cold!");
                                Console.WriteLine("");
                                Console.WriteLine("Ungrateful b!#*h");
                                Console.WriteLine("You are unsatisfied.");
                                Console.WriteLine("");
                                Console.WriteLine("You . . .");
                                Console.WriteLine("Win?");
                            }
                        }
                        else
                        {
                            Console.WriteLine("");
                            Console.WriteLine("Jerry: This isn't right... I'm leaving!");
                        }
                    }
                    else if (customerServed == 3)
                    {
                        // Mrs. Gabriel after Millie
                        Console.WriteLine("");
                        Console.WriteLine("Collect the ingredients for Mrs. Gabriel's glass of water with lots of ice.");
                        Console.WriteLine("");
                        Console.WriteLine("      [Ice Cubes]                  [Tap Water]     ");
                        Console.WriteLine("");
                        Console.WriteLine("                      [Poison]                     ");
                        Console.WriteLine("");
                        Console.WriteLine("Select the correct ingredients (separate with commas):");

                        string gabrielIngredients2 = Console.ReadLine();
                        bool gabrielDrinkPoisoned2 = gabrielIngredients2.ToLower() == "ice cubes, tap water, poison";

                        if (gabrielDrinkPoisoned2)
                        {
                            Console.WriteLine("");
                            Console.WriteLine("You poisoned Mrs. Gabriel right away...");
                            Console.WriteLine("Mrs. Gabriel: This water tastes funny...");
                            Console.WriteLine("Mrs. Gabriel suddenly collapses to the floor.");
                            Console.WriteLine("");
                            Console.WriteLine("You poisoned your high school teacher who you never liked.");
                            Console.WriteLine("The crowd builds up around her.");
                            Console.WriteLine("It didn't take long for the police to arrive");
                            Console.WriteLine("You were arrested for poisoning Mrs. Gabriel");
                            Console.WriteLine("But in your world, you don't care because you never liked her");
                            Console.WriteLine("");
                            Console.WriteLine("You won in your heart.");
                            Console.WriteLine("But you're a convicted criminal now");
                            Console.WriteLine("");
                            Console.WriteLine("You Win!");
                            Console.WriteLine("Kinda");
                        }
                        else
                        {
                            Console.WriteLine("");
                            Console.WriteLine("You served Mrs. Gabriel some regular water.");
                            Console.WriteLine("");
                            Console.WriteLine("Mrs. Gabriel: This water is too cold!");
                            Console.WriteLine("Ungrateful b!#*h");
                            Console.WriteLine("You are unsatisfied.");
                            Console.WriteLine("");
                            Console.WriteLine("It's just Jerry now");
                            Console.WriteLine("");
                            Console.WriteLine("Collect the ingredients for Jerry's cactus milkshake with battery acid.");
                            Console.WriteLine("");
                            Console.WriteLine("[Chocolate Syrup] [Potted Cactus] [Egg Shells] [Pencil Shavings]");
                            Console.WriteLine("[Battery Acid] [Toothpaste] [Soda Water] [Vinegar] [Ice Cream]");
                            Console.WriteLine("[Green Paint] [Armpit Hair] [Shaving Cream] [Milk]");
                            Console.WriteLine("");
                            Console.WriteLine("Select the correct ingredients (separate with commas):");

                            string jerryIngredients2 = Console.ReadLine();
                            bool jerryDrinkCorrect2 = jerryIngredients2.ToLower() == "potted cactus, battery acid, ice cream, milk";

                            if (jerryDrinkCorrect2)
                            {
                                Console.WriteLine("");
                                Console.WriteLine("You served Jerry his milkshake.");
                                Console.WriteLine("Jerry: Ah, just like how mama used to make it.");
                                Console.WriteLine("");
                                Console.WriteLine("You win I guess?");
                            }
                            else
                            {
                                Console.WriteLine("");
                                Console.WriteLine("Jerry: This isn't right... I'm leaving!");
                            }
                        }
                    }
                }
                else
                {
                    Console.WriteLine("");
                    Console.WriteLine("Millie: Something's missing... I'm Leaving!");
                }
            }
            // Mrs. Gabriel first
            else if (customerServed == 3)
            {
                Console.WriteLine("");
                Console.WriteLine("Collect the ingredients for Mrs. Gabriel's glass of water with lots of ice.");
                Console.WriteLine("");
                Console.WriteLine("      [Ice Cubes]                  [Tap Water]     ");
                Console.WriteLine("");
                Console.WriteLine("                      [Poison]                     ");
                Console.WriteLine("");
                Console.WriteLine("Select the correct ingredients (separate with commas):");

                string gabrielIngredients3 = Console.ReadLine();
                bool gabrielDrinkPoisoned3 = gabrielIngredients3.ToLower() == "ice cubes, tap water, poison";

                if (gabrielDrinkPoisoned3)
                {
                    Console.WriteLine("");
                    Console.WriteLine("You poisoned Mrs. Gabriel right away...");
                    Console.WriteLine("Mrs. Gabriel: This water tastes funny...");
                    Console.WriteLine("Mrs. Gabriel suddenly collapses to the floor.");
                    Console.WriteLine("");
                    Console.WriteLine("You poisoned your high school teacher who you never liked.");
                    Console.WriteLine("The crowd builds up around her.");
                    Console.WriteLine("It didn't take long for the police to arrive");
                    Console.WriteLine("You were arrested for poisoning Mrs. Gabriel");
                    Console.WriteLine("But in your world, you don't care because you never liked her");
                    Console.WriteLine("");
                    Console.WriteLine("You won in your heart.");
                    Console.WriteLine("But you're a convicted criminal now");
                    Console.WriteLine("");
                    Console.WriteLine("You Win!");
                    Console.WriteLine("Kinda");
                }
                else
                {
                    Console.WriteLine("");
                    Console.WriteLine("You served Mrs. Gabriel some regular water.");
                    Console.WriteLine("");
                    Console.WriteLine("Mrs. Gabriel: This water is too cold!");
                    Console.WriteLine("Ungrateful b!#*h");
                    Console.WriteLine("You are unsatisfied.");
                    Console.WriteLine("");
                    Console.WriteLine("Who will you serve now?");
                    Console.WriteLine("");
                    Console.WriteLine("1. Jerry");
                    Console.WriteLine("2. Millie");

                    customerServed = int.Parse(Console.ReadLine());

                    if (customerServed == 1)
                    {
                        // Jerry after Mrs. Gabriel
                        Console.WriteLine("");
                        Console.WriteLine("Collect the ingredients for Jerry's cactus milkshake with battery acid.");
                        Console.WriteLine("");
                        Console.WriteLine("[Chocolate Syrup] [Potted Cactus] [Egg Shells] [Pencil Shavings]");
                        Console.WriteLine("[Battery Acid] [Toothpaste] [Soda Water] [Vinegar] [Ice Cream]");
                        Console.WriteLine("[Green Paint] [Armpit Hair] [Shaving Cream] [Milk]");
                        Console.WriteLine("");
                        Console.WriteLine("Select the correct ingredients (separate with commas):");

                        string jerryIngredients3 = Console.ReadLine();
                        bool jerryDrinkCorrect3 = jerryIngredients3.ToLower() == "potted cactus, battery acid, ice cream, milk";

                        if (jerryDrinkCorrect3)
                        {
                            Console.WriteLine("");
                            Console.WriteLine("You served Jerry his milkshake.");
                            Console.WriteLine("Jerry: Ah, just like how mama used to make it.");
                            Console.WriteLine("");
                            Console.WriteLine("Only Millie is left to serve.");
                            // Millie last
                            Console.WriteLine("");
                            Console.WriteLine("Collect the ingredients for Millie's garbage juice.");
                            Console.WriteLine("");
                            Console.WriteLine("[Banana Peel] [Orange Puree] [Pineapple Juice] [Candy]");
                            Console.WriteLine("[Hand Sanitizer] [Used Socks] [Cup of Pee] [Cheese]");
                            Console.WriteLine("[Snotty Tissue] [Garbage Water] [Strawberries] [Vomit]");
                            Console.WriteLine("");
                            Console.WriteLine("Select the correct ingredients (separate with commas):");

                            string millieIngredients3 = Console.ReadLine();
                            bool millieDrinkCorrect3 = millieIngredients3.ToLower() == "banana peel, used socks, cup of pee, snotty tissue, garbage water, vomit";

                            if (millieDrinkCorrect3)
                            {
                                Console.WriteLine("");
                                Console.WriteLine("You served Millie her garbage juice.");
                                Console.WriteLine("Millie: This is the best garbage juice I've ever had!");
                                Console.WriteLine("");
                                Console.WriteLine("You win I guess?");
                            }
                            else
                            {
                                Console.WriteLine("");
                                Console.WriteLine("Millie: Something's missing... I'm Leaving!");
                            }
                        }
                        else
                        {
                            Console.WriteLine("");
                            Console.WriteLine("Jerry: This isn't right... I'm leaving!");
                        }
                    }
                    else if (customerServed == 2)
                    {
                        // Millie after Mrs. Gabriel
                        Console.WriteLine("");
                        Console.WriteLine("Collect the ingredients for Millie's garbage juice.");
                        Console.WriteLine("");
                        Console.WriteLine("[Banana Peel] [Orange Puree] [Pineapple Juice] [Candy]");
                        Console.WriteLine("[Hand Sanitizer] [Used Socks] [Cup of Pee] [Cheese]");
                        Console.WriteLine("[Snotty Tissue] [Garbage Water] [Strawberries] [Vomit]");
                        Console.WriteLine("");
                        Console.WriteLine("Select the correct ingredients (separate with commas):");

                        string millieIngredients3 = Console.ReadLine();
                        bool millieDrinkCorrect3 = millieIngredients3.ToLower() == "banana peel, used socks, cup of pee, snotty tissue, garbage water, vomit";

                        if (millieDrinkCorrect3)
                        {
                            Console.WriteLine("");
                            Console.WriteLine("You served Millie her garbage juice.");
                            Console.WriteLine("Millie: This is the best garbage juice I've ever had!");
                            Console.WriteLine("");
                            Console.WriteLine("Only Jerry is left to serve.");
                            // Jerry last
                            Console.WriteLine("");
                            Console.WriteLine("Collect the ingredients for Jerry's cactus milkshake with battery acid.");
                            Console.WriteLine("");
                            Console.WriteLine("[Chocolate Syrup] [Potted Cactus] [Egg Shells] [Pencil Shavings]");
                            Console.WriteLine("[Battery Acid] [Toothpaste] [Soda Water] [Vinegar] [Ice Cream]");
                            Console.WriteLine("[Green Paint] [Armpit Hair] [Shaving Cream] [Milk]");
                            Console.WriteLine("");
                            Console.WriteLine("Select the correct ingredients (separate with commas):");

                            string jerryIngredients3 = Console.ReadLine();
                            bool jerryDrinkCorrect3 = jerryIngredients3.ToLower() == "potted cactus, battery acid, ice cream, milk";

                            if (jerryDrinkCorrect3)
                            {
                                Console.WriteLine("");
                                Console.WriteLine("You served Jerry his milkshake.");
                                Console.WriteLine("Jerry: Ah, just like how mama used to make it.");
                                Console.WriteLine("");
                                Console.WriteLine("You win I guess?");
                            }
                            else
                            {
                                Console.WriteLine("");
                                Console.WriteLine("Jerry: This isn't right... I'm leaving!");
                            }
                        }
                        else
                        {
                            Console.WriteLine("");
                            Console.WriteLine("Millie: Something's missing... I'm Leaving!");
                        }
                    }
                }
            }
        }
        else if (answer.ToLower() == "no")
        {
            Console.WriteLine("Your boss won't like this");
            Console.WriteLine("Boss: You're fired!");
        }
    }
}
