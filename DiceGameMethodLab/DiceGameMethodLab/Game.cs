using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceGameMethodLab
{
    internal class Game
    {
        //Member Variables - Declares variables that can be accessed anywhere in this class
        int playerOneScore;
        int playerTwoScore;
        
        Random rand;

        //Constructor - Sets the scores to 0 when a new game is created
        public Game()
        {
            playerOneScore = 0;
            playerTwoScore = 0;
            rand = new Random();
        }

        //Member Methods
        public int RollDice(int numberOfSides)
        {
            //This method is complete! When called, it will return a random number.
            //You will need to pass in an integer as the parameter to represent the
            //number of sides of the dice being rolled.
            return rand.Next(numberOfSides);
        }

        public void DisplayWelcome()
        {
            //This method is complete! It will display a welcome message to the player
            //Notice that it is already being called inside the RunGame() method,
            //so it will run when you start the application.
            Console.WriteLine("Welcome to the game!");
        }

        //Don't change anything above this ^^^^^^^^^^^^



        public int ChooseNumberOfSides()
        {
            //This method should prompt the user to enter the number of sides,
            //capture user input and return it after converting it to an integer.
            //This method only needs to be called once in RunGame(), but the returned
            //value should be captured as a variable that will be passed into the
            //RollDice() method each time it's called.
            
            Console.WriteLine("Please enter number of sides:");
            int numberOfSides = Convert.ToInt32(Console.ReadLine());

            return numberOfSides;
        }

        public int ChooseNumberOfRounds()
        {
            Console.WriteLine("Please enter number of rounds you want to play");
            int numberOfRounds = Convert.ToInt32(Console.ReadLine());

            return numberOfRounds;
        }


        public void CompareRolls(int playerOneRoll, int playerTwoRoll)
        {
            //This method should compare the two parameter values, then increase the
            //score of whoever's roll is higher
            //For example, if playerOneRoll is 5 and playerTwoRoll is 2,
            //playerOneScore should be increased by 1.
            Console.WriteLine($"Player one roll {playerOneRoll}");
            Console.WriteLine($"Player two roll {playerTwoRoll}");

            if (playerOneRoll > playerTwoRoll)
            {
                Console.WriteLine("Player one wins the round!");
                playerOneScore++;
            }
            else if(playerOneRoll < playerTwoRoll)
            {
                Console.WriteLine("Player two wins the round!");
                playerTwoScore++;
            }
            else
            {
                Console.WriteLine("Tie round!");
            }

            Console.WriteLine();
        }


        public void DisplayWinner()
        {
            //This method should print a message declaring the winner of the game,
            //ie, the first player who reaches a score of 3

                if(playerOneScore > playerTwoScore)
                {
                    Console.WriteLine("Player One wins the game!");
                }
                else if(playerOneScore < playerTwoScore)
                {
                    Console.WriteLine("Player Two wins the game!");
                }
                else
                {
                    Console.WriteLine($"Tie game! Player one: {playerOneScore}. Player two: {playerTwoScore}");
                }
        }


        public void RunGame()
        {
            //This is the main method that is called in the Program when you press Start
            //Call your other methods inside this method
            //You should incorporate a loop to allow for rounds of play
            //to continue until there is a winner
            int numberOfsides = 0;
            int numberOfRounds = 0;
            DisplayWelcome();
            while (true)
            {
                try
                {
                    numberOfsides = ChooseNumberOfSides();
                    numberOfRounds = ChooseNumberOfRounds();

                    break;
                }
                catch (Exception)
                {
                    Console.WriteLine("You must enter the number, wrong input\n");
                }
            }
            

            int counter = 0;

            while (counter != numberOfRounds)
            {
                CompareRolls(RollDice(numberOfsides), RollDice(numberOfsides));

                counter++;
            }

            DisplayWinner();
        }
    }
}









//namespace DiceGameMethodLab
//{
//    internal class Game
//    {
//        //Member Variables - Declares variables that can be accessed anywhere in this class
//        int playerOneScore;
//        int playerTwoScore;
//        Random rand;

//        //Constructor - Sets the scores to 0 when a new game is created
//        public Game()
//        {
//            playerOneScore = 0;
//            playerTwoScore = 0;
//            rand = new Random();
//        }

//        //Member Methods
//        public int RollDice(int numberOfSides)
//        {
//            //This method is complete! When called, it will return a random number.
//            //You will need to pass in an integer as the parameter to represent the
//            //number of sides of the dice being rolled.
//            return rand.Next(numberOfSides);
//        }

//        public void DisplayWelcome()
//        {
//            //This method is complete! It will display a welcome message to the player
//            //Notice that it is already being called inside the RunGame() method,
//            //so it will run when you start the application.
//            Console.WriteLine("Welcome to the game!");
//        }

//        //Don't change anything above this ^^^^^^^^^^^^


//        public int ChooseNumberOfSides()
//        {
//            //This method should prompt the user to enter the number of sides,
//            //capture user input and return it after converting it to an integer.
//            //This method only needs to be called once in RunGame(), but the returned
//            //value should be captured as a variable that will be passed into the
//            //RollDice() method each time it's called.

//            Console.WriteLine("Please enter number of sides:");
//            int numberOfSides = Convert.ToInt32(Console.ReadLine());

//            return numberOfSides;
//        }


//        public void CompareRolls(int playerOneRoll, int playerTwoRoll)
//        {
//            //This method should compare the two parameter values, then increase the
//            //score of whoever's roll is higher
//            //For example, if playerOneRoll is 5 and playerTwoRoll is 2,
//            //playerOneScore should be increased by 1.
//            Console.WriteLine($"Player one roll {playerOneRoll}");
//            Console.WriteLine($"Player two roll {playerTwoRoll}");

//            if (playerOneRoll > playerTwoRoll)
//            {
//                Console.WriteLine("Player one wins the round!");
//                playerOneScore++;
//            }
//            else if (playerOneRoll < playerTwoRoll)
//            {
//                Console.WriteLine("Player two wins the round!");
//                playerTwoScore++;
//            }
//            else
//            {
//                Console.WriteLine("Tie round!");
//            }

//            Console.WriteLine();
//        }


//        public void DisplayWinner()
//        {
//            //This method should print a message declaring the winner of the game,
//            //ie, the first player who reaches a score of 3

//            if (playerOneScore == 3)
//            {
//                Console.WriteLine("Player One wins the game!");
//            }
//            else
//            {
//                Console.WriteLine("Player Two wins the game!");
//            }
//        }


//        public void RunGame()
//        {
//            //This is the main method that is called in the Program when you press Start
//            //Call your other methods inside this method
//            //You should incorporate a loop to allow for rounds of play
//            //to continue until there is a winner

//            DisplayWelcome();
//            int numberOfsides = ChooseNumberOfSides();

//            while (true)
//            {
//                CompareRolls(RollDice(numberOfsides), RollDice(numberOfsides));

//                if (playerOneScore == 3 || playerTwoScore == 3)
//                {
//                    break;
//                }
//            }

//            DisplayWinner();
//        }
//    }
//}