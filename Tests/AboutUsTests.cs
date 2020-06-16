using NUnit.Framework;
using Framework;
using static Framework.Header;
using static Framework.Pages.AboutUsPage;

namespace Tests
{
    public class AboutUsTests : Settings
    {
        [Test]
        public void CheckIfAboutUsPageIsDisplayedTest()
        {
            ClickAboutUsButtonOnMenu();
            CheckIfAboutUsPageIsDisplayed();
        }

        [Test]
        public void CheckIfImageInAboutUsPageIsDisplayedTest()
        {
            ClickAboutUsButtonOnMenu();
            CheckIfImageInAboutUsPageIsDisplayed();
        }

        [Test]
        public void CheckIfMoreAboutUsTextIsDisplayedTest()
        {
            ClickAboutUsButtonOnMenu();
            CheckIfMoreAboutUsTextIsDisplayed();
        }
    }
}
