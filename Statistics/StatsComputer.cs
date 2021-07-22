using System;
using System.Collections.Generic;

  namespace Statistics
{
    public class StatsComputer
    {
        public double average;
        public double max;
        public double min;

        public StatisticsDataModel CalculateStatistics(List<float> numbers)
        {   

            this.max = numbers[0];
            this.min = numbers[0];
            var sum = 0f;
            if (numbers.Count == 0)
             return new StatisticsDataModel();
    
           
                foreach(var number in numbers)
            {
                
                    if (number > this.max)
                        this.max = number;
                    if (number < this.min)
                        this.min = number;
                    sum += number;
            }
                
                this.average = sum / numbers.Count;
        
                return (new StatisticsDataModel(this.max,this. min, this.average));

            


            }
        }
    }


