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
        private const int MAX_PLAYER_SCORE = 20;
        public string compChoice, name, playerChoice;
        public int playerScore = 0;
        public int compScore = 0;

        RPSImages rpsImages = new RPSImages();
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
        public void RunRPS()
        {
            SetupScreen();
            Introduction();
            do
            {
                GetPlayerChoice();
                GetComputerChoice();
                DrawPlayerChoice();
                ShowResult();
                ShowChoices();
                ShowScores();
            }
            while (playerScore < MAX_PLAYER_SCORE && compScore < MAX_PLAYER_SCORE);
            ShowResults();
            Console.ReadKey();   // wait for a key press
        }

        /// <summary>
        /// This sets the background colour of the screen aswell as displaying a setup message
        /// </summary>
        /// 
        public void SetupScreen()
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
        public void Introduction()
        {
            Console.WriteLine("\tPlay the Rock-Paper-Scissors Game");
            Console.WriteLine("\t==================================");
            Console.Write("What is your Name: ");
            name = Console.ReadLine();
        }

        /// <summary>
        /// This method asks the user for their choice, between Rock, Paper and Scissors
        /// </summary>
        public void GetPlayerChoice()
        {
            Console.WriteLine("\n\tWhat is your choice " + name + " ?");
            Console.Write("\tRock Paper or Scissors : ");
            playerChoice = Console.ReadLine();
            playerChoice = playerChoice.ToUpper();
        }

        /// <summary>
        /// This method randomly generates a number with 3 values, if it generates a 0 then the computers choice is set to rock, 1 = paper and 2 = scissors
        /// </summary>
        public void GetComputerChoice()
        {
            int num;
            num = randy.Next(3);  // pick a random number (0, 1 or 2)
            if (num == 0) 
            {
                compChoice = "ROCK";
            }
            else if (num == 1)
            {
                compChoice = "PAPER";
            }
            else if (num == 2)
            {
                compChoice = "SCISSORS";
            }
        }

        /// <summary>
        /// This method displays what the user picks and aslo what the computer picked
        /// </summary>
        public void ShowChoices()
        {
            Console.WriteLine("\n\t" + name + "  picked " + playerChoice);
            Console.WriteLine("\tThe computer choice is " + compChoice);
        }

        /// <summary>
        /// This method, using if's, prints a message saying whether the user won, lost or drew and then increments to player, computers or both's scores.
        /// </summary>
        public void ShowResult()
        {
            if (playerChoice == compChoice)
            {
                Console.WriteLine("\n\tA DRAW!!");
                playerScore++;
                compScore++;
            }
            else if (playerChoice == "ROCK" && compChoice != "PAPER")
            {
                Console.WriteLine("\n\t" + name + " WINS!!");
                playerScore += 2;
            }
            else if (playerChoice == "PAPER" && compChoice != "SCISSORS")
            {
                Console.WriteLine("\n\t" + name + " WINS!!");
                playerScore += 2;
            }
            else if (playerChoice == "SCISSORS" && compChoice != "ROCK")
            {
                Console.WriteLine("\n\t" + name + " WINS!!");
                playerScore += 2;
            }
            else
            {
                Console.WriteLine("\n\t" + name + " LOSES!!");
                compScore += 2;
            }
        }

        /// <summary>
        /// This method draws using images that are stored in the RPSImages class using a object which was created above
        /// depending on what choice the user and computer made it will display different results
        /// </summary>
        public void DrawPlayerChoice()
        {
            if (playerChoice == "ROCK")
            {
                rpsImages.DrawRock(10, 6);
            }
            else if (playerChoice == "PAPER")
            {
                rpsImages.DrawPaper(10, 6);
            }
            else if (playerChoice == "SCISSORS")
            {
                rpsImages.DrawScissors(10, 6);
            }
            if (compChoice == "ROCK")
            {
                rpsImages.DrawRock(60, 6);
            }
            else if (compChoice == "PAPER")
            {
                rpsImages.DrawPaper(60, 6);
            }
            else if (compChoice == "SCISSORS")
            {
                rpsImages.DrawScissors(60, 6);
            }
        }

        /// <summary>
        /// This method shows the scores at the bottom of the screen after each game rather than after the whole match
        /// </summary>
        public void ShowScores()
        {
            Console.WriteLine("\n\tScores So Far");
            Console.WriteLine("\t=============");
            Console.WriteLine("\tComputer: " + compScore);
            Console.WriteLine("\t" + name + ": " + playerScore);
            Console.WriteLine("\t=============");
            Console.WriteLine("Type any key to continue!");
            Console.ReadKey();
            Console.Clear();
        }

        /// <summary>
        /// This method is displayed once the whole game is completed and a someone has a score above 20
        /// It displays the user and computers score, and then draws a different image depending on the outcome, which was called from RPSImages
        /// </summary>
        public void ShowResults()
        {
            int WinnerScore;
            Console.Clear();
            Console.WriteLine("\n\tGAME OVER !!!");
            Console.WriteLine("\n\t=============");
            Console.WriteLine("\tComputer: " + compScore);
            Console.WriteLine("\t" + name + ": " + playerScore);

            if (compScore == MAX_PLAYER_SCORE && playerScore == MAX_PLAYER_SCORE)
            {
                rpsImages.DrawSmile();
                Console.WriteLine("\n\tThe Computer and " + name + " Drew!!!");
            }
            else if (compScore == MAX_PLAYER_SCORE || compScore > MAX_PLAYER_SCORE)
            {
                rpsImages.DrawThumbsDown();
                WinnerScore = compScore - playerScore;
                Console.WriteLine("\n\tThe Computer Wins!\n By " + WinnerScore + " Points!");
            }
            else if (playerScore == MAX_PLAYER_SCORE || playerScore > MAX_PLAYER_SCORE)
            {
                rpsImages.DrawThumbsUp();
                WinnerScore = playerScore - compScore;
                Console.WriteLine("\n\t" + name + " Wins!\n By " + WinnerScore + " Points!");
            }
        }
    }
}