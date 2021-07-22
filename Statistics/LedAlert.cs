using System;
using System.Collections.Generic;
using System.Text;

namespace Statistics
{
    class LedAlert : IAlert
    {

        public bool ledGlows;
       public void Alert(double maxThreshold, double max)
        {
            if (max > maxThreshold)
            {

                ledGlows = true;
            }
            else
                ledGlows = false;

        }



    }
}
