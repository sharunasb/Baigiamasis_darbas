using baigiamasis_darbas.Driver;
using baigiamasis_darbas.Page;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace baigiamasis_darbas.Tools
{
    public class BaseTest
    {
        protected static IWebDriver driver;

        

        [OneTimeSetUp]
        public static void SetUp()
        {
            driver = CustomDriver.GetFirefoxDriver();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            KixArtPage KixArtPage = new KixArtPage(driver);
        }

        [TearDown]
        public static void Screenshot()
        {

            ScreenshotTool.TakeScreenshot(driver);

        }

        [OneTimeTearDown]
        public static void TearDown()
        {
            driver.Quit();
        }

    }
}