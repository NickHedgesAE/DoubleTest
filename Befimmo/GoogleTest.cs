using NUnit.Framework;
using System.Collections.Generic;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Befimmo
{
    public class OtherTests
    {
        private IWebDriver driver;
        private IJavaScriptExecutor js;
        public IDictionary<string, object> vars { get; private set; }

        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
            js = (IJavaScriptExecutor)driver;
            vars = new Dictionary<string, object>();
        }

        [Test]
        public void Events()
        {
            driver.Navigate().GoToUrl("https://www.google.be");
        }

        [TearDown]
        protected void TearDown()
        {
            driver.Quit();
        }
    }
    
}
