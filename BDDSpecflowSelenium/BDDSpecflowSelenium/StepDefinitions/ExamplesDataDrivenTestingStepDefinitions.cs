using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace BDDSpecflowSelenium.StepDefinitions
{
    [Binding]
    public sealed class ExamplesDataDrivenTestingStepDefinitions
    {
        private IWebDriver driver;

        public ExamplesDataDrivenTestingStepDefinitions(IWebDriver driver)
        {
            this.driver = driver;
        }

        [When(@"Enter (.*) and (.*)")]
        public void WhenEnterRahulshettyacademyAndLearning(string username, string password)
        {
            driver.FindElement(By.Id("username")).SendKeys(username);
            driver.FindElement(By.Id("password")).SendKeys(password);
        }






    }
}
