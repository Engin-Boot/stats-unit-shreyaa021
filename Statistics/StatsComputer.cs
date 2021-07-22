using System;
using System.Collections.Generic;

  namespace Statistics
{
    public class StatsComputer
    {      

        public StatisticsDataModel CalculateStatistics(List<float> numbers)
        {   
        
           
          
            var sum = 0f;
            if (numbers.Count == 0)
            {              
              
              return new StatisticsDataModel(Double.NaN,Double.NaN,Double.NaN);
            }
            

            else {

                 double average= numbers[0];
                 double max =numbers[0];
                 double min=numbers[0];
           
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
           return new StatisticsDataModel(max,min,average);

            }
        }
    }


