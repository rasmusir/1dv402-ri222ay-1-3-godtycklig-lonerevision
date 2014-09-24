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
                Console.Clear();
                int count = ReadInt("Ange antal löner att mata in: ");
                Console.WriteLine();
                int[] salaries = ReadSalaries(count);
                ViewResult(salaries);
            }
            while (IsContinuing());
        }

        static bool IsContinuing()
        {
            Console.WriteLine();
            ViewMessage("Tryck tangent för att fortsätta - Esc avsluta.");    // TODO Replace with resource later.
            if (Console.ReadKey().Key == ConsoleKey.Escape)
                return false;
            return true;
        }

        static int ReadInt(string prompt)
        {
            while (true)
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
                values[i] = ReadInt(string.Format("Ange lön nummer {0}: ",i+1));
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
            Console.WriteLine();
            Console.WriteLine("Medianlön:    {0,20:C0}",MyExtension.Median(salaries));
            Console.WriteLine("Medellön:     {0,20:C0}", salaries.Average());
            Console.WriteLine("Lönespridning:{0,20:C0}", MyExtension.Dispersion(salaries));
            Console.WriteLine();
            for (int i = 0; i<salaries.Length; i++)
            {
                Console.Write("{0,10}",salaries[i]);
                if ((i+1) % 3 == 0)
                    Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}
