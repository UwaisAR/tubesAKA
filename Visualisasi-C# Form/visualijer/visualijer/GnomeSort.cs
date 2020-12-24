using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace visualijer
{
    class GnomeSort : InterfaceS2
    {
        private bool _sorted = false;
        private int[] arr2;
        private Graphics g2;
        private int MaxVal2;
        private Stopwatch RunningTime2;
        Brush WhiteBrush = new System.Drawing.SolidBrush(System.Drawing.Color.White);
        Brush BlackBrush = new System.Drawing.SolidBrush(System.Drawing.Color.Black);

        public void DoWork2(int[] arr2_In, Graphics g2_In, int MaxVal2_In, Stopwatch RunningTime2_In)
        {
            arr2 = arr2_In;
            g2 = g2_In;
            MaxVal2 = MaxVal2_In;
            RunningTime2 = RunningTime2_In;

            while (!_sorted)
            {
                int index = 0;

                while (index < arr2.Count())
                {

                    if (index == 0)
                    {
                        index++;
                    }
                    if (arr2[index] >= arr2[index - 1])
                    {
                        index++;
                    }
                    else
                    {
                        int temp = 0;
                        temp = arr2[index];
                        arr2[index] = arr2[index - 1];
                        arr2[index - 1] = temp;
                        DrawBar2(index, arr2[index]);
                        DrawBar2(index-1, arr2[index-1]);
                        index--;

                    }
                }
                _sorted = InterfaceS2();
                RunningTime2.Stop();
            }
        }

        private void DrawBar2(int position, int height)
        {
            g2.FillRectangle(BlackBrush, position, 0, 1, MaxVal2);
            g2.FillRectangle(WhiteBrush, position, MaxVal2 - arr2[position], 1, MaxVal2);
        }

        private bool InterfaceS2()
        {
            for (int i = 0; i < arr2.Count() - 1; i++)
            {
                if (arr2[i] > arr2[i + 1]) return false;
            }
            return true;
        }
    }
}