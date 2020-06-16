using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace Framework
{
    public class Settings
    {
        protected static IWebDriver driver { get; set; }

        public static string url = "http://localhost/";

        [SetUp]
        public void SetUp()
        {
            driver = new ChromeDriver();
            Console.WriteLine("Opening Google Chrome browser.");
            driver.Manage().Window.Maximize();
            Console.WriteLine("Maximize window.");
            driver.Navigate().GoToUrl(url);
            Console.WriteLine($"Navigate to: '{url}'.");
        }

        [TearDown]
        public void TearDown()
        {
            driver.Close();
            driver.Dispose();
            Console.WriteLine("Close driver.");
        }
    }
}
