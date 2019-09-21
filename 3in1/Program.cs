using System;

namespace _3in1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello! Here we can play some games. How should I call you?");
            string player = Console.ReadLine();
            Console.WriteLine($"Ok, {player}, type 1-3 to choose a game or anything else to quit and press <Enter>");
            GameChoice();
        }
        static void GameChoice()
        {
            Console.WriteLine("1. \"You guess the number\"");
            Console.WriteLine("2. \"AI guesses the number\"");
            Console.WriteLine("3. \"Journey to Sphynx\"");
            ChoiceAlg();
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
            Console.WriteLine("Ok, now AI will set a number from 1 to 100 and you'll have to try to guess it");
            Console.WriteLine("Type your guesses and press <Enter>");
            AIGuessAlg();
        }
        static int RandomizedNumber()
        {
            Random number = new Random();
            int SetNmbr = number.Next(1, 100);
            return SetNmbr;
        }
        static void AIGuessAlg()
        {
            int AInmbr = RandomizedNumber();
            bool flag = true;
            while (flag)
            {
                bool guessCheck = Int32.TryParse(Console.ReadLine(), out int guess);
                if (guess > 100 || guess < 1 || guessCheck == false)
                {
                    Console.WriteLine($"You should choose numbers from 1 to 100");
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
                    Console.WriteLine("That's it! Now you may try other games");
                    GameChoice();
                }
            }
        }
        static void YouGuess()
        {

        }
        static void Sphynx()
        {

        }
        static void Exit()
        {
            Console.WriteLine("See you later!");
            Console.ReadLine();
        }
    }
}
