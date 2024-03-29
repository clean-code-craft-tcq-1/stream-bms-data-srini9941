using BMSReceiver.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMSReceiver
{
    public class StateOfCharge : IBMSOperations
    {
        public double FindMaximum(List<Double> SOC)
        {
            return SOC.Max<double>();
        }

        public double FindMinimum(List<Double> SOC)
        {
            return SOC.Min<double>();
        }

        public double FindSimpleMovingAverage(List<Double> SOC)
        {
            SOC.Reverse();
            return SOC.Take(5).ToList().Average();
        }
    }
}
