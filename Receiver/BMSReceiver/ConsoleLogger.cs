using BMSReceiver.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMSReceiver
{
    public class ConsoleLogger : ILogger
    {
        public void PrintBMSOperationResult(MeasureResult result, string ParameterName)
        {
            Console.WriteLine("Maximum "+ ParameterName+": " + result.Maximum);
            Console.WriteLine("Minimum " + ParameterName+ ": " + result.Minimum);
            Console.WriteLine("Simple Moving Average of " + ParameterName+ ": " + result.MovingAverage);
        }
    }
}
