using NUnit.Framework;
using OpenQA.Selenium;
using System;

namespace Framework
{
    public class Header : Settings
    {
        //Elements
        private readonly static string Logo = "navbar-brand";

        private readonly static string Home = "//a[@class='nav-link'][contains(text(),'Home')]";
        private readonly static string AboutUs = "//a[@class='nav-link'][text()='About Us']";
        private readonly static string BlogEntries = "//a[@class='nav-link'][text()='Blog Entries']";
        private readonly static string PostDetails = "//a[@class='nav-link'][text()='Post Details']";
        private readonly static string ContactUs = "//a[@class='nav-link'][text()='Contact Us']";

        //Methods
        public static void ClickHomeButtonOnMenu()
        {
            driver.FindElement(By.XPath(Home)).Click();
            Console.WriteLine("Going to 'Home' page.");
        }

        public static void ClickAboutUsButtonOnMenu()
        {
            driver.FindElement(By.XPath(AboutUs)).Click();
            Console.WriteLine("Going to 'About us' page.");
        }


        //Assertions
        public static void CheckIfLogoIsDisplayed()
        {
            IWebElement element = driver.FindElement(By.ClassName(Logo));
            try
            {
                Assert.IsTrue(element.Displayed);
                Console.WriteLine("Logo is displayed correctly.");
            }
            catch (Exception)
            {
                Console.WriteLine("Something went wrong. Logo is not displayed correctly.");
            }
        }
        public static void CheckIfHomeButtonIsDisplayed()
        {
            IWebElement element = driver.FindElement(By.XPath(Home));
            try
            {
                Assert.IsTrue(element.Displayed);
                Console.WriteLine($"{element.Text} button is displayed correctly.");
            }
            catch (Exception)
            {
                Console.WriteLine($"Something went wrong. {element.Text} is not displayed correctly.");
            }
        }
        public static void CheckIfAboutUsButtonIsDisplayed()
        {
            IWebElement element = driver.FindElement(By.XPath(AboutUs));
            try
            {
                Assert.IsTrue(element.Displayed);
                Console.WriteLine($"{element.Text} button is displayed correctly.");
            }
            catch (Exception)
            {
                Console.WriteLine($"Something went wrong. {element.Text} is not displayed correctly.");
            }
        }
        public static void CheckIfBlogEntriesButtonIsDisplayed()
        {
            IWebElement element = driver.FindElement(By.XPath(BlogEntries));
            try
            {
                Assert.IsTrue(element.Displayed);
                Console.WriteLine($"{element.Text} button is displayed correctly.");
            }
            catch (Exception)
            {
                Console.WriteLine($"Something went wrong. {element.Text} is not displayed correctly.");
            }
        }
        public static void CheckIfPostDetailsButtonIsDisplayed()
        {
            IWebElement element = driver.FindElement(By.XPath(PostDetails));
            try
            {
                Assert.IsTrue(element.Displayed);
                Console.WriteLine($"{element.Text} button is displayed correctly.");
            }
            catch (Exception)
            {
                Console.WriteLine($"Something went wrong. {element.Text} is not displayed correctly.");
            }
        }
        public static void CheckIfContactUsButtonIsDisplayed()
        {
            IWebElement element = driver.FindElement(By.XPath(ContactUs));
            try
            {
                Assert.IsTrue(element.Displayed);
                Console.WriteLine($"{element.Text} button is displayed correctly.");
            }
            catch (Exception)
            {
                Console.WriteLine($"Something went wrong. {element.Text} is not displayed correctly.");
            }
        }
    }
}
