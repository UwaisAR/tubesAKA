using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace visualijer
{
    internal class SelectionSort : InterfaceS
    {
        private bool _sorted = false;
        private int[] arr;
        private Graphics g;
        private int MaxVal;
        private Stopwatch RunningTime;
        Brush WhiteBrush = new System.Drawing.SolidBrush(System.Drawing.Color.White);
        Brush BlackBrush = new System.Drawing.SolidBrush(System.Drawing.Color.Black);

        public void DoWork(int[] arr_In, Graphics g_In, int MaxVal_In, Stopwatch RunningTime_In)
        {
            arr = arr_In;
            g = g_In;
            MaxVal = MaxVal_In;
            RunningTime = RunningTime_In;
            while (!_sorted)
            {
                for (int i = 0; i < arr.Count() - 1; i++)
                {
                    int min_idx = i;
                    for (int j = i + 1; j < arr.Count(); j++)
                    {
                        if (arr[j] < arr[min_idx])
                        {
                            min_idx = j;
                        }
                    }
                    int temp = arr[min_idx];
                    arr[min_idx] = arr[i];
                    arr[i] = temp;
                    DrawBar(i, arr[i]);
                    DrawBar(min_idx, arr[min_idx]);
                }
                _sorted = InterfaceS();
            }
            RunningTime.Stop();
        }

        private void DrawBar(int position, int height)
        {
            g.FillRectangle(BlackBrush, position, 0, 1, MaxVal);
            g.FillRectangle(WhiteBrush, position, MaxVal - arr[position], 1, MaxVal);
        }

        private bool InterfaceS()
        {
            for (int i = 0; i < arr.Count() - 1; i++)
            {
                if (arr[i] > arr[i + 1]) return false;
            }
            return true;
        }   
    }
}