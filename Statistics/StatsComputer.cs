using System;
using System.Collections.Generic;

  namespace Statistics
{
    public class StatsComputer
    {



        public StatisticsDataModel CalculateStatistics(List<double> numbers)
        {


        public double average;
        public double max;
        public double min;

        max = numbers[0];
            min = numbers[0];
            average = 0;
            if (numbers.Count == 0)
             return new StatisticsDataModel();
    
           
                for (int i=0; i<numbers.Count;i++) 
            {
                
                    if (numbers[i] > max)
                        max = numbers[i];
                    if (numbers[i] < min)
                        min = numbers[i];
                    average += numbers[i];
            }
                
                average = average / numbers.Count;
        
                return (new StatisticsDataModel(max, min, average));

            


            }
        }
    }


