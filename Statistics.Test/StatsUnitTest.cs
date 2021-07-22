using System;
using Xunit;
using Statistics;
using System.Collections.Generic;

namespace Statistics.Test
{
    public class StatsUnitTest
    {
        [Fact]
        public void ReportsAverageMinMax()
        {
            var statsComputer = new StatsComputer();
          
            var statistics = statsComputer.CalculateStatistics(new List<float> {1.5f, 8.9f ,3.2f, 4.5f});
            float epsilon = 0.001F;
            Assert.True(Math.Abs(statistics.average - 4.525) <= epsilon);
            Assert.True(Math.Abs(statistics.max - 8.9) <= epsilon);
            Assert.True(Math.Abs(statistics.min - 1.5) <= epsilon);
        }
        [Fact]
        public void ReportsNaNForEmptyInput()
        {
            var statsComputer = new StatsComputer();
            var Statistics = statsComputer.CalculateStatistics(new List<float> { });
            Assert.True(Double.NaN.Equals(Statistics.average));
            Assert.True(Double.NaN.Equals(Statistics.max));
            Assert.True(Double.NaN.Equals(Statistics.min));
            //All fields of computedStats (average, max, min) must be
            //Double.NaN (not-a-number), as described in
            //https://docs.microsoft.com/en-us/dotnet/api/system.double.nan?view=netcore-3.1
        }
        [Fact]
        public void RaisesAlertsIfMaxIsMoreThanThreshold()
        {
            var emailAlert = new EmailAlert();
            var ledAlert = new LedAlert();
            IAlert[] alerts = { emailAlert, ledAlert };
            List<IAlert> alerters = new List<IAlert>(alerts);
            const float maxThreshold = 10.2f;
            AlertHandler statsAlerter = new AlertHandler(maxThreshold, alerters);
            statsAlerter.CheckStatisticsandAlert(new List<float>{0.2f, 11.9f, 4.3f, 8.5f});

            Assert.True(emailAlert.emailSent);
            Assert.True(ledAlert.ledGlows);
        }
    }
}
