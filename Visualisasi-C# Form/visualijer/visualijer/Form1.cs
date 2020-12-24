using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace visualijer
{
    public partial class Form1 : Form
    {
        private Stopwatch RunningTime, RunningTime2;
        Graphics g, g2;
        int[] arr, arr2;

        public Form1()
        {
            InitializeComponent();
        }

        private void generateBtn_Click(object sender, EventArgs e)
        {
            RunningTime.Reset();
            RunningTime2.Reset();
            g = panel1.CreateGraphics();
            g2 = panel2.CreateGraphics();
            //generate panel 1 dan 2
            int NumEntries = panel1.Width;
            int MaxVal = panel1.Height;
            int NumEntries2 = panel2.Width;
            int MaxVal2 = panel2.Height;
            arr = new int[NumEntries];
            arr2 = new int[NumEntries2];
            Task taskA = new Task(() => generate(g, NumEntries, MaxVal, arr));
            Task taskB = new Task(() => generate(g2, NumEntries2, MaxVal2, arr2));
            taskB.Start();
            taskA.Start();
        }

        private void generate(Graphics g, int NumEntries, int MaxVal, int[] arr)
        {
            g.FillRectangle(new System.Drawing.SolidBrush(System.Drawing.Color.Black), 0, 0, NumEntries, MaxVal);
            Random rand = new Random();
            for (int i = 0; i < NumEntries; i++)
            {
                arr[i] = rand.Next(0, MaxVal);
            }
            for (int i = 0; i < NumEntries; i++)
            {
                g.FillRectangle(new System.Drawing.SolidBrush(System.Drawing.Color.White), i, MaxVal - arr[i], 1, MaxVal);
            }
        }

        private void startBtn_Click(object sender, EventArgs e)
        {
            RunningTime.Start();
            RunningTime2.Start();
            InterfaceS2 we = new GnomeSort();
            InterfaceS se = new SelectionSort();
            Task taskB = new Task(() => we.DoWork2(arr2, g2, panel2.Height, RunningTime2));
            taskB.Start();
            Task taskA = new Task(() => se.DoWork(arr, g, panel1.Height, RunningTime));
            taskA.Start();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            RunningTime = new Stopwatch();
            RunningTime2 = new Stopwatch();
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            this.detik1.Text = String.Format("{0:ss\\,fff\\s}", RunningTime.Elapsed);
            this.detik2.Text = String.Format("{0:ss\\,fff\\s}", RunningTime2.Elapsed);
        }
    }
}
