using System;

namespace C0453_ConsoleApp.Unit4
{
    /// <summary>
    /// Task 4.2 & 4.3 Horror Story
    /// This class will using preset or manually entered details, write a story based on the users details
    /// Author: Shamial Rashid 21905385
    /// </summary>
    class Book
    {
        private string author;
        private string name, town, animal, weapon, job, colour, song, sex, gender, answer;
        /// <summary>
        /// This public Book method has a set of default data that can be entered into the story
        /// </summary>
        public Book()
        {
            author = "Shamial";
            name = "John";
            town = "High Wycombe";


            animal = "Cat";
            job = "Architect";
            weapon = "Pencil";

            sex = "male";
            colour = "Red";
            song = "Queen";
        }
        /// <summary>
        /// This is a method which can be called whenever a question is asked using the parameter in the method to get the question and then send it back using return.
        /// </summary>
        public string GetString(string prompt)
        {
            string answer;
            Console.Write(prompt);
            answer = Console.ReadLine();
            return answer;
        }
        /// <summary>
        /// This calls the Ask method and gets the data that will be entered into the book if the user wanted to manually enter it
        /// </summary>
        public void GetDetails()
        {
            Console.WriteLine("Would you like to use Default or Manual Answers");
            answer = Console.ReadLine();

            if (answer == "Manual")
            {
                author = GetString("Please type your Name : ");
                name = GetString("Please type a friend's Name : ");
                town = GetString("Now give me the Name of a Town : ");


                animal = GetString("Now a type of Animal : ");
                job = GetString("Now a type of Job : ");
                weapon = GetString("And your Weapon of choice : ");

                sex = GetString("Are you male or female : ");
                colour = GetString("What's your favourite color : ");
                song = GetString("What's your favourite band : ");
            }
        }
        /// <summary>
        /// speprate method which using the gender the user previously input will set the gender to he or she which will be displayed in the story 
        /// </summary>
        public void CheckGender()
        {
            if (sex == "male" || sex == "M" || sex == "m")
            {
                gender = "he";
            }
            else if (sex == "female" || sex == "f" || sex == "F")
            {
                gender = "she";
            }
            else
            {
                gender = "they";
            }
        }
        /// <summary>
        /// This method actually writes the first chapter of the story using the data previously collected or the default data
        /// </summary>
        public void WriteChapter1()
        {
            Console.Clear();
            Console.WriteLine("A Horror Story : by " + author);
            Console.WriteLine("=============== CHAPTER 1 ================");
            Console.WriteLine("It was a dark night in " + town
                + " and " + name + " could hear " + animal + "s screaming in the distance.");
            Console.WriteLine(name + " staggered terrified through the streets of " + town
                + ", realising that " + gender + " had been followed.");
            Console.WriteLine("In the shadow of a doorway, a demented " + job + " waited, clutching a menacing " + weapon + " in his hand.");
        }
        /// <summary>
        /// This method writes the second chapter of the story using the data previously collected or the default data
        /// </summary>
        public void WriteChapter2()
        {
            Console.WriteLine("A Horror Story : by " + author);
            Console.WriteLine("=============== CHAPTER 2 ================");
            Console.WriteLine("It was a dark night in " + town
                + " and " + name + " could hear " + animal + "s screaming in the distance while listening to " + song + " as " + gender + " was walking home.");
            Console.WriteLine(name + " sprinted, having dropped the " + colour + " Coloured backpack that " + gender + " was holding, running through the streets of " + town
                + ", realising " + gender + " had been followed.");
            Console.WriteLine("This time there was nobody waiting there so she was quite happy going on her way.");
        }
    }
}