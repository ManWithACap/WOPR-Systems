using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace WOPR_Systems
{
    class Toolbox
    {
        public static void TitleCard()
        {
            SoundPlayer player = new SoundPlayer("./Assets/Sounds/title card intro.wav");
            player.Play();
            Console.WriteLine();
            Program.CenterType(" __          __  _                            _         "); Task.WaitAll(Task.Delay(250));
            Program.CenterType(@" \ \        / / | |                          | |        "); Task.WaitAll(Task.Delay(250));
            Program.CenterType(@"  \ \  /\  / /__| | ___ ___  _ __ ___   ___  | |_ ___   "); Task.WaitAll(Task.Delay(250));
            Program.CenterType(@"   \ \/  \/ / _ \ |/ __/ _ \| '_ ` _ \ / _ \ | __/ _ \  "); Task.WaitAll(Task.Delay(150));
            Program.CenterType(@"    \  /\  /  __/ | (_| (_) | | | | | |  __/ | || (_) | "); Task.WaitAll(Task.Delay(150));
            Program.CenterType(@"     \/  \/ \___|_|\___\___/|_| |_| |_|\___|  \__\___/  "); Task.WaitAll(Task.Delay(100));
            Color screenTextColor = Color.Red;
            Color screenBackgroundColor = Color.Black;
            int irc = SetScreenColorsApp.SetScreenColors(screenTextColor, screenBackgroundColor);
            Program.CenterType("  _ ___          ______  _____  _____     _____           _                    _ _   _   _ "); Task.WaitAll(Task.Delay(100));
            Program.CenterType(@" ( | ) \        / / __ \|  __ \|  __ \   / ____|         | |                  ( | ) | | | |"); Task.WaitAll(Task.Delay(50));
            Program.CenterType(@"  V V \ \  /\  / / |  | | |__) | |__) | | (___  _   _ ___| |_ ___ _ __ ___  ___V V  | | | |"); Task.WaitAll(Task.Delay(50));
            Program.CenterType(@"       \ \/  \/ /| |  | |  ___/|  _  /   \___ \| | | / __| __/ _ \ '_ ` _ \/ __|    | | | |"); Task.WaitAll(Task.Delay(50));
            Program.CenterType(@"        \  /\  / | |__| | |    | | \ \   ____) | |_| \__ \ ||  __/ | | | | \__ \    |_| |_|"); Task.WaitAll(Task.Delay(50));
            Program.CenterType(@"         \/  \/   \____/|_|    |_|  \_\ |_____/ \__, |___/\__\___|_| |_| |_|___/    (_) (_)"); Task.WaitAll(Task.Delay(25));
            Program.CenterType(@"                                                 __/ |                                     "); Task.WaitAll(Task.Delay(25));
            Program.CenterType(@"                                                |___/                                      "); Task.WaitAll(Task.Delay(300));
            Console.WriteLine();
            screenTextColor = Color.FromArgb(100, 205, 250);
            screenBackgroundColor = Color.Black;
            irc = SetScreenColorsApp.SetScreenColors(screenTextColor, screenBackgroundColor);
            Program.CenterType(" _______________________________________________________________ "); Task.WaitAll(Task.Delay(100));
            Program.CenterType("|                                                               |"); Task.WaitAll(Task.Delay(100));
            Program.CenterType("|       This is an interactive experience developed by Cappy    |"); Task.WaitAll(Task.Delay(100));
            Program.CenterType("|     and highly inspired by the movie Wargames from 1983.      |"); Task.WaitAll(Task.Delay(100));
            Program.CenterType("|     I definitely recommend you watch it before playing.       |"); Task.WaitAll(Task.Delay(100));
            Program.CenterType("|     It is a unique and creative movie. It is also a good      |"); Task.WaitAll(Task.Delay(100));
            Program.CenterType("|     idea to watch the movie because there is a lot of         |"); Task.WaitAll(Task.Delay(100));
            Program.CenterType("|     references and easter eggs for the movie. So you might    |"); Task.WaitAll(Task.Delay(100));
            Program.CenterType("|     not understand or find them all.                          |"); Task.WaitAll(Task.Delay(100));
            Program.CenterType("|                                                               |"); Task.WaitAll(Task.Delay(100));
            Program.CenterType("|                 Either way, I hope you enjoy the experience!  |"); Task.WaitAll(Task.Delay(100));
            Program.CenterType("|_______________________________________________________________|", false);
            Console.ReadKey();
            Console.Write("Press any key...");
            Console.ReadKey();
            player.Stop();
        }

        public static void DialingNumbers()
        {
            Console.Clear();
            SoundPlayer player = new SoundPlayer("./Assets/Sounds/intro.wav");
            player.Play();
            Console.WriteLine("TO SCAN FOR CARRIER TONES, PLEASE LIST");
            Console.WriteLine("DESIRED AREA CODES AND PREFIXES");
            Task.WaitAll(Task.Delay(250));
            Console.WriteLine();
            Console.WriteLine("AREA              AREA              AREA              ARE\n" +
                              "CODE PRFX NUMBER  CODE PRFX NUMBER  CODE PRFX NUMBER  CODE PRFX NUMBER\n" + 
                              "━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━\n");

            //(311) 399-9978
            //(311) 437-9978
            //(311) 767-9978
            //(311) 936-0000

            Task.WaitAll(Task.Delay(750));
            for (int i = 0; i < 8; i++)
            {
                Console.WriteLine("(311) 399-" + (9978 + i) + "    (311) 437-" + (9978 + i) + "    (311) 767-" + (9978 + i) + "    (311) 936-" + (9978 + i));
                Task.WaitAll(Task.Delay(250));
            }
            Task.WaitAll(Task.Delay(1000));
            for (int i = 0; i < 14; i++)
            {
                Console.WriteLine("(311) 399-" + (9986 + i) + "    (311) 437-" + (9986 + i) + "    (311) 767-" + (9986 + i) + "    (311) 936-" + (9986 + i));
            }

            Console.Write("\"Okay, let's see what we've got...\"");
            Console.WriteLine();
            Console.ReadKey();
        }

        public static void ListingNumbers()
        {
            SoundPlayer player = new SoundPlayer("./Assets/Sounds/menu music quiet.wav");

            void PrintMenu()
            {
                player.PlayLooping();
                Console.Clear();
                Program.CenterType("NUMBERS FOR WHICH CARRIER TONES WERE DETECTED:");
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Program.CenterType("(311) 399-2364");
                Program.CenterType("(311) 399-3582");
                Program.CenterType("(311) 437-8739");
                Program.CenterType("(311) 437-1083");
                Program.CenterType("(311) 437-2977");
                Program.CenterType("(311) 767-7305");
                Program.CenterType("(311) 767-3395");
                Program.CenterType("(311) 936-1493");
                Program.CenterType("(311) 936-3923");
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Program.CenterType("Please select a number (1 - 9, top to bottom) and then press <RETURN> to begin dialing ", false);
                string menuselection = Console.ReadLine();

                switch (menuselection)
                {
                    case "1":
                        player.Stop();
                        Bank_Number();
                        break;

                    case "2":
                        player.Stop();
                        PANAM_Number();
                        break;

                    case "3":
                        player.Stop();
                        NORAD_Number();
                        break;

                    case "4":
                        Console.WriteLine("test");
                        break;

                    case "5":
                        Console.WriteLine("test");
                        break;

                    case "6":
                        Console.WriteLine("test");
                        break;

                    case "7":
                        Console.WriteLine("test");
                        break;

                    case "8":
                        Console.WriteLine("test");
                        break;

                    case "9":
                        Console.WriteLine("test");
                        break;

                    default:
                        Console.Clear();
                        PrintMenu();
                        menuselection = Console.ReadLine();
                        break;
                }
            }

            void PANAM_ErrorMessage()
            {
                SoundPlayer typingsound = new SoundPlayer("./Assets/Sounds/computer text whirr.wav");
                typingsound.PlayLooping();
                Console.WriteLine();
                Program.SetColors(Color.Red);
                Program.TypeOut("! !  -ERROR WITH SYSTEM, PANAM SYSTEMS CURRENTLY IN MAINTENENCE-  ! !\n", 50);
                Program.SetColors(Color.FromArgb(100, 205, 250));
                Program.TypeOut("\nPress any key to continue...", 50, false);
                typingsound.Stop();
            }

            void BAD_LISTING()
            {
                Program.TypeOut("\n! !  -ERROR WITH SYSTEM, NORAD SYSTEMS CURRENTLY IN MAINTENENCE-  ! !", 50, true);
                Program.TypeOut("\nPress any key to continue...", 50, false);
                Console.ReadKey();
            }

            PrintMenu();

            void Bank_Number()
            {
                Console.Clear();
                SoundPlayer mcih = new SoundPlayer("./Assets/Sounds/might come in handy.wav");
                mcih.Play();
                Task.WaitAll(Task.Delay(1000));
                Program.SetColors(Color.FromArgb(100, 205, 250));
                Program.TypeOut("TGS SYSTEM A-45 34:34:33                  Y-1293.323", 45);
                Program.TypeOut("UNION MARINE BANK - SOUTHWEST REGIONAL DATA CENTER", 30);
                Program.TypeOut("\nLOGON >", 100);
                Task.WaitAll(Task.Delay(1000));
                Program.TypeOut("Press any key to continue...", 50);
                Console.ReadKey();
                PrintMenu();
            }

            void PANAM_Number()
            {
                void Reprint()
                {
                    Console.Clear();
                    Console.WriteLine("(enter in \"exit\" to go back to main menu)\n\n007:2312:435:936                         PAN-AM RESERVATION SYSTEM\n" +
                                      "TERMINAL STATUS:  ACTIVE\n  1.  FLIGHT SCHEDULES\n  2.  CREDIT CHECK\n  3.  PASSENGER INFORMATION\n  4.  SYSTEM STATUS FUNCTIONS\n  5.  ALTERNATE ROUTINGS");
                    Console.Write("\n\n  MENU CHOICE? ");
                }

                Console.Clear();
                SoundPlayer toparis = new SoundPlayer("./Assets/Sounds/to paris.wav");
                toparis.Play();
                Task.WaitAll(Task.Delay(2200));
                Console.WriteLine("(enter in \"exit\" to go back to main menu)");
                Program.TypeOut("007:2312:435:936                         PAN-AM RESERVATION SYSTEM", 1);
                Program.TypeOut("TERMINAL STATUS:  ACTIVE\n  1.  FLIGHT SCHEDULES\n  2.  CREDIT CHECK\n  3.  PASSENGER INFORMATION\n  4.  SYSTEM STATUS FUNCTIONS\n  5.  ALTERNATE ROUTINGS", 1);
                Task.WaitAll(Task.Delay(8000));
                Program.TypeOut("\n\n  MENU CHOICE? ", 5, false);
                string menuselection = Console.ReadLine();
                selectiontime:
                switch (menuselection)
                {
                    case "1":
                        PANAM_ErrorMessage();
                        Console.ReadKey();
                        Reprint();
                        menuselection = Console.ReadLine();
                        goto selectiontime;
                        break;

                    case "2":
                        PANAM_ErrorMessage();
                        Console.ReadKey();
                        Reprint();
                        menuselection = Console.ReadLine();
                        goto selectiontime;
                        break;

                    case "3":
                        Console.Clear();
                        Program.TypeOut("DESTINATION: ", 50, true);
                        Console.ReadLine();
                        Program.TypeOut("\nPOINT OF DEPARTURE: ", 50, true);
                        Console.ReadLine();
                        Program.TypeOut("\nPASSENGER TOTAL: ", 50, true);
                        Console.ReadLine();
                        Program.TypeOut("\nSMOKING? ", 50, true);
                        Console.ReadLine();

                        Console.Clear();
                        Program.TypeOut("009:4277:987\n" +
                                        "NAME OF PASSENGER: MACK, JENNIFER K.  DEPART DATE: 08/18/83   FLIGHT: 114\n\n" +
                                        "                           CARRIER:   FLIGHT:   CLASS:   DATE:   TIME:   STATUS:\n" +
                                        "FROM: CHICAGO/O'HARE         PANAM      114       Q      18AUG   0815A     OK\n" +
                                        "  TO: DEGAUL/PARIS\n\n" +
                                        "FARE:  1164.10      GJATWA SLM 172.00TWA GJA\n" +
                                        "TAX:     70.90       172.00 $172.00\n\n" +
                                        "TOTAL: 1235.00\n\n\n" +
                                        "REQUEST: SPEC DATA\n\n", 1, true);
                        SoundPlayer ctp = new SoundPlayer("./Assets/Sounds/confirmed to paris.wav");
                        ctp.PlaySync();
                        Console.Write("\nPress any key to continue...");
                        Console.ReadKey();
                        PrintMenu();
                        break;

                    case "4":
                        PANAM_ErrorMessage();
                        Console.ReadKey();
                        Reprint();
                        menuselection = Console.ReadLine();
                        goto selectiontime;
                        break;

                    case "5":
                        PANAM_ErrorMessage();
                        Console.ReadKey();
                        Reprint();
                        menuselection = Console.ReadLine();
                        goto selectiontime;
                        break;

                    case "exit":
                        PrintMenu();
                        break;

                    default:
                        Reprint();
                        menuselection = Console.ReadLine();
                        goto selectiontime;
                        break;
                }
            }

            void NORAD_Number()
            {
                bool firstPrint = true;
                SoundPlayer ta = new SoundPlayer("./Assets/Sounds/try anything.wav");
                Task.WaitAll(Task.Delay(2000));
                ta.Play();
                reprint:
                Console.Clear();
                Task.WaitAll(Task.Delay(500));
                for (int i = 0; i < 3; i++)
                {
                    Program.TypeOut("            ", 1, false, false);
                    Task.WaitAll(Task.Delay(100));
                    Program.TypeOut("            ", 1, false, false);
                    Task.WaitAll(Task.Delay(100));
                    Program.TypeOut("            ", 1, false, false);
                    Task.WaitAll(Task.Delay(100));
                    Program.TypeOut("            ", 1, false, false);
                    Task.WaitAll(Task.Delay(100));
                    Console.WriteLine();
                }
                Program.TypeOut("   LOGON >", 50);
                string logonInput = Console.ReadLine();
                logonswitch:
                switch (logonInput.ToUpper())
                {
                    case "HELP":
                        Program.TypeOut("\nHELP NOT AVAILABLE", 5, true, false);
                        SoundPlayer thing = new SoundPlayer("./Assets/Sounds/help games.wav");
                        thing.PlaySync();
                        Console.WriteLine("\n\n\nPress any key to continue...");
                        Console.ReadKey();
                        goto reprint;
                        break;

                    case "HELP GAMES":
                        SoundPlayer grt = new SoundPlayer("./Assets/Sounds/games refers to.wav");
                        grt.Play();
                        Task.WaitAll(Task.Delay(1300));
                        Program.TypeOut("\n'GAMES' REFERS TO MODELS, SIMULATIONS AND GAMES\nWHICH HAVE TACTICAL AND STRATIGIC APPLICATIONS.", 25, false, false);
                        Task.WaitAll(Task.Delay(10000));
                        Console.WriteLine("\n\n\nPress any key to continue...");
                        Console.ReadKey();
                        goto reprint;
                        break;

                    case "LIST GAMES":
                        bool sound = false;
                        if (firstPrint == true)
                        {
                            sound = false;
                            firstPrint = false;
                            SoundPlayer list = new SoundPlayer("./Assets/Sounds/oh my god.wav");
                            list.Play();
                            Task.WaitAll(Task.Delay(1000));
                            Program.TypeOut("\nFALKEN'S MAZE", 1, sound);
                            Task.WaitAll(Task.Delay(1500));
                            Program.TypeOut("BLACK JACK", 1, sound);
                            Task.WaitAll(Task.Delay(1000));
                            Program.TypeOut("GIN RUMMY", 1, sound);
                            Task.WaitAll(Task.Delay(1000));
                            Program.TypeOut("HEARTS", 1, sound);
                            Task.WaitAll(Task.Delay(1000));
                            Program.TypeOut("BRIDGE", 1, sound);
                            Task.WaitAll(Task.Delay(800));
                            Program.TypeOut("CHECKERS", 1, sound);
                            Task.WaitAll(Task.Delay(500));
                            Program.TypeOut("CHESS", 1, sound);
                            Task.WaitAll(Task.Delay(500));
                            Program.TypeOut("POKER", 1, sound);
                            Task.WaitAll(Task.Delay(500));
                            Program.TypeOut("FIGHTER COMBAT", 1, sound);
                            Task.WaitAll(Task.Delay(500));
                            Program.TypeOut("GUERRILLA ENGAGEMENT", 1, sound);
                            Task.WaitAll(Task.Delay(700));
                            Program.TypeOut("DESERT WARFARE", 1, sound);
                            Task.WaitAll(Task.Delay(1900));
                            Program.TypeOut("AIR-TO-GROUND ACTIONS", 5, sound);
                            Task.WaitAll(Task.Delay(1900));
                            Program.TypeOut("THEATERWIDE TACTICAL WARFARE", 20, sound);
                            Task.WaitAll(Task.Delay(1300));
                            Program.TypeOut("THEATERWIDE BIOTOXIC AND CHEMICAL WARFARE", 20, sound);
                            Task.WaitAll(Task.Delay(1000));
                            Program.TypeOut("\nGLOBAL THERMONUCLEAR WAR", 10, sound);
                            Task.WaitAll(Task.Delay(800));
                            Program.TypeOut("\n\n", 1, false, false);
                            Task.WaitAll(Task.Delay(8500));
                        }
                        else
                        {
                            sound = true;
                            Console.Clear();
                            Console.WriteLine();
                            Program.TypeOut("\nFALKEN'S MAZE", 1, sound);
                            Program.TypeOut("BLACK JACK", 1, sound);
                            Program.TypeOut("GIN RUMMY", 1, sound);
                            Program.TypeOut("HEARTS", 1, sound);
                            Program.TypeOut("BRIDGE", 1, sound);
                            Program.TypeOut("CHECKERS", 1, sound);
                            Program.TypeOut("CHESS", 1, sound);
                            Program.TypeOut("POKER", 1, sound);
                            Program.TypeOut("FIGHTER COMBAT", 1, sound);
                            Program.TypeOut("GUERRILLA ENGAGEMENT", 1, sound);
                            Program.TypeOut("DESERT WARFARE", 1, sound);
                            Program.TypeOut("AIR-TO-GROUND ACTIONS", 5, sound);
                            Program.TypeOut("THEATERWIDE TACTICAL WARFARE", 20, sound);
                            Program.TypeOut("THEATERWIDE BIOTOXIC AND CHEMICAL WARFARE", 20, sound);
                            Program.TypeOut("\nGLOBAL THERMONUCLEAR WAR", 10, sound);
                            Program.TypeOut("\n\n", 1, false, false);
                        }
                        

                        Console.Write("\nSELECTION (or \"exit\"): ");
                        string game = Console.ReadLine();
                        switch (game.ToUpper())
                        {
                            case "FALKEN'S MAZE":                        //PLAYABLE GAME
                                Games.FalkensMaze.StartGame();
                                Thread.Sleep(3000);
                                goto logonswitch;

                            case "BLACK JACK":                        //PLAYABLE GAME
                                CardGames.BlackJack.StartGame();
                                Thread.Sleep(3000);
                                goto logonswitch;

                            case "GIN RUMMY":                        //PLAYABLE GAME
                                BAD_LISTING();
                                goto logonswitch;

                            case "HEARTS":                        //PLAYABLE GAME
                                BAD_LISTING();
                                goto logonswitch;

                            case "CHECKERS":                        //PLAYABLE GAME
                                BAD_LISTING();
                                goto logonswitch;

                            case "CHESS":                        //PLAYABLE GAME
                                BAD_LISTING();
                                goto logonswitch;

                            case "POKER":                        //PLAYABLE GAME
                                BAD_LISTING();
                                goto logonswitch;

                            case "FIGHTER COMBAT":                        //PLAYABLE GAME
                                BAD_LISTING();
                                goto logonswitch;

                            case "GUERRILLA ENGAGEMENT":
                                BAD_LISTING();
                                goto logonswitch;

                            case "DESERT WARFARE":
                                BAD_LISTING();
                                goto logonswitch;

                            case "AIR-TO-GROUND ACTIONS":                        //PLAYABLE GAME
                                BAD_LISTING();
                                goto logonswitch;

                            case "THEATERWIDE TACTICAL WARFARE":                        //PLAYABLE GAME
                                BAD_LISTING();
                                goto logonswitch;

                            case "THEATERWIDE BIOTOXIC AND CHEMICAL WARFARE":
                                BAD_LISTING();
                                goto logonswitch;

                            case "GLOBAL THERMONUCLEAR WAR":                        //PLAYABLE GAME
                                BAD_LISTING();
                                goto logonswitch;

                            case "EXIT":
                                PrintMenu();
                                break;

                            default:
                                BAD_LISTING();
                                goto logonswitch;
                        }
                        break;

                    default:
                        SoundPlayer hr = new SoundPlayer("./Assets/Sounds/how rude.wav");
                        hr.Play();
                        Program.TypeOut("\n\nINDENTIFICATION NOT RECOGNIZED BY SYSTEM\n--CONNECTION TERMINATED--", 50, false, false);
                        Task.WaitAll(Task.Delay(3000));
                        SoundPlayer aifh = new SoundPlayer("./Assets/Sounds/ask it for help.wav");
                        aifh.PlaySync();
                        Console.WriteLine("\n\n\nPress any key to continue...");
                        Console.ReadKey();
                        goto reprint;
                        break;
                }
            }
        }
    }
}
