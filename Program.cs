using System;
using System.Threading;
using System.Numerics;
using System.Globalization;

namespace consoleresize
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.White;
            //int width = Console.WindowWidth;
            //int height = Console.WindowHeight;
            //Console.WriteLine("Current window width = "+width);
            //Console.WriteLine("Current window height = "+height);
            for(;;){
                Thread.Sleep(1000);
                //int width = Console.WindowWidth;
                int height = Console.WindowHeight;
                //Console.WriteLine("W : "+Console.WindowWidth+" H : "+Console.WindowHeight);
                Console.BackgroundColor = ConsoleColor.Blue;
                Console.Clear();
                Console.BackgroundColor=ConsoleColor.Gray;
                for (int i = 0; i < Console.WindowWidth; i++)
                {
                    Console.BackgroundColor=ConsoleColor.Gray;
                    utils.WriteAt(" ", i, height-1);
                    Console.BackgroundColor=ConsoleColor.DarkGray;
                    utils.WriteAt(" ", i, height);
                    Console.BackgroundColor=ConsoleColor.Gray;
                    utils.WriteAt(" ", i, 0);
                    Console.BackgroundColor=ConsoleColor.DarkGray;
                    utils.WriteAt(" ", i, 1);
                    
                }
                
                

            }
        }
    }
    class utils{
        public static void WriteAt(string s, int x, int y)
        {
        try
            {
            Console.SetCursorPosition(x, y);
            Console.Write(s);
            }
        catch (ArgumentOutOfRangeException e)
            {
            Console.Clear();
            Console.WriteLine(e.Message);
            }
        }
        //public static void writeAt(int width, int height){

        //}
    }
}
