using CalculationAPI.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Web.Http;
using System.Web.Http.Results;

namespace CalculationApp.Tests
{
    [TestClass]
    public class UnitTest
    {
        /// <summary>
        /// This Test method tests "sumandcheck" action with the api endpoint
        /// </summary>
        [TestMethod]
        public void Caluculation_ShouldReturnSum()
        {
            var controller = new CalcController
            {
                Request = new HttpRequestMessage(),
                Configuration = new HttpConfiguration()
            };

            var action = controller.Get("sumandcheck", "1,2,3");
            var actionResult = action.ExecuteAsync(CancellationToken.None).Result;
            var expect = new { result= 6,isPrime= false};
            Assert.IsNotNull(actionResult);
            Assert.IsNotNull(actionResult.Content);
            Assert.AreEqual(HttpStatusCode.OK, actionResult.StatusCode);
        }

        /// <summary>
        /// This Test method tests "checkprime" action with the api endpoint
        /// </summary>
        [TestMethod]
        public void CheckPrime_ShouldReturnIsPrime()
        {
            var controller = new CalcController
            {
                Request = new HttpRequestMessage(),
                Configuration = new HttpConfiguration()
            };

            var action = controller.Get("checkprime", "89");
            var actionResult = action.ExecuteAsync(CancellationToken.None).Result;
            Assert.IsNotNull(actionResult);
            Assert.IsNotNull(actionResult.Content);
            Assert.AreEqual(HttpStatusCode.OK, actionResult.StatusCode);
        }

        /// <summary>
        /// This Test method tests if Bad Request error is returned when bad data is passed to the endpoint
        /// </summary>
        [TestMethod]
        public void BadRequest_ShouldReturnError()
        {
            var controller = new CalcController
            {
                Request = new HttpRequestMessage(),
                Configuration = new HttpConfiguration()
            };

            var action = controller.Get("","");
            var actionResult = action.ExecuteAsync(CancellationToken.None).Result;
            Assert.IsNotNull(actionResult);
            Assert.IsNotNull(actionResult.Content);
            Assert.AreEqual(HttpStatusCode.BadRequest, actionResult.StatusCode);
        }
    }
}
