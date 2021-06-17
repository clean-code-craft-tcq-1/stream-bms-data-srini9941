using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BMSReceiver
{
    public class ProcessInputReadings
    {
        public BatteryMeasures ProcessRawBatteryMeasureReadings(string readingsInput)
        {
            BatteryMeasures measures = new BatteryMeasures();
            var batteryReadings = Regex.Matches(readingsInput, @"\d+").Cast<Match>().Select(x => double.Parse(x.Value)).ToArray();
            if (batteryReadings.Length == 2)
            {
                measures.Temperature = batteryReadings[0];
                measures.StateOfCharge = batteryReadings[1];
            }
            return measures;
        }
    }
}
