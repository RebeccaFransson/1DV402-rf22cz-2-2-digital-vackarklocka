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



           public int AlarmHour //kontrollerar data
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

           public int AlarmMinute//kontrollerar data
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

           public int Hour//kontrollerar data
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

           public int Minute//kontrollerar data
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
        public AlarmClock() : this(0,0)
        {
            
        }

        public AlarmClock(int hour, int minute) : this(hour, minute, 0, 0)
        {
            
        }

        public AlarmClock(int hour, int minute, int alarmHour, int alarmMinute) // parametrarna sätter värden till properties
        {
            Hour = hour;
            Minute = minute;
            AlarmHour = alarmHour;
            AlarmMinute = alarmMinute;
        }

        public bool TickTock()
        {
            if (Minute < 59)
            {
                Minute++;
                if(Hour == 23)
                {
                    Hour = 0;
                    Minute = 0;
                }
            }
            else
            {
                Minute = 0;
                
                if(Hour == 23)
                {
                    Hour = 0;
                }
                else
                {
                    Hour++;
                }
            }
            
           return Minute==AlarmMinute && Hour==AlarmHour;
          
        }
        
        public string ToString()
        {
            //if(Minute < 10)
            //{
            //    return String.Format("{0}:0{1} <{2}:{3}>", Hour, Minute, AlarmHour, AlarmMinute);
            //}
            return String.Format("{0}:{1} <{2}:{3}>", Hour, Minute, AlarmHour, AlarmMinute);
        }
        
    }
}
