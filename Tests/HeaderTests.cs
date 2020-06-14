using NUnit.Framework;
using Framework.Pages;
using Framework.Utils;
using Framework.Header;

namespace Tests
{
    public class HeaderTests : Settings
    {
        Header headerPage => new Header(driver);
        HomePage homePage => new HomePage(driver);

        [Test]
        public void CheckIfLogoIsDisplayed()
        {
            homePage.GoToHomePage();
            headerPage.CheckIfLogoIsDisplayed();
        }

        [Test]
        public void CheckIfHomeButtonIsDisplayed()
        {
            homePage.GoToHomePage();
            headerPage.CheckIfHomeButtonIsDisplayed();
        }

        [Test]
        public void CheckIfAboutUsButtonIsDisplayed()
        {
            homePage.GoToHomePage();
            headerPage.CheckIfAboutUsButtonIsDisplayed();
        }

        [Test]
        public void CheckIfBlogEntriesButtonIsDisplayed()
        {
            homePage.GoToHomePage();
            headerPage.CheckIfBlogEntriesButtonIsDisplayed();
        }

        [Test]
        public void CheckIfPostDetailsButtonIsDisplayed()
        {
            homePage.GoToHomePage();
            headerPage.CheckIfPostDetailsButtonIsDisplayed();
        }

        [Test]
        public void CheckIfContactUsButtonIsDisplayed()
        {
            homePage.GoToHomePage();
            headerPage.CheckIfContactUsButtonIsDisplayed();
        }
    }
}
