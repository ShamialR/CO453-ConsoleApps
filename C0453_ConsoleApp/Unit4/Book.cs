using System;


namespace C0453_ConsoleApp.Unit4
{
    class Book
    {
        private string author;
        private string name, town, animal, weapon, job, colour, song, sex, gender;

        //**********************************
        public string ask(string prompt)    // use prompt to ask for info
        {
            string answer;
            Console.Write(prompt);
            answer = Console.ReadLine();
            return answer;
        }
        //***********************************
        public void getDetails()
        {
            author = ask("Please type your name : ");
            name = ask("Please type a friend's name : ");
            town = ask("Now give me the name of a town : ");


            animal = ask("Now a type of animal : ");
            job = ask("Now a type of job : ");
            weapon = ask("And your weapon of choice : ");

            sex = ask("Are you male or female : ");
            colour = ask("What's your favourite color : ");
            song = ask("What's your favourite song : ");
        }
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
        //****************************************

        public void writeChapter1()
        {
            Console.Clear();
            Console.WriteLine("A Horror Story : by " + author);
            Console.WriteLine("=============== CHAPTER 1 ================");
            Console.WriteLine("It was a dark night in " + town
                + " and " + name + " could hear " + animal + "s screaming in the distance.");
            Console.WriteLine(name + " staggered terrified through the streets of " + town
                + ", realising " + gender + " had been followed.");
            Console.WriteLine("In the shadow of a doorway, a demented " + job + " waited, clutching a menacing " + weapon + " in his hand.");
        }
        //****************************************

        public void writeChapter2()
        {
            Console.WriteLine("A Horror Story : by " + author);
            Console.WriteLine("=============== CHAPTER 2 ================");
            Console.WriteLine("It was a dark night in " + town
                + " and " + name + " could hear " + animal + "s screaming in the distance while listening to " + song + " walking home.");
            Console.WriteLine(name + " staggered, having dropped his " + colour + " backpack, terrified through the streets of " + town
                + ", realising " + gender + " had been followed.");
            Console.WriteLine("In the shadow of a doorway, a demented " + job + " waited, clutching a menacing " + weapon + " in his hand.");
        }
    }
}
