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
                Console.WriteLine("Welcome to Cat Roulette!");
                Console.WriteLine();
                Console.WriteLine("Here are the rules: ");
                Console.WriteLine("Each player takes turnes until the cannon has been fired 8 times or until the cannon goes off and hits a cat.");
                Console.WriteLine("the player that hits the cat has won the game.");
                Console.WriteLine();
                Console.WriteLine("Press enter if you want to play the game: ");
                Console.ReadLine();
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
           
                CatRoulette();
           

            void CatRoulette()
            {

                    for (int i = 0; i < Catnumber.Length; i++)
                    {
                if (catShot == false)
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
    }
}