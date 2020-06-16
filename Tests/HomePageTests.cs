using Framework.Utils;
using NUnit.Framework;
using static Framework.Pages.HomePage;

namespace Tests
{
    public class HomePageTests : Settings
    {
        [Test]
        public void CheckIfPreviousButtonIsDisplayedTest()
        {
            CheckIfPreviousButtonIsDisplayed();
        }

        [Test]
        public void CheckIfNextButtonIsDisplayedTest()
        {
            CheckIfNextButtonIsDisplayed();
        }

        [Test]
        public void CheckIfDownloadTemplateBannerIsDisplayedTest()
        {
            CheckIfDownloadTemplatePageBannerIsDisplayed();
        }

        [Test]
        public void CheckIfDownloadTemplatePageIsCorrectTest()
        {
            GoToDownloadTemplatePage();
            CheckIfDownloadTemplatePageIsCorrect();
        }

        [Test]
        public void CheckIfLifeStylePostIsDisplayedTest()
        {
            CheckIfLifestylePostIsDisplayed();
        }

        [Test]
        public void CheckIfLifeStylePostImageIsDisplayedTest()
        {
            CheckIfLifestylePostImageIsDisplayed();
        }

        [Test]
        public void CheckIfLifeStylePostTitleIsDisplayedTest()
        {
            CheckIfLifestylePostTitleIsDisplayed();
        }

        [Test]
        public void CheckIfSearchFieldIsDisplayedTest()
        {
            CheckIfSearchFieldIsDisplayed();
        }
    }
}
