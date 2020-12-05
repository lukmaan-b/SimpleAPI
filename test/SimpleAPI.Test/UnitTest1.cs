using System;
using Xunit;
using SimpleAPI.Controllers;
using SimpleAPI;
using System.Collections.Generic;
using System.Linq;

namespace SimpleAPI.Test
{
    public class UnitTest1
    {
        WeatherForecastController controller = new WeatherForecastController(); 

        [Fact]
        public void Get_Returns_My_Name()
        {
            var returnValue = (controller.Get()).ToArray();
            Assert.Equal(5,returnValue.Length);
        }
    }
}
