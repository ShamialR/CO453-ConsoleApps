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
        int[] Scores;
        string[] Names;
        int HighScore = 0;
        string HighScoreName = "";
        const int MAX = 12;
        /// <summary>
        /// This method is the constructor which creates the Array of Snores and Names of size MAX
        /// </summary>
        public Tournament()
        {
            Scores = new int[MAX];
            Names = new string[MAX];
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
                Names[i] = Console.ReadLine();
                Console.Write("Enter player < " + Names[i] + " > score : ");
                Scores[i] = Convert.ToInt32(Console.ReadLine());
            }
        }
        /// <summary>
        /// This method was created for task 1 and is no longer used, it shows the players name and what they scored using a loop
        /// </summary>
        public void ShowScores()
        {
            Console.WriteLine("\nTournament Scores\n================");
            for (int Sc = 0; Sc < MAX; Sc++)
            {
                Console.Write("Player number " + (Sc + 1) + " Scored < " + Scores[Sc] + " >\n");
            }
        }
        /// <summary>
        /// This method displays the users names, scores aswell as who scored the highest aswell as their score
        /// </summary>
        public void ShowDetails()
        {
            Console.WriteLine("\nTournament Results\n================");
            for (int Sc = 0; Sc < MAX; Sc++)
            {
                Console.Write("Player " + Names[Sc] + " Scored < " + Scores[Sc] + " >\n");
                if (Scores[Sc] > HighScore)
                {
                    HighScore = Scores[Sc];
                    HighScoreName = Names[Sc];
                }
            }
            Console.WriteLine("The highest Score is " + HighScore + " From " + HighScoreName);
        }
    }
}

