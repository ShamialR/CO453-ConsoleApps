using System;

namespace C0453_ConsoleApp.Unit5
{

    class Tournament
    {
        int[] scores;           // define scores as an integer array
        string[] names;
        int HighScore = 0;
        string HighScoreName = "";
        const int MAX = 12;     // set a constant size

        //******************************************************
        public Tournament()             // the class constructor
        {
            scores = new int[MAX];      // create the array of size MAX
            names = new string[MAX];
        }
        //******************************************************
        public void getDetails()
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
        //******************************************************
        public void ShowScores()
        {
            Console.WriteLine("\nTournament Scores\n================");
            for (int Sc = 0; Sc < MAX; Sc++)
            {
                Console.Write("Player number " + (Sc + 1) + " Scored < " + scores[Sc] + " >\n");
            }
        }

        public void ShowDetails()
        {
            Console.WriteLine("\nTournament Results\n================");
            for (int Sc = 0; Sc < MAX; Sc++)
            {
                Console.Write("Player " + names[Sc] + " Scored < " + scores[Sc] + " >\n");
                if (scores[Sc] > HighScore)
                {
                    HighScore = scores[Sc];
                    HighScoreName = names[Sc];
                }
            }
            Console.WriteLine("The highest Score is " + HighScore + " From " + HighScoreName);
        }
    }
}

