using System;
using System.Drawing;
using System.Threading;

namespace SoloLearn
{
    class Program
    {
        public static bool KeyAvailable { get; set; }

        static void Main(string[] args)
        {
            // Defines the background and foreground colors of the console application
            Console.CursorVisible = false;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();

            do // Loops the entire program until interupted using a while
            {
                while (!KeyAvailable)
                {
                    Console.CursorVisible = false;
                    Console.Beep(200, 500);
                    Console.Beep(400, 500);
                    // converts the DateTime format into binary and limits their string scope
                    string _binHour = Convert.ToString(DateTime.Now.Hour, 2).PadLeft(5, '0');
                    string _binMinute = Convert.ToString(DateTime.Now.Minute, 2).PadLeft(6, '0');
                    string _binSecond = Convert.ToString(DateTime.Now.Second, 2).PadLeft(6, '0');

                    // int hour definitions
                    int binHour1 = Convert.ToInt32(_binHour.Substring(0, 1));
                    int binHour2 = Convert.ToInt32(_binHour.Substring(1, 1));
                    int binHour3 = Convert.ToInt32(_binHour.Substring(2, 1));
                    int binHour4 = Convert.ToInt32(_binHour.Substring(3, 1));
                    int binHour5 = Convert.ToInt32(_binHour.Substring(4, 1));

                    // int minute definitions
                    int binMinute1 = Convert.ToInt32(_binMinute.Substring(0, 1));
                    int binMinute2 = Convert.ToInt32(_binMinute.Substring(1, 1));
                    int binMinute3 = Convert.ToInt32(_binMinute.Substring(2, 1));
                    int binMinute4 = Convert.ToInt32(_binMinute.Substring(3, 1));
                    int binMinute5 = Convert.ToInt32(_binMinute.Substring(4, 1));
                    int binMinute6 = Convert.ToInt32(_binMinute.Substring(5, 1));

                    // int second definitions
                    int binSecond1 = Convert.ToInt32(_binSecond.Substring(0, 1));
                    int binSecond2 = Convert.ToInt32(_binSecond.Substring(1, 1));
                    int binSecond3 = Convert.ToInt32(_binSecond.Substring(2, 1));
                    int binSecond4 = Convert.ToInt32(_binSecond.Substring(3, 1));
                    int binSecond5 = Convert.ToInt32(_binSecond.Substring(4, 1));
                    int binSecond6 = Convert.ToInt32(_binSecond.Substring(5, 1));

                    Console.SetCursorPosition(51, 23);
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine(DateTime.Now.ToString("HH    mm    ss"));


                    //HOURS using the switch/case methode

                    switch (binHour5)
                    {
                        case 1:
                            Console.ForegroundColor = ConsoleColor.DarkGray;
                            Console.SetCursorPosition(50, 5); Console.Write("████");
                            Console.SetCursorPosition(50, 6); Console.Write("████");
                            break;
                        default:
                            Console.ForegroundColor = ConsoleColor.Gray;
                            Console.SetCursorPosition(50, 5); Console.Write("████");
                            Console.SetCursorPosition(50, 6); Console.Write("████");
                            break;
                    }

                    switch (binHour4)
                    {
                        case 1:
                            Console.ForegroundColor = ConsoleColor.DarkGray;
                            Console.SetCursorPosition(50, 8); Console.Write("████");
                            Console.SetCursorPosition(50, 9); Console.Write("████");
                            break;
                        default:
                            Console.ForegroundColor = ConsoleColor.Gray;
                            Console.SetCursorPosition(50, 8); Console.Write("████");
                            Console.SetCursorPosition(50, 9); Console.Write("████");
                            break;
                    }

                    switch (binHour3)
                    {
                        case 1:
                            Console.ForegroundColor = ConsoleColor.DarkGray;
                            Console.SetCursorPosition(50, 11); Console.Write("████");
                            Console.SetCursorPosition(50, 12); Console.Write("████");
                            break;
                        default:
                            Console.ForegroundColor = ConsoleColor.Gray;
                            Console.SetCursorPosition(50, 11); Console.Write("████");
                            Console.SetCursorPosition(50, 12); Console.Write("████");
                            break;
                    }

                    switch (binHour2)
                    {
                        case 1:
                            Console.ForegroundColor = ConsoleColor.DarkGray;
                            Console.SetCursorPosition(50, 14); Console.Write("████");
                            Console.SetCursorPosition(50, 15); Console.Write("████");
                            break;
                        default:
                            Console.ForegroundColor = ConsoleColor.Gray;
                            Console.SetCursorPosition(50, 14); Console.Write("████");
                            Console.SetCursorPosition(50, 15); Console.Write("████");
                            break;
                    }

                    switch (binHour1)
                    {
                        case 1:
                            Console.ForegroundColor = ConsoleColor.DarkGray;
                            Console.SetCursorPosition(50, 17); Console.Write("████");
                            Console.SetCursorPosition(50, 18); Console.Write("████");
                            break;
                        default:
                            Console.ForegroundColor = ConsoleColor.Gray;
                            Console.SetCursorPosition(50, 17); Console.Write("████");
                            Console.SetCursorPosition(50, 18); Console.Write("████");
                            break;
                    }

                    // MINUTES  - Using the if/else methode.

                    if (binMinute6 == 1)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        Console.SetCursorPosition(56, 5); Console.Write("████");
                        Console.SetCursorPosition(56, 6); Console.Write("████");
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.SetCursorPosition(56, 5); Console.Write("████");
                        Console.SetCursorPosition(56, 6); Console.Write("████");
                    }

                    if (binMinute5 == 1)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        Console.SetCursorPosition(56, 8); Console.Write("████");
                        Console.SetCursorPosition(56, 9); Console.Write("████");
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.SetCursorPosition(56, 8); Console.Write("████");
                        Console.SetCursorPosition(56, 9); Console.Write("████");
                    }

                    if (binMinute4 == 1)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        Console.SetCursorPosition(56, 11); Console.Write("████");
                        Console.SetCursorPosition(56, 12); Console.Write("████");
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.SetCursorPosition(56, 11); Console.Write("████");
                        Console.SetCursorPosition(56, 12); Console.Write("████");
                    }

                    if (binMinute3 == 1)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        Console.SetCursorPosition(56, 14); Console.Write("████");
                        Console.SetCursorPosition(56, 15); Console.Write("████");
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.SetCursorPosition(56, 14); Console.Write("████");
                        Console.SetCursorPosition(56, 15); Console.Write("████");
                    }

                    if (binMinute2 == 1)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        Console.SetCursorPosition(56, 17); Console.Write("████");
                        Console.SetCursorPosition(56, 18); Console.Write("████");
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.SetCursorPosition(56, 17); Console.Write("████");
                        Console.SetCursorPosition(56, 18); Console.Write("████");
                    }

                    if (binMinute1 == 1)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        Console.SetCursorPosition(56, 20); Console.Write("████");
                        Console.SetCursorPosition(56, 21); Console.Write("████");
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.SetCursorPosition(56, 20); Console.Write("████");
                        Console.SetCursorPosition(56, 21); Console.Write("████");
                    }

                    // SECONDS

                    if (binSecond6 == 1)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        Console.SetCursorPosition(62, 5); Console.Write("████");
                        Console.SetCursorPosition(62, 6); Console.Write("████");
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.SetCursorPosition(62, 5); Console.Write("████");
                        Console.SetCursorPosition(62, 6); Console.Write("████");
                    }

                    if (binSecond5 == 1)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        Console.SetCursorPosition(62, 8); Console.Write("████");
                        Console.SetCursorPosition(62, 9); Console.Write("████");
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.SetCursorPosition(62, 8); Console.Write("████");
                        Console.SetCursorPosition(62, 9); Console.Write("████");
                    }

                    if (binSecond4 == 1)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        Console.SetCursorPosition(62, 11); Console.Write("████");
                        Console.SetCursorPosition(62, 12); Console.Write("████");
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.SetCursorPosition(62, 11); Console.Write("████");
                        Console.SetCursorPosition(62, 12); Console.Write("████");
                    }

                    if (binSecond3 == 1)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        Console.SetCursorPosition(62, 14); Console.Write("████");
                        Console.SetCursorPosition(62, 15); Console.Write("████");
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.SetCursorPosition(62, 14); Console.Write("████");
                        Console.SetCursorPosition(62, 15); Console.Write("████");
                    }

                    if (binSecond2 == 1)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        Console.SetCursorPosition(62, 17); Console.Write("████");
                        Console.SetCursorPosition(62, 18); Console.Write("████");
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.SetCursorPosition(62, 17); Console.Write("████");
                        Console.SetCursorPosition(62, 18); Console.Write("████");
                    }

                    if (binSecond1 == 1)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        Console.SetCursorPosition(62, 20); Console.Write("████");
                        Console.SetCursorPosition(62, 21); Console.Write("████");
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.SetCursorPosition(62, 20); Console.Write("████");
                        Console.SetCursorPosition(62, 21); Console.Write("████");
                    }
                }
            }
            while (KeyAvailable && Console.ReadKey(true).Key != ConsoleKey.Escape);



        }

    }
}
