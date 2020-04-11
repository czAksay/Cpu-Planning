using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CPUPlanning
{
    class ResourceScheduler
    {
        Resource res;
        Queue<Process> que;
        int bursInterval;   //интервал времени работы на процессоре, указанный пользователем. Исп. для генерации нового интервала в случае входа в очередь.

        public delegate void Delegate1();
        public event Delegate1 EvEndResource;
        public Resource Resource { get { return res; } }

        public ResourceScheduler(int i)
        {
            bursInterval = i;
            res = new Resource();
            que = new Queue<Process>();
        }

        public void AddNewProcess(Process p)
        {
            int t = 1;
            if (bursInterval!=1)
                t = Form1.rnd.Next(1, bursInterval);
            p.NewBurstTime(t);
            que.Enqueue(p);
        }

        public void ManipulateResource(PriorityQueue<Process> qu)
        {
            if (!res.Free && res.ActiveProcess.CheckBurstTime())
            {
                int t = 1;
                if (bursInterval != 1)
                    t = Form1.rnd.Next(1, bursInterval);
                res.ActiveProcess.NewBurstTime(t);
                qu.Add(res.ActiveProcess, res.ActiveProcess.GetPriority());
                res.DismissProcess();
                EvEndResource();
            }
            if (res.Free && que.Count!=0)
            {
                res.LoadProcess(que.Dequeue());
            }
        }

        public void NextStep()
        {
            res.NextStep();
        }

        public Queue<Process> GetQueue()
        {
            return que;
        }

        public void IncreaseProcessWaitTime()
        {
            foreach (Process p in que)
            {
                p.IncreaseWaitTime();
            }
        }
    }
}
