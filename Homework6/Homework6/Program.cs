using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework6
{
    class Program
    {
        static void StartTimer(string taskName, int timeTaskExecution)
        {
            Console.WriteLine($"Setting {taskName} timer: time execution {timeTaskExecution}");   
        }

        static void FinishTimer(string taskName)
        {
            Console.WriteLine($"Timer {taskName} was delete!");
        }

        static void Main(string[] args)
        {
            List<ICutDownNotifier> cutDownNotifiers = new List<ICutDownNotifier>()
            {
            new FirstHandler(StartTimer, FinishTimer),
            new SecondHandler(StartTimer, FinishTimer),
            new ThirdHandler(StartTimer, FinishTimer)
            };

            cutDownNotifiers[0].Init("Reading task", 5);
            cutDownNotifiers[1].Init("Doing task", 10);
            cutDownNotifiers[2].Init("Checking task", 5);

            foreach (var i in cutDownNotifiers)
            {
                i.Run();
            }

            cutDownNotifiers.Clear();

            GC.Collect();
            GC.WaitForPendingFinalizers();

            Console.ReadKey();
        }
    }
}
