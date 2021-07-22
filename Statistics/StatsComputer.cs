using System;
using System.Collections.Generic;

  namespace Statistics
{
    public class StatsComputer
    {      

        public StatisticsDataModel CalculateStatistics(List<float> numbers)
        {   
        
           double average,max,min;
               
          
            var sum = 0f;
            if (numbers.Count == 0)
            {              
              
              return new StatisticsDataModel(Double.NaN,Double.NaN,Double.NaN);
            }
            
              
           
            else {

                 max= numbers[0];
                 min=numbers[0];


                foreach(var number in numbers)
            {
                

                    if (number > max)
                        max = number;
                    if (number < min)
                        min = number;
                    sum += number;
            }
                
                average = sum / numbers.Count;
                     return new StatisticsDataModel(max,min,average);
            }
          

            }
        }
    }


