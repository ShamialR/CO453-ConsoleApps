using System;
using System.Collections.Generic;
using System.Text;

namespace C0453_ConsoleApp.Project
{
    class RPSProject
    {
        string CompChoice;
        string Name;
        string PlayerChoice;
        int PlayerScore = 0;
        int CompScore = 0;
        Random randy;

        //*******************************************************
        public RPSProject()
        {
            randy = new Random();       // create new Random object
        }
        //*******************************************************
        public void Play()
        {
            SetupScreen();
            Introduction();
            do
            {
                GetPlayerChoice();
                GetComputerChoice();
                DrawPlayerChoice();
                PrintChoices();
                ShowResult();
                ShowScores();
            }
            while (PlayerScore < 20 && CompScore < 20);
            Finish();
            Console.ReadKey();   // wait for a key press
        }
        //********************************************************
        private void SetupScreen()
        {
            Console.Title = " The Great Rock-Paper-Scissors Game";
            Console.SetWindowSize(100, 36);
            Console.SetBufferSize(100, 36);
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();  // clear screen in chosen colour
        }
        //********************************************************
        private void Introduction()
        {
            Console.WriteLine("\tPlay the Rock-Paper-Scissors Game");
            Console.WriteLine("\t==================================");
            Console.Write("What is your Name: ");
            Name = Console.ReadLine();
        }
        //********************************************************
        private void GetPlayerChoice()
        {
            Console.WriteLine("\n\tWhat is your choice " + Name + " ?");
            Console.Write("\tRock Paper or Scissors : ");
            PlayerChoice = Console.ReadLine();
            PlayerChoice = PlayerChoice.ToUpper();
        }
        //*******************************************************
        private void GetComputerChoice()
        {
            int num;
            num = randy.Next(3);  // pick a random number (0, 1 or 2)
            if (num == 0)
            {
                CompChoice = "ROCK";
            }
            else if (num == 1)
            {
                CompChoice = "PAPER";
            }
            else if (num == 2)
            {
                CompChoice = "SCISSORS";
            }
        }
        //***************************************************
        private void PrintChoices()
        {
            Console.WriteLine("\n\t" + Name + "  picked " + PlayerChoice);
            Console.WriteLine("\tThe computer choice is " + CompChoice);
        }
        //***************************************************
        private void ShowResult()
        {
            if (PlayerChoice == CompChoice)
            {
                Console.WriteLine("\n\tA DRAW!!");
                PlayerScore ++;
                CompScore ++;
            }
            else if (PlayerChoice == "ROCK" && CompChoice != "PAPER")
            {
                Console.WriteLine("\n\t" + Name + " WINS!!");
                PlayerScore += 2;
            }
            else if (PlayerChoice == "PAPER" && CompChoice != "SCISSORS")
            {
                Console.WriteLine("\n\t" + Name + " WINS!!");
                PlayerScore += 2;
            }
            else if (PlayerChoice == "SCISSORS" && CompChoice != "ROCK")
            {
                Console.WriteLine("\n\t" + Name + " WINS!!");
                PlayerScore += 2;
            }
            else
            {
                Console.WriteLine("\n\t" + Name + " LOSES!!");
                CompScore += 2;
            }
            Console.Clear();
        }
        //******************************************************
        private void DrawPlayerChoice()
        {
            if (PlayerChoice == "ROCK")
            {
                DrawRock(10, 5);
            }
            else if (PlayerChoice == "PAPER")
            {
                DrawPaper(10, 5);
            }
            else if(PlayerChoice == "SCISSORS")
            {
                DrawScissors(10, 5);
            }
        }
        //*******************************************************************

        private void ShowScores()
        {
            Console.WriteLine("\n\tScores So Far");
            Console.WriteLine("\t=============");
            Console.WriteLine("\tComputer: " + CompScore);
            Console.WriteLine("\t" + Name + ": " + PlayerScore);
            Console.WriteLine("\t=============");
        }

        //*******************************************************************
        private void Finish()
        {
            int WinnerScore = 0;
            Console.Clear();
            Console.WriteLine("\n\tGAME OVER !!!");
            Console.WriteLine("\n\t=============");
            Console.WriteLine("\tComputer: " + CompScore);
            Console.WriteLine("\t" + Name + ": " + PlayerScore);

            if (CompScore == 20 && PlayerScore == 20)
            {
                DrawSmile();
                Console.WriteLine("\n\tThe Computer and " + Name + " Drew!!!");
            }
            else if (CompScore == 20 || CompScore > 20)
            {
                DrawThumbsDown();
                WinnerScore = CompScore - PlayerScore;
                Console.WriteLine("\n\tThe Computer Wins!\n By " + WinnerScore + " Points!");
            }
            else if (PlayerScore == 20 || PlayerScore > 20)
            {
                DrawThumbsUp();
                WinnerScore = PlayerScore - CompScore;
                Console.WriteLine("\n\t" + Name + " Wins!\n By " + WinnerScore + " Points!");
            }
        }

        //******************************************************
        private void DrawScissors(int x, int y)
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
        //**************************************************************
        private void DrawRock(int x, int y)
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
        private void DrawPaper(int x, int y)
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
        private void DrawSmile()
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
        private void DrawThumbsUp()
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
        private void DrawThumbsDown()
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
