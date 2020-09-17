using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework6
{
    class FirstHandler : Handler, ICutDownNotifier
    {
        public FirstHandler(TaskTime startTask, Action<string> endTask) :
           base(startTask, endTask)
        { }

        public override void Init(string taskName, int timeTaskExecutionSeconds)
        {
            base.Init(taskName, timeTaskExecutionSeconds);
            //Methods
            timer.OnSecondsLeft += SecondsLeft;
            timer.OnBeginTimer += TimerLife;
            timer.OnFinishTimer += TimerLife;
        }

        void TimerLife(object sender, string notification)
        {
            var o = sender as Timer;

            Console.WriteLine($"{o.TimerName}: {notification}");
        }

        void SecondsLeft(object sender, int secondsLeft)
        {
            var o = sender as Timer;

            Console.WriteLine($"{o.TimerName}: {secondsLeft} seconds left");
        }
    }
}
