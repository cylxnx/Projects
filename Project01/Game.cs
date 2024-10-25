using System.Drawing;
using System.Security.Cryptography;

namespace Project01
{
    /// <summary>
    /// Game logic for the smash hit game Wirt, Deckard, Diablo
    /// </summary>
    internal class Game
    {
        /// <summary>
        /// Calculates the winner of Wirt, Deckard, Diablo.
        /// User input is 1 for Wirt, 2 for Deckard, and 3 for Diablo.
        /// Char values are used for player choices and a byte value is returned for the winner.
        /// </summary>
        /// <param name="playerOneChoice">Player one character choice</param>
        /// <param name="playerTwoChoice">Player two character choice</param>
        /// <returns>winner as a byte value</returns>
        public static byte CalculateWinner(char playerOneChoice, char playerTwoChoice)
        {
            if (playerOneChoice == playerTwoChoice)
            {
                return 0;
            }
            else if (playerOneChoice == '1' && playerTwoChoice == '3' ||
                     playerOneChoice == '2' && playerTwoChoice == '1' ||
                     playerOneChoice == '3' && playerTwoChoice == '2')
            {
                return 1;
            }
            else
            {
                return 2;
            }
        }

        /// <summary>
        /// Prints the results of the game using CalculateWinner method.
        /// Player choices are printed along with the winner.
        /// </summary>
        /// <param name="playerOneName">Player one name</param>
        /// <param name="playerOneChoice">Player one character choice</param>
        /// <param name="playerTwoName">Player two name</param>
        /// <param name="playerTwoChoice">Player two character choice</param>
        public static void PrintResults(string playerOneName, char playerOneChoice, string playerTwoName, char playerTwoChoice)
        {
            if (CalculateWinner(playerOneChoice, playerTwoChoice) == 0)
            {
                Console.WriteLine($"\n     {playerOneName} chose {Game.ConvertChoiceToName(playerOneChoice)}!");
                Console.WriteLine($"     {playerTwoName} chose {Game.ConvertChoiceToName(playerTwoChoice)}!");
                Console.WriteLine("\n    It's a tie!");
                Console.WriteLine("\n");
        }
            else if (CalculateWinner(playerOneChoice, playerTwoChoice) == 1)
            {
                Console.WriteLine($"\n     {playerOneName} chose {Game.ConvertChoiceToName(playerOneChoice)}!");
                Console.WriteLine($"     {playerTwoName} chose {Game.ConvertChoiceToName(playerTwoChoice)}!");
                Console.WriteLine($"\n     {Game.ConvertChoiceToName(playerOneChoice)} beats {Game.ConvertChoiceToName(playerTwoChoice)}");
                Console.WriteLine($"\n     {playerOneName} wins!");
                Console.WriteLine("\n");
            }
            else
            {
                Console.WriteLine($"\n     {playerOneName} chose {Game.ConvertChoiceToName(playerOneChoice)}!");
                Console.WriteLine($"     {playerTwoName} chose {Game.ConvertChoiceToName(playerTwoChoice)}!");
                Console.WriteLine($"\n     {Game.ConvertChoiceToName(playerTwoChoice)} beats {Game.ConvertChoiceToName(playerOneChoice)}");
                Console.WriteLine($"\n     {playerTwoName} wins!");
                Console.WriteLine("\n");
            }
        }

        /// <summary>
        /// Converts the player choice to a character name
        /// </summary>
        /// <param name="playerChoice">Player choice</param>
        /// <returns>Character name as a string</returns>
        public static string ConvertChoiceToName(char playerChoice)
        {
            switch (playerChoice)
            {
                case '1':
                    return "Wirt";
                case '2':
                    return "Deckard";
                case '3':
                    return "Diablo";
                default:
                    return "Unknown";
            }
        }

        public static void PrintLargeWelcomeMessage()
        {
            #region variables
            string wi = "Wirt";
            string de = "Deckard";
            string di = "Diablo";
            string we = "Welcome to:";
            string ar = "‡    ‡    ‡";
            string li = "†------------------------†";
            #endregion

            #region title screen
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine(li);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(we.PadLeft(18));
            Console.WriteLine();
            Console.WriteLine(ar.PadLeft(18));
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine(wi.PadLeft(15));
            Console.WriteLine(de.PadLeft(16));
            Console.WriteLine(di.PadLeft(16));
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();
            Console.WriteLine(ar.PadLeft(18));
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine(li);
            Console.ForegroundColor = ConsoleColor.White;
            #endregion
        }

        public static void PrintSmallHeader()
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("-------- Wirt, Deckard, Diablo --------");
            Console.ForegroundColor = ConsoleColor.White;
        } 

        public static char ShowMenu()
        {
            Console.WriteLine("     1. 1P Game");
            Console.WriteLine("     2. 2P Game");
            Console.WriteLine("     3. Rules");
            Console.WriteLine("     4. Exit");
            Console.WriteLine();
            Console.Write("Enter your choice (1-4): ");
            return Console.ReadKey().KeyChar;


        }

        public static void PrintRules()
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("      Wirt beats Diablo");
            Console.WriteLine("      Diablo beats Deckard");
            Console.WriteLine("      Deckard beats Wirt");
            Console.WriteLine();
            Console.WriteLine("------Press any key to continue-----");
            Console.ReadKey(true);
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
