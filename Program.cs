using System;

namespace ZooVisitorsApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Prompt the user to enter the animal's hunger level
            int hungerLevel;
            while (true)
            {
                Console.Write("Enter the animal's hunger level (1-10): ");
                if (int.TryParse(Console.ReadLine(), out hungerLevel) && hungerLevel >= 1 && hungerLevel <= 10)
                {
                    break;
                }
                Console.WriteLine("Invalid input. Please enter a number between 1 and 10.");
            }

            // If-Else statement to determine the animal's response based on hunger level
            if (hungerLevel >= 8)
            {
                Console.WriteLine("Lion: Roar! I need a big meal!");
            }
            else if (hungerLevel >= 5)
            {
                Console.WriteLine("Monkey: Ooh ooh! I'll take some bananas.");
            }
            else
            {
                Console.WriteLine("Tortoise: Slow and steady—I'll have some lettuce.");
            }

            // Ternary operator to output an animal sound based on hunger level
            string animalSound = hungerLevel >= 8 ? "Listen to the Lion: Roar!" : "Listen to the Monkey: Ooh ooh!";
            Console.WriteLine(animalSound);

            // Prompt the user to enter a day of the week as a number
            int dayOfWeek;
            while (true)
            {
                Console.Write("Enter a day of the week (1-7, where 1 is Sunday): ");
                if (int.TryParse(Console.ReadLine(), out dayOfWeek) && dayOfWeek >= 1 && dayOfWeek <= 7)
                {
                    break;
                }
                Console.WriteLine("Invalid input. Please enter a number between 1 and 7.");
            }

            // Switch statement to display a Zoo-themed message for each day of the week
            switch (dayOfWeek)
            {
                case 1:
                    Console.WriteLine("Sunday: Family Day! Kids under 12 get free admission.");
                    break;
                case 2:
                    Console.WriteLine("Monday: Start your week with a roar! Lion feeding at 10 AM.");
                    break;
                case 3:
                    Console.WriteLine("Tuesday: Tortoise Tuesday! Learn about our oldest residents.");
                    break;
                case 4:
                    Console.WriteLine("Wednesday: Wild Wednesday! Discounted tickets for students.");
                    break;
                case 5:
                    Console.WriteLine("Thursday: Seniors get 10% off admission on Thursday!");
                    break;
                case 6:
                    Console.WriteLine("Friday: Feed the monkeys! Special banana buffet at 2 PM.");
                    break;
                case 7:
                    Console.WriteLine("Saturday: Safari Saturday! Guided tours every hour.");
                    break;
                default:
                    Console.WriteLine("Invalid day entered. Please choose a number between 1 and 7.");
                    break;
            }
        }
    }
}