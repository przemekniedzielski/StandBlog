using NUnit.Framework;
using Framework;
using static Framework.Header;

namespace Tests
{
    public class HeaderTests : Settings
    {

        [Test]
        public void CheckIfLogoIsDisplayedTest()
        {
            CheckIfLogoIsDisplayed();
        }

        [Test]
        public void CheckIfHomeButtonIsDisplayedTest()
        {
            CheckIfHomeButtonIsDisplayed();
        }

        [Test]
        public void CheckIfAboutUsButtonIsDisplayedTest()
        {
            CheckIfAboutUsButtonIsDisplayed();
        }

        [Test]
        public void CheckIfBlogEntriesButtonIsDisplayedTest()
        {
            CheckIfBlogEntriesButtonIsDisplayed();
        }

        [Test]
        public void CheckIfPostDetailsButtonIsDisplayedTest()
        {
            CheckIfPostDetailsButtonIsDisplayed();
        }

        [Test]
        public void CheckIfContactUsButtonIsDisplayedTest()
        {
            CheckIfContactUsButtonIsDisplayed();
        }
    }
}
