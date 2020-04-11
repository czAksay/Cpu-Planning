using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPUPlanning
{
    class Resource
    {
        bool free;    //свободен ли процессор
        Process activeProcess;  //активный процесс на процессоре
        public bool Free { get { return free; } }
        public Process ActiveProcess { get { return activeProcess; } }

        public Resource()
        {
            free = true;
            activeProcess = null;
        }

        public void LoadProcess(Process p)
        {
            activeProcess = p;
            free = false;
        }

        public void NextStep()
        {
            if (!free)
                activeProcess.IncreaseWorkTime();
        }

        public void DismissProcess()
        {
            activeProcess = null;
            free = true;
        }
    }
}
