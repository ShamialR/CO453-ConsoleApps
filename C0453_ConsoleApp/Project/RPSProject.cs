using System;
using System.Collections.Generic;
using System.Text;

namespace C0453_ConsoleApp.Project
{
    class RPSProject
    {
        RPSImages MyGameHolder = new RPSImages();
        string CompChoice;
        string Name;
        string PlayerChoice;
        int PlayerScore = 0;
        int CompScore = 0;
        int MaxPlayerScore = 20;
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
                ShowResult();
                PrintChoices();
                ShowScores();
            }
            while (PlayerScore < MaxPlayerScore && CompScore < MaxPlayerScore);
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
                PlayerScore++;
                CompScore++;
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
        }
        //******************************************************
        private void DrawPlayerChoice()
        {
            if (PlayerChoice == "ROCK")
            {
                MyGameHolder.DrawRock(10, 6);
            }
            else if (PlayerChoice == "PAPER")
            {
                MyGameHolder.DrawPaper(10, 6);
            }
            else if (PlayerChoice == "SCISSORS")
            {
                MyGameHolder.DrawScissors(10, 6);
            }
            if (CompChoice == "ROCK")
            {
                MyGameHolder.DrawRock(60, 6);
            }
            else if (CompChoice == "PAPER")
            {
                MyGameHolder.DrawPaper(60, 6);
            }
            else if (CompChoice == "SCISSORS")
            {
                MyGameHolder.DrawScissors(60, 6);
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
            Console.WriteLine("Type any key to continue!");
            Console.ReadKey();
            Console.Clear();
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

            if (CompScore == MaxPlayerScore && PlayerScore == MaxPlayerScore)
            {
                MyGameHolder.DrawSmile();
                Console.WriteLine("\n\tThe Computer and " + Name + " Drew!!!");
            }
            else if (CompScore == MaxPlayerScore || CompScore > MaxPlayerScore)
            {
                MyGameHolder.DrawThumbsDown();
                WinnerScore = CompScore - PlayerScore;
                Console.WriteLine("\n\tThe Computer Wins!\n By " + WinnerScore + " Points!");
            }
            else if (PlayerScore == MaxPlayerScore || PlayerScore > MaxPlayerScore)
            {
                MyGameHolder.DrawThumbsUp();
                WinnerScore = PlayerScore - CompScore;
                Console.WriteLine("\n\t" + Name + " Wins!\n By " + WinnerScore + " Points!");
            }
        }

        //******************************************************
    }
}