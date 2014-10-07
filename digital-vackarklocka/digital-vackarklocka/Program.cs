using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace digital_vackarklocka
{
    class Program
    {
        static void Main(string[] args)
        {
            //här ska koden som testar programmet komma
            //AlarmClock ac = new AlarmClock(10,32,14,24);
            //for (int i = 0; i < 2000; i++)
            //{
            //    if (ac.TickTock() == true) {
            //        Console.WriteLine("SANT!");
            //    }
            //}Console.BackgroundColor = ConsoleColor.DarkGreen;


            //static string HorizontalLine()
            
            ViewTestHeader("Test 2\nTest av konstruktorn med två parametrar, (9, 42) ");
            AlarmClock ac = new AlarmClock(9, 42);

            Console.WriteLine(ac.ToString());
            
        }

        static void Run(AlarmClock ac,int minutes)
        {
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine(" ╔══════════════════════════════════════╗ ");
            Console.WriteLine(" ║      Väckarklockan URLED (TM)        ║ ");
            Console.WriteLine(" ╚══════════════════════════════════════╝ ");
            Console.ResetColor();
        }

        static void ViewErrorMessage(string message)
        {
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.WriteLine(message);
            Console.ResetColor();
        }
        static void ViewTestHeader(string header)
        {
            Console.WriteLine(header);
        }
    }

}
