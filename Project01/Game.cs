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
            CalculateWinner(playerOneChoice, playerTwoChoice);
            Console.WriteLine($"{playerOneName} chose {playerOneChoice} and {playerTwoName} chose {playerTwoChoice}");
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
            Console.WriteLine(@"");


        }

        public static void PrintSmallHeader()
        {



        } 

        static char ShowMenu()
        {
            Console.WriteLine("1. Wirt");
            Console.WriteLine("2. Deckard");
            Console.WriteLine("3. Diablo");
            Console.Write("Choose a character: ");
            return Console.ReadKey().KeyChar;
        }

        public static void PrintRules()
        {
            Console.WriteLine("Welcome to Wirt, Deckard, Diablo!");
            Console.WriteLine("Choose a character to play:");
            Console.WriteLine("1. Wirt");
            Console.WriteLine("2. Deckard");
            Console.WriteLine("3. Diablo");
            Console.WriteLine("Wirt beats Diablo, Diablo beats Deckard, and Deckard beats Wirt.");
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey(true);
        }
    }
}
