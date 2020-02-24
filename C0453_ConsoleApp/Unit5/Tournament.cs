using System;

namespace C0453_ConsoleApp.Unit5
{
    /// <summary>
    /// Task 5.1 & 5.3 Tournament Scores
    /// This class makes a list of what each person scored, and the person with the highest score + their score
    /// Author: Shamial Rashid 21905385
    /// </summary>
    class Tournament
    {
        int[] scores;
        string[] names;
        int highScore = 0;
        string highScoreName = "";
        const int MAX = 12;
        /// <summary>
        /// This method is the constructor which creates the Array of Snores and Names of size MAX
        /// </summary>
        public Tournament()
        {
            scores = new int[MAX];
            names = new string[MAX];
        }
        /// <summary>
        /// This method asks the users to enter their names and what they scored, using a loop it stores eacy name and score in the array
        /// </summary>
        public void GetDetails()
        {
            Console.WriteLine("Inputting the Tournament Names & Scores");
            Console.WriteLine("===============================");
            for (int i = 0; i < MAX; i++)
            {
                Console.Write("Enter player " + (i + 1) + " name : ");
                names[i] = Console.ReadLine();
                Console.Write("Enter player < " + names[i] + " > score : ");
                scores[i] = Convert.ToInt32(Console.ReadLine());
            }
        }
        /// <summary>
        /// This method was created for task 1 and is no longer used, it shows the players name and what they scored using a loop
        /// </summary>
        public void ShowScores()
        {
            Console.WriteLine("\nTournament Scores\n================");
            for (int score = 0; score < MAX; score++)
            {
                Console.Write("Player number " + (score + 1) + " Scored < " + scores[score] + " >\n");
            }
        }
        /// <summary>
        /// This method displays the users names, scores aswell as who scored the highest aswell as their score
        /// </summary>
        public void ShowDetails()
        {
            Console.WriteLine("\nTournament Results\n================");
            for (int score = 0; score < MAX; score++)
            {
                Console.Write("Player " + names[score] + " Scored < " + scores[score] + " >\n");
                if (scores[score] > highScore)
                {
                    highScore = scores[score];
                    highScoreName = names[score];
                }
            }
            Console.WriteLine("The highest Score is " + highScore + " From " + highScoreName);
        }
    }
}

