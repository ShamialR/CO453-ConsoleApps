﻿using System;

namespace C0453_ConsoleApp.Unit5
{
    /// <summary>
    /// Task 5.2 MP3 Chart Vote
    /// This class allows users to vote for their favourite song among a list of 10 songs
    /// Author: Shamial Rashid 21905385
    /// </summary>
    class Mp3Chart
    {
        string[] TopTen;
        int[] Votes;
        const int MAX = 10;
        int Total = 0;
        /// <summary>
        /// This creates the object, sets the number of MAX votes and lists the 10 songs
        /// </summary>
        public Mp3Chart()
        {
            TopTen = new string[MAX];
            Votes = new int[MAX];
            TopTen[0] = "Revolution";
            TopTen[1] = "Mera Dil Tuta Hain";
            TopTen[2] = "CandyMan";
            TopTen[3] = "Ruby Tuesday";
            TopTen[4] = "Old Man";
            TopTen[5] = "Song 6";
            TopTen[6] = "Song 7";
            TopTen[7] = "Song 8";
            TopTen[8] = "Song 9";
            TopTen[9] = "Song 10";
        }
        /// <summary>
        /// This method runs the other methods
        /// </summary>
        public void Vote()
        {
            ShowMusicList();
            GetVotes();
            DisplayVotes();
        }
        /// <summary>
        /// This method displays the list of songs using a loop rather than listing them again
        /// </summary>
        public void ShowMusicList()
        {
            Console.Clear();
            Console.WriteLine("\tMusic List");
            Console.WriteLine("\t==========");
            for (int i = 0; i < MAX; i++)
            {
                Console.WriteLine("\tSong " + (i + 1) + " is " + TopTen[i]);
            }
        }
        /// <summary>
        /// This asks the user to vote 10 times and records what song they voted for
        /// </summary>
        public void GetVotes()
        {
            int UserVote;
            Console.WriteLine("\n\tSelect your favourite Song");
            Console.WriteLine("\t==========================");
            for (int Vo = 0; Vo < MAX; Vo++)
            {
                Console.Write("\tChoose a song to vote for between 1 - 10 as listed above : ");
                UserVote = Convert.ToInt32(Console.ReadLine());
                Votes[UserVote] ++;
                Total++;
            }
        }
        /// <summary>
        /// This method displays the number of votes each song got
        /// </summary>
        public void DisplayVotes()
        {
            int t = 1;
            Console.WriteLine("\n\tMP3 Track Votes\n\t=================");
            while (t < MAX)
            {
                Console.WriteLine("\t Track " + t + " ," + TopTen[t] + " Had " + Votes[t] + " votes");
                t++;
            }
            Console.WriteLine("\tTotal Number Of Votes < " + Total + " > ");
        }
    }
}

