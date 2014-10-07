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
            //Console.BackgroundColor = ConsoleColor.DarkGreen;


            string HorizontalLine = "═══════════════════════════════════════════════════════════";

            // test 1
            ViewTestHeader("Test 1\nTest av standardkonstruktorn. ");
            AlarmClock ac = new AlarmClock();
            Console.WriteLine(ac.ToString());
            Console.WriteLine(HorizontalLine);

            // test 2
            ViewTestHeader("Test 2\nTest av konstruktorn med två parametrar, (9, 42) ");
            ac = new AlarmClock(9, 42);
            Console.WriteLine(ac.ToString());
            Console.WriteLine(HorizontalLine);

            // test 3
            ViewTestHeader("Test 3\nTest av konstruktorn med två parametrar, (13, 24, 7, 35) ");
            ac = new AlarmClock(13, 24, 7, 35);
            Console.WriteLine(ac.ToString());
            Console.WriteLine(HorizontalLine);
            
            // test 4
            ViewTestHeader("Test 4\nStällder befintligt alarm-objekt till 23:58 och låter det gå 13 'minuter'.");
            ac = new AlarmClock(23, 58, 7, 35);
            Run(ac, 13);
            //Console.WriteLine(ac.ToString());
            Console.WriteLine(HorizontalLine);

            // test 5
            ViewTestHeader("Test 4\nStällder befintligt alarm-objekt till 6:12 och låter det gå 6 'minuter'.");
            ac = new AlarmClock(6, 12, 6, 15);
            Run(ac, 6);
            //Console.WriteLine(ac.ToString());
            Console.WriteLine(HorizontalLine);
        }

        static void Run(AlarmClock ac,int minutes)
        {
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine(" ╔═════════════════════════════════════════════════════════╗ ");
            Console.WriteLine(" ║      Väckarklockan Gjord Av Rebecca Fransson (TM)       ║ ");
            Console.WriteLine(" ╚═════════════════════════════════════════════════════════╝ ");
            Console.ResetColor();

            for (int i = 0; i < minutes; i++)
            {
                if (ac.TickTock() == true)
                {
                    Console.BackgroundColor = ConsoleColor.DarkBlue;
                    Console.Write("BEEP!", ac.ToString());
                    Console.WriteLine("{0} BEEP! BEEP!", ac.ToString());
                    Console.ResetColor();
                }
                else
                { Console.WriteLine("{0,17}", ac.ToString()); }
            }
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
