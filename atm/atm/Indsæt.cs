using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atm
{
    class Indsæt
    {
        public static void lars()
        {
            int beløb = 3000;
            int indsæt;
            Console.CursorVisible = false;
            while (true)
            {
                string valg = Function.Select(new string[] { "Saldo", "Indsæt", "Tilbage" });
                Console.Clear();
                switch (valg)
                {
                    case "Saldo":
                        Console.WriteLine(beløb);
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case "Indsæt":
                        Console.WriteLine("Indtast beløb (Max beløb 1000): ");
                        indsæt = Convert.ToInt32(Console.ReadLine());
                        int total = beløb + indsæt;
                        if (indsæt <= 1000)
                        {
                            Console.WriteLine("Total beløb på konto: " + total);
                        }
                        Console.ReadKey();
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