using BMSReceiver.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMSReceiver
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<BatteryMeasures> _measureList = new List<BatteryMeasures>();
            ProcessInputReadings _process = new ProcessInputReadings();
            string getData; 
            int readingsCount = 1;
            while((getData = Console.ReadLine()) != null)
            {
                _measureList.Add(_process.ProcessRawBatteryMeasureReadings(getData));
                readingsCount++;
            }

            if (readingsCount > 15)
            {
                List<Double> TemperatureList = _measureList.Select(list => list.Temperature).ToList();
                List<Double> StateOfChargeList = _measureList.Select(list => list.StateOfCharge).ToList();

                MeasureResult TemperatureResult = GetMeasureResult(TemperatureList, new Temperature());
                PrintResult(TemperatureResult, new Temperature());

                MeasureResult SOCResult = GetMeasureResult(StateOfChargeList, new StateOfCharge());
                PrintResult(SOCResult, new StateOfCharge());
            }
        }

        public static MeasureResult GetMeasureResult(List<Double> _measureReadings, IBMSOperations _measureClass)
        {
            MeasureResult _result = new MeasureResult();
            if (Validation.IsReadingsHasValues(_measureReadings) && !Validation.IsReadingsHasNaN(_measureReadings))
            {
                _result.Maximum = _measureClass.FindMaximum(_measureReadings);
                _result.Minimum = _measureClass.FindMinimum(_measureReadings);
                _result.MovingAverage = _measureClass.FindSimpleMovingAverage(_measureReadings);
            }
            return _result;
        }

        public static void PrintResult(MeasureResult _result, IBMSOperations _measureClass)
        {
            _measureClass.PrintOperationResult(_result);
        }

    }
}
