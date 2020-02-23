using System;
using System.Collections.Generic;
using System.Text;

namespace C0453_ConsoleApp.Project
{
    /// <summary>
    /// Project Rock Paper Scissors
    /// This class allows the user to play a rock paper scissors game against the computer whic hrandomly picks between rock paper and scissors with the first to reach 20 points winning
    /// Author: Shamial Rashid 21905385
    /// </summary>
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

        /// <summary>
        /// This creates a random object
        /// </summary>
        public RPSProject()
        {
            randy = new Random();
        }
        /// <summary>
        /// This method calls other methods which run the program, it also contains a loop which ends once a player has reached 20
        /// </summary>
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
        /// <summary>
        /// This sets the background colour of the screen aswell as displaying a setup message
        /// </summary>
        private void SetupScreen()
        {
            Console.Title = " The Great Rock-Paper-Scissors Game";
            Console.SetWindowSize(100, 36);
            Console.SetBufferSize(100, 36);
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();  // clear screen in chosen colour
        }
        /// <summary>
        /// This method displays a short introduction of the game and asks the user for their name which will be displayed throughout the game
        /// </summary>
        private void Introduction()
        {
            Console.WriteLine("\tPlay the Rock-Paper-Scissors Game");
            Console.WriteLine("\t==================================");
            Console.Write("What is your Name: ");
            Name = Console.ReadLine();
        }
        /// <summary>
        /// This method asks the user for their choice, between Rock, Paper and Scissors
        /// </summary>
        private void GetPlayerChoice()
        {
            Console.WriteLine("\n\tWhat is your choice " + Name + " ?");
            Console.Write("\tRock Paper or Scissors : ");
            PlayerChoice = Console.ReadLine();
            PlayerChoice = PlayerChoice.ToUpper();
        }
        /// <summary>
        /// This method randomly generates a number with 3 values, if it generates a 0 then the computers choice is set to rock, 1 = paper and 2 = scissors
        /// </summary>
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
        /// <summary>
        /// This method displays what the user picks and aslo what the computer picked
        /// </summary>
        private void PrintChoices()
        {
            Console.WriteLine("\n\t" + Name + "  picked " + PlayerChoice);
            Console.WriteLine("\tThe computer choice is " + CompChoice);
        }
        /// <summary>
        /// This method, using if's, prints a message saying whether the user won, lost or drew and then increments to player, computers or both's scores.
        /// </summary>
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
        /// <summary>
        /// This method draws using images that are stored in the RPSImages class using a object which was created above
        /// depending on what choice the user and computer made it will display different results
        /// </summary>
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
        /// <summary>
        /// This method shows the scores at the bottom of the screen after each game rather than after the whole match
        /// </summary>
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
        /// <summary>
        /// This method is displayed once the whole game is completed and a someone has a score above 20
        /// It displays the user and computers score, and then draws a different image depending on the outcome, which was called from RPSImages
        /// </summary>
        private void Finish()
        {
            int WinnerScore;
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
    }
}