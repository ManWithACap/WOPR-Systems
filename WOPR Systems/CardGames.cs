using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using static WOPR_Systems.Deck;

namespace WOPR_Systems
{
    public static class CardGames
    {
        public static class BlackJack
        {
            private static Deck myDeck;
            private static CardPlayer User;
            private static CardPlayer Computer;
            private static string wincondition;
            private static int numPasses;
            private static CardPlayer? Winner;

            public static void StartGame()
            {
                Console.Clear();
                Program.TypeOut("Setting up Black Jack.....\nPress any key to continue.....", 25, true, false);

                Winner = null;
                numPasses = 0;
                wincondition = "";
                myDeck = new Deck(true);
                Computer = new CardPlayer(2, myDeck);
                User = new CardPlayer(2, myDeck);

                Console.ReadKey();
                Console.Clear();



                Computer.CardList.ElementAt(0).Flip();
                Run();
            }

            public static void DisplayPlayerHand()
            {
                Console.WriteLine("YOUR HAND: ");
                for (int i = 0; i < User.CardList.Count; i++)
                {
                    if (i % 5 == 0)
                    {
                        User.CardList.ElementAt(i).Draw(true);
                    }
                    else
                    {
                        User.CardList.ElementAt(i).Draw();
                    }
                }
                Console.WriteLine("\n");
            }

            public static void DisplayComputerHand(bool allUp = false)
            {
                Console.WriteLine("OPPONENT'S HAND: ");
                if (allUp)
                {
                    Computer.CardList.ElementAt(0).Flip();
                }

                for (int i = 0; i < Computer.CardList.Count; i++)
                {
                    if (i % 5 == 0)
                    {
                        Computer.CardList.ElementAt(i).Draw(true);
                    }
                    else
                    {
                        Computer.CardList.ElementAt(i).Draw();
                    }
                }
                Console.WriteLine("");
            }

            public static void HandleInput()
            {
                Program.TypeOut("Current Score: > " + User.CalculateSum() + " <", 20, true);
                Program.TypeOut("\n(H)it, (P)ass or (F)old: ", 20, true, false);
                string input = Console.ReadLine();
                input = input.ToUpper();
                switch (input)
                {
                    case "H":
                        User.ParentDeck.Draw(User);
                        Console.WriteLine("\n\n\nYou drew:\n");
                        User.CardList.Last().Draw(true);
                        Console.Write("\nPress any key to continue...");
                        Console.ReadKey();
                        break;

                    case "P":
                        //...do nothing and pass turn (continue program and go to the below if statement chain)
                        numPasses += 1;
                        break;

                    case "F":
                        wincondition = "Loss by forefeit";
                        Winner = Computer; //...straight up forefeit
                        break;

                    default:
                        //...do nothing and restart the game loop (basically reprint screen and do the selection again)
                        Run();
                        break;
                }

                //calculate score and decide if there is a winner. if not, pass and continue game loop.
                if (User.CalculateSum() < 21)
                {
                    //...
                    ComputerInput();
                }
                else if (User.CalculateSum() == 21)
                {
                    wincondition = "Your score was: " + User.CalculateSum() + "\nYou win!";
                    Winner = User;
                }
                else if (User.CalculateSum() > 21)
                {
                    wincondition = "Your score was over 21...\nYou lose.";
                    Winner = Computer;
                }
            }

            public static void ComputerInput()
            {
                if (Computer.CalculateSum() <= 10)
                {
                    Computer.ParentDeck.Draw(Computer);
                }
                else
                {
                    numPasses += 1;
                }


                if (Computer.CalculateSum() < 21)
                {
                    //...
                }
                else if (Computer.CalculateSum() == 21)
                {
                    wincondition = "The computer hit 21 points before you!";
                    Winner = Computer;
                }
                else if (Computer.CalculateSum() > 21)
                {
                    wincondition = "The computer has bust! Their score was over 21.\nYou win!";
                    Winner = User;
                }


                if (numPasses >= 2)
                {
                    RevealHands();
                }
                else
                {
                    numPasses = 0;
                }
            }

            public static void RevealHands()
            {
                Console.Clear();
                DisplayPlayerHand();
                DisplayComputerHand(true);

                Program.TypeOut($"Your score: {User.CalculateSum()}   |   Computer's score: {Computer.CalculateSum()}\n\nPress any key to continue...", 20, true);
                Console.ReadKey();

                if (User.CalculateSum() > Computer.CalculateSum())
                {
                    wincondition = "You had a higher score than the computer! You win!";
                    Winner = User;
                }
                else if (User.CalculateSum() < Computer.CalculateSum())
                {
                    wincondition = "You had a lower score than the computer! You lose!";
                    Winner = Computer;
                }
                else
                {
                    wincondition = "No winner! You've tied!";
                }
            }

            public static void Run()
            {
                while (true)
                {
                    Console.Clear();

                    DisplayPlayerHand();

                    DisplayComputerHand();

                    HandleInput();

                    if(Winner != null)
                    {
                        if (Winner == User)
                        {
                            Console.Clear();
                            Console.WriteLine(wincondition + "\n\n");
                            /*        ___  __   __ _   ___  ____   __  ____  _  _  __     __  ____  __  __   __ _  ____  _   
                                     / __)/  \ (  ( \ / __)(  _ \ / _\(_  _)/ )( \(  )   / _\(_  _)(  )/  \ (  ( \/ ___)/ \  
                                    ( (__(  O )/    /( (_ \ )   //    \ )(  ) \/ (/ (_/\/    \ )(   )((  O )/    /\___ \\_/  
                                     \___)\__/ \_)__) \___/(__\_)\_/\_/(__) \____/\____/\_/\_/(__) (__)\__/ \_)__)(____/(_)  
                                                     _  _  __   _  _  _ _  _  ____    _  _   __   __ _  _                    
                                                    ( \/ )/  \ / )( \(// )( \(  __)  / )( \ /  \ (  ( \/ \                   
                                                     )  /(  O )) \/ (  \ \/ / ) _)   \ /\ /(  O )/    /\_/                   
                                                    (__/  \__/ \____/   \__/ (____)  (_/\_) \__/ \_)__)(_)                   
                             */
                            Console.WriteLine("  ___  __   __ _   ___  ____   __  ____  _  _  __     __  ____  __  __   __ _  ____  _   \r\n / __)/  \\ (  ( \\ / __)(  _ \\ / _\\(_  _)/ )( \\(  )   / _\\(_  _)(  )/  \\ (  ( \\/ ___)/ \\  \r\n( (__(  O )/    /( (_ \\ )   //    \\ )(  ) \\/ (/ (_/\\/    \\ )(   )((  O )/    /\\___ \\\\_/  \r\n \\___)\\__/ \\_)__) \\___/(__\\_)\\_/\\_/(__) \\____/\\____/\\_/\\_/(__) (__)\\__/ \\_)__)(____/(_)  \r\n _  _  __   _  _  _ _  _  ____    _  _   __   __ _  _                                    \r\n( \\/ )/  \\ / )( \\(// )( \\(  __)  / )( \\ /  \\ (  ( \\/ \\                                   \r\n )  /(  O )) \\/ (  \\ \\/ / ) _)   \\ /\\ /(  O )/    /\\_/                                   \r\n(__/  \\__/ \\____/   \\__/ (____)  (_/\\_) \\__/ \\_)__)(_)                                   ");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("\n\nYOU HAVE LOST! COMPUTER IS THE WINNER!\nTAKE THAT, PUNY HUMAN!");
                            break;
                        }
                    }

                    Thread.Sleep(20);
                }
            }
        }
    }
}
