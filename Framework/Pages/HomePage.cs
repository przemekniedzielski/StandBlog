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
        private readonly static string downloadTemplateBanner = "//div[@class='container']//div[@class='main-content']";
        private readonly static string downloadTemplateButton = "//div[@class='container']//div[@class='main-content']//div[@class='main-button']//a";
        private readonly static string lifestylePost = "//div[@class='all-blog-posts']//span[text()='Lifestyle']//ancestor::div[@class='blog-post']";
        private readonly static string lifestylePostTitle = "//div[@class='all-blog-posts']//span[text()='Lifestyle']";
        private readonly static string lifeStylePostImage = "//div[@class='all-blog-posts']//span[text()='Lifestyle']//ancestor::div[@class='blog-post']//img";
        private readonly static string search = "search_form";

        //Methods
        public void GoToHomePage()
        {
            driver.Navigate().GoToUrl(Settings.url);
        }

        public void GoToDownloadTemplatePage()
        {
            driver.FindElement(By.XPath(downloadTemplateButton)).Click();
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
                Console.WriteLine($"Something went wrong. {nameof(element)} button is not displayed.");
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
                Console.WriteLine($"Something went wrong. {nameof(element)} button is not displayed.");
            }
        }

        public void CheckIfDownloadTemplatePageBannerIsDisplayed()
        {
            IWebElement element = driver.FindElement(By.XPath(downloadTemplateBanner));
            try
            {
                Assert.IsTrue(element.Displayed);
                Console.WriteLine("Download template page banner is displayed correctly.");
            }
            catch (Exception)
            {
                Console.WriteLine("Something went wrong. Download template page banner not is displayed correctly.");
            }
        }

        public void CheckIfDownloadTemplatePageIsCorrect()
        {
            string pageUrl = driver.Url;
            try
            {
                Assert.AreEqual(pageUrl, "https://templatemo.com/tm-551-stand-blog");
                Console.WriteLine($"Download template page is correct and equals '{pageUrl}'.");
            }
            catch (Exception)
            {
                Console.WriteLine("Something went wrong.");
            }
        }

        public void CheckIfLifestylePostIsDisplayed()
        {
            IWebElement element = driver.FindElement(By.XPath(lifestylePost));
            try
            {
                Assert.IsTrue(element.Displayed);
                Console.WriteLine("Lifestyle post is displayed correctly.");
            }
            catch (Exception)
            {
                Console.WriteLine("Something went wrong. Lifestyle post is not displayed correctly.");
            }
        }

        public void CheckIfLifestylePostTitleIsDisplayedCorrectly()
        {
            IWebElement element = driver.FindElement(By.XPath(lifestylePostTitle));
            try
            {
                Assert.AreEqual(element.Text, "LIFESTYLE");
                Console.WriteLine($"Lifestyle post title is displayed correctly and equals '{element.Text}'.");
            }
            catch (Exception)
            {
                Console.WriteLine("Something went wrong. Post title is not correct.");
            }
        }

        public void CheckIfLifestylePostImageIsDisplayed()
        {
            IWebElement element = driver.FindElement(By.XPath(lifeStylePostImage));
            try
            {
                Assert.IsTrue(element.Displayed);
                Console.WriteLine("Lifestyle post image is displayed correctly.");
            }
            catch (Exception)
            {
                Console.WriteLine($"Something went wrong. Lifestyle post image is not displayed correctly.");
            }
        }

        public void CheckIfSearchFieldIsDisplayed()
        {
            IWebElement element = driver.FindElement(By.Id(search));
            try
            {
                Assert.IsTrue(element.Displayed);
                Console.WriteLine("Search field is displayed correctly.");
            }
            catch (Exception)
            {
                Console.WriteLine("Something went wrong. Search field is not displayed correctly.");
            }
        }
    }
}
