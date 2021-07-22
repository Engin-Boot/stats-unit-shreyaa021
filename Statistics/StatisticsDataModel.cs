using System;
using System.Collections.Generic;
using System.Text;


namespace Statistics
{
    public class StatisticsDataModel
    {
        public double max {get ;set ;}
        public double min {get;set;}
        public double average{get ;set;}



        public StatisticsDataModel(double max, double min, double average)
        {
            this.max = max;
            this.min = min;
            this.average = average;
        

        }

       
    }

   
}
