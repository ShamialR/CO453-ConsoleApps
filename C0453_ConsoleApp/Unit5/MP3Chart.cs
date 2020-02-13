using System;

namespace C0453_ConsoleApp.Unit5
{
    class Mp3Chart
    {

        string[] topTen;
        int[] Votes;
        const int MAX = 10;
        int Total = 0;
        //*****************************************
        public Mp3Chart()
        {
            topTen = new string[MAX];
            Votes = new int[MAX];

            topTen[0] = "Revolution";
            topTen[1] = "Mera Dil Tuta Hain";
            topTen[2] = "CandyMan";
            topTen[3] = "Ruby Tuesday";
            topTen[4] = "Old Man";
            topTen[5] = "Song 1";
            topTen[6] = "Song 2";
            topTen[7] = "Song 3";
            topTen[8] = "Song 4";
            topTen[9] = "Song 5";
        }
        //*****************************************
        public void Vote()
        {
            showMusicList();
            getVotes();
            TestVotes();
        }
        //***********************************************
        public void showMusicList()
        {
            Console.Clear();
            Console.WriteLine("\tMusic List");
            Console.WriteLine("\t==========");
            for (int i = 0; i < MAX; i++)
            {
                Console.WriteLine("\tSong " + (i + 1) + " is " + topTen[i]);
            }
        }
        //***********************************************
        public void getVotes()
        {
            int userVote;

            Console.WriteLine("\n\tSelect your favourite Song");
            Console.WriteLine("\t==========================");
            for (int Vo = 0; Vo < MAX; Vo++)
            {
                Console.Write("\tChoose a song to vote for between 1 - 10 as listed above : ");
                userVote = Convert.ToInt32(Console.ReadLine());

                if (userVote == 1)
                {
                    Votes[0] += 1;
                }
                else if (userVote == 2)
                {
                    Votes[1] += 1;
                }
                else if (userVote == 3)
                {
                    Votes[2] += 1;
                }
                else if (userVote == 4)
                {
                    Votes[3] += 1;
                }
                else if (userVote == 5)
                {
                    Votes[4] += 1;
                }
                else if (userVote == 6)
                {
                    Votes[5] += 1;
                }
                else if (userVote == 7)
                {
                    Votes[6] += 1;
                }
                else if (userVote == 8)
                {
                    Votes[7] += 1;
                }
                else if (userVote == 9)
                {
                    Votes[8] += 1;
                }
                else if (userVote == 10)
                {
                    Votes[9] += 1;
                }

                Total += Votes[Vo];
            }
        }
        //*************************************************

        public void TestVotes()
        {
            int t = 0;
            Console.WriteLine("\n\tMP3 Track Votes\n\t=================");
            while (t < MAX)
            {
                Console.WriteLine("\t" + topTen[t] + " Had < " + Votes[t] + " >");
                Console.WriteLine("\t Total Number Of Votes < " + Total + " > ");
                t++;
            }
        }
    }
}

