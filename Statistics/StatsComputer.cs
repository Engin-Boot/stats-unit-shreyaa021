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
            this.average = numbers[0];
            var sum = 0f;
            if (numbers.Count == 0)
            {
                this.max = Double.NaN;
                this.min = Double.NaN;
                this.average = Double.NaN;
                return new StatisticsDataModel(this.max, this.min, this.average);
            }
           
                foreach(var number in numbers)
            {
                
                    if (number > this.max)
                        this.max = number;
                    if (number < this.min)
                        this.min = number;
                    sum += number;
            }
                
                this.average = sum / numbers.Count;
        
                return (new StatisticsDataModel{
			min=this.min,
			max=this.max,
			average=this.average
		});

            


            }
        }
    }


