using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program1
{
    public class ClockEventArgs:EventArgs
    {
        public int hour;
        public int minute;
        public int second;
    }

    public delegate void ClockEventHandler(Object sender, ClockEventArgs e);

    public class Clock
    {
        public event ClockEventHandler ClockAlert;

        public void DoClock()
        {
            string clock = "19:25";
            if(ClockAlert != null)
            {
                ClockEventArgs args = new ClockEventArgs();
                if(DateTime.Now.ToShortTimeString() == clock)
                {
                    ClockAlert(this, args);
                }
            }
        }
    }

    class UseClock
    {
        static void Main(string[] args)
        {
            var clocker = new Clock();

            clocker.ClockAlert += Alert;
            clocker.DoClock();
        }

        static void Alert(Object sender, ClockEventArgs e)
        {
            Console.Write("Time's up!");
        }
    }
}
