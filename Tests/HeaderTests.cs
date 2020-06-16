using NUnit.Framework;
using Framework.Pages;
using Framework.Utils;
using Framework.Header;

namespace Tests
{
    public class HeaderTests : Settings
    {
        Header headerPage => new Header(driver);

        [Test]
        public void CheckIfLogoIsDisplayed()
        {
            headerPage.CheckIfLogoIsDisplayed();
        }

        [Test]
        public void CheckIfHomeButtonIsDisplayed()
        {
            headerPage.CheckIfHomeButtonIsDisplayed();
        }

        [Test]
        public void CheckIfAboutUsButtonIsDisplayed()
        {
            headerPage.CheckIfAboutUsButtonIsDisplayed();
        }

        [Test]
        public void CheckIfBlogEntriesButtonIsDisplayed()
        {
            headerPage.CheckIfBlogEntriesButtonIsDisplayed();
        }

        [Test]
        public void CheckIfPostDetailsButtonIsDisplayed()
        {
            headerPage.CheckIfPostDetailsButtonIsDisplayed();
        }

        [Test]
        public void CheckIfContactUsButtonIsDisplayed()
        {
            headerPage.CheckIfContactUsButtonIsDisplayed();
        }
    }
}
