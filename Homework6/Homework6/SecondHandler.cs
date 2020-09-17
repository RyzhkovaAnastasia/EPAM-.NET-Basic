using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework6
{
    class SecondHandler : Handler, ICutDownNotifier
    {

        public SecondHandler(TaskTime startTask, Action<string> endTask) :
           base(startTask, endTask)
        { }

        public override void Init(string taskName, int timeTaskExecutionSeconds)
        {
            base.Init(taskName, timeTaskExecutionSeconds);

            //Anonymous methods
            timer.OnSecondsLeft += delegate (object sender, int secondsLeft)
            {
                var o = sender as Timer;
                Console.WriteLine($"{o.TimerName}: {secondsLeft} seconds left");
            };

            timer.OnBeginTimer += delegate (object sender, string notification)
            {
                var o = sender as Timer;
                Console.WriteLine($"{o.TimerName}: {notification}");
            };

            timer.OnFinishTimer += delegate (object sender, string notification)
            {
                var o = sender as Timer;
                Console.WriteLine($"{o.TimerName}: {notification}");
            };
        }
    }
}
