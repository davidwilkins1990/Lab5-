/*
 David Wilkins
 Lab 5 - Dice Rolling
 01/23/18

 This program simulates a dice rolling of a pair of dice
 with the user input of how many sides are on the dice (ie d6 , d20, etc)


 
 */


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    class Program
    {
        public static void roll()
        {
            try
            {
                //RNGesus , creates a new random generator and call .Next() to
                //burn off the first one for a more random roll
                Random random = new Random();
                random.Next();

                Console.WriteLine("*** Dice Rolling ***");
                Console.Write("\nHow many sides on the each die you want to roll?: ");
                int sides = int.Parse(Console.ReadLine());
                Console.Write("Press 'y' to roll the dice or any other key to start over: ");
                string input = Console.ReadLine();
                input = input.ToLower();
                if (input == "y")
                {
                    int die1 = 0;
                    int die2 = 0;
                    int rollTotal = 0;
                    Console.WriteLine("Rolling dice...");
                    die1 = random.Next(1, sides + 1);
                    die2 = random.Next(1, sides + 1);
                    rollTotal = die1 + die2;
                    Console.WriteLine("You rolled a " + die1 + " and a " + die2 + "\nYou rolled a total of: " + rollTotal);
                    if (sides == 6)
                    {
                        if (die1 == 1 && die2 == 1)
                        {
                            Console.WriteLine("You rolled SNAKE EYES!");
                        }
                        else if (die1 == 6 && die2 == 6)
                        {
                            Console.WriteLine("You rolled BOXCARS!");
                        }
                        else if (rollTotal == 2 || rollTotal == 3 || rollTotal == 12)
                        {
                            Console.WriteLine("You rolled CRAPS!");
                        }
                    }
                    Console.WriteLine("\nPress 'y' to play again or any other key to quit.");
                    string again = Console.ReadLine();
                    if (again == "y")
                    {
                        roll();
                    }
                    else
                    {
                        Console.WriteLine("*** Goodbye! ***");
                    }


                }
                else
                {
                    roll();
                }
            }
            catch
            {
                Console.Clear();
                Console.WriteLine("****ERROR: The sides of die must be a whole number. Please try again****");
                roll();
            }

        }
        static void Main(string[] args)
        {
            roll();
            Console.ReadLine();
        }
    }
}
