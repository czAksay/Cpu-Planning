using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace CPUPlanning
{
    class CpuScheduler
    {
        public delegate void Delegate1();
        public delegate void Delegate2(int qu);
        public delegate void Delegate3(Process p);

        public event Delegate1 EvNewProc;
        public event Delegate1 EvProcIsFree;
        public event Delegate2 EvNewLength;
        public event Delegate3 EvFinishedProc;
        public event Delegate1 EvDenied;
        public event Delegate1 EvLeftProc;

        double intensivity;
        int interval;
        int prDiapason;
        int numOfRes;   //кол-во ресурсов
        int memInterval;    //интервал выделяемых битов
        bool showmessages;  //показывать ли сообщения
        int numOfProcess;   

        public CpuScheduler(double inten, int inter, int prD, int nres, int mem, bool sm)
        {
            intensivity = inten;
            interval = inter;
            prDiapason = prD;
            numOfProcess = 0;
            numOfRes = nres;
            memInterval = mem;
            showmessages = sm;
        }

        public void CreateProcess(int takt, PriorityQueue<Process> que, MemoryScheduler memSh)
        {
            int a = Form1.rnd.Next(0, 100)+1;
            int b = (int)(intensivity * 100);
            if (a<=b)
            {
                EvNewProc();
                int prdiap = Form1.rnd.Next(prDiapason)+1;
                int memory = Form1.rnd.Next(1,memInterval+1);
                int inter = Form1.rnd.Next(interval)+1;
                Process pr = new Process(takt, ++numOfProcess, prdiap, inter, memory);
                if (memSh.LoadNewProcess(pr))
                {
                    que.Add(pr, pr.GetPriority());
                    EvNewLength(que.GetLength());
                }
                else
                {
                    if (showmessages)
                        MessageBox.Show("Процесс не поступил в очередь из-за нехватки памяти.");
                    EvDenied();
                }
            }
        }

        public void ManipulateCpu(Cpu cpu, PriorityQueue<Process> que, ResourceScheduler[] resSh, MemoryScheduler memSh)
        {
            if (cpu.Free)
                EvProcIsFree();
            if (!cpu.Free)
            {
                if (cpu.GetActiveProcess().CheckBurstTime())
                {
                    Process pr = cpu.GetActiveProcess();
                    EvFinishedProc(pr);

                    int a = Form1.rnd.Next(0, numOfRes + 1);
                    if (a == 0)
                    {
                        EvLeftProc();
                        if (showmessages)
                            MessageBox.Show("Процесс " + pr.Name + " завершен.");
                        memSh.UnloadProcess(pr);
                    }
                    else
                    {
                        if (showmessages)
                            MessageBox.Show("Процесс " + pr.Name + " переходит в очередь к ресурсу " + a.ToString());
                        resSh[a - 1].AddNewProcess(pr);
                    }
    
                    cpu.FinishActiveProcess();
                }
                else if (cpu.CheckQuantTime())
                {
                    Process pr = que.GetFirst();
                    que.DeleteFirst();
                    cpu.GetActiveProcess().ReducePriorityToMin();
                    que.AddToEnd(cpu.GetActiveProcess());
                    cpu.LoadNewProcess(pr);
                }
            }
            if (!que.IsEmpty() && !cpu.Free && que.GetFirst().GetPriority() > cpu.GetActiveProcess().GetPriority())
            {
                Process pr = que.GetFirst();
                que.DeleteFirst();
                que.Add(cpu.GetActiveProcess(), cpu.GetActiveProcess().GetPriority());
                cpu.LoadNewProcess(pr);
            }
            if (cpu.Free && !que.IsEmpty())
            {
                cpu.LoadNewProcess(que.GetFirst());
                que.DeleteFirst();
            }
        }
    }
}
