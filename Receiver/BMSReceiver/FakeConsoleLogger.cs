using BMSReceiver.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMSReceiver
{
    public class FakeConsoleLogger : ILogger
    {
        public bool isPrintFunctionCalledAtleastOnce = false;
        public void PrintBMSOperationResult(MeasureResult result, string ParameterName)
        {
            this.isPrintFunctionCalledAtleastOnce = true;
        }
    }
}
