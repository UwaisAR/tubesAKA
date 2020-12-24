using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace visualijer
{
    interface InterfaceS
    {
        void DoWork(int[] arr, Graphics g, int MaxVal, Stopwatch RunningTime);
    }
}
