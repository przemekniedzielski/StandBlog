using Framework.Header;
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
            homePage.CheckIfPreviousButtonIsDisplayed();
        }

        [Test]
        public void CheckIfNextButtonIsDisplayed()
        {
            homePage.CheckIfNextButtonIsDisplayed();
        }

        [Test]
        public void CheckIfDownloadTemplateBannerIsDisplayed()
        {
            homePage.CheckIfDownloadTemplatePageBannerIsDisplayed();
        }

        [Test]
        public void CheckIfDownloadTemplatePageIsCorrect()
        {
            homePage.GoToDownloadTemplatePage();
            homePage.CheckIfDownloadTemplatePageIsCorrect();
        }

        [Test]
        public void CheckIfLifeStylePostIsDisplayed()
        {
            homePage.CheckIfLifestylePostIsDisplayed();
        }

        [Test]
        public void CheckIfLifeStylePostImageIsDisplayed()
        {
            homePage.CheckIfLifestylePostImageIsDisplayed();
        }

        [Test]
        public void CheckIfLifeStylePostTitleIsDisplayedCorrectly()
        {
            homePage.CheckIfLifestylePostTitleIsDisplayedCorrectly();
        }

        [Test]
        public void CheckIfSearchFieldIsDisplayedCorrectly()
        {
            homePage.CheckIfSearchFieldIsDisplayed();
        }
    }
}
