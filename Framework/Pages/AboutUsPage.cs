using NUnit.Framework;
using OpenQA.Selenium;
using System;

namespace Framework.Pages
{
    public class AboutUsPage : Settings
    {
        //Elements
        private readonly static string titleInBanner = "//section[@class='page-heading']//h4";
        private readonly static string moreInfoInBanner = "//section[@class='page-heading']//h2";
        private readonly static string aboutUsImage = "//section[@class='about-us']//img";

        //Methods

        //Assertions
        public static void CheckIfAboutUsPageIsDisplayed()
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

        public static void CheckIfMoreAboutUsTextIsDisplayed()
        {
            IWebElement element = driver.FindElement(By.XPath(moreInfoInBanner));
            try
            {
                Assert.AreEqual(element.Text, "MORE ABOUT US!");
                Console.WriteLine($"Text on banner is displayed correctly and equals '{element.Text}'.");
            }
            catch (Exception)
            {
                Console.WriteLine("Something went wrong. Text on banner is not correct.");
            }
        }

        public static void CheckIfImageInAboutUsPageIsDisplayed()
        {
            IWebElement element = driver.FindElement(By.XPath(aboutUsImage));
            try
            {
                Assert.IsTrue(element.Displayed);
                Console.WriteLine("Image in 'About us' page is displayed correctly.");
            }
            catch (Exception)
            {
                Console.WriteLine("Something went wrong. Image in 'About us' page is not displayed.");
            }
        }
    }
}