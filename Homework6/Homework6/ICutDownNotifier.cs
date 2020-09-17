using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework6
{
    interface ICutDownNotifier
    {
        void Init(string taskName, int timeTaskExecutionSeconds);
        void Run();
    }
}
