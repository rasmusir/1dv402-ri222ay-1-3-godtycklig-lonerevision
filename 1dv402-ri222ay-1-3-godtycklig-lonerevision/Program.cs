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
            while(true)
            {
                Console.Write(prompt);
                int value = 0;
                string input = Console.ReadLine();
                if (int.TryParse(input, out value))
                {
                    return value;
                }
                ViewMessage(string.Format("FEL! {0} kan inte tolkas som ett heltal!", ConsoleColor.Red, ConsoleColor.Black, input));
            }
        }

        static int[] ReadSalaries(int count)
        {
            int[] values = new int[count];
            for(int i = 0; i<count; i++)
            {
                values[i] = ReadInt(string.Format("Ange lön nummer {0}",i));
            }
            return values;
        }

        static void ViewMessage(string message, ConsoleColor backgroundColor = ConsoleColor.Blue, ConsoleColor foregroundColor = ConsoleColor.White)
        {
            Console.BackgroundColor = backgroundColor;
            Console.ForegroundColor = foregroundColor;
            Console.WriteLine(message);
            Console.ResetColor();
        }

        static void ViewResult(int[] salaries)
        {
            
        }
    }
}
