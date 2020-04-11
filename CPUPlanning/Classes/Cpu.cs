using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPUPlanning
{
    class Cpu
    {
        bool free;    //свободен ли процессор
        int sizeOfQuant;    //величина кванта
        Process activeProcess;  //активный процесс на процессоре
        int currentProcessWork; //работа активного процесса на процессоре. Обнуляется при смене процесса.
        public bool Free { get { return free; } }
        
        public Cpu(int soq)
        {
            free = true;
            activeProcess = null;
            sizeOfQuant = soq;
            currentProcessWork = 0;
        }

        public Process GetActiveProcess()   //возвращает активный процесс, если такой имеется
        {
            if (free)
                return null;
            else
                return activeProcess;
        }

        public void NextStep()  //следующий такт. 
        {
            if (!free)
            {
                activeProcess.IncreaseWorkTime();   //увеличивается время работы процесса на процессоре
                currentProcessWork++;   //увеличивается время работы процессора для сравнения с квантом
            }
        }

        public void LoadNewProcess(Process p)   //загружает на процессор новый процесс.
        {
            activeProcess = p;
            free = false;
            currentProcessWork = 0;
        }
        /*по факту, красивее была бы реализация типа:
        public Process LoadNewProcess(Process p)
        {
            if (p!=null)
            {
                Process prTmp = activeProcess;
                acriveProvess = p;
                isFree = false;
                currentProcessWork = 0;
                return prTmp;
            }
            else
            {
                return null;
            }
        }

        Это позволило бы возвращать в планировщик процесс для занесения его обратно в очередь (если надо) и сразу же загрузить новый на процессор.
        Лень делать.
        */


        public void FinishActiveProcess()   //сводит на ноль активный процесс
        {
            activeProcess = null;
            free = true;
            currentProcessWork = 0;
        }

        public bool CheckQuantTime()    //проверяет, исчерпал ли процессор свой квант времени.
        {
            return (sizeOfQuant==currentProcessWork);
        }
    }
}
