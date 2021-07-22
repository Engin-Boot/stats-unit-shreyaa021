using System;
using System.Collections.Generic;
using System.Text;

namespace Statistics
{
    public class AlertHandler
    {   
        List<IAlert> Alerters = new List<IAlert>();
         public double threshold;


        public AlertHandler(double maxThreshold, List<IAlert> alerters)
        {
            threshold = maxThreshold;
            for (int i = 0; i < alerters.Count; i++)
                Alerters.Add(alerters[i]);
        }
       
        public void CheckStatisticsandAlert(List<double> numbers)
        {
            var statsComputer = new StatsComputer();
            var max = statsComputer.CalculateStatistics(numbers).max;
     
          
            foreach(IAlert alerter in Alerters)
            { 
                alerter.Alert(threshold, max);
            }

    }
    }
}
