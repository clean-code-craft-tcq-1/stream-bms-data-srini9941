using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMSReceiver.Interfaces
{
    public interface IBMSOperations
    {
        double FindMaximum(List<double> measures);
        double FindMinimum(List<double> measures);
        double FindSimpleMovingAverage(List<double> measures);
    }
}
