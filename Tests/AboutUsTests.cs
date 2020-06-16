using Framework.Pages;
using Framework.Header;
using Framework.Utils;
using NUnit.Framework;

namespace Tests
{
    public class AboutUsTests : Settings
    {
        Header headerPage => new Header(driver);
        AboutUsPage aboutUsPage => new AboutUsPage(driver);

        [Test]
        public void CheckIfPreviousButtonIsDisplayed()
        {
            headerPage.ClickAboutUs();
            aboutUsPage.CheckIfAboutUsPageIsDisplayed();
        }
    }
}
