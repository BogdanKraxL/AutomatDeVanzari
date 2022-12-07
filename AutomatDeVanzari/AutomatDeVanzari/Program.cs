using System;
using System.Data;
using System.Data.SqlTypes;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Text.Json.Serialization.Metadata;

namespace MiculAutomat
{
    class Program 
    {
        static void Main(string[] args)
        {
            int Food = runMenu();
            int Price = retrievePrice(Food);
            int Insert = moneyInserted(Price);
            int Change = changeOut(Insert);
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Thanks for purchasing, have a nice day!");
            Console.ForegroundColor = ConsoleColor.White;
        }
        public static int runMenu()
        {
            int choice = 0;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\n\nPlease enter your selection:" +
                "\n1: Pepsi   \t170" +
                "\n2: Doritoes\t175" +
                "\n3: Snickers\t125" +
                "\n4: Twix    \t120" +
                "\n5: Skittles\t130" +
                "\n6: M&N     \t135\n");

            Console.WriteLine("******************");
                choice = int.Parse(Console.ReadLine());
                Console.WriteLine("******************\n");
            
            while (choice < 1 || choice > 6)
            {
                Console.WriteLine("\n******************");
                Console.WriteLine("Try again.");
                choice = int.Parse(Console.ReadLine());
                Console.WriteLine("******************\n");
            }
            return choice;
        }
        public static int retrievePrice(int menuChoice)
        {
            if (menuChoice == 1)
            {
                return 170;
            }
            if (menuChoice == 2)
            {
                return 175;
            }
            if (menuChoice == 3)
            {
                return 125;
            }
            if (menuChoice == 4)
            {
                return 120;
            }
            if (menuChoice == 5)
            {
                return 130;
            }
            if (menuChoice == 6)
            {
                return 135;
            }
            else
            {
                return 0;
            }
        }
        public static int moneyInserted(int Price)
        {
            int money = 0;
            Console.Write($"Your item costs: {Price}. Please enter the amount of money: ");
            money = int.Parse(Console.ReadLine());
            while (money < Price)
            {
                Console.WriteLine("Please insert sufficient funds. Please Insert more money.");
                money = money + int.Parse(Console.ReadLine());
            }
            return money - Price;
        }
        public static int changeOut(int changing)
        {
            int quarters = 0;
            int dimes = 0;
            int nickels = 0;
            int pennies = 0;
            while (changing >= 25)
            {
                quarters = quarters + 1;
                changing = changing - 25;
            }
            while (changing >= 10)
            {
                dimes = dimes + 1;
                changing = changing - 10;
            }
            while (changing >= 5)
            {
                nickels = nickels + 1;
                changing = changing - 5;
            }
            if (changing < 5)
            {
                pennies = changing;
            }
            Console.WriteLine($"\nYour change is: {quarters} Quarters, {dimes} Dimes, {nickels} Nickels and {pennies} Pennies.");
            return changing;
        }
    }
}