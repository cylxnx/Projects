//Cody Lane
//clane15@stumail.northeaststate.edu
namespace Project01
{
    /// <summary>
    /// Prompt methods for user input
    /// </summary>
    internal class Prompt
    {
        /// <summary>
        /// Prompts the user for a char value and returns it.
        /// </summary>
        /// <param name="messagePrompt">message to print with prompt</param>
        /// <returns>user input as a char</returns>
        public static char PromptForChar(string messagePrompt)
        {
            Console.Write(messagePrompt);
            return Console.ReadKey().KeyChar;
        }

        /// <summary>
        /// Prompts the user for a char value and returns it, without echoing the input.
        /// </summary>
        /// <param name="messagePrompt">message to print with prompt</param>
        /// <returns>user input as a hidden char</returns>
        public static char PromptForCharHidden(string messagePrompt)
        {
            Console.Write(messagePrompt);
            return Console.ReadKey(true).KeyChar;
        }

        /// <summary>
        /// Prompts the user for a string value and returns it.
        /// </summary>
        /// <param name="messagePrompt">message to print with prompt</param>
        /// <returns>user input</returns>
        public static string PromptForString(string messagePrompt)
        {
            Console.Write(messagePrompt);
            return Console.ReadLine();
        }

        /// <summary>
        /// Prompts the user to press any key to continue.
        /// </summary>
        public static void PromptForAnyKey()
        {
            Console.Write("Press any key to continue...");
            Console.ReadKey(true);
        }

    }
}


