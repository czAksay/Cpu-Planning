using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CPUPlanning
{
    public partial class Form1 : Form
    {
        public static Random rnd;
        Cpu cpu;
        CpuScheduler cpSch;
        Timer timer;
        Statistics st;
        PriorityQueue<Process> queue;
        ResourceScheduler[] resSh;
        MemoryScheduler memSh;
        int ResCount;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            cbShowMessages.Enabled = false;
            pnlMemory.Enabled = false;
            pnlParameters.Enabled = false;
            btnNext.Enabled = true;
            btnStop.Enabled = true;
            btnStart.Enabled = false;


            rnd = new Random();
            ResCount = Convert.ToInt32(numCountOfRes.Value);
            cpu = new Cpu(Convert.ToInt32(numQuant.Value));
            timer = new Timer();
            queue = new PriorityQueue<Process>();
            cpSch = new CpuScheduler(Convert.ToDouble(numIntensivity.Value), Convert.ToInt32(numInterval.Value), Convert.ToInt32(numPrDiapason.Value), ResCount, Convert.ToInt32(numBitSize.Value), cbShowMessages.Checked);
            st = new Statistics();
            resSh = new ResourceScheduler[ResCount];
            memSh =  new MemoryScheduler(Convert.ToInt32(numLayers.Value));
            DisplayStats();
            DisplayMemory();


            for (int i=0; i<= ResCount; i++)
            {
                if (i != ResCount)
                {
                    resSh[i] = new ResourceScheduler(Convert.ToInt32(numInterval.Value));
                    resSh[i].EvEndResource += new ResourceScheduler.Delegate1(st.HndFinishRes);
                }
                switch (i)
                {
                    case 1:
                        gbRes1.Enabled = true; gbResQu1.Enabled = true; break;
                    case 2:
                        gbRes2.Enabled = true; gbResQu2.Enabled = true; break;
                    case 3:
                        gbRes3.Enabled = true; gbResQu3.Enabled = true; break;
                }
            }

            cpSch.EvNewProc += new CpuScheduler.Delegate1(st.HndNewProc);
            cpSch.EvNewLength += new CpuScheduler.Delegate2(st.HndNewLengthOfQueue);
            cpSch.EvProcIsFree += new CpuScheduler.Delegate1(st.HndProcIsFree);
            cpSch.EvFinishedProc += new CpuScheduler.Delegate3(st.HndFinishProc);
            cpSch.EvDenied += new CpuScheduler.Delegate1(st.HndDeniedProcess);
            cpSch.EvLeftProc += new CpuScheduler.Delegate1(st.HndLeftProcess);
            //cpSch.CreateProcess(timer.NumOfTakt, queue);
            //DisplayQueue(); 
        }

        private void DisplayQueue()
        {
            lbQueue.Items.Clear();
            LinkedList<Process> proc = new LinkedList<Process>();
            LinkedList<int> pr = new LinkedList<int>();
            queue.GetQueue(ref proc, ref pr);

            if (proc.Count == pr.Count)
            {
                LinkedListNode<Process> procNode = proc.First;
                LinkedListNode<int> prNode = pr.First;
                while (procNode!=null)
                {
                    lbQueue.Items.Add(procNode.Value.GetInfo());
                    procNode = procNode.Next;
                }
            }
            else
                throw new Exception("Непонятка какая-то!");
        }

        private void IncreaseQueueProcessWaitTime()
        {
            LinkedList<Process> proc = new LinkedList<Process>();
            LinkedList<int> pr = new LinkedList<int>();
            queue.GetQueue(ref proc, ref pr);

            if (proc.Count == pr.Count)
            {
                LinkedListNode<Process> procNode = proc.First;
                while (procNode != null)
                {
                    procNode.Value.IncreaseWaitTime();
                    procNode = procNode.Next;
                }
            }
            else
                throw new Exception("Непонятка какая-то!");
        }

        private void DisplayResources()
        {
            for (int i = 0;i<ResCount; i++)
            {
                switch (i)
                {
                    case 0:
                        lbRes1.Items.Clear();
                        if (!resSh[i].Resource.Free)
                            lbRes1.Items.Add(resSh[i].Resource.ActiveProcess.GetInfo());
                        break;
                    case 1:
                        lbRes2.Items.Clear();
                        if (!resSh[i].Resource.Free)
                            lbRes2.Items.Add(resSh[i].Resource.ActiveProcess.GetInfo());
                        break;
                    case 2:
                        lbRes3.Items.Clear();
                        if (!resSh[i].Resource.Free)
                            lbRes3.Items.Add(resSh[i].Resource.ActiveProcess.GetInfo());
                        break;
                }
            }
        }

        private void DisplayResourceQueues()
        {
            for (int i = 0; i<ResCount; i++)
            {
                Queue<Process> qu = resSh[i].GetQueue();
                switch (i)
                {
                    case 0:
                        lbResQu1.Items.Clear();
                        foreach (Process p in qu)
                            lbResQu1.Items.Add(p.GetInfo());
                        break;
                    case 1:
                        lbResQu2.Items.Clear();
                        foreach (Process p in qu)
                            lbResQu2.Items.Add(p.GetInfo());
                        break;
                    case 2:
                        lbResQu3.Items.Clear();
                        foreach (Process p in qu)
                            lbResQu3.Items.Add(p.GetInfo());
                        break;
                }
            }
        }

        private void DisplayStats()
        {
            lbStats.Items.Clear();

            string info = st.GetInfo();
            string[] inf = info.Split(new char[] { '\n'});
            for (int i = 0; i < inf.Length; i++)
                lbStats.Items.Add(inf[i]);
        }

        private void DisplayCpu()
        {
            lbCpu.Items.Clear();
            if (!cpu.Free)
                lbCpu.Items.Add(cpu.GetActiveProcess().GetInfo());
        }

        void DisplayMemory()
        {
            bool[,] b = memSh.GetBitCard();
            lbMemory.Items.Clear();
            for (int j = 0; j < b.GetLength(1); j++)
            {
                string s = "";
                for (int i = 0; i < b.GetLength(0); i++)
                {
                    s += Convert.ToInt16(b[i, j]).ToString()+" ";
                }
                lbMemory.Items.Add(s);
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            cbShowMessages.Enabled = true;
            pnlMemory.Enabled = true;
            gbResQu1.Enabled = false;
            gbResQu2.Enabled = false;
            gbResQu3.Enabled = false;
            gbRes1.Enabled = false;
            gbRes2.Enabled = false;
            gbRes3.Enabled = false;
            pnlParameters.Enabled = true;
            btnNext.Enabled = false;
            btnStop.Enabled = false;
            btnStart.Enabled = true;
            lbRes1.Items.Clear();
            lbRes2.Items.Clear();
            lbRes3.Items.Clear();
            lbResQu1.Items.Clear();
            lbResQu2.Items.Clear();
            lbResQu3.Items.Clear();
            lbMemory.Items.Clear();

            lbCpu.Items.Clear();
            lbQueue.Items.Clear();
            lbStats.Items.Clear();

            cpu = null;
            cpSch = null;
            st = null;
            timer = null;
            queue = null;
            resSh = null;
            memSh = null;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            timer.NextStep();
            IncreaseQueueProcessWaitTime();
            cpu.NextStep();
            for (int i = 0; i < ResCount; i++)
            {
                resSh[i].NextStep();
                resSh[i].IncreaseProcessWaitTime();
            }

            cpSch.CreateProcess(timer.NumOfTakt, queue, memSh);
            cpSch.ManipulateCpu(cpu, queue, resSh, memSh);
            for (int i=0; i< ResCount; i++)
            {
                resSh[i].ManipulateResource(queue);
            }

            DisplayQueue();
            DisplayCpu();
            DisplayStats();
            DisplayResources();
            DisplayResourceQueues();
            DisplayMemory();
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            string text = "Программа, моделирующая функционирование вычислительной системы.\nРеализация очереди с приоритетами: бинарное дерево поиска.\nИспользуемая стратегия планирования процессора: HPF с вытеснением и квантованием времени.\nСпособ учета использованной памяти: битовая карта.\nСтратегия выбора свободной области памяти: стратегия следующего подходящего.\n\nВыполнил студент 2 курса 2 группы направления Компьютерная инженерия, Хоба Юрий.";
            string title = "Справка";
            MessageBox.Show(text,title,MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
