using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsLab
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 0;
            string input = "";
            bool isValidInput;
            bool shouldContinue = true;

            do
            {
                do
                {
                    try
                    {
                        isValidInput = true;
                        Console.WriteLine("Welcome to our C# Class. Which student would you like to learn more about? (enter a number 1 - 20)");
                        input = Console.ReadLine();
                        num = int.Parse(input);
                    }
                    catch (IndexOutOfRangeException ex)
                    {
                        Console.WriteLine("That student does not exist. PLease try again. (enter a number 1 - 20)");
                        isValidInput = false;
                    }

                } while (!isValidInput);

                do
                {
                    try
                    {
                        Console.WriteLine("Student {0} is {1}. What would you like to know about {0}? (enter hometown or favorite food)", num, People[num - 1, 0]);
                        input = Console.ReadLine();

                        if (!input.Equals("hometown", StringComparison.InvariantCultureIgnoreCase) && !input.Equals("favorite food", StringComparison.InvariantCultureIgnoreCase))
                        {
                            throw new FormatException("That data does not exist. Please try again. (enter hometown or favorite food");
                        }
                    }
                    catch (FormatException ex)
                    {
                        Console.WriteLine(ex.Message);
                        isValidInput = false;
                    }
                } while (!isValidInput);

                if (input.Equals("hometown", StringComparison.InvariantCultureIgnoreCase))
                {
                    Console.WriteLine("{0}'s hometown is {1} ", People[num - 1, 0], People[num - 1, 1]);
                }
                else
                {
                    Console.Write("{0}'s favorite food is {1} ", People[num - 1, 0], People[num - 1, 2]);
                }

                Console.WriteLine("Would you like to know more students?(enter yes or no)");
                input = Console.ReadLine();

                if (input.Equals("yes", StringComparison.InvariantCultureIgnoreCase))
                {
                    shouldContinue = true;
                }
            } while (shouldContinue);
            Console.ReadKey();
        }

        static string[,] People = new string[,]
        {
            {"Adriana", "New York", "French Toast"},
            {"Milton", "Atlanta", "Biscuts and Gravy"},
            {"Marilyn", "Baltimore", "Fish"},
            {"Andrew", "Memphis", "Grits"},
            {"John", "Las Vegas", "Tacos"},
            {"Johnny", "Austin", "T-Bone Steak"},
            {"Keith", "Bismarck", "Fries"},
            {"Chaz", "Los Angeles", "Salad"},
            {"Blake", "Detroit", "Bratwurst"},
            {"Richard", "Boston", "Scallops"},
            {"Julia", "El Paso", "Chicken Wings"},
            {"Bill", "San Antonio", "BBQ"},
            {"Louis", "Buffalo", "Tiramisu"},
            {"Zoey", "Newark", "Spring Roll"},
            {"Francis", "Seattle", "Quiche"},
            {"Rochelle", "St.Louis", "Chicken Nuggets"},
            {"Nick", "San Fransico", "Dulce De Leche"},
            {"Ellis", "Kansas City", "Waffles"},
            {"Coach", "Chicago", "Hotdogs"},
        };
    }
}







