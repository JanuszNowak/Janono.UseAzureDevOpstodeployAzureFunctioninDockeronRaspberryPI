using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{

    [TestClass]
    public class UnitTestConvertWindSpeedData //: FunctionApp1.FunctionTest
    {
        private readonly ILogger logger = TestFactory.CreateLogger();

        [TestMethod]
        public void CanConvertLowWindSpeed()
        {
            //Arrange
            var request = TestFactory.CreateHttpRequest("name", "Bill");
            ////Act
            var response = (OkObjectResult)FunctionApp1.IsAlive.Run(request, logger);
            //Assert
            Assert.IsTrue(response.Value.ToString().Contains("Region"));
        }
    }
}
