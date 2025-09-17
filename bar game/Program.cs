using System;
using System.ComponentModel.Design;

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

            //character who player roleplays as has bad history with Mrs. Gabriel
            //bad history will be brought up later in the game

            Console.WriteLine("");
            Console.WriteLine("Who do you serve first?");
            Console.WriteLine("");
            Console.WriteLine("1. Jerry");
            Console.WriteLine("2. Millie");
            Console.WriteLine("3. Mrs. Gabriel");
            int customerServed = int.Parse(Console.ReadLine());

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

                //player must choose the correct ingredients in the right sequence

                bool jerryDrinkcorrect = jerryIngredients.ToLower() == "potted cactus, battery acid, ice cream, milk";

                if (jerryDrinkcorrect)
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
                        Console.WriteLine("");
                        Console.WriteLine("Collect the ingredients for Millie's garbage juice.");
                        Console.WriteLine("");
                        Console.WriteLine("[Banana Peel] [Orange Puree] [Pineapple Juice] [Candy]");
                        Console.WriteLine("[Hand Sanitizer] [Used Socks] [Cup of Pee] [Cheese]");
                        Console.WriteLine("Snotty Tissue] [Garbage Water] [Stawberries] [Vomit]");
                        Console.WriteLine("");
                        Console.WriteLine("Select the correct ingredients (separate with commas):");

                        string millieIngredients = Console.ReadLine();

                        bool millieDrinkcorrect = millieIngredients.ToLower() == "banana peel, used socks, cup of pee, snotty tissue, garbage water, vomit";

                        if (millieDrinkcorrect)
                        {
                            Console.WriteLine("");
                            Console.WriteLine("you served Millie her garbage juice.");
                            Console.WriteLine("Millie: This is the best garbage juice I've ever had!");
                            Console.WriteLine("");
                            Console.WriteLine("Only Mrs. Gabriel is left to serve.");
                            Console.WriteLine("");
                            Console.WriteLine("Collect the ingredients for Mrs. Gabriel's glass of water with lots of ice.");
                            Console.WriteLine("");
                            Console.WriteLine("      [Ice Cubes]                  [Tap Water]     ");
                            Console.WriteLine("");
                            Console.WriteLine("");
                            Console.WriteLine("");
                            Console.WriteLine("                      [Poison]                     ");
                            Console.WriteLine("");
                            Console.WriteLine("");
                            Console.WriteLine("Select the correct ingredients (separate with commas):");
                            string gabrielIngredients = Console.ReadLine();

                            bool gabrieldrinkPoisoned = gabrielIngredients.ToLower() == "ice cubes, tap water, poison";

                            if (gabrieldrinkPoisoned)
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
                        Console.WriteLine("");
                        Console.WriteLine("Jerry: This isn't right... I'm leaving!");
                    }
                }
                else if (customerServed == 2)
                {
                    Console.WriteLine("");
                    Console.WriteLine("Collect the ingredients for her garbage juice.");
                    Console.WriteLine("");
                    Console.WriteLine("[Banana Peel] [Orange Puree] [Pineapple Juice] [Candy]");
                    Console.WriteLine("[Hand Sanitizer] [Used Socks] [Cup of Pee] [Cheese]");
                    Console.WriteLine("Snotty Tissue] [Garbage Water] [Stawberries] [Vomit]");
                    Console.WriteLine("");
                    Console.WriteLine("Select the correct ingredients (separate with commas):");
                    string millieIngredients2 = Console.ReadLine();
                    bool millieDrinkcorrect2 = millieIngredients2.ToLower() == "banana peel, used socks, cup of pee, snotty tissue, garbage water, vomit";
                    if (millieDrinkcorrect2)
                    {
                        Console.WriteLine("");
                        Console.WriteLine("you served Millie her garbage juice.");
                        Console.WriteLine("Millie: This is the best garbage juice I've ever had!");
                        Console.WriteLine("");
                        Console.WriteLine("Who will you serve now?");
                        Console.WriteLine("");
                        Console.WriteLine("1. Jerry");
                        Console.WriteLine("3. Mrs. Gabriel");
                        customerServed = int.Parse(Console.ReadLine());
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
                            string jerryIngredients2 = Console.ReadLine();
                            bool jerrydrinkCorrect2 = jerryIngredients2.ToLower() == "potted cactus, battery acid, ice cream, milk";
                            if(jerrydrinkCorrect2)
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
                                Console.WriteLine("");
                                Console.WriteLine("                      [Poison]                     ");
                                Console.WriteLine("");
                                Console.WriteLine("");
                                Console.WriteLine("Select the correct ingredients (separate with commas):");
                                string gabrielIngredients2 = Console.ReadLine();
                                bool gabrieldrinkPoisoned2 = gabrielIngredients2.ToLower() == "ice cubes, tap water, poison";
                                if ( gabrieldrinkPoisoned2)
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
                        }

                    }
                    else
                    {
                        Console.WriteLine("");
                        Console.WriteLine("Millie: Something's missing... I'm Leaving!");
                    }
                }
                else if (customerServed == 3)
                {

                }
            }
          
        }
        else if (answer.ToLower() == "no") //finally moved the "no" option to the proper place
        {
            Console.WriteLine("Your boss won't like this");
            Console.WriteLine("Boss: You're fired!");

            //player loses for not playing the game
        }
    }
}
