using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPUPlanning
{
    class MemoryScheduler
    {
        int layers; //количество слоев
        bool[,] block;  //Указывает, занят ли соответствующий блок.
        int[,] ids; //id'ы процессов в каждом блоке.
        int x, y;   //координаты для метода следующего подходящего. Аналоги соответствующих i, j;

        public MemoryScheduler(int n)
        {
            if (n < 1)
                throw new Exception("Количество слоев битовойт карты не может быть равно нулю.");
            layers = n;
            block = new bool[8, n];
            ids = new int[8, n];
            x = 0;
            y = 0;
        }

        private void FillMemory(int xtmp, int ytmp, Process p, int i, int j)
        {
            int counter = 0;
            x = i;
            y = j;
            while (counter != p.Size)
            {
                block[xtmp, ytmp] = true;
                ids[xtmp, ytmp] = p.Id;
                counter++;

                xtmp++;
                if (xtmp > 7)
                {
                    xtmp = 0;
                    ytmp++;
                    if (ytmp >= layers)
                        ytmp = 0;
                }
            }
        }

        public bool LoadNewProcess(Process p)
        {
            bool circle = false;
            int xTmp = x, yTmp = y; //временные координаты чтобы запомнить, с какого места начинался поиск
            int length = p.Size;    //длина нужного участка памяти
            int l=0;    //счетчик длины найденной памяти
            int i = x, j = y;   //счетчики нахождения в битовой карте в данный момент
            while (!(i==x && j==y) || !circle)
            {
                if (!block[i,j])
                {
                    if (l==0)
                    { xTmp = i;  yTmp = j; }
                    l++;
                }
                else
                {
                    l = 0;
                }

                if (l>=length)
                {
                    FillMemory(xTmp, yTmp, p, i, j);
                    return true;
                }
                else
                {
                    i++;
                    if (i>7)
                    {
                        i = 0;
                        j++;
                        if (j>=layers)
                        {
                            j = 0;
                            circle = true;
                        }
                    }
                }
            }
            return false;
        }

        public bool[,] GetBitCard()
        {
            return block;
        }

        public void UnloadProcess(Process p)
        {
            bool found = false;
            for (int j = 0; j < layers; j++)
            {
                for (int i = 0; i < 8; i++)
                {
                    if (ids[i,j]==p.Id)
                    {
                        found = true;
                        block[i, j] = false;
                        ids[i, j] = 0;
                    }
                    else if (found)
                    {
                        return;
                    }
                }
            }
        }
    }
}
