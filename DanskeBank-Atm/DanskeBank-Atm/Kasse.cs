using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DanskeBank_Atm
{
    class Kasse
    {
        public static void GraphicFrame(int x, int y, int x2, int y2, ConsoleColor color = ConsoleColor.White)
        {
            x = 5;
            y = 5;
            x2 = 4;
            y2 = 4;
            // Needed something else to do, so added throwing when the starting points is not lower than the starting points.
            
            if (x >= x2) throw new Exception("x must be smaller than x2");
            if (y >= y2) throw new Exception("y must be smaller than y2");
            
            int preX = Console.CursorLeft;
            int preY = Console.CursorTop;

            Console.CursorLeft = x;
            Console.CursorTop = y;

            // To Left
            for (int i = x; i < x2; i++)
            {
                Console.WriteLine("-", color);
                Console.CursorLeft++;
            }

            // To Bottom
            for (int i = y; i < y2; i++)
            {
                Console.WriteLine("¦", color);
                Console.CursorTop++;
            }

            // To Right
            for (int i = x2; i > x; i--)
            {
                Console.WriteLine("-", color);
                Console.CursorLeft--;
            }

            // To Top
            for (int i = y2; i > y; i--)
            {
                Console.WriteLine("¦", color);
                Console.CursorTop--;
            }

            // Set the corners
            Console.SetCursorPosition(x, y);
            Console.WriteLine("+", color);
            Console.SetCursorPosition(x2, y);
            Console.WriteLine("+", color);
            Console.SetCursorPosition(x2, y2);
            Console.WriteLine("+", color);
            Console.SetCursorPosition(x, y2);
            Console.WriteLine("+", color);

            // Return the color to the previous position the command was executed at.
            Console.CursorLeft = preX;
            Console.CursorTop = preY;
        }
    }
}