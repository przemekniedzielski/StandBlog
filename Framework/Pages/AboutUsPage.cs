using Framework.Utils;
using NUnit.Framework;
using OpenQA.Selenium;
using System;

namespace Framework.Pages
{
    public class AboutUsPage
    {
        private readonly IWebDriver driver;

        public AboutUsPage(IWebDriver webDriver)
        {
            driver = webDriver;
        }

        //Elements
        private readonly static string titleInBanner = "//section[@class='page-heading']//h4";

        //Methods

        //Assertions
        public void CheckIfAboutUsPageIsDisplayed()
        {
            IWebElement element = driver.FindElement(By.XPath(titleInBanner));
            try
            {
                Assert.AreEqual(element.Text, "ABOUT US");
                Console.WriteLine("About us page is displayed correctly.");
            }
            catch (Exception)
            {
                Console.WriteLine("Something went wrong. About us page is not displayed.");
            }
        }
    }
}