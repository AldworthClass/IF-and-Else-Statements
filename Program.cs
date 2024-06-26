﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IF_and_Else_Statements
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("5.2 Task 1 - Multiple Choice");
            Console.WriteLine("-------------------------");
            Task1MultipleChoice();
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("5.2 Task 1 - The State of Water");
            Console.WriteLine("-------------------------");
            Task2WaterState();
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("5.2 Task 3 - How Old Are You? Revisited");
            Console.WriteLine("----------------------------");
            Task3HowOldAreYouRevisited();
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Press ENTER to finish");
            Console.ReadLine();
        }

        // Task 1 - Weekday
        public static void Task1MultipleChoice()
        {
            string choice;
            Console.WriteLine("Who is the greatest Starship Captain?");
            Console.WriteLine("a - Captain James Kirk                b - Captain Crunch");
            Console.WriteLine("c - Captain Jean Luc Picard           d - Captain Han Solo");
            Console.WriteLine();
            Console.Write(">>");
            choice = Console.ReadLine().ToLower();  //  You can convert to lowercase so it is not case sensitive.
            Console.WriteLine();
            if (choice == "a")
            {
                Console.WriteLine("Good guess, but Kirk is no Picard.");
            }
            else if (choice == "b")
            {
                Console.WriteLine("I said starship captain!  Althoguh he does make an good cereal.");
            }
            else if (choice == "c")
            {
                Console.WriteLine("This is the only correct answer.");
            }
            else if (choice == "d")
            {
                Console.WriteLine("Being in charge of a single wookie doesn't make you a great captain.");
            }
            else
            {
                Console.WriteLine("You have made an invalid selection.  To the brig...");
            }


        }
        // 5.2 Task 2 - The State of Water
        public static void Task2WaterState()
        {
            int temp;
            Console.WriteLine("Please enter the temperature of the H2O: ");
            if (int.TryParse(Console.ReadLine(), out temp))
            {
                if (temp <= 0)
                    Console.WriteLine("You have a solid.");
                else if (temp < 100)
                    Console.WriteLine("You have liquid!");
                else
                    Console.WriteLine("You have gas!");
            }
            else
            {
                Console.WriteLine("Invalid input");
            }
        }


        // 5.2 Task 3 - How Old Are You Revisited
        public static void Task3HowOldAreYouRevisited()
        {
            string name;
            int age;
            Console.Write("Hey, what's your name? ");
            name = Console.ReadLine();
            Console.WriteLine();
            Console.Write("Ok, " + name + ", how old are you?  ");
            if (int.TryParse(Console.ReadLine(), out age))  // Verifies numeric input
            {
                Console.WriteLine();
                if (age < 0)
                {
                    Console.WriteLine("I didn't know fetuses could use a computer!");
                }
                else if (age < 16)
                {
                    Console.WriteLine("You can't drive.");
                }
                else if (age < 18)
                {
                    Console.WriteLine("You can't vote.");
                }
                else if (age < 25)
                {
                    Console.WriteLine("You can't rent a car.");
                }
                else
                {
                    Console.WriteLine("You can do anything that is legal.");
                }
            }
            else
            {
                Console.WriteLine("Invalid Numeric Input");
            }
            
        }

    }
}
