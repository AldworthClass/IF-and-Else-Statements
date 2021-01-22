using System;
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
            Console.WriteLine("5.2 Task 1 - Weekday");
            Console.WriteLine("-------------------------");
            Task1Weekday();
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("5.2 Task 2 - How Old Are You? Revisited");
            Console.WriteLine("----------------------------");
            Task2HowOldAreYouRevisited();
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Press ENTER to finish");
            Console.ReadLine();
        }


        // This method will accept an integer representing the day of the week, and return a string representation of that day
        public static string WeekdayName(int day)
        {
            string result = "";
            if (day == 1)
            {
                result = "Monday";
            }
            else if (day == 2)
            {
                result = "Tuesday";
            }
            else if (day == 3)
            {
                result = "Wednesday";
            }
            else if (day == 4)
            {
                result = "Thursday";
            }
            else if (day == 5)
            {
                result = "Friday";
            }
            else if (day == 6)
            {
                result = "Saturday";
            }
            else if (day == 7 || day == 0)  // the || in this condition means "or"
            {
                result = "Sunday";
            }
            else
            {
                result = "error";
            }

            return result;
        }

        // Task 1 - Weekday
        public static void Task1Weekday()
        {
            // This will get the current date from the computer
            DateTime localDate = DateTime.Now;
            int today = (int)localDate.DayOfWeek;

            Console.WriteLine("Weekday 1: " + WeekdayName(1));
            Console.WriteLine("Weekday 2: " + WeekdayName(2));
            Console.WriteLine("Weekday 3: " + WeekdayName(3));
            Console.WriteLine("Weekday 4: " + WeekdayName(4));
            Console.WriteLine("Weekday 5: " + WeekdayName(5));
            Console.WriteLine("Weekday 6: " + WeekdayName(6));
            Console.WriteLine("Weekday 7: " + WeekdayName(7));
            Console.WriteLine("Weekday 0: " + WeekdayName(0));
            Console.WriteLine();
            Console.WriteLine("Weekday 43: " + WeekdayName(43));
            Console.WriteLine("Weekday 17: " + WeekdayName(17));
            Console.WriteLine("Weekday -1: " + WeekdayName(-1));
            Console.WriteLine();
            Console.WriteLine("Today's is a " + WeekdayName(today));
        }

        // 5.2 Task 2 - How Old Are You Revisited
        public static void Task2HowOldAreYouRevisited()
        {
            string name;
            int age;
            Console.Write("Hey, what's your name? ");
            name = Console.ReadLine();
            Console.WriteLine();
            Console.Write("Ok, " + name + ", how old are you?  ");
            age = Convert.ToInt32(Console.ReadLine());
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

    }
}
