using System;
using Xunit;
using SimpleApi.Controllers;
using Newtonsoft.Json.Linq;

namespace SimpleApi.test
{
    public class UnitTest1
    {
        WeatherForecastController controller = new WeatherForecastController();

        [Fact]
        public void GetReturnMyname(){
            var ReturnValue = controller.Get();

            Assert.Equal("Jorge Tamariz", ReturnValue);
        }

        [Fact]
        public void Test1()
        {

        }
    }
}
