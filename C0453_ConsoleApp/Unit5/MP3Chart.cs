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
        public const int MAXN_SONGS = 10;

        private string[] chart;
        private int[] votes;
        private int total = 0;

        /// <summary>
        /// This creates the object, sets the number of MAX songs and lists the 10 songs
        /// </summary>
        public Mp3Chart()
        {
            chart = new string[MAXN_SONGS];
            votes = new int[MAXN_SONGS];

            chart[0] = "Revolution";
            chart[1] = "Mera Dil Tuta Hain";
            chart[2] = "CandyMan";
            chart[3] = "Ruby Tuesday";
            chart[4] = "Old Man";
            chart[5] = "Song 6";
            chart[6] = "Song 7";
            chart[7] = "Song 8";
            chart[8] = "Song 9";
            chart[9] = "Song 10";
        }

        /// <summary>
        /// This method displays the list of songs using a loop rather than listing them again
        /// </summary>
        public void DisplayMusicList()
        {
            Console.Clear();
            Console.WriteLine("\tMusic List");
            Console.WriteLine("\t==========");
            for (int songs = 0; songs < MAXN_SONGS; songs++)
            {
                Console.WriteLine("\tSong " + (songs + 1) + " is " + chart[songs]);
            }
        }

        /// <summary>
        /// This asks the user to vote 10 times and records what song they voted for
        /// </summary>
        public void GetVotes()
        {
            int userVote;

            Console.WriteLine("\n\tSelect your favourite Song");
            Console.WriteLine("\t==========================");

            for (int vote = 0; vote < MAXN_SONGS; vote++)
            {
                Console.Write("\tChoose a song to vote for between 1 - 10 as listed above : ");
                userVote = Convert.ToInt32(Console.ReadLine());
                votes[userVote] ++;
                total++;
            }
        }

        /// <summary>
        /// This method displays the number of votes each song got
        /// </summary>
        public void DisplayVotes()
        {
            int count = 1;
            Console.WriteLine("\n\tMP3 Track Votes\n\t=================");

            while (count < MAXN_SONGS)
            {
                Console.WriteLine("\t Track " + count + " ," + chart[count] + " Had " + votes[count] + " votes");
                count++;
            }

            Console.WriteLine("\tTotal Number Of Votes < " + total + " > ");
        }
    }
}

