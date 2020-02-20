using System;
using System.Collections.Generic;
using System.Text;

namespace C0453_ConsoleApp.Project
{
    class RPSImages
    {
        public void DrawScissors(int x, int y)
        {
            Console.SetCursorPosition(x, y++);   // set start position then increment y to move down
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
        public void DrawRock(int x, int y)
        {
            Console.SetCursorPosition(x, y++);   // set start position then increment y to move down
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
        //************************************************************************
        public void DrawPaper(int x, int y)
        {
            Console.SetCursorPosition(x, y++);    // set start position then increment y to move down
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
        //************************************************************************
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
        //*************************************
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
        //*************************************
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
