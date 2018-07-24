
using System;

namespace CSharpPartySupplyPlannerConsoleApp
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome To The Party Supply Planner Application");
            Console.WriteLine("I'll first collect the quantity of supplies needed for one person and then the quantity of people attending the party!");
            Console.WriteLine();

            PartyPlanner PartyPlanner = new PartyPlanner();
            Console.WriteLine("What is the quantity needed for one person?");
            PartyPlanner.qtyNeeded = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(("How many people do you plan on having attend the party, if any?"));
            try
            {
                PartyPlanner.peopleAttending = Convert.ToInt32(Console.ReadLine());
            }
            catch
            // I'd imagine there has to be a better way to do this, but after quite a bit of searching I really didn't find much information,
            // so any pointers on how to do this more efficiently would be fantastic! I know that integers cannot be considered null, and doing multiple parse or conversions
            // are frowned upon. This works, but have a feeling theres a much more straightforward way of going about it! Thank you and have a nice day!

            {
                PartyPlanner.peopleAttending = 0;
            }

            if (PartyPlanner.peopleAttending > 0)
            {
                Console.WriteLine();
                Console.WriteLine("The supplies needed for one person: " + PartyPlanner.qtyNeeded);
                Console.WriteLine("Total people attending party: " + PartyPlanner.peopleAttending);
                Console.WriteLine("Total quantity needed: " + PartyPlanner.TotalSupplyCalc());
                Console.WriteLine();
                Console.WriteLine("Press enter to exit");
                Console.ReadLine();
            }
            else Console.WriteLine("A personal party! Thats ok, all you need to order is enough for you! Quantity needed: " + PartyPlanner.qtyNeeded);
            Console.ReadLine();
        }
    }
}