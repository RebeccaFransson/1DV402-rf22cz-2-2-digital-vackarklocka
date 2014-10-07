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
            //}


            //static string HorizontalLine()
            ViewTestHeader("Test 1\nTest av standardkonstruktorn.");
            AlarmClock ac = new AlarmClock();
            
            Console.WriteLine(ac.ToString());

            
        }

        static void Run(AlarmClock ac,int minutes)
        {

        }

        static void ViewErrorMessage(string message)
        {

        }
        static void ViewTestHeader(string header)
        {
            Console.WriteLine(header);
        }
    }

}
