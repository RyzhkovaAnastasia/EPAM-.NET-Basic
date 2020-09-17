using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework6
{
    abstract class Handler
    {
        protected Timer timer;
        private string _taskName;

        public delegate void TaskTime(string taskName, int timeTaskExecution);
        TaskTime _startTimerNotify;
        public Action<string> _endTimerNotify;

        public Handler(TaskTime startTask, Action<string> finishTask)
        {
            _startTimerNotify += startTask;
            _endTimerNotify += finishTask;
        }
        public virtual void Init(string taskName, int timeTaskExecutionSeconds)
        {
            timer = new Timer(taskName, timeTaskExecutionSeconds);
            _startTimerNotify?.Invoke(taskName, timeTaskExecutionSeconds);
            _taskName = taskName;
        }
        public void Run()
        {
            timer.RunTimer();
        }
        ~Handler()
        {
            _endTimerNotify?.Invoke(_taskName);
        }
    }
}
