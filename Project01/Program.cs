namespace Project01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string playerOneName = Prompt.PromptForString("Player one, enter your name: ");
            char playerOneChoice = Prompt.PromptForCharHidden("\nPlayer one, enter 1 for Wirt, 2 for Deckard, or 3 for Diablo: ");
            string playerTwoName = Prompt.PromptForString("\nPlayer two, enter your name: ");
            char playerTwoChoice = Prompt.PromptForCharHidden("\nPlayer two, enter 1 for Wirt, 2 for Deckard, or 3 for Diablo: ");
            Game.PrintResults(playerOneName, playerOneChoice, playerTwoName, playerTwoChoice);
            Prompt.PromptForAnyKey();
        }
    }
}
