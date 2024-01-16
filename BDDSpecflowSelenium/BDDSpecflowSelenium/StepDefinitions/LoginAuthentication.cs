using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace BDDSpecflowSelenium.StepDefinitions
{
    [Binding]
    public sealed class LoginAuthentication
    {
        private IWebDriver driver;

        public LoginAuthentication(IWebDriver driver)
        {
            this.driver = driver;
        }

        [Given(@"Launch browser and go to URL")]
        public void GivenLaunchBrowserAndGoToURL()
        {
            //driver = new ChromeDriver();
            driver.Url = "https://rahulshettyacademy.com/loginpagePractise/";
            //Thread.Sleep(3000);
        }

        [When(@"Enter Username and Password login")]
        public void WhenEnterUsernameAndPassword()
        {
            driver.FindElement(By.Id("username")).SendKeys("rahulshettyacademy");
            driver.FindElement(By.Id("password")).SendKeys("learning");

        }

        [When(@"User can click login button and go to product page")]
        public void ThenUserCanClickLoginButtonAndGoToProductPage()
        {
            driver.FindElement(By.Id("signInBtn")).Click();
            //Thread.Sleep(3000);
            //driver.Quit();
        }

        [Then(@"Verify user is on products page")]
        public void ThenVerifyUserIsOnProductsPage()
        {
            string expectedText = "Shop Name";
            string shopNameText = driver.FindElement(By.CssSelector("h1.my-4")).Text;

            Assert.That(shopNameText, Is.EqualTo(expectedText), $"Expected: {expectedText}, Actual: {shopNameText}");
        }




    }
}
