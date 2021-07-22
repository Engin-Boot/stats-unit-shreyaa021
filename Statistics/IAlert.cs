using System;
using System.Collections.Generic;
using System.Text;

namespace Statistics
{
    interface IAlert
    {
       public void Alert(double maxThreshold, double max);
    }
}
