using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPUPlanning
{
    class Process
    {
        string name; //имя процесса
        int id; //идентификатор процесса
        int priority; //приоритет процесса
        int burst_time; //интервал обслуживания на ЦП в тактах. Генерируется сразу при постановке в очередь.
        int work_time; //общее время работы процесса на ЦП
        int wait_time; //общее время ожидания в очереди
        int creation_time; //время создания процесса
        int bit_size;   //размер выделяемой процессу памяти в битах

        public int WorkTime { get { return work_time; } }
        public int WaitTime { get { return wait_time; } }
        public string Name { get { return name; } }
        public int Size { get { return bit_size; } }
        public int Id { get { return id; } }

        public Process(int takt, int numofpr, int prDiap, int inter, int memory)
        {
            name = "P"+takt.ToString();
            id = numofpr;
            priority = prDiap;
            burst_time = inter;
            work_time = 0;
            wait_time = 0;
            creation_time = takt;
            bit_size = memory;
        }

        public int GetPriority()
        {
            return priority;
        }

        public void IncreaseWorkTime()
        {
            work_time += 1;
        }

        public void IncreaseWaitTime()
        {
            wait_time += 1;
        }

        public string GetInfo()
        {
            string info;
            info = "Name: "+name + ". Id: " + id.ToString() + ". Pr: " + priority.ToString()+". BT: "+burst_time.ToString()+". WoT: "+work_time.ToString()+". WaT: "+wait_time.ToString()+". Mem: "+bit_size.ToString();
            return info;
        }

        public bool CheckBurstTime()
        {
            if (work_time >= burst_time)
                return true;
            else
                return false;
        }

        public void ReducePriorityToMin()
        {
            priority = 1;
        }

        public void NewBurstTime(int t)
        {
            if (t >= 1)
            {
                burst_time = t;
                work_time = 0;
                wait_time = 0;
            }
        }
    }
}
