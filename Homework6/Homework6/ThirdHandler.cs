using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework6
{
    class ThirdHandler : Handler, ICutDownNotifier
    {

        public ThirdHandler(TaskTime startTask, Action<string> endTask) :
           base(startTask, endTask)
        { }

        public override void Init(string taskName, int timeTaskExecutionSeconds)
        {
            base.Init(taskName, timeTaskExecutionSeconds);
            //Lambda methods
            timer.OnSecondsLeft += (object sender, int secondsLeft) 
                => Console.WriteLine($"{(sender as Timer).TimerName}: {secondsLeft} seconds left");

            timer.OnBeginTimer += (object sender, string notification)
                => Console.WriteLine($"{(sender as Timer).TimerName}: {notification}");

            timer.OnFinishTimer += (object sender, string notification)
               => Console.WriteLine($"{(sender as Timer).TimerName}: {notification}");

        }
    }
}
