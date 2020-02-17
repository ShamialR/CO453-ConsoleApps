using System;

namespace C0453_ConsoleApp.Unit5
{

    class Tournament
    {
        int[] Scores;           // define Scores as an integer array
        string[] Names;
        int HighScore = 0;
        string HighScoreName = "";
        const int MAX = 12;     // set a constant size

        //******************************************************
        public Tournament()             // the class constructor
        {
            Scores = new int[MAX];      // create the array of size MAX
            Names = new string[MAX];
        }
        //******************************************************
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
        //******************************************************
        public void ShowScores()
        {
            Console.WriteLine("\nTournament Scores\n================");
            for (int Sc = 0; Sc < MAX; Sc++)
            {
                Console.Write("Player number " + (Sc + 1) + " Scored < " + Scores[Sc] + " >\n");
            }
        }

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

