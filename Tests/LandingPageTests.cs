using System;
using AutomationTools.Testing;
using HardCopyDelivery.UI.Tests.Utilities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HardCopyDelivery.UI.Tests.Pages;

namespace HardCopyDelivery.UI.Tests.Tests
{
    [TestClass]
    public class LandingPageTests : BaseTest
    {
        public LandingPageTests() : base(DriverUtil.DetermineBrowserType())
        {

        }

        [TestInitialize]
        public void TestInit()
        {
            Driver.Navigate().GoToUrl("https://devhotel.fncinc.com/hardcopydelivery/");
            Driver.Manage().Window.Maximize();
        }

        [TestMethod]
        public void Whatever()
        {
            var LandingPage = new LandingPage(Driver);
            LandingPage.Click_LoginButton();
        }
    }
}
