using System;
using System.Collections.Generic;

  namespace Statistics
{
    public class StatsComputer
    {      

        public StatisticsDataModel CalculateStatistics(List<float> numbers)
        {   
       double average= numbers[0];
       double max =numbers[0];
        double min=numbers[0];

           
          
            var sum = 0f;
            if (numbers.Count == 0)
            {
                max = Double.NaN;
                min = Double.NaN;
                average = Double.NaN;
                
	
            }
            else {
           
                foreach(var number in numbers)
            {
                
                    if (number > max)
                        max = number;
                    if (number < min)
                        min = number;
                    sum += number;
            }
                
                average = sum / numbers.Count;
        
         

            
            }
           return new StatisticsDataModel{
			min= min,
			max=max,
			average=average
		};

            }
        }
    }


