namespace week5._2
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
            bool catshot = false;
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
                catshot = false;
                while (!catshot)
                {
                    for (int i = 0; i < Catnumber.Length; i++)
                    {

                        Console.Write($"{playerNames[0]}, Type shoot and press enter: ");
                        GiveShoot = Console.ReadLine();
                        if (GiveShoot == "")
                        {
                            CatNumber = RNGCat.Next(1, 9);

                            if (CatNumber == 7)
                            {
                                Console.Clear();
                                Console.WriteLine("You shot a cat with the cannon");
                                catshot = true;
                                WinningScreenP1();
                            }
                            if (CatNumber == 8)
                            {
                                Console.Clear();
                                Console.WriteLine("You shot a cat with the cannon");
                                catshot = true;
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


                        if (GiveShoot == "")
                        {
                            CatNumber = RNGCat.Next(1, 9);

                            if (CatNumber == 7)
                            {
                                Console.Clear();
                                Console.WriteLine("You shot a cat with the cannon");
                                WinningScreenP2();
                                catshot = true;
                            }
                            if (CatNumber == 8)
                            {
                                Console.Clear();
                                Console.WriteLine("You shot a cat with the cannon");
                                WinningScreenP2();
                                catshot = true;
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
                        string again;
                        Console.WriteLine($"Congrats {playerNames[0]}, You have won the game!");
                        Console.WriteLine("if you want to play again type yes");
                        Console.WriteLine("if you want to leave type no");
                        again = Console.ReadLine();
                        if (again == "yes")
                        {
                            CatRoulette();
                            Console.WriteLine("lets start again");
                        }
                        else if (again == "no")
                        {
                            Environment.Exit(0);
                            Console.WriteLine("lets start again");
                        }
                        else
                        {
                            Console.WriteLine("thats not an option");
                            WinningScreenP1();
                        }
                    }
                    void WinningScreenP2()
                    {
                        string again;
                        Console.WriteLine($"Congrats {playerNames[1]}, You have won the game!");
                        Console.WriteLine("if you want to play again type yes");
                        Console.WriteLine("if you want to leave type no");
                        again = Console.ReadLine();
                        if( again == "yes")
                        {
                            CatRoulette();
                            Console.WriteLine("lets start again");
                        }
                        else if ( again == "no") 
                        { 
                            Environment.Exit(0);
                            Console.WriteLine("lets start again");
                        }
                        else
                        {
                            Console.WriteLine("thats not an option");
                            WinningScreenP2();
                        }
                    }
                }
            }


                //Console.WriteLine("Welcome to cat roulette user!");
                //Console.WriteLine("Please type shoot and press enter to start cat roulette");
                //GiveShoot = Console.ReadLine();


            }



        }
    }   
