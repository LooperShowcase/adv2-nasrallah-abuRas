using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace nsr_aboras
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor read;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear()
            Console.WriteLine("welcm to my play")
            Console.WriteLine("win if you can looll")
            char[] lines = { '_', '_', '_', '_' };
            int hearts = 4;

            printLines(lines);
            while (hearts > 0)
            {
                char ch = askUser();
                int result = checkLetter(tw, ch, lines);
                if (result == -1)
                {
                    hearts--;
                    Console.WriteLine("you have a" + hearts + "hearts");
                }
                else {
                    lines[result] = ch;
                }

                if (checkWin(lines)) 
                {
                    break;
                }
            }

            if (hearts > 0)
            {
                Console.WriteLine("GOOOD YOU WIN ");
            }
            else { " ooops you loser"}
        }

    }
}
public static int checkLetter(string todayWord, char a, char[] lines)
{
    for (int i = 0; i < 4; i++)
    {
        if (a == todayWord[i])
        {
            return i;
        }

    }
    return -1;

}           
}




    public static char AskUser();
        {
            Console.WriteLine("plse enter a chsar");
               char c = Console.ReadLine()[0];
                  return c;
        } 


    public static string geTodayWord()
    {

        string[] arr = { "home", "loop", "dogs", "story", "army", "game", "food", "city", "face" };
          Random rnd = new Random();
           int number = rnd.Next(0, arr.Length);
            return arr[number];

    }

    public static void printLines(char[] lines)
    {
        for (int i = 0; i < lines.Length; i++)
        {
            Console.Write(lines[i] + " ");
        }

        Console.WriteLine();
    }


public static bool checkWin(char[] lines)
    {
        for (int i = 0; i < lines.Length; i++)
        {
            if (lines[i] == '_')
            {
                return false;
            }
        }

        return true;
    }
}
