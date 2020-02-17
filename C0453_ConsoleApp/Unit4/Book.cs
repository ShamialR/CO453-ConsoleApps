using System;


namespace C0453_ConsoleApp.Unit4
{
    class Book
    {
        private string Author;
        private string Name, Town, Animal, Weapon, Job, Colour, Song, Sex, Gender, Answer;

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
        //**********************************
        public string Ask(string prompt)    // use prompt to Ask for info
        {
            string Answer;
            Console.Write(prompt);
            Answer = Console.ReadLine();
            return Answer;
        }
        //***********************************
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
        //****************************************

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
        //****************************************

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
