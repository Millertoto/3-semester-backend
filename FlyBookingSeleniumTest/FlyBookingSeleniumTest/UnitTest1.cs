using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;

namespace FlyBookingSeleniumTest
{
    [TestClass]
    public class UnitTest1
    {
        private static readonly string DriverDirectory = "C:\\SeleniumDrivers";
        private static IWebDriver _driver;

        [ClassInitialize]
        public static void Setup(TestContext context)
        {
             _driver = new ChromeDriver(DriverDirectory); // fast
            //_driver = new FirefoxDriver(DriverDirectory);  // slow
            // _driver = new EdgeDriver(DriverDirectory); // times out ... not working
        }

        [ClassCleanup]
        public static void TearDown()
        {
            _driver.Dispose();
        }
        [TestMethod]
        public void ShowFligtsTest()
        {
            _driver.Navigate().GoToUrl("http://localhost:3000/");
            Assert.AreEqual("Coding Template", _driver.Title);

            IWebElement Elementbutton = _driver.FindElement(By.Id("all"));
            Elementbutton.Click();

            WebDriverWait wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(10));
            IWebElement listElement = wait.Until(d => d.FindElement(By.Id("RejseListe")));
            Assert.IsTrue(listElement.Text.Contains("Pismo"));
        }
        [TestMethod]
        public void Test()
        {
            _driver.Navigate().GoToUrl("http://localhost:3000/");

            IWebElement flightButton = _driver.FindElement(By.Id("all"));
            flightButton.Click();

            WebDriverWait wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(10));
            IWebElement visMere = wait.Until(d => d.FindElement(By.Id("Tk1-09m")));

            visMere.Click();

            IWebElement listElement = wait.Until(d => d.FindElement(By.Id("RejseListe")));

            Assert.IsTrue(listElement.Text.Contains("CO2 udledning per. passager: 3.2"));
            


        }
    }
}
