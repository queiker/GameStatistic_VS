using System;
using GameStatisticsApp.Services;


namespace GameStatistic_VS
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            PrintMenu();
            ConsoleKeyInfo input;
            do
            {
                input = Console.ReadKey();
                switch (input.Key)
                {
                    case ConsoleKey.D1:
                        var numberOfGames = GameService.GetInstance().GetNumberOfGames();
                        Console.Clear();
                        Console.WriteLine($"There are {numberOfGames} games.");
                        break;
                    case ConsoleKey.D2:
                        Console.Clear();
                        Console.WriteLine("What year are you interested in?");
                        var userInput = Console.ReadLine();
                        var result = GameService.GetInstance().IsThereGameFromYear(int.Parse(userInput));
                        if (result)
                        {
                            Console.WriteLine($"There is a game from {userInput}");
                        }
                        else
                        {
                            Console.WriteLine($"There is no game from {userInput}");
                        }

                        break;
                    case ConsoleKey.Enter:
                        Console.Clear();
                        PrintMenu();
                        break;
                }

                Console.WriteLine("Click enter to get back to menu or escape to quit");
            } while (input.Key != ConsoleKey.Escape);
        }

        private static void PrintMenu()
        {
            Console.WriteLine("Main menu");
            Console.WriteLine("1) How many games are there?");
            Console.WriteLine("2) Is there a game from given year?");
            Console.WriteLine("");
        }


    }
}
