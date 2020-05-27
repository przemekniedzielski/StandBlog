using NUnit.Framework;
using OpenQA.Selenium;
using System;

namespace Framework.Header
{
    public class Header
    {
        private readonly IWebDriver driver;

        public Header(IWebDriver webDriver)
        {
            driver = webDriver;
        }

        //Elements
        public static string Logo = "navbar-brand";

        public static string Home = "//a[@class='nav-link'][contains(text(),'Home')]";
        public static string AboutUs = "//a[@class='nav-link'][text()='About Us']";
        public static string BlogEntries = "//a[@class='nav-link'][text()='Blog Entries']";
        public static string PostDetails = "//a[@class='nav-link'][text()='Post Details']";
        public static string ContactUs = "//a[@class='nav-link'][text()='Contact Us']";


        //Assertions
        public void CheckIfLogoIsDisplayed()
        {
            IWebElement element = driver.FindElement(By.ClassName(Logo));
            try
            {
                Assert.IsTrue(element.Displayed);
                Console.WriteLine($"Logo is displayed correctly.");
            }
            catch (Exception)
            {
                Console.WriteLine($"Logo is not displayed.");
            }
        }
        public void CheckIfHomeButtonIsDisplayed()
        {
            IWebElement element = driver.FindElement(By.XPath(Home));
            try
            {
                Assert.IsTrue(element.Displayed);
                Console.WriteLine($"{element.Text} button is displayed correctly.");
            }
            catch (Exception)
            {
                Console.WriteLine($"{element.Text} is not displayed.");
            }
        }
        public void CheckIfAboutUsButtonIsDisplayed()
        {
            IWebElement element = driver.FindElement(By.XPath(AboutUs));
            try
            {
                Assert.IsTrue(element.Displayed);
                Console.WriteLine($"{element.Text} button is displayed correctly.");
            }
            catch (Exception)
            {
                Console.WriteLine($"{element.Text} is not displayed.");
            }
        }
        public void CheckIfBlogEntriesButtonIsDisplayed()
        {
            IWebElement element = driver.FindElement(By.XPath(BlogEntries));
            try
            {
                Assert.IsTrue(element.Displayed);
                Console.WriteLine($"{element.Text} button is displayed correctly.");
            }
            catch (Exception)
            {
                Console.WriteLine($"{element.Text} is not displayed.");
            }
        }
        public void CheckIfPostDetailsButtonIsDisplayed()
        {
            IWebElement element = driver.FindElement(By.XPath(PostDetails));
            try
            {
                Assert.IsTrue(element.Displayed);
                Console.WriteLine($"{element.Text} button is displayed correctly.");
            }
            catch (Exception)
            {
                Console.WriteLine($"{element.Text} is not displayed.");
            }
        }
        public void CheckIfContactUsButtonIsDisplayed()
        {
            IWebElement element = driver.FindElement(By.XPath(ContactUs));
            try
            {
                Assert.IsTrue(element.Displayed);
                Console.WriteLine($"{element.Text} button is displayed correctly.");
            }
            catch (Exception)
            {
                Console.WriteLine($"{element.Text} is not displayed.");
            }
        }
    }
}
