using System;

namespace C0453_ConsoleApp.Project
{
    /// <summary>
    /// Project Rock Paper Scissors (Images)
    /// This class is called from the RPSProject class, RPSImages stores the images that are displaYed when the program is run
    /// Author: Shamial Rashid 21905385
    /// </summary>
    class RPSImages
    {
        /// <summary>
        /// This method draws the scissors when it is called, the parameter X and Y are the position on the page it is shown by putting the cursor there
        /// </summary>
        public void DrawScissors(int x, int y)
        {
            Console.SetCursorPosition(x, y++);   // set start position then increment Y to move down
            Console.Write("     \\            /");
            Console.SetCursorPosition(x, y++);
            Console.Write("      \\          /");
            Console.SetCursorPosition(x, y++);
            Console.Write("       \\        /");
            Console.SetCursorPosition(x, y++);
            Console.Write("        \\      /");
            Console.SetCursorPosition(x, y++);
            Console.Write("         \\    /");
            Console.SetCursorPosition(x, y++);
            Console.Write("          \\  /");
            Console.SetCursorPosition(x, y++);
            Console.Write("           **");
            Console.SetCursorPosition(x, y++);
            Console.Write("          /  \\");
            Console.SetCursorPosition(x, y++);
            Console.Write("    (----/    \\----)");
            Console.SetCursorPosition(x, y++);
            Console.Write("     \\  /      \\  /");
            Console.SetCursorPosition(x, y++);
            Console.Write("      ==        ==");
            Console.WriteLine("\n\n");
        }
        /// <summary>
        /// This method draws the rock when it is called, the parameter X and Y are the position on the page it is shown by putting the cursor there
        /// </summary>
        public void DrawRock(int x, int y)
        {
            Console.SetCursorPosition(x, y++);   // set start position then increment Y to move down
            Console.Write("                 ___---___     ");
            Console.SetCursorPosition(x, y++);
            Console.Write("              .--         --.    ");
            Console.SetCursorPosition(x, y++);
            Console.Write("           ./   ()       .-. \\.   ");
            Console.SetCursorPosition(x, y++);
            Console.Write("           /   o    .   (   )  \\  ");
            Console.SetCursorPosition(x, y++);
            Console.Write("          / .            '-'    \\  ");
            Console.SetCursorPosition(x, y++);
            Console.Write("         /     ()   ()           \\ ");
            Console.SetCursorPosition(x, y++);
            Console.Write("        |    o           ()       | ");
            Console.SetCursorPosition(x, y++);
            Console.Write("        |      .--.           O   | ");
            Console.SetCursorPosition(x, y++);
            Console.Write("         \\ .  |    |              |  ");
            Console.SetCursorPosition(x, y++);
            Console.Write("          \\   `.__.'     o   .   /    ");
            Console.SetCursorPosition(x, y++);
            Console.Write("           `\\  o    ()         /'    ");
            Console.SetCursorPosition(x, y++);
            Console.Write("              `--___    ___--'    ");
            Console.SetCursorPosition(x, y++);
            Console.Write("                     ---         ");
            Console.WriteLine();
        }
        /// <summary>
        /// This method draws the paper when it is called, the parameter X and Y are the position on the page it is shown by putting the cursor there
        /// </summary>
        public void DrawPaper(int x, int y)
        {
            Console.SetCursorPosition(x, y++);    // set start position then increment Y to move down
            Console.Write("      .--.------------------.");
            Console.SetCursorPosition(x, y++);
            Console.Write("     /      \\  \\ \\ \\ \\ \\ \\ \\ \\");
            Console.SetCursorPosition(x, y++);
            Console.Write("    /   OOO  \\                |");
            Console.SetCursorPosition(x, y++);
            Console.Write("   |   OOOO   || A N D R E X | |");
            Console.SetCursorPosition(x, y++);
            Console.Write("   |   OOOO   |                |");
            Console.SetCursorPosition(x, y++);
            Console.Write("    \\   OOO   /                /");
            Console.SetCursorPosition(x, y++);
            Console.Write("     \\      // / / / / / / / //");
            Console.SetCursorPosition(x, y++);
            Console.Write("       `--'-|| | | | | | | | |");
            Console.SetCursorPosition(x, y++);
            Console.Write("             \\                \\");
            Console.SetCursorPosition(x, y++);
            Console.Write("              \\                \\");
            Console.SetCursorPosition(x, y++);
            Console.Write("               \\                \\");
            Console.SetCursorPosition(x, y++);
            Console.Write("                \\ \\ \\ \\ \\ \\ \\ \\ \\\\");
            Console.SetCursorPosition(x, y++);
            Console.Write("                 \\________________\\");
            Console.WriteLine();
        }
        /// <summary>
        /// This method draws a smile in the console when the user draws with the computer in the rock paper scissors game
        /// </summary>
        public void DrawSmile()
        {
            Console.WriteLine("\n                    .-\"\"\"\"-.-\"\"\"\"-. ");
            Console.WriteLine("               _.'`               `'._   ");
            Console.WriteLine("            .-'  __..,.___.___.,..__  '-.   ");
            Console.WriteLine("           '-.-;` |  |    |    |  | `;-.-'   ");
            Console.WriteLine("            \\'-\\_/\\__|    |    |__/\\_/-'/   ");
            Console.WriteLine("             \\, _     '---'---'     _ ,/   ");
            Console.WriteLine("              \\'./`'.--.--.--,--.'`\\.'/   ");
            Console.WriteLine("               \\ `'-;__|__|__|__;-'` /   ");
            Console.WriteLine("                '.                 .'   ");
            Console.WriteLine("                 `'-....---....-'`    ");
        }
        /// <summary>
        /// This method draws a Thumbs Up in the console when the user beats the computer in the rock paper scissors game
        /// </summary>
        public void DrawThumbsUp()
        {
            Console.WriteLine();
            Console.WriteLine("       _ ");
            Console.WriteLine("      ( ((  ");
            Console.WriteLine("       \\ =\\   ");
            Console.WriteLine("      __\\_ `-\\   ");
            Console.WriteLine("     (____))(  \\-----  ");
            Console.WriteLine("     (____)) _    ");
            Console.WriteLine("     (____))   ");
            Console.WriteLine("     (____))____/-----  ");
            Console.WriteLine();
        }
        /// <summary>
        /// This method draws a Thumbs Down in the console when the user loses against the computer in the rock paper scissors game
        /// </summary>
        public void DrawThumbsDown()
        {
            Console.WriteLine();
            Console.WriteLine("       ______ ");
            Console.WriteLine("     ((____  \\-----  ");
            Console.WriteLine("     ((_____         ");
            Console.WriteLine("     ((_____      ");
            Console.WriteLine("     ((____   -----   ");
            Console.WriteLine("          /  /    ");
            Console.WriteLine("         (_((     ");
            Console.WriteLine();
        }
    }
}
