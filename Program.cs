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
            int width = Console.WindowWidth;
            int height = Console.WindowHeight;
            //Console.WriteLine("Current window width = "+width);
            //Console.WriteLine("Current window height = "+height);
            Console.WriteLine(Console.LargestWindowHeight);
            Console.WriteLine(Console.LargestWindowWidth);
            for(;;){
                Thread.Sleep(1000);
                //int width = Console.WindowWidth;
                //Console.WriteLine("W : "+Console.WindowWidth+" H : "+Console.WindowHeight);
                if(width != Console.WindowWidth || height != Console.WindowHeight){
                    //reset values
                    width = Console.WindowWidth;
                    height = Console.WindowHeight;
                    //prepare console curser 
                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.Clear();
                    Console.BackgroundColor=ConsoleColor.Gray;
                    //draw

                    draw.text("sample text");
                    draw.borders(height, width);
                }
            }
        }
    }

    class draw{
        public static void borders(int height, int width){
            //top bottom
            for (int i = 0; i < Console.WindowWidth; i++)
            {
                //bottom layer  
                Console.BackgroundColor=ConsoleColor.Gray;
                utils.WriteAt(" ", i, height-2);
                Console.BackgroundColor=ConsoleColor.DarkGray;
                utils.WriteAt(" ", i, height-1);
                //top layer
                Console.BackgroundColor=ConsoleColor.Gray;
                utils.WriteAt(" ", i, 0);
                Console.BackgroundColor=ConsoleColor.DarkGray;
                utils.WriteAt(" ", i, 1);
                
            }
            for (int j = 0; j < Console.WindowHeight-3; j++)
            {
                //left side
                Console.BackgroundColor=ConsoleColor.Gray;
                utils.WriteAt("  ", 0,j+1);
                Console.BackgroundColor=ConsoleColor.DarkGray;
                utils.WriteAt("  ", 2,j+1);
            }
            for (int i = 0; i < Console.WindowHeight-1; i++)
            {                
                Console.BackgroundColor=ConsoleColor.Gray;
                utils.WriteAt("  ", width-4,i);
                Console.BackgroundColor=ConsoleColor.DarkGray;
                utils.WriteAt("  ", width-2,i);
            }
        }
        public static void text (string text){
            int lenght = text.Length;
            int halflenght = lenght/2;
            int conheight = Console.WindowHeight;
            int halfheight = conheight/2;
            int conwidth = Console.WindowWidth;
            int halfwidth = conwidth/2;

            Console.BackgroundColor=ConsoleColor.Blue;
            Console.ForegroundColor=ConsoleColor.Black;
            int curserpos = halfwidth-halflenght;
            utils.WriteAt(text, curserpos, halfheight);
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
