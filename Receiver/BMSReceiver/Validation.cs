using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMSReceiver
{
    public class Validation
    {
        public static bool IsReadingsHasValues(List<Double> readings)
        {
            if (readings.Count > 0)
                return true;
            return false;
        }

        public static bool IsReadingsHasNaN(List<Double> readings)
        {
            foreach(double value in readings)
            {
                if (Double.IsNaN(value))
                    return true;
            }
            return false;
        }
    }
}
