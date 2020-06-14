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

        [Test]
        public void CheckIfDownloadTemplateBannerIsDisplayed()
        {
            homePage.GoToHomePage();
            homePage.CheckIfDownloadTemplatePageBannerIsDisplayed();
        }

        [Test]
        public void CheckIfDownloadTemplatePageIsCorrect()
        {
            homePage.GoToHomePage();
            homePage.GoToDownloadTemplatePage();
            homePage.CheckIfDownloadTemplatePageIsCorrect();
        }

        [Test]
        public void CheckIfLifeStylePostIsDisplayed()
        {
            homePage.GoToHomePage();
            homePage.CheckIfLifestylePostIsDisplayed();
        }

        [Test]
        public void CheckIfLifeStylePostImageIsDisplayed()
        {
            homePage.GoToHomePage();
            homePage.CheckIfLifestylePostImageIsDisplayed();
        }

        [Test]
        public void CheckIfLifeStylePostTitleIsDisplayedCorrectly()
        {
            homePage.GoToHomePage();
            homePage.CheckIfLifestylePostTitleIsDisplayedCorrectly();
        }
    }
}
