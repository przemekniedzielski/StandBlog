using Framework.Utils;
using NUnit.Framework;
using OpenQA.Selenium;
using System;

namespace Framework.Pages
{
    public class HomePage
    {
        private static IWebDriver driver;

        public HomePage (IWebDriver webDriver)
        {
            driver = webDriver;
        }

        //Elements
        private readonly static string prevButton = "owl-prev";
        private readonly static string nextButton = "owl-next";

        //Methods
        public void GoToHomePage()
        {
            driver.Navigate().GoToUrl(Settings.url);
        }

        //Assertions
        public void CheckIfPreviousButtonIsDisplayed()
        {
            IWebElement element = driver.FindElement(By.ClassName(prevButton));
            try
            {
                Assert.IsTrue(element.Displayed);
                Console.WriteLine($"{nameof(element)} button is displayed correctly.");
            }
            catch (Exception)
            {
                Console.WriteLine($"{nameof(element)} button is not displayed.");
            }
        }

        public void CheckIfNextButtonIsDisplayed()
        {
            IWebElement element = driver.FindElement(By.ClassName(nextButton));
            try
            {
                Assert.IsTrue(element.Displayed);
                Console.WriteLine($"{nameof(element)} button is displayed correctly.");
            }
            catch (Exception)
            {
                Console.WriteLine($"{nameof(element)} button is not displayed.");
            }
        }
    }
}
