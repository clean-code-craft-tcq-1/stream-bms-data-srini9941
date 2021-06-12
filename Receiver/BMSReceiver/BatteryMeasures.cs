using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMSReceiver
{
    public class BatteryMeasures
    {
        public double Temperature {get;set;}
        public double StateOfCharge { get; set; }
    }

    public class MeasureResult
    {
        public double Maximum { get; set; }
        public double Minimum { get; set; }
        public double MovingAverage { get; set; }
    }
}
