using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1dv402_ri222ay_1_3_godtycklig_lonerevision
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {

            }
            while (IsContinuing());
        }

        static bool IsContinuing()
        {
            ViewMessage("Tryck tangent för att fortsätta - Esc avsluta.");    // TODO Replace with resource later.
            if (Console.ReadKey().Key == ConsoleKey.Escape)
                return false;
            return true;
        }

        static int ReadInt(string prompt)
        {
            throw new NotImplementedException();
        }

        static int[] ReadSalaries(int count)
        {
            throw new NotImplementedException();
        }

        static void ViewMessage(string message, ConsoleColor backgroundColor = ConsoleColor.Blue, ConsoleColor foregroundColor = ConsoleColor.White)
        {
            Console.BackgroundColor = backgroundColor;
            Console.ForegroundColor = foregroundColor;
            Console.WriteLine(message);
            Console.ResetColor();
        }

        static void ViewResults(int[] salaries)
        {
            throw new NotImplementedException();
        }
    }
}
