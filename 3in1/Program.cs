using System;

namespace _3in1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello! Here we can play some games. How should I call you?");
            string name = SetName();
            Console.WriteLine($"Ok, {name}, type 1-3 to choose a game or anything else to quit and press <Enter>");
            GameChoice();
        }
        static void Replay()
        {
            Console.WriteLine("Type 1-3 to choose a game or anything else to quit and press <Enter>");
            GameChoice();
        }
        static void GameChoice()
        {
            Console.WriteLine("1. \"You guess the number\"");
            Console.WriteLine("2. \"AI guesses the number\"");
            Console.WriteLine("3. \"Journey to Sphynx\"");
            ChoiceAlg();
        }
        static string SetName()
        {
            string player = Console.ReadLine();
            return player;
        }
        static void ChoiceAlg()
        {
            string choice = Console.ReadLine();
            if (choice == "1")
            {
                YouGuess();
            }
            else if (choice == "2")
            {
                AIGuess();
            }
            else if (choice == "3")
            {
                Sphynx();
            }
            else
            {
                Exit();
            }
        }
        static void AIGuess()
        {
            Console.WriteLine("Ok, now AI will set a number from 1 to 100 and you'll have to try to guess it \nType your guesses and press <Enter>");
            AIGuessAlg();
        }
        static void AIGuessAlg()
        {
            int AInmbr = RandomizedNumber();
            while (true)
            {
                bool guessCheck = Int32.TryParse(Console.ReadLine(), out int guess);
                if (guess > 100 || guess < 1 || guessCheck == false)
                {
                    Console.WriteLine("You should choose numbers from 1 to 100");
                }
                else if (guess > AInmbr)
                {
                    Console.WriteLine("Not so big! Try again, please");
                }
                else if (guess < AInmbr)
                {
                    Console.WriteLine("Not so small! Try again, please");
                }
                else if (guess == AInmbr)
                {
                    Console.WriteLine("That's it! Now you can try other games");
                    Replay();
                }
            }
        }
        static int RandomizedNumber()
        {
            Random number = new Random();
            int SetNmbr = number.Next(1, 100);
            return SetNmbr;
        }
        static void YouGuess()
        {
            Console.WriteLine("Here AI will try to guess your number. It should be 1-100. Don't enter it, only keep in mind!" +
            "\nEnter \"<\" if guessed number is too big, \">\" - if too small, or \"=\" when AI is right.");
            YouGuessAlg();
        }
        static void YouGuessAlg()
        {
            Console.WriteLine("Not done yet, sorry.");
            Replay();
        }
        static void Sphynx()
        {
            SphStart();
            StartingChoice();
        }
        static string SphStart()
        {
            Console.WriteLine("Hello Stranger! You're now at the beginning of a dangerous journey." +
                "\n Are you ready to start ?");
            string firstAnswer = Console.ReadLine();
            firstAnswer.ToLower();
            return firstAnswer;
        }
        static void StartingChoice()
        {
            while (SphStart() != "yes")
            {
                if (SphStart() == "yes")
                {
                    Console.WriteLine("A large door in the rock is opened before you and you made a step inside." +
                        "\nThe darkness surrounds and you see only a small plate on the wall in front of you." +
                        "\nIt says: \"Next you'll have no right for a mistake\"." +
                        "\nOn reading these lines you feel that something stares at you. What will you do?");
                }
                else if (SphStart() == "no")
                {
                    Console.WriteLine("Actually, you have no right to choose.");
                }
                else
                {
                    Console.WriteLine("You must type <yes> or <no>.");
                }
            }
            PreSecondChoice();
        }
        static string PreSecondChoice()
        {
            Console.WriteLine("You may <run>, <turn back> or <do nothing>");
            string secondAnswer = Console.ReadLine();
            secondAnswer.ToLower();
            return secondAnswer;
        }
        static void SecondChoice()
        {
            while (PreSecondChoice() != "turn back")
            {
                if (PreSecondChoice() == "run")
                {
                    Console.WriteLine("You started to run from the horrifying stare and suddenly fell into the abyss.");
                    BadEnd();
                }
                else if (PreSecondChoice() == "do nothing")
                {
                    Console.WriteLine("The darkness swallowed you.");
                    BadEnd();
                }
                else if (PreSecondChoice() == "turn back")
                {
                    Console.WriteLine("You slowly turned back and saw a giant Sphynx.");
                    MeetSphynx();
                }
            }
        }
        static void MeetSphynx()
        {
            Console.WriteLine("He looked at you with his sparkling eyes and said \"The time for riddles has come." +
            "\nSo, the first one is:" +
            "\n\"I am born of water but when I return to water, I die. What am I?\"");
            string firstRiddle = Console.ReadLine();
            firstRiddle.ToLower();
            while (firstRiddle != "ice")
            {
                if (firstRiddle == "ice")
                {
                    Console.WriteLine("\"Well done! The next riddle.");
                    SecondRiddle();
                }
                else
                {
                    Console.WriteLine("\"You should think harder. My patience's for you. Listen again:");
                }
            }
        }
        static void SecondRiddle()
        {
            Console.WriteLine("\"What gives you the strength and power to walk through a wall?\"");
            string secondRiddle = Console.ReadLine();
            secondRiddle.ToLower();
            while (secondRiddle != "door")
            {
                if (secondRiddle == "door")
                {
                    Console.WriteLine("\"Well. We're coming to an end.");
                    LastRiddle();
                }
                else
                    Console.WriteLine("\"Think harder! My patience is almost out. I repeat:");
            }
        }
        static void LastRiddle()
        {
            Console.WriteLine("Now you'll have only one chance. Listen attentively and show your best." +
            "\n\"Which creature walks on four legs in the morning, two legs in the afternoon, and three legs in the evening?\"");
            string lastRiddle = Console.ReadLine();
            lastRiddle.ToLower();
            if (lastRiddle == "human")
            {
                Console.WriteLine("\"Great! For now you'll be rewarded.\"");
                GoodEnd();
            }
            else
            {
                Console.WriteLine("\"So, it was your last mistake.\"");
                PreBadEnd();
            }
        }
        static void PreBadEnd()
        {
            Console.WriteLine("The Spynx looked disappointed with you. +" +
                "\nThe last you saw was the darkness of his abysmal throat.");
            BadEnd();
        }
        static void BadEnd()
        {
            Console.WriteLine("Your journey is over. You died.");
            Ending();
        }
        static void GoodEnd()
        {
            Console.WriteLine("The Spnynx is pleased with your answer." +
            "\nHe slowly disappears leaving you a beutiful gem. This is your prize." +
            "\nThe rocks has opened, and you see the light. Now you may go home");
            Ending();
        }
        static void Ending()
        {
            Console.WriteLine("Enter <1> to start once again or any key to quit.");
            string answer = Console.ReadLine();
            if (answer == "1")
            {
                Replay();
            }
            else
            {
                Console.WriteLine("Bye.");
                Exit();
            }
        }
        static void Exit()
        {
            Console.WriteLine("See you later!");
        }
    }
}

