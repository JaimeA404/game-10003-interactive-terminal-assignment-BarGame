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
            Console.WriteLine("Who do you serve first? (Jerry/Millie/Mrs. Gabriel)");
            string customer = Console.ReadLine();

            if (customer.ToLower() == "jerry")
            {
                Console.WriteLine("");
                Console.WriteLine("Collect the ingredients for his cactus milkshake with battery acid.");
                Console.WriteLine("[Chocolate Syrup] [Potted Cactus] [Egg Shells] [Pencil Shavings]");
                Console.WriteLine("[Battery Acid] [Toothpaste] [Soda Water] [Vinegar] [Ice Cream]");
                Console.WriteLine("[Green Paint] [Armpit Hair] [Shaving Cream] [Milk]");
                Console.WriteLine("");
                Console.WriteLine("Select the correct ingredients (separate with commas):");

                string jerryingredients = Console.ReadLine();

                // ✅ Strict boolean: must match exactly
                bool jerrydrinkcorrect = jerryingredients.ToLower() == "potted cactus, battery acid, ice cream, milk";

                if (jerrydrinkcorrect)
                {
                    Console.WriteLine("");
                    Console.WriteLine("You served Jerry his milkshake.");
                    Console.WriteLine("Jerry: Ah, just like how mama used to make it.");
                    Console.WriteLine("");
                    Console.WriteLine("Who will you serve now? (Millie/Mrs. Gabriel)");
                }
                else
                {
                    Console.WriteLine("");
                    Console.WriteLine("Jerry: This isn't right... I'm leaving!");
                }
            }
        }
        else if (answer.ToLower() == "no") // ✅ now in the right place
        {
            Console.WriteLine("Your boss won't like this");
            Console.WriteLine("Boss: You're fired!");
        }
    }
}
