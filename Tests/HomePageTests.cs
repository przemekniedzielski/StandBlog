using Framework.Pages;
using Framework.Utils;
using NUnit.Framework;

namespace Tests
{
    public class HomePageTests : Settings
    {
        HomePage homePage => new HomePage(driver);

        [Test]
        public void CheckIfPreviousButtonIsDisplayed()
        {
            homePage.GoToHomePage();
            homePage.CheckIfPreviousButtonIsDisplayed();
        }
        [Test]
        public void CheckIfNextButtonIsDisplayed()
        {
            homePage.GoToHomePage();
            homePage.CheckIfNextButtonIsDisplayed();
        }
    }
}
