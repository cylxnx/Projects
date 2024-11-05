//Cody Lane
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
        /// One player mode. Prints a message that one player mode is only 
        /// available in the COW LEVEL DLC.
        /// </summary>
        static void OnePlayerMode()
        {
            string OneP = "1P Mode Available";
            string OnlY = "ONLY in the";
            string CowL = "COW LEVEL DLC!!!";

            Game.PrintSmallHeader();
            Console.WriteLine();
            Console.WriteLine(OneP.PadLeft(28));
            Console.WriteLine(OnlY.PadLeft(25));
            Console.WriteLine(CowL.PadLeft(28));
            Thread.Sleep(3000);
            Console.Clear();
        }

        /// <summary>
        /// Two player mode. Prompts for player names and choices, then prints the results.
        /// If invalid input is entered, the prompt will repeat until valid input is entered.
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
            while (playerOneChoice.CompareTo('1') != 0 && playerOneChoice.CompareTo('2') != 0 && playerOneChoice.CompareTo('3') != 0)
            {
                playerOneChoice = Prompt.PromptForCharHidden($"\n     {playerOneName} ->");
            }
            char playerTwoChoice = Prompt.PromptForCharHidden($"\n     {playerTwoName} ->");
            while (playerTwoChoice.CompareTo('1') != 0 && playerTwoChoice.CompareTo('2') != 0 && playerTwoChoice.CompareTo('3') != 0)
            {
                playerTwoChoice = Prompt.PromptForCharHidden($"\n     {playerTwoName} ->");
            }
            Console.Clear();

            Game.PrintSmallHeader();
            Game.PrintResults(playerOneName, playerOneChoice, playerTwoName, playerTwoChoice);
            Prompt.PromptForAnyKey();
            Console.Clear();
        }

        /// <summary>
        /// Rules mode. Prints the rules of the game and prompts for any key to continue.
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
            Console.WriteLine("\nAre you sure?");
            Console.WriteLine("\nPerhaps you should stay a while, and listen.");
            Thread.Sleep(2000);
            Console.Clear();
        }

        /// <summary>
        /// Main menu with choices for one player mode, two player mode, rules, and exit.
        /// Uses a switch statement to determine which method to call based on user input.
        /// </summary>
        static void MainMenu()
        {
            Game.PrintLargeWelcomeMessage();
            Console.WriteLine();
            char choice = Game.ShowMenu();

            if (choice == '1' || choice == '2' || choice == '3' || choice == '4')
            {
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
            else
            {
                Console.Clear();
                MainMenu();
            }








            
        }
    }
}





















