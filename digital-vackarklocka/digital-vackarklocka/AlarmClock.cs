using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace digital_vackarklocka
{
    public class AlarmClock
    {
    //fält
           private int _alarmHour; //ska kaplas in av egenskapen AlarmHour
           private int _alarmMinute; //kaplas in av eg. AlarmMinute
           private int _hour; //Kaplas in av eg. Hour
           private int _minute; //Kaplas in av eg. Minyte



           private int AlarmHour //kontrollerar data
           {
               get { return _alarmHour; }
               set
               {
                   if (value > 23 || value < 0) //validerar data
                   {
                       throw new ArgumentException();
                   }
                   _alarmHour = value;
               }

           }

           private int AlarmMinute//kontrollerar data
           {
               get { return _alarmMinute; }
               set
               {
                   if (value > 59 || value < 0)
                   {
                       throw new ArgumentException();
                   }
                   _alarmMinute = value;
               }
           }

           private int Hour//kontrollerar data
           {
               get { return _hour; }
               set
               {
                   if (value > 23 || value < 0)
                   {
                       throw new ArgumentException();
                   }
                   _hour = value;
               }
           }

           private int Minute//kontrollerar data
           {
               get { return _minute; }
               set
               {
                   if (value > 59 || value < 0)
                   {
                       throw new ArgumentException();
                   }
                   _minute = value;
               }
           }
        private AlarmClock() : this(0,0)
        {
            
        }

        private AlarmClock(int hour, int minute) : this(hour, minute, 0, 0)
        {
            
        }

        private AlarmClock(int hour, int minute, int alarmHour, int alarmMinute)
        {
            Hour = hour;

        }

        private bool TickTock()
        {
            throw new NotImplementedException();
        }
        
        private string ToString()
        {
            throw new NotImplementedException();
        }
        
    }
}
