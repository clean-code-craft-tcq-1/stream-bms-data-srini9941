using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace BMSReceiver.Test
{
    [TestClass]
    public class ReceiverTest
    {
        [TestMethod]
        public void GivenEmptyReadings_WhenListIsEmpty_ThenReturnFalse()
        {
            bool HasValues = Validation.IsReadingsHasValues(new List<Double> { });
            Assert.IsFalse(HasValues);
        }

        [TestMethod]
        public void GivenListOfReadings_WhenListHasValues_ThenReturnTrue()
        {
            bool HasValues = Validation.IsReadingsHasValues(new List<Double> {1.1,1.2,1.3,1.4,1.5});
            Assert.IsTrue(HasValues);
        }

        [TestMethod]
        public void GivenListOfReadings_WhenListHasNaN_ThenReturnTrue()
        {
            bool IsValid = Validation.IsReadingsHasNaN(new List<Double> { 1.1, 1.2, Double.NaN, 1.4, 1.5 });
            Assert.IsTrue(IsValid);
        }

        [TestMethod]
        public void GivenListOfReadings_WhenListHasValidReadings_ThenReturnFalse()
        {
            bool IsValid = Validation.IsReadingsHasNaN(new List<Double> { 1.1, 1.2, 1.24, 1.42, 1.75 });
            Assert.IsFalse(IsValid);
        }

        [TestMethod]
        public void GivenTemperatureList_WhenListHasValidReadings_ThenReturnDoubleMaximumValue()
        {
            double maxValue = new Temperature().FindMaximum(new List<Double> { 1.1, 1.4, 1.6, 1.9, 1.028, 1.33 });
            Assert.IsTrue(!Double.IsNaN(maxValue));
        }

        [TestMethod]
        public void GivenTemperatureList_WhenListHasValidReadings_ThenReturnDoubleMinimumValue()
        {
            double minValue = new Temperature().FindMinimum(new List<Double> { 1.9, 1.1, 1.4, 1.6, 1.028, 1.33 });
            Assert.IsTrue(!Double.IsNaN(minValue));
        }

        [TestMethod]
        public void GivenTemperatureList_WhenListHasValidReadings_ThenReturnDoubleAverageValue()
        {
            double avgValue = new Temperature().FindSimpleMovingAverage(new List<Double> { 1.1, 1.4, 1.028, 1.33, 1.6, 1.9 });
            Assert.IsTrue(!Double.IsNaN(avgValue));
        }

        [TestMethod]
        public void GivenSOCList_WhenListHasValidReadings_ThenReturnDoubleMaximumValue()
        {
            double maxValue = new StateOfCharge().FindMaximum(new List<Double> { 1.1, 65.8, 45.4, 1.9, 1.028, 1.33 });
            Assert.IsTrue(!Double.IsNaN(maxValue));
        }

        [TestMethod]
        public void GivenSOCList_WhenListHasValidReadings_ThenReturnDoubleMinimumValue()
        {
            double minValue = new StateOfCharge().FindMaximum(new List<Double> { 1.1, 33.3, 20.2, 1.9, 1.028, 1.33 });
            Assert.IsTrue(!Double.IsNaN(minValue));
        }

        [TestMethod]
        public void GivenSOCList_WhenListHasValidReadings_ThenReturnDoubleAvgValue()
        {
            double avgValue = new StateOfCharge().FindSimpleMovingAverage(new List<Double> { 40.1, 50.4, 60.6, 1.9, 1.028, 1.33 });
            Assert.IsTrue(!Double.IsNaN(avgValue));
        }

        [TestMethod]
        public void GivenTemperatureReadings_ThenReturnMeasureResult()
        {
            List<double> TemperatureReadings = new List<double>() { 22.3, 43, 6, 65.9, 76.4, 34.0 };
            MeasureResult _result = Program.GetMeasureResult(TemperatureReadings, new Temperature());
            Assert.IsNotNull(_result);
        }

        [TestMethod]
        public void GivenSOCReadings_ThenReturnMeasureResult()
        {
            List<double> SOCReadings = new List<double>() { 22.3, 43, 6, 65.9, 76.4, 34.0 };
            MeasureResult _result = Program.GetMeasureResult(SOCReadings, new StateOfCharge());
            Assert.IsNotNull(_result);
        }
    }
}
