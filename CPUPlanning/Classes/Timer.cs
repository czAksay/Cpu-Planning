using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPUPlanning
{
    class Timer
    {
        int takt;
        public int NumOfTakt { get { return takt; } }

        public Timer()
        {
            takt = 0;
        }

        public void NextStep()
        {
            takt++;
            if (takt == 100000)
            {
                takt = 0;
                throw new Exception("Выход такта за пределы максимального значения.");
            }
        }
    }
}
