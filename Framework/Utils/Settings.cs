using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Framework.Utils
{
    public class Settings
    {
        public IWebDriver driver { get; set; }

        public static string url = "http://localhost/";

        [SetUp]
        public void SetUp()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
        }

        [TearDown]
        public void TearDown()
        {
            driver.Close();
            driver.Dispose();
        }
    }
}
