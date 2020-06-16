using Framework.Utils;
using NUnit.Framework;
using static Framework.Header.Header;
using static Framework.Pages.AboutUsPage;

namespace Tests
{
    public class AboutUsTests : Settings
    {
        [Test]
        public void CheckIfAboutUsPageIsDisplayedTest()
        {
            ClickAboutUsButtonInHeader();
            CheckIfAboutUsPageIsDisplayed();
        }

        [Test]
        public void CheckIfImageInAboutUsPageIsDisplayedTest()
        {
            ClickAboutUsButtonInHeader();
            CheckIfImageInAboutUsPageIsDisplayed();
        }
    }
}
