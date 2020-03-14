using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace AutoClicker
{
    internal class Time
    {
        public static void StartTimer(DateTime interval)
        {
            Timer timer = new Timer()
            {
                AutoReset = true,
                Interval = interval.Ticks,
                Enabled = true,
            };
            timer.Elapsed += Ticked;
        }

        private static void Ticked(object sender, ElapsedEventArgs e)
        {
            
            throw new NotImplementedException();
            
        }
    }
}
