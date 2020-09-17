using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Homework6
{
    public class Timer
    {
        public delegate void RunTimerHandler(object sender, int secondsLeft);
        public event RunTimerHandler OnSecondsLeft;

        public delegate void TimerHandler(object sender, string notification);
        public event TimerHandler OnBeginTimer;
        public event TimerHandler OnFinishTimer;

        public string TimerName { get; set; }
        public int TimerTime { get; set; }

        public Timer (string name, int seconds)
        {
            TimerName = name;
            TimerTime = seconds;
        }

        public void RunTimer()
        {
            OnBeginTimer?.Invoke(this, "Timer is starting");
            for (int i = TimerTime; i > 0; i--)
            {
                Thread.Sleep(1000);
                OnSecondsLeft?.Invoke(this, i);
            }
            OnFinishTimer?.Invoke(this, "Timer is over");
        }
    }
}
