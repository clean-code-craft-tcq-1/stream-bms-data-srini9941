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
                
                //Setting static limit, since sender keep on sending without stopping streaming battery parameters
                if(readingsCount == 20) 
                    break;
            }
            
            List<Double> TemperatureList = _measureList.Select(list => list.Temperature).ToList();
            List<Double> StateOfChargeList = _measureList.Select(list => list.StateOfCharge).ToList();
            ConsoleLogger logger = new ConsoleLogger();

            MeasureResult TemperatureResult = GetMeasureResult(TemperatureList, new Temperature());
            logger.PrintBMSOperationResult(TemperatureResult, "Temperature");

            MeasureResult SOCResult = GetMeasureResult(StateOfChargeList, new StateOfCharge());
            logger.PrintBMSOperationResult(SOCResult, "State of Charge");       
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
    }
}
