using System;
using System.Collections.Generic;
using System.Text;

namespace Statistics
{
    class EmailAlert :IAlert
    {
        public bool emailSent;
        void Alert(double maxThreshold, double max)
        {
            if (max > maxThreshold)
            {

                emailSent = true;
            }
            else
                emailSent = false;

        }
    }
}
