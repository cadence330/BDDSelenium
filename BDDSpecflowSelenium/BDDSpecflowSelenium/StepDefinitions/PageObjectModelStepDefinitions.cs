using BDDSpecflowSelenium.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace BDDSpecflowSelenium.StepDefinitions
{
    [Binding]
    public sealed class PageObjectModelStepDefinitions
    {
        private IWebDriver driver;
        SearchPage searchPage;
        ResultPage resultPage;
        ChannelPage channelPage;

        public PageObjectModelStepDefinitions(IWebDriver driver)
        {
            this.driver = driver;
        }

        [Given(@"Enter the youtube URL")]
        public void GivenEnterTheYoutubeURL()
        {
            driver.Url = "https://www.youtube.com/";
            Thread.Sleep(5000);
        }

        [When(@"Search for the testers talk in youtube")]
        public void WhenSearchForTheTestersTalkInYoutube()
        {
            searchPage = new SearchPage(driver);

            resultPage = searchPage.searchText("testers talk");

        }

        [When(@"Navigate to channel")]
        public void WhenNavigateToChannel()
        {
            channelPage = resultPage.clickOnChannel();
        }

        [Then(@"Verify title of the page")]
        public void ThenVerifyTitleOfThePage()
        {
            Assert.That("testers talk - YouTube", Is.EqualTo(channelPage.getTitle()));
        }







    }
}
