using BMSReceiver.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMSReceiver
{
    public class Temperature : IBMSOperations
    {
        public double FindMaximum(List<Double> Temperature)
        {
            return Temperature.Max<double>();
        }

        public double FindMinimum(List<Double> Temperature)
        {
            return Temperature.Min<double>();
        }

        public double FindSimpleMovingAverage(List<Double> Temperature)
        {
            Temperature.Reverse();
            List<double> LastFive = Temperature.Take(5).ToList();
            return Temperature.Average();
            
        }

        public void PrintOperationResult(MeasureResult result)
        {
            Console.WriteLine("Maximum Temperature: " + result.Maximum);
            Console.WriteLine("Minimum Temperature: " + result.Minimum);
            Console.WriteLine("Simple Moving Average of Temperature: " + result.MovingAverage);
        }
    }
}
