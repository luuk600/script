//namespace opdracht
//{
//    using System;

//    class Program
//    {
//        static void Main()
//        {

//            string[] playerNames = new string[] { "Player1", "Player2", "Player3", "Player4" };


//            foreach (string playerName in playerNames)
//            {

//                int roll = RollDie();


//                Console.WriteLine($"{playerName} rolled a {roll}");
//            }
//        }


//        static int RollDie()
//        {
//            Random random = new Random();
//            return random.Next(1, 11); 
//        }
//    }
//}


using System.Security.Cryptography.X509Certificates;

using static System.Net.Mime.MediaTypeNames;

namespace Cat_Roulette

{

    internal class Program

    {

        static void Main(string[] args)

        {

            int CannonRounds = 6;

            string[] Catnumber = new string[CannonRounds];

            Random RNGCat = new Random();

            string GiveShoot;

            int CatNumber;

            bool catShot = false;

            int numOfPlayers = 2;

            string[] playerNames = new string[numOfPlayers];



            int rollD20;

            Random RNG = new Random();

            Menu();

            void Menu()

            {

                while (true)
                {
                    Console.Clear();
                    Console.WriteLine("Welcome to the Game Menu");
                    Console.WriteLine("1. See the rules");
                    Console.WriteLine("2. Play the game");
                    Console.WriteLine("3. Quit the application");

                    Console.Write("Enter your choice (1-3): ");
                    string choice = Console.ReadLine();

                    if (choice == "1")
                    {
                        Rules();
                    }
                    else if (choice == "2")
                    {
                        Game();
                    }
                    else if (choice == "3")
                    {
                        Quit();
                    }
                    else
                    {
                        Console.WriteLine("Invalid choice. Please enter a number between 1 and 3.");
                    }


                }


                for (int i = 0; i < playerNames.Length; i++)

                {

                    Console.Clear();

                    Console.Write($"Player {i + 1}, Please enter your username: ");

                    playerNames[i] = Console.ReadLine();

                    Console.WriteLine($"You have entered the name: {playerNames[i]}");

                    Console.WriteLine();

                }

                Console.Clear();

                Console.WriteLine($"you have chosen the names: {playerNames[0]} & {playerNames[1]}");

                Console.WriteLine();

                //cat roulette starts

                if (catShot == false)

                {

                    CatRoulette();

                }

                void CatRoulette()

                {

                    for (int i = 0; i < Catnumber.Length; i++)

                    {

                        Console.Write($"{playerNames[0]}, Type shoot and press enter: ");

                        GiveShoot = Console.ReadLine();

                        if (GiveShoot == "shoot")

                        {

                            CatNumber = RNGCat.Next(1, 9);

                            if (CatNumber == 7)

                            {

                                catShot = true;

                                Console.Clear();

                                Console.WriteLine("You shot a cat with the cannon");

                                WinningScreenP1();

                            }

                            if (CatNumber == 8)

                            {

                                catShot = true;

                                Console.Clear();

                                Console.WriteLine("You shot a cat with the cannon");

                                WinningScreenP1();

                            }

                            else

                            {

                                Console.Clear();

                                Console.WriteLine("Nothing Happened");

                            }

                            //Console.WriteLine($"Player Two Rolled: {CatNumber}");

                        }

                        else

                        {

                            Console.WriteLine("That is an Invalid input");

                        }


                        Console.Write($"{playerNames[1]}, Type shoot and press enter: ");

                        GiveShoot = Console.ReadLine();


                        if (GiveShoot == "shoot")

                        {

                            CatNumber = RNGCat.Next(1, 9);

                            if (CatNumber == 7)

                            {

                                catShot = true;

                                Console.Clear();

                                Console.WriteLine("You shot a cat with the cannon");

                                WinningScreenP2();

                            }

                            if (CatNumber == 8)

                            {

                                catShot = true;

                                Console.Clear();

                                Console.WriteLine("You shot a cat with the cannon");

                                WinningScreenP2();

                            }

                            else

                            {

                                Console.Clear();

                                Console.WriteLine("Nothing Happened");

                            }

                            //Console.WriteLine($"Player Two Rolled: {CatNumber}");

                        }

                        else

                        {

                            Console.Clear();

                            Console.WriteLine("That is an Invalid input");

                            CatRoulette();

                        }



                    }


                    void WinningScreenP1()

                    {

                        Console.WriteLine($"Congrats {playerNames[0]}, You have won the game!");

                        //Application.Exit();

                    }

                    void WinningScreenP2()

                    {

                        Console.WriteLine($"Congrats {playerNames[1]}, You have won the game!");

                    }


                    //Console.WriteLine("Welcome to cat roulette user!");

                    //Console.WriteLine("Please type shoot and press enter to start cat roulette");

                    //GiveShoot = Console.ReadLine();


                }


            }
             void Rules()
            {
                Console.Clear();
                Console.WriteLine("Here are the rules: ");

                Console.WriteLine("Each player takes turnes until the cannon has been fired 8 times or until the cannon goes off and hits a cat.");

                Console.WriteLine("the player that hits the cat has won the game.");

                Console.WriteLine();

                Console.WriteLine("Press enter if you want to go to the main menu: ");

                Console.ReadLine();

            }
            void Game()
            {
                Console.Clear();
                Console.WriteLine("Let's play the game!");


                Console.Write("\nPress Enter to return to the main menu...");
                Console.ReadLine();
            }
            void Quit()
            {
                Console.Clear();
                Console.WriteLine("Exiting the game. Goodbye!");
                Environment.Exit(0);
            }


        }

    }
}

