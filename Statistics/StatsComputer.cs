using System;
using System.Collections.Generic;

  namespace Statistics
{
    public class StatsComputer
    {
        public double average;
        public double max;
        public double min;

        public StatisticsDataModel CalculateStatistics(List<double> numbers)
        {   

            this.max = numbers[0];
            this.min = numbers[0];
            this.average = 0;
            if (numbers.Count == 0)
             return new StatisticsDataModel();
    
           
                foreach(double number in numbers)
            {
                
                    if (number > this.max)
                        this.max = number;
                    if (number < this.min)
                        this.min = number;
                    this.average += number;
            }
                
                this.average = this.average / numbers.Count;
        
                return (new StatisticsDataModel(this.max,this. min, this.average));

            


            }
        }
    }


