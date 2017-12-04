using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GreetingTDD.Tests
{
    [TestClass]
    public class GreetingTests
    {
        private IUserLoginService _UserLoginService;

        [TestInitialize]
        public void Test_init()
        {
            _UserLoginService = new UserLoginService();
        }

        [TestMethod]
        public void If_A_Name_Length_GreaterThan_0_Then_Service_Returns_message()
        {
            if (_UserLoginService == null)
            {
                throw new NullReferenceException();
            }

            var validName = "Buddy";

            var actualGreeting = _UserLoginService.GreetUser(validName);
            var expectedGreeting = "Hello Buddy!";

            Assert.AreEqual(expectedGreeting, actualGreeting, "The user Greeting is incorrect");

        }
    }
}
