using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        static IWebDriver driver;

        [AssemblyInitialize]
        public static void SetUp(TestContext context)
        {
            //driver = new FirefoxDriver();
            driver = new ChromeDriver();
        }

        [TestMethod]
        public void TestMethod2()
        {
            driver.Navigate().GoToUrl("https://www.amazon.in/");
            driver.Manage().Window.Maximize();
            driver.FindElement(By.XPath("//span[text()='Hello. Sign in']")).Click();
            driver.FindElement(By.Id("ap_email")).SendKeys("test");
            driver.FindElement(By.Id("continue")).Click();
            //driver.Manage().Timeouts().ImplicitWait.Milliseconds.
            driver.FindElement(By.Id("ap_password")).SendKeys("tester123");
            driver.FindElement(By.Id("signInSubmit")).Click();

            
        }

        [AssemblyCleanup]
        public static void TearDown()
        {
           driver.Quit();
        }
    }
}
