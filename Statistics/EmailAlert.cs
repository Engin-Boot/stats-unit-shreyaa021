using System;
using System.Collections.Generic;
using System.Text;

namespace Statistics
{
    public class EmailAlert :IAlert
    {
        public bool emailSent;
       public  void Alert(double maxThreshold, double max)
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
