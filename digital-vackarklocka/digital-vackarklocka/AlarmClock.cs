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
            
        }//hämtar de värderna från metoden under

        public AlarmClock(int hour, int minute) : this(hour, minute, 0, 0)
        {
            
        }//hämtar de värderna från metoden under

        public AlarmClock(int hour, int minute, int alarmHour, int alarmMinute) // parametrarna sätter värden till properties
        {
            Hour = hour;
            Minute = minute;
            AlarmHour = alarmHour;
            AlarmMinute = alarmMinute;
        }

        public bool TickTock() //får tiden att gå. Får timmen och minuten att slå om vid 23 och 59
        {
            if (Minute < 59)
            {
                Minute++;
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
        
        public string ToString() //tiden som kommer skrivas ut när man kallar på metoden
        {
            return String.Format("{0,2}:{1:00} <{2}:{3:00}>", Hour, Minute, AlarmHour, AlarmMinute); //Här kommer alltid vara två st siffror, så om minutes är mindre än 10 kommer nollan skrivas dit innan
        }
        
    }
}
