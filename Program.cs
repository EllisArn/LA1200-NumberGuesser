using System;
using System.Diagnostics;
using System.Threading;
using Figgle;

namespace LA1200
{
    class Program
    {
        static void Main(string[] args)
        {

            Random random = new Random();
            int randomNumber = random.Next(0, 100);

            int userGuess = 0;
            int userAttempts = 0;
            string font = @"

██╗    ██╗██╗██╗     ██╗     ██╗  ██╗ ██████╗ ███╗   ███╗███╗   ███╗███████╗███╗   ██╗    ██████╗ ███████╗██╗       
██║    ██║██║██║     ██║     ██║ ██╔╝██╔═══██╗████╗ ████║████╗ ████║██╔════╝████╗  ██║    ██╔══██╗██╔════╝██║       
██║ █╗ ██║██║██║     ██║     █████╔╝ ██║   ██║██╔████╔██║██╔████╔██║█████╗  ██╔██╗ ██║    ██████╔╝█████╗  ██║       
██║███╗██║██║██║     ██║     ██╔═██╗ ██║   ██║██║╚██╔╝██║██║╚██╔╝██║██╔══╝  ██║╚██╗██║    ██╔══██╗██╔══╝  ██║       
╚███╔███╔╝██║███████╗███████╗██║  ██╗╚██████╔╝██║ ╚═╝ ██║██║ ╚═╝ ██║███████╗██║ ╚████║    ██████╔╝███████╗██║       
 ╚══╝╚══╝ ╚═╝╚══════╝╚══════╝╚═╝  ╚═╝ ╚═════╝ ╚═╝     ╚═╝╚═╝     ╚═╝╚══════╝╚═╝  ╚═══╝    ╚═════╝ ╚══════╝╚═╝       
                                                                                                                    
███╗   ██╗██╗   ██╗███╗   ███╗██████╗ ███████╗██████╗      ██████╗ ██╗   ██╗███████╗███████╗███████╗███████╗██████╗ 
████╗  ██║██║   ██║████╗ ████║██╔══██╗██╔════╝██╔══██╗    ██╔════╝ ██║   ██║██╔════╝██╔════╝██╔════╝██╔════╝██╔══██╗
██╔██╗ ██║██║   ██║██╔████╔██║██████╔╝█████╗  ██████╔╝    ██║  ███╗██║   ██║█████╗  ███████╗███████╗█████╗  ██████╔╝
██║╚██╗██║██║   ██║██║╚██╔╝██║██╔══██╗██╔══╝  ██╔══██╗    ██║   ██║██║   ██║██╔══╝  ╚════██║╚════██║██╔══╝  ██╔══██╗
██║ ╚████║╚██████╔╝██║ ╚═╝ ██║██████╔╝███████╗██║  ██║    ╚██████╔╝╚██████╔╝███████╗███████║███████║███████╗██║  ██║
╚═╝  ╚═══╝ ╚═════╝ ╚═╝     ╚═╝╚═════╝ ╚══════╝╚═╝  ╚═╝     ╚═════╝  ╚═════╝ ╚══════╝╚══════╝╚══════╝╚══════╝╚═╝  ╚═╝
                                                                                                 
";
            Console.WriteLine(font);
            Console.WriteLine("Drücken Sie Leertaste um zu spielen");
            while (Console.ReadKey().Key != ConsoleKey.Spacebar)
            {
                Console.Write("\b \b");
            }

            string round = "y";

            do
            {

                Console.Clear();

                Stopwatch stopWatch = new Stopwatch();
                stopWatch.Start();

                Console.WriteLine("\nGeben Sie eine Nummer zwischen 1 und 100 ein");


                while (userGuess != randomNumber)
                {
                    try
                    {

                        userGuess = Convert.ToInt32(Console.ReadLine());
                        userAttempts++;

                        if (userGuess > 100)
                        {
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Fehler");
                            Console.WriteLine("Geben Sie eine Zahl zwischen 1 und 100 ein");
                            Console.ForegroundColor = ConsoleColor.White;
                            if (userAttempts >= 0)
                            {
                                userAttempts--;
                            }
                        }

                        else if (userGuess < 1)
                        {
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Fehler");
                            Console.WriteLine("Geben Sie eine Zahl zwischen 1 und 100 ein");
                            Console.ForegroundColor = ConsoleColor.White;
                            if (userAttempts >= 0)
                            {
                                userAttempts--;
                            }
                        }

                        else if (userGuess > randomNumber)
                        {
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Falsch");
                            Console.WriteLine("Ihre Zahl ist grösser als die zufällige Zahl");
                            Console.ForegroundColor = ConsoleColor.White;
                        }

                        else if (userGuess < randomNumber)
                        {
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Falsch");
                            Console.WriteLine("Ihre Zahl ist kleiner als die zufällige Zahl");
                            Console.ForegroundColor = ConsoleColor.White;
                        }

                    }

                    catch
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Fehler");
                        Console.WriteLine("Ihre Eingabe muss eine Zahl sein.");
                        Console.ForegroundColor = ConsoleColor.White;
                        if (userAttempts >= 0)
                        {
                            userAttempts--;
                        }

                    }


                }
                stopWatch.Stop();

                TimeSpan ts = stopWatch.Elapsed;

                string elapsedTime = string.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                ts.Hours, ts.Minutes, ts.Seconds,
                ts.Milliseconds / 10);

                Console.Clear();

                Console.ForegroundColor = ConsoleColor.Green;

                Console.WriteLine(
                FiggleFonts.Standard.Render("Glückwunsch"));

                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Sie haben " + userAttempts + " Versuche und " + elapsedTime + " gebraucht um die Zahl zu erraten");

                Console.WriteLine("Wollen Sie noch einmal spielen? [y/n]");
                round = Console.ReadLine();
                random = new Random();
                randomNumber = random.Next(0, 100);
                userAttempts = 0;


                //----------------------------------------------------------------------------------------------------------------------------------------------
            }
            while (round == "y");


        }
    }
}
