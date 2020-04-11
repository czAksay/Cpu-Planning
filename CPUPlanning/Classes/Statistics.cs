using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPUPlanning
{
    class Statistics
    {
        int numOfIncomTasks;    //кол-во поступивших заданий
        int numOfFinishedTasks; //кол-во завершенных заданий
        int WaTiOfFin;  //время ожидания завершившихся заданий.
        int WoTiOfFin;  //время работы завершившихся заданий.
        int averWaTiOfFin;  //среднее время ожидания для завершившихся заданий
        int averWoTiOfFin;  //среднее время работы для завершившихся заданий
        int maxLengthOfQueue; //максимальная длина очереди.
        int taktsOfDowntime;  //время простоя процессора без заданий.

        int numOfDenied; //кол-во отказанных процессов
        int numOfFinishedResouces;  //кол-во выполненных ресурсами процессов
        int numOfLeft;  //кол-во покинувших систему


        public Statistics()
        {
            numOfIncomTasks = 0;
            numOfFinishedTasks = 0;
            WaTiOfFin = 0;
            WoTiOfFin = 0;
            averWaTiOfFin = 0;
            averWoTiOfFin = 0;
            maxLengthOfQueue = 0;
            taktsOfDowntime = 0;
            numOfDenied = 0;
            numOfFinishedResouces = 0;
        }

        public void HndNewProc()
        {
            numOfIncomTasks++;
        }

        public void HndFinishProc(Process p)
        {
            numOfFinishedTasks++;
            WoTiOfFin += p.WorkTime;
            WaTiOfFin += p.WaitTime;
            averWaTiOfFin = WaTiOfFin/numOfFinishedTasks;
            averWoTiOfFin = WoTiOfFin / numOfFinishedTasks;
        }

        public void HndLeftProcess()
        {
            numOfLeft++;
        }

        public void HndNewLengthOfQueue(int lng)
        {
            if (lng > maxLengthOfQueue)
                maxLengthOfQueue = lng;
        }

        public void HndProcIsFree()
        {
            taktsOfDowntime++;
        }

        public void HndDeniedProcess()
        {
            numOfDenied++;
        }

        public void HndFinishRes()
        {
            numOfFinishedResouces++;
        }

        public string GetInfo()
        {
            string info="";
            info += "Кол-во поступивших заданий: " + numOfIncomTasks.ToString()+"\n";
            info += "Кол-во заданий, выполненных процессором: " + numOfFinishedTasks.ToString() + "\n";
            info += "Кол-во заданий, выполненных ресурсами: " + numOfFinishedResouces.ToString() + "\n";
            info += "Кол-во отказов в обслуживании: " + numOfDenied.ToString() + "\n";
            info += "Кол-во заданий, покинувших систему: " + numOfLeft.ToString() + "\n";
            info += "Среднее время ожидания завершенных заданий: " + averWaTiOfFin.ToString() + "\n";
            info += "Среднее время работы завершенных заданий: " + averWoTiOfFin.ToString() + "\n";
            info += "Максимальная длина очереди: " + maxLengthOfQueue.ToString() + "\n";
            info += "Время простоя процессора без заданий: " + taktsOfDowntime.ToString();
            return info;
        }
    }
}
