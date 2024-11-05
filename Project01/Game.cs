//Cody Lane
//clane15@stumail.northeaststate.edu
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
            else if (CalculateWinner(playerOneChoice,playerTwoChoice) == 2)
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

        /// <summary>
        /// Prints the large welcome message for the game, with
        /// ASCII art accents and appropriately demonic color scheme.
        /// </summary>
        public static void PrintLargeWelcomeMessage()
        {

            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write(@"
                     __                _________ _______ ________      __       
                    /  \      |\     /|\__   __/(  ____ )\__   __|    /  \      
                   | () |     | )   ( |   ) (   | (    )|   ) (      | () |     
                 |\_\  /_/|   | | _ | |   | |   | (____)|   | |    |\_\  /_/|   
                 | _    _ |   | |( )| |   | |   |     __)   | |    | _    _ |   
                 |/ |  | \|   | || || |   | |   | (\ (      | |    |/ |  | \|   
                    |  |      | () () |___) (___| ) \ \__   | |       |  |      
                   /____\     (_______)\_______/|/   \__/   )_(      /____\");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(@"
                 ______   _______  _______  _        _______  ______   ______   
                (  __  \ (  ____ \(  ____ \| \    /\(  ___  )(  ____ )(  __  \  
                | (  \  )| (    \/| (    \/|  \  / /| (   ) || (    )|| (  \  ) 
                | |   ) || (__    | |      |  (_/ / | (___) || (____)|| |   ) | 
                | |   | ||  __)   | |      |   _ (  |  ___  ||     __)| |   | | 
                | |   ) || (      | |      |  ( \ \ | (   ) || (\ (   | |   ) | 
                | (__/  )| (____/\| (____/\|  /  \ \| )   ( || ) \ \__| (__/  ) 
                (______/ (_______/(_______/|_/    \/|/     \||/   \__/(______/ ");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write(@"
                     ______  _________ _______  ______   _        _______       
                    (  __  \ \__   __/(  ___  )(  ___ \ ( \      (  ___  )      
                    | (  \  )   ) (   | (   ) || (   ) )| (      | (   ) |      
                    | |   ) |   | |   | (___) || (__/ / | |      | |   | |      
                    | |   | |   | |   |  ___  ||  __ (  | |      | |   | |      
                    | |   ) |   | |   | (   ) || (  \ \ | |      | |   | |      
                    | (__/  )___) (___| )   ( || )___) )| (____/\| (___) |      
                    (______/ \_______/|/     \||/ \___/ (_______/(_______)");
            Console.ForegroundColor = ConsoleColor.White;

        }

        /// <summary>
        /// Prints the small header for the game in red text, returning to white text after.
        /// </summary>
        public static void PrintSmallHeader()
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("-------------------‡-Wirt-‡-----------‡-Deckard-‡-----------‡-Diablo-‡-------------------");
            Console.ForegroundColor = ConsoleColor.White;
        }

        /// <summary>
        /// Prints the menu for the game and returns the user's choice.
        /// </summary>
        /// <returns>user choice as a char value</returns>
        public static char ShowMenu()
        {
            Console.WriteLine("          1. 1P Game");
            Console.WriteLine("          2. 2P Game");
            Console.WriteLine("          3. Rules");
            Console.WriteLine("          4. Exit");
            Console.WriteLine();
            return Prompt.PromptForChar("   Enter your choice (1-4): ");  
        }

        /// <summary>
        /// Prints the rules of the game in red text, returning to white text after.
        /// </summary>
        public static void PrintRules()
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("\n\n                                    Wirt Beats Diablo          ");
            Console.WriteLine("\n                                   Diablo Beats Deckard       ");
            Console.WriteLine("\n                                    Deckard Beats Wirt         ");
            Console.WriteLine("\n----------- ‡ ---------- ‡ ---------- ‡ ---------- ‡ ---------- ‡ ---------- ‡ ----------\n\n");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
