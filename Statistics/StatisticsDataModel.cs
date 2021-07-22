using System;
using System.Collections.Generic;
using System.Text;


namespace Statistics
{
    public class StatisticsDataModel
    {
        public double max;
        public double min;
        public double average;




        public StatisticsDataModel(double max, double min, double average)
        {
            this.max = max;
            this.min = min;
            this.average = average;


        }
        public StatisticsDataModel()
        {
            this.max = Double.NAN;
            this.min = Double.NAN;
            this.average = Double.NAN;


        }
    }
}
