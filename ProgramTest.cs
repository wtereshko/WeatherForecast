using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Weather_Forecast
{
    [TestFixture]
   public class ProgramTest
    {
        [TestCase("'-39C'")]
        [TestCase("'fg-1,1C")]
        public void GetResults_Test_ColdWeather(string weatherResult)
        {
            string expectedResult = "It’s super cold today.Be sure you dressed well!";
            string actualResult = Program.GetResult(weatherResult);
            
            StringAssert.AreEqualIgnoringCase(expectedResult, actualResult);
        }

        [TestCase("'0C'")]
        [TestCase("'+9C")]
        public void GetResults_Test_WindyWeather(string weatherResult)
        {
            string expectedResult = "It’s windy outside, but we are sure you will enjoy your day!";
            string actualResult = Program.GetResult(weatherResult);

            StringAssert.AreEqualIgnoringCase(expectedResult, actualResult);
        }
       
        [TestCase("'+15C'")]
        [TestCase("test'+29,9C")]
        public void GetResults_Test_PerfectWeather(string weatherResult)
        {
            string expectedResult = "It’s time for the outdoor walking!";
            string actualResult = Program.GetResult(weatherResult);

            StringAssert.AreEqualIgnoringCase(expectedResult, actualResult);
        }

        [TestCase("'+31C'")]
        [TestCase("38.2C")]
        public void GetResults_Test_HotWeather(string weatherResult)
        {
            string expectedResult = "It's so hot outside!";
            string actualResult = Program.GetResult(weatherResult);

            StringAssert.AreEqualIgnoringCase(expectedResult, actualResult);
        }

        [TestCase("'+41C'")]
        [TestCase("+50C")]
        public void GetResults_Test_HellWeather(string weatherResult)
        {
            string expectedResult = "Welcome to hell!";
            string actualResult = Program.GetResult(weatherResult);

            StringAssert.AreEqualIgnoringCase(expectedResult, actualResult);
        }

        [TestCase("'jkvjknjasxuyn'")]
        [TestCase("@#$!$%-+C\'")]
        public void GetResults_Test_ReCheck(string weatherResult)
        {
            string expectedResult = "Please re-check results in 5 mins.";
            string actualResult = Program.GetResult(weatherResult);

            StringAssert.AreEqualIgnoringCase(expectedResult, actualResult);
        }
    }
}
