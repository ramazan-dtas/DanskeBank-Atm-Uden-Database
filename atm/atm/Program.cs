using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atm
{
    class Program
    {
        public static void Main()
        {
            Console.CursorVisible = false;
            bool PC = false;
            string tekst = "Forkert Pin prøv igen - Press enter for at fortsætte";
            int Pin;
            while (!PC)
            {
                Console.Write("Pin: ");
                while (!int.TryParse(Console.ReadLine(), out Pin))
                {
                    Console.Clear();
                    Console.WriteLine("Du må kun bruge tal!!!!!!!!");
                    Console.ReadKey();
                }

                if (Pin == 1234)
                {
                    PC = true;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine(tekst.ToUpper());
                    Console.ReadKey();
                    Console.Clear();
                }
            }

            ConsoleKey mainKey = new ConsoleKey();
            while(mainKey != ConsoleKey.Escape)
            {
               
                Console.WriteLine("Tryk Esc for at gå ud og Enter for at fortsætte");
                if((mainKey = Console.ReadKey().Key) != ConsoleKey.Escape)
                {

                    string answer;
                    answer = Function.Select(new string[] { "Indsæt", "Hæve" });
                    Console.ReadKey();
                    Console.Clear();
                    switch (answer)
                    {
                        case "Indsæt":
                            Indsæt.lars();
                            
                            Console.Clear();
                            break;

                        case "Hæve":
                            Hæve.Ole();
                            Console.Clear();
                            break;
                    }
                    
                }
            }
            Console.ReadKey();

        }
    }
}