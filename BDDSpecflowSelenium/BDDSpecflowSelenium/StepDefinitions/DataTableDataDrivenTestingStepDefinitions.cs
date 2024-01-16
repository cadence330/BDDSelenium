using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow.Assist;

namespace BDDSpecflowSelenium.StepDefinitions
{
    [Binding]
    public sealed class DataTableDataDrivenTestingStepDefinitions
    {
        private IWebDriver driver;

        public DataTableDataDrivenTestingStepDefinitions(IWebDriver driver)
        {
            this.driver = driver;
        }

        [When(@"Enter email data in field")]
        public void WhenEnterEmailDataInField(Table table)
        {
            var usernameData = table.CreateSet<EnterUsernameData>();

            foreach (var username in usernameData)
            {
                driver.FindElement(By.Id("username")).Clear();
                driver.FindElement(By.Id("username")).SendKeys(username.usernameData);
                driver.FindElement(By.Id("username")).SendKeys(Keys.Enter);



            }
        }


    }

    public class EnterUsernameData
    {
        public string usernameData { get; set; }
    }
}
