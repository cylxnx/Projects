﻿//Cody Lane
//clane15@stumail.northeaststate.edu
namespace Project01
{
    internal class Program
    {
        static void Main()
        {
            MainMenu();

        }

        /// <summary>
        /// One player mode. Prints a message that one player mode is only available in the COW DLC.
        /// </summary>
        static void OnePlayerMode()
        {
            Game.PrintSmallHeader();
            Console.WriteLine("1P Mode Available in COW DLC!!");
            Thread.Sleep(3000);
            Console.Clear();
        }

        /// <summary>
        /// Two player mode. Prompts for player names and choices, then prints the results.
        /// </summary>
        static void TwoPlayerMode()
        {
            Game.PrintSmallHeader();
            Console.WriteLine();
            string playerOneName = Prompt.PromptForString("     Player One Name: ");
            string playerTwoName = Prompt.PromptForString("     Player Two Name: ");
            Console.Clear();

            Game.PrintSmallHeader();
            Console.WriteLine();
            Console.WriteLine($"\n     {playerOneName} vs {playerTwoName}");
            Console.WriteLine();
            Game.PrintRules();
            Console.WriteLine();
            Console.WriteLine("Choose your character:");
            Console.WriteLine("Wirt[1] Deckard[2] Diablo[3]");
            Console.WriteLine();
            char playerOneChoice = Prompt.PromptForCharHidden($"     {playerOneName} ->");
            char playerTwoChoice = Prompt.PromptForCharHidden($"\n     {playerTwoName} ->");
            Console.Clear();

            Game.PrintSmallHeader();
            Game.PrintResults(playerOneName, playerOneChoice, playerTwoName, playerTwoChoice);
            Prompt.PromptForAnyKey();
            Console.Clear();
        }

        /// <summary>
        /// Rules mode. Prints the rules of the game.
        /// </summary>
        static void RulesMode()
        {
            Game.PrintSmallHeader();
            Game.PrintRules();
            Prompt.PromptForAnyKey();
            Console.Clear();
    }

        /// <summary>
        /// Exit option. Prints a message and waits 2 seconds before clearing the console.
        /// </summary>
        static void ExitOption()
        {
            Game.PrintLargeWelcomeMessage();
            Console.WriteLine("Are you sure?");
            Console.WriteLine("Perhaps you should stay a while, and listen.");
            Thread.Sleep(2000);
            Console.Clear();
}

        /// <summary>
        /// Main menu. Prints the welcome message and shows the menu.
        /// </summary>
        static void MainMenu()
        {
            Game.PrintLargeWelcomeMessage();
            Console.WriteLine();
            char choice = Game.ShowMenu();

            switch (choice)
            {
                case '1':
                    Console.Clear();
                    OnePlayerMode();
                    MainMenu();
                    break;
                case '2':
                    Console.Clear();
                    TwoPlayerMode();
                    MainMenu();
                    break;
                case '3':
                    Console.Clear();
                    RulesMode();
                    MainMenu();
                    break;
                case '4':
                    Console.Clear();
                    ExitOption();
                    break;
                default:
                    break;
            }
        }
    }
}
         
    

    


     












