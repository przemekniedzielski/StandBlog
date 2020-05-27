using Framework.Utils;
using OpenQA.Selenium;

namespace Framework.Pages
{
    public class HomePage
    {
        private static IWebDriver driver;

        public HomePage (IWebDriver webDriver)
        {
            driver = webDriver;
        }
        public void GoToHomePage()
        {
            driver.Navigate().GoToUrl(Settings.url);
        }
    }
}
