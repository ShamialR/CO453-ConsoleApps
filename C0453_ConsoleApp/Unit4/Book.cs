using System;

namespace C0453_ConsoleApp.Unit4
{
    /// <summary>
    /// Task 4.2 & 4.3 Horror Story
    /// This class will using preset or manually entered details, write a story based on the users details
    /// Author: Shamial Rashid
    /// </summary>
    class Book
    {
        private string Author;
        private string Name, Town, Animal, Weapon, Job, Colour, Song, Sex, Gender, Answer;
        /// <summary>
        /// This public Book method has a set of default data that can be entered into the story
        /// </summary>
        public Book()
        {
            Author = "Shamial";
            Name = "John";
            Town = "High Wycombe";


            Animal = "Cat";
            Job = "Architect";
            Weapon = "Pencil";

            Sex = "male";
            Colour = "Red";
            Song = "Queen";
        }
        /// <summary>
        /// This is a method which can be called whenever a question is asked using the parameter in the method to get the question and then send it back using return.
        /// </summary>
        public string Ask(string prompt)    // use prompt to Ask for info
        {
            string Answer;
            Console.Write(prompt);
            Answer = Console.ReadLine();
            return Answer;
        }
        /// <summary>
        /// This calls the Ask method and gets the data that will be entered into the book if the user wanted to manually enter it
        /// </summary>
        public void GetDetails()
        {
            Console.WriteLine("Would you like to use Default or Manual Answers");
            Answer = Console.ReadLine();

            if (Answer == "Manual")
            {
                Author = Ask("Please type your Name : ");
                Name = Ask("Please type a friend's Name : ");
                Town = Ask("Now give me the Name of a Town : ");


                Animal = Ask("Now a type of Animal : ");
                Job = Ask("Now a type of Job : ");
                Weapon = Ask("And your Weapon of choice : ");

                Sex = Ask("Are you male or female : ");
                Colour = Ask("What's your favourite color : ");
                Song = Ask("What's your favourite band : ");
            }
            else if (Answer == "Manual")
            {

            }
        }
        /// <summary>
        /// speprate method which using the gender the user previously input will set the gender to he or she which will be displayed in the story 
        /// </summary>
        public void CheckGender()
        {
            if (Sex == "male" || Sex == "M" || Sex == "m")
            {
                Gender = "he";
            }
            else if (Sex == "female" || Sex == "f" || Sex == "F")
            {
                Gender = "she";
            }
            else
            {
                Gender = "they";
            }
        }
        /// <summary>
        /// This method actually writes the first chapter of the story using the data previously collected or the default data
        /// </summary>
        public void WriteChapter1()
        {
            Console.Clear();
            Console.WriteLine("A Horror Story : by " + Author);
            Console.WriteLine("=============== CHAPTER 1 ================");
            Console.WriteLine("It was a dark night in " + Town
                + " and " + Name + " could hear " + Animal + "s screaming in the distance.");
            Console.WriteLine(Name + " staggered terrified through the streets of " + Town
                + ", realising that " + Gender + " had been followed.");
            Console.WriteLine("In the shadow of a doorway, a demented " + Job + " waited, clutching a menacing " + Weapon + " in his hand.");
        }
        /// <summary>
        /// This method writes the second chapter of the story using the data previously collected or the default data
        /// </summary>
        public void WriteChapter2()
        {
            Console.WriteLine("A Horror Story : by " + Author);
            Console.WriteLine("=============== CHAPTER 2 ================");
            Console.WriteLine("It was a dark night in " + Town
                + " and " + Name + " could hear " + Animal + "s screaming in the distance while listening to " + Song + " as " + Gender + " was walking home.");
            Console.WriteLine(Name + " sprinted, having dropped the " + Colour + " Coloured backpack that " + Gender + " was holding, running through the streets of " + Town
                + ", realising " + Gender + " had been followed.");
            Console.WriteLine("In the shadow of a doorway, a demented " + Job + " waited, clutching a menacing " + Weapon + " in his hand.");
        }
    }
}
