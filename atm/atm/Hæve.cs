using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atm
{
    class Hæve
    {
        public static void Ole()
        {
            Console.CursorVisible = false;
            int Saldo = 3000;
            int Hæve;
            
            while(true)
            {
                string valg = Function.Select(new string[] { "Saldo", "Hæve", "Tilbage" });
                Console.Clear();
                switch (valg)
                {
                    case "Saldo":
                        Console.Write(Saldo);
                        break;
                    case "Hæve":
                        Console.Clear();
                        Console.WriteLine("Hvor meget vil du hæve");
                        Hæve = Convert.ToInt32(Function.Select(new string[] { "100", "200", "500", "1000" })); 
                        int total = Saldo - Hæve;
                        Console.WriteLine("Du har nu " + total + " tilbage");
                        Console.Clear();
                        break;
                    case "Tilbage":
                        Program.Main();
                        break;
                }
            }
            
            
        }
    }
}
