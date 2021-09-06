using System;

namespace GuessingGame1
{
    class Program
    {
        static void Main(string[] args)
        {
            string Difficulty = "";

            Console.WriteLine("Welcome To the Number Guessing Game!");

            //Select your difficult level
            Console.WriteLine("indicate the level you want to play \n (E for easy) \n (M for Medium) \n (H for Hard)");
            Console.Write("Difficulty: ");
            Difficulty = Console.ReadLine();
            Difficulty = Difficulty.ToUpper();

            if(Difficulty == "E")
            {
                Console.WriteLine("You have chosen the Easy Mode");
                Console.WriteLine("\n Guess a number from 1 to  10. You have up to 6 attempts ");
                int number = new Random().Next(1,10);

                int AllowedTrials = 6;
                int NoOfGuesses = 0;

                while(true)
                {
                    int Guess = int.Parse(Console.ReadLine());
                    NoOfGuesses++;

                    if(Guess == number)
                    {
                        Console.WriteLine("You guessed right!!!");
                        break;
                    }
                    else if(Guess < 1 || Guess > 10)
                    {
                        Console.WriteLine("Only numbers from 1 to 10 are allowed");
                        continue;
                    }

                    else if(NoOfGuesses == AllowedTrials)
                    {
                        Console.WriteLine("Sorry! You've exhausted your number of trials \n Try again... ");
                        break;
                    }

                    else
                    {
                        Console.WriteLine("Wrong!");
                    }

                    Console.WriteLine("Number of guesses so far is " + NoOfGuesses + "\n Continue guessing: ");

                }
            }

            else if(Difficulty == "M")
            {
                Console.WriteLine("You have chosen the Medium Mode");
                Console.WriteLine("\n Guess a number from 1 to  20. You have up to 4 attempts ");
                int number = new Random().Next(1,20);

                int AllowedTrials = 4;
                int NoOfGuesses = 0;

                while(true)
                {
                    int Guess = int.Parse(Console.ReadLine());
                    NoOfGuesses++;

                    if(Guess == number)
                    {
                        Console.WriteLine("You guessed right!!!");
                        break;
                    }
                    else if(Guess < 1 || Guess > 20)
                    {
                        Console.WriteLine("Only numbers from 1 to 20 are allowed");
                        continue;
                    }

                    else if(NoOfGuesses == AllowedTrials)
                    {
                        Console.WriteLine("Sorry! You've exhausted your number of trials \n Try again... ");
                        break;
                    }

                    else
                    {
                        Console.WriteLine("Wrong!");
                    }

                    Console.WriteLine("Number of guesses so far is " + NoOfGuesses + "\n Continue guessing: ");

                }
            }

            else if(Difficulty == "H")
            {
                Console.WriteLine("You have chosen the Hard Mode");
                Console.WriteLine("\n Guess a number from 1 to  50. You have up to 3 attempts ");
                int number = new Random().Next(1,50);

                int AllowedTrials = 3;
                int NoOfGuesses = 0;

                while(true)
                {
                    int Guess = int.Parse(Console.ReadLine());
                    NoOfGuesses++;

                    if(Guess == number)
                    {
                        Console.WriteLine("You guessed right!!!");
                        break;
                    }
                    else if(Guess < 1 || Guess > 50)
                    {
                        Console.WriteLine("Only numbers from 1 to 50 are allowed");
                        continue;
                    }

                    else if(NoOfGuesses == AllowedTrials)
                    {
                        Console.WriteLine("Sorry! You've exhausted your number of trials \n Try again... ");
                        break;
                    }

                    else
                    {
                        Console.WriteLine("Wrong!");
                    }

                    Console.WriteLine("Number of guesses so far is " + NoOfGuesses + "\n Continue guessing: ");

                }
            }

            else
            {
                Console.WriteLine("Please, select the difficulty level by typing in E, M or H");

            }
        


        }
    }
}
